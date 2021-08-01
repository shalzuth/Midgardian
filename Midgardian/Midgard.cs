using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading;
using System.Windows.Forms;
using UnrealSharp;
using SDK.Script.EngineSDK;
using SDK.Script.TOMSDK;

namespace Midgardian
{
    public class Midgard
    {
        String staticGameName => "TOM-Win64-Shipping";
        Process process;
        public Overlay overlay;
        public void InitWindow()
        {
            while (true)
            {
                process = Process.GetProcesses().FirstOrDefault(p => p.ProcessName.Contains(staticGameName) && p.MainWindowHandle != IntPtr.Zero);
                if (process != null) break;
                Thread.Sleep(500);
            }
            new UnrealEngine(new Memory(process)).UpdateAddresses();
            //new UnrealEngine(new Memory(process)).LoadAddesses(SDK.Addresses.Hardcoded.Payload);
            overlay = new Overlay(process);
        }
        public void Start()
        {
            while (!Hotkeys.IsPressed(Keys.Delete) && !process.HasExited)
            {
                overlay.Begin();
                if (EngineLoop() > 0) { UEObject.ClearCache(); }
                overlay.End();
            }
        }
        public class Config
        {
            public Boolean Menu = !Hotkeys.ToggledKey(Keys.Insert);
            public Boolean Esp = Hotkeys.ToggledKey(Keys.F1);
            public Boolean Zoom = Hotkeys.ToggledKey(Keys.F2);
            public Boolean EarlyStart = Hotkeys.SinglePress(Keys.F3);
            public Boolean RevealMap = Hotkeys.SinglePress(Keys.F4);
            public Boolean UnlockShrines = Hotkeys.SinglePress(Keys.F5);
            public Boolean Invuln = Hotkeys.ToggledKey(Keys.F6);
            public Boolean InvulnTree = Hotkeys.SinglePress(Keys.F7);
            public Boolean GotoTown = Hotkeys.SinglePress(Keys.F8);
            public Boolean GotoGiant = Hotkeys.SinglePress(Keys.F9);
            public Boolean SpawnGiant = Hotkeys.SinglePress(Keys.F10);
            public Boolean GotoCursor = Hotkeys.SinglePress(Keys.F11);
            public Boolean AdvanceDays = Hotkeys.SinglePress(Keys.F12);
        }
        Int32 EngineLoop()
        {
            if (UnrealEngine.GWorldPtr == 0) return 1;
            var cfg = new Config();
            var World = new World(UnrealEngine.Memory.ReadProcessMemory<UInt64>(UnrealEngine.GWorldPtr)); if (!World.IsA<World>()) return 1;
            if (cfg.Menu)
            {
                var sb = new StringBuilder();
                sb.AppendLine("Shalzuth's Helper Tool");
                sb.AppendLine("FPS : " + overlay.MeasuredFps.ToString("0.00"));
                sb.AppendLine("Hide menu (Insert)");
                sb.AppendLine("Unload (Delete)");
                var fields = cfg.GetType().GetFields();
                for(var i = 1; i < fields.Length; i++) sb.AppendLine(fields[i].Name + "(F" + i + ")");
                overlay.DrawText(sb.ToString(), new Vector2(20, 20), Color.OrangeRed);
            }
            var OwningGameInstance = World.OwningGameInstance; if (!OwningGameInstance.IsA<GameInstance>()) return 1;
            var LocalPlayers = OwningGameInstance.LocalPlayers;
            var PlayerController = LocalPlayers[0].PlayerController.As<TOMPlayerController>(); if (!PlayerController.IsA<PlayerController>()) return 1;
            var Player = PlayerController.Player;
            var AcknowledgedPawn = PlayerController.AcknowledgedPawn.As<TOMCharacter>(); if (AcknowledgedPawn == null || !AcknowledgedPawn.IsA<Character>()) return 1;            
            var RelativeLocation = AcknowledgedPawn.RootComponent.RelativeLocation;
            var PlayerLocation = UnrealEngine.Memory.ReadProcessMemory<Vector3>(RelativeLocation.Address);
            var solo = World.GameState.PlayerArray.Num == 1;
            if (cfg.Zoom) if (AcknowledgedPawn.TargetCameraZoomLevel != SDK.Script.SharedSDK.ECameraZoomLevel.MythBoss) AcknowledgedPawn.SetCameraZoomLevel(SDK.Script.SharedSDK.ECameraZoomLevel.MythBoss);
            if (solo && cfg.RevealMap) PlayerController.RevealMap();
            if (solo && cfg.UnlockShrines) PlayerController.CheatActivateShrines();
            if (solo && cfg.InvulnTree) PlayerController.SetYggdrasilInvincible(1);
            if (solo && cfg.GotoTown) PlayerController.TeleportToVillage();
            if (solo && cfg.GotoGiant) PlayerController.TeleportToGiant();
            if (solo && cfg.SpawnGiant) PlayerController.SpawnGiant(1);
            //if (solo && cfg.SpeedHack) AcknowledgedPawn.SpeedRatio = 5f; // only works in saga, kinda meh with all the other stuff
            if (solo && cfg.Invuln)
                if (AcknowledgedPawn.HealthComponent.HealthComponentRepProperties.currentHealth < AcknowledgedPawn.HealthComponent.HealthComponentRepProperties.DefaultHealth)
                    PlayerController.HealAllPlayers((int)(AcknowledgedPawn.HealthComponent.HealthComponentRepProperties.DefaultHealth - AcknowledgedPawn.HealthComponent.HealthComponentRepProperties.currentHealth));
            if (solo && cfg.GotoCursor) PlayerController.TeleportToCoordinates(PlayerController.GetMouseWorldProjectedPosition());
            if (solo && cfg.AdvanceDays)
            {
                var cm = PlayerController.CheatManager.As<TOMCheatManager>();
                for (var i = 0; i < 50; i++)
                {
                    cm.TOMSetTimeOfDaySegmentClient(1);
                    cm.TOMSetTimeOfDaySegmentClient(2);
                    cm.TOMSetTimeOfDaySegmentClient(3);
                    cm.TOMSetTimeOfDaySegmentClient(4);
                    cm.TOMSetTimeOfDaySegmentClient(0);
                }
            }
            if (solo && cfg.EarlyStart)
            {
                PlayerController.EnableCheats();
                var cm = PlayerController.CheatManager.As<TOMCheatManager>();
                cm.TOMDropItem(0x264, 1); // hack sword
                //cm.TOMDropItem(0x285, 80); // horns``
                cm.TOMDropItem(0x38, 1000); //souls
                cm.TOMDropItem(0x28d, 5); // fence 2
                cm.TOMDropItem(0x28e, 5); // barrier 2
                cm.TOMDropItem(0x28f, 5); // ground 2
                cm.TOMDropItem(0x291, 5); // ramp 2

                /*cm.TOMDropItem(0x38, 90000); //souls
                cm.TOMDropItem(0x21f, 1); // fenrir sword
                cm.TOMDropItem(0x220, 1); // fenrir boot
                cm.TOMDropItem(0x221, 1); // fenrir chest
                cm.TOMDropItem(0x222, 1); // fenrir glove
                cm.TOMDropItem(0x223, 1); // fenrir head
                cm.TOMDropItem(0x224, 1); // henrir legs
                cm.TOMDropItem(0x24f, 1);
                cm.TOMDropItem(0x264, 1); // hack sword

                cm.TOMDropItem(0x4c, 1); //forn axe

                cm.TOMDropItem(0x57, 1); //baldr sword
                cm.TOMDropItem(0x63, 1); //forn  shield
                cm.TOMDropItem(0x6d, 1); // forn boot
                cm.TOMDropItem(0x76, 1); // forn chest
                cm.TOMDropItem(0x7f, 1); // forn glove
                cm.TOMDropItem(0x88, 1); // forn head
                cm.TOMDropItem(0x93, 1); // forn legs
                cm.TOMDropItem(0x71, 1); // baldr boot
                cm.TOMDropItem(0x7a, 1); // baldr chest
                cm.TOMDropItem(0x83, 1); // baldr glove
                cm.TOMDropItem(0x8c, 1); // baldr head
                cm.TOMDropItem(0x97, 1); // baldr legs
                cm.TOMDropItem(0x1e7, 1); // mine
                cm.TOMDropItem(0x1e8, 1);
                cm.TOMDropItem(0x1ea, 50); // event
                cm.TOMDropItem(0x1eb, 50); // jotunn
                cm.TOMDropItem(0x1ec, 50); // hideout
                cm.TOMDropItem(0x1ed, 50); // quest
                cm.TOMDropItem(0x21f, 1); // fenrir*/
            }
            if (cfg.Esp)
            {
                var PlayerCameraManager = PlayerController.PlayerCameraManager;
                var CameraCache = PlayerCameraManager.CameraCachePrivate;
                var CameraPOV = CameraCache["POV"];
                var CameraLocation = UnrealEngine.Memory.ReadProcessMemory<Vector3>(CameraPOV["Location"].Address);
                var CameraRotation = UnrealEngine.Memory.ReadProcessMemory<Vector3>(CameraPOV["Rotation"].Address);
                var CameraFOV = UnrealEngine.Memory.ReadProcessMemory<Single>(CameraPOV["FOV"].Address);

                overlay.DrawMinimap(PlayerLocation, PlayerLocation, CameraRotation, "*", Color.Blue);
                // https://github.com/EpicGames/UnrealTournament/blob/3bf4b43c329ce041b4e33c9deb2ca66d78518b29/Engine/Source/Runtime/Engine/Classes/Engine/Level.h#L366
                // Actors
                // StreamedLevelOwningWorld
                // Owning World
                var actorListOffset = (UInt64)World.PersistentLevel.GetFieldOffset(World.PersistentLevel.GetFieldAddr("OwningWorld")) - 0x10;
                var Actors = new Array<Actor>(World.PersistentLevel.Address + actorListOffset);
                Dictionary<String, Vector4> ClosestObjs = new Dictionary<String, Vector4>();
                for (var i = 0u; i < Actors.Num; i++)
                {
                    var Actor = Actors[i];
                    if (Actor.Address == 0) continue;
                    if (Actor.Address == Player.Address) continue;
                    if (!Actor.IsA<Actor>()) continue;
                    if (Actor.IsA(out MaterialSourceBase material))
                    {
                        if (Actor.bActorIsBeingDestroyed) continue;
                        var RootComponent = Actor.RootComponent; if (RootComponent.Address == 0) continue; if (!RootComponent.IsA<SceneComponent>()) continue;
                        RelativeLocation = RootComponent.RelativeLocation; if (RelativeLocation.Address == 0) continue;
                        if (material.GetFieldAddr("InteractableActorComponent") == 0) continue;
                        var interactable = material.InteractableActorComponent["IsInteractable"];
                        if (interactable == null || interactable.Address == 0) continue;
                        if (!interactable.Flag) continue;
                        var Location = UnrealEngine.Memory.ReadProcessMemory<Vector3>(RelativeLocation.Address);
                        var dist = Vector3.Distance(Location, PlayerLocation);
                        dist += (float)Math.Pow((Location.Z - PlayerLocation.Z), 2.0f);
                        var name = Actor.GetShortName().Replace("BP_MaterialSource_", "").Replace("BP_PopProp_", "").Replace("BP_PopPropTree", "").Replace("_C", "").Replace("_000", "").Replace("_001", "").Replace("_002", "").Replace("_003", "");
                        if (name.Contains("Tree")) name = "Tree";
                        overlay.DrawMinimap(Location, PlayerLocation, CameraRotation, "*", Color.Yellow);
                        var radarLoc = overlay.WorldToScreen(Location, CameraLocation, CameraRotation, CameraFOV);
                        overlay.DrawText(name, radarLoc, Color.Yellow);
                        if (!ClosestObjs.ContainsKey(name)) ClosestObjs.Add(name, new Vector4(Location, dist));
                        else if (ClosestObjs[name].W > dist) ClosestObjs[name] = new Vector4(Location, dist);
                    }
                    else if (Actor.IsA(out DestructibleLandmarkBase landmark))
                    {
                        if (Actor.bActorIsBeingDestroyed) continue;
                        var RootComponent = Actor.RootComponent; if (RootComponent.Address == 0) continue; if (!RootComponent.IsA<SceneComponent>()) continue;
                        RelativeLocation = RootComponent.RelativeLocation; if (RelativeLocation.Address == 0) continue;
                        var Location = UnrealEngine.Memory.ReadProcessMemory<Vector3>(RelativeLocation.Address);
                        var dist = Vector3.Distance(Location, PlayerLocation);
                        dist += (float)Math.Pow((Location.Z - PlayerLocation.Z), 2.0f);
                        var name = Actor.GetShortName().Replace("BP_", "").Replace("_C", "").Replace("_000", "").Replace("_001", "").Replace("_002", "").Replace("_003", "");
                        overlay.DrawMinimap(Location, PlayerLocation, CameraRotation, "*", Color.Purple);
                        name += Guid.NewGuid().ToString().Substring(0, 4);
                        ClosestObjs.Add(name, new Vector4(Location, dist));
                    }
                    else if (Actor.IsA(out TOMCharacter character))
                    {
                        if (Actor.bActorIsBeingDestroyed) continue;
                        var health = character.HealthComponent; if (health == null || health.Address < 100) continue;
                        if (health.GetFieldAddr("HealthComponentRepProperties") == 0) continue;
                        var healthProp = health.HealthComponentRepProperties; if (healthProp == null || healthProp.Address == 0 || healthProp.currentHealth == 0) continue;
                        var RootComponent = Actor.RootComponent; if (RootComponent.Address == 0) continue; if (!RootComponent.IsA<SceneComponent>()) continue;
                        RelativeLocation = RootComponent.RelativeLocation; if (RelativeLocation.Address == 0) continue;
                        var Location = UnrealEngine.Memory.ReadProcessMemory<Vector3>(RelativeLocation.Address);
                        overlay.DrawMinimap(Location, PlayerLocation, CameraRotation, "*", Color.Red);
                        var radarLoc = overlay.WorldToScreen(Location, CameraLocation, CameraRotation, CameraFOV);
                        //var radarLoc = esp.WorldToScreen(Location, PlayerLocation, CameraRotation);
                        var name = Actor.GetShortName().Replace("BP_", "").Replace("Animal_", "").Replace("NPC", "").Replace("_C", "").Replace("_000", "").Replace("_001", "").Replace("_002", "").Replace("_003", "");
                        if (name.Contains("Player")) continue;
                        overlay.DrawText(name, radarLoc, Color.OrangeRed);
                    }
                }
                var c = 0;
                //foreach (var closestObj in ClosestObjs.OrderBy(o => o.Value.W))
                foreach (var closestObj in ClosestObjs.OrderBy(o => o.Key))
                {
                    var radarLoc = overlay.WorldToWindow(new Vector3(closestObj.Value.X, closestObj.Value.Y, closestObj.Value.Z), PlayerLocation, CameraRotation, 5000, 200);
                    var endLoc = radarLoc - new Vector2(100, 100);
                    endLoc = Vector2.Normalize(endLoc) * 10;
                    overlay.DrawLine(Color.Yellow, new Vector2(1700 - 15, 200 + 8 + c * 20), new Vector2(1700 - 15, 200 + 8 + c * 20) + endLoc);
                    endLoc /= 3;
                    overlay.DrawLine(Color.Blue, new Vector2(1700 - 15, 200 + 8 + c * 20), new Vector2(1700 - 15, 200 + 8 + c * 20) + endLoc);
                    overlay.DrawText(closestObj.Key + " : " + (Math.Sqrt(closestObj.Value.W) - 92), new Vector2(1700, 200 + c++ * 20), Color.Yellow);
                }
            }
            return 0;
        }
    }
}