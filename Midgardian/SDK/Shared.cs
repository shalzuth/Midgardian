using UnrealSharp;
using Object = UnrealSharp.UEObject;
using SDK.Script.BifrostSDK;
using SDK.Script.CoreUObjectSDK;
using SDK.Script.EngineSDK;
namespace SDK.Script.SharedSDK
{
    public class GameDataModel : Object
    {
        public GameDataModel(ulong addr) : base(addr) { }
        public Object CraftingRecipes { get { return this[nameof(CraftingRecipes)]; } set { this[nameof(CraftingRecipes)] = value; } }
        public Object Doors { get { return this[nameof(Doors)]; } set { this[nameof(Doors)] = value; } }
        public Object ItemRarities { get { return this[nameof(ItemRarities)]; } set { this[nameof(ItemRarities)] = value; } }
        public Object ItemTypes { get { return this[nameof(ItemTypes)]; } set { this[nameof(ItemTypes)] = value; } }
        public Object Items { get { return this[nameof(Items)]; } set { this[nameof(Items)] = value; } }
        public Object Attacks { get { return this[nameof(Attacks)]; } set { this[nameof(Attacks)] = value; } }
        public Object AttackStats { get { return this[nameof(AttackStats)]; } set { this[nameof(AttackStats)] = value; } }
        public Object Projectiles { get { return this[nameof(Projectiles)]; } set { this[nameof(Projectiles)] = value; } }
        public Object Weapons { get { return this[nameof(Weapons)]; } set { this[nameof(Weapons)] = value; } }
        public Object WeightedLoots { get { return this[nameof(WeightedLoots)]; } set { this[nameof(WeightedLoots)] = value; } }
        public Object Shields { get { return this[nameof(Shields)]; } set { this[nameof(Shields)] = value; } }
        public Object StarterKits { get { return this[nameof(StarterKits)]; } set { this[nameof(StarterKits)] = value; } }
        public Object Transmogs { get { return this[nameof(Transmogs)]; } set { this[nameof(Transmogs)] = value; } }
        public Object Armors { get { return this[nameof(Armors)]; } set { this[nameof(Armors)] = value; } }
        public Object MaterialSources { get { return this[nameof(MaterialSources)]; } set { this[nameof(MaterialSources)] = value; } }
        public Object Fortifications { get { return this[nameof(Fortifications)]; } set { this[nameof(Fortifications)] = value; } }
        public Object Giants { get { return this[nameof(Giants)]; } set { this[nameof(Giants)] = value; } }
        public Object Consumables { get { return this[nameof(Consumables)]; } set { this[nameof(Consumables)] = value; } }
        public Object Containers { get { return this[nameof(Containers)]; } set { this[nameof(Containers)] = value; } }
        public Object Characters { get { return this[nameof(Characters)]; } set { this[nameof(Characters)] = value; } }
        public Object Rarities { get { return this[nameof(Rarities)]; } set { this[nameof(Rarities)] = value; } }
        public Object Biomes { get { return this[nameof(Biomes)]; } set { this[nameof(Biomes)] = value; } }
        public Object BiomeLevels { get { return this[nameof(BiomeLevels)]; } set { this[nameof(BiomeLevels)] = value; } }
        public Object Modules { get { return this[nameof(Modules)]; } set { this[nameof(Modules)] = value; } }
        public Object ModuleDistributionTypeModels { get { return this[nameof(ModuleDistributionTypeModels)]; } set { this[nameof(ModuleDistributionTypeModels)] = value; } }
        public Object Resources { get { return this[nameof(Resources)]; } set { this[nameof(Resources)] = value; } }
        public Object ResourcesEntries { get { return this[nameof(ResourcesEntries)]; } set { this[nameof(ResourcesEntries)] = value; } }
        public Object Buildings { get { return this[nameof(Buildings)]; } set { this[nameof(Buildings)] = value; } }
        public Object CreaturePacks { get { return this[nameof(CreaturePacks)]; } set { this[nameof(CreaturePacks)] = value; } }
        public Object DamageTypes { get { return this[nameof(DamageTypes)]; } set { this[nameof(DamageTypes)] = value; } }
        public Object Perks { get { return this[nameof(Perks)]; } set { this[nameof(Perks)] = value; } }
        public Object PlayerSkills { get { return this[nameof(PlayerSkills)]; } set { this[nameof(PlayerSkills)] = value; } }
        public Object GameSeasons { get { return this[nameof(GameSeasons)]; } set { this[nameof(GameSeasons)] = value; } }
        public Object Caves { get { return this[nameof(Caves)]; } set { this[nameof(Caves)] = value; } }
        public Object CodexEntries { get { return this[nameof(CodexEntries)]; } set { this[nameof(CodexEntries)] = value; } }
        public Object ContentBundles { get { return this[nameof(ContentBundles)]; } set { this[nameof(ContentBundles)] = value; } }
        public DataObject GameConfig { get { return this[nameof(GameConfig)].As<DataObject>(); } set { this["GameConfig"] = value; } }
        public DataObject NewsConfig { get { return this[nameof(NewsConfig)].As<DataObject>(); } set { this["NewsConfig"] = value; } }
        public DataObject PatchNotesConfig { get { return this[nameof(PatchNotesConfig)].As<DataObject>(); } set { this["PatchNotesConfig"] = value; } }
        public DataObject RoadmapConfig { get { return this[nameof(RoadmapConfig)].As<DataObject>(); } set { this["RoadmapConfig"] = value; } }
        public DataObject SocialConfig { get { return this[nameof(SocialConfig)].As<DataObject>(); } set { this["SocialConfig"] = value; } }
        public Object UserLevels { get { return this[nameof(UserLevels)]; } set { this[nameof(UserLevels)] = value; } }
        public DataObject GenerationConfig { get { return this[nameof(GenerationConfig)].As<DataObject>(); } set { this["GenerationConfig"] = value; } }
        public DataObject DurabilityConfig { get { return this[nameof(DurabilityConfig)].As<DataObject>(); } set { this["DurabilityConfig"] = value; } }
        public DataObject VillageConfig { get { return this[nameof(VillageConfig)].As<DataObject>(); } set { this["VillageConfig"] = value; } }
        public DataObject ReviveConfig { get { return this[nameof(ReviveConfig)].As<DataObject>(); } set { this["ReviveConfig"] = value; } }
        public DataObject NakedEquipmentConfig { get { return this[nameof(NakedEquipmentConfig)].As<DataObject>(); } set { this["NakedEquipmentConfig"] = value; } }
        public DataObject PlayerLootConfig { get { return this[nameof(PlayerLootConfig)].As<DataObject>(); } set { this["PlayerLootConfig"] = value; } }
        public DataObject GiantConfig { get { return this[nameof(GiantConfig)].As<DataObject>(); } set { this["GiantConfig"] = value; } }
        public DataObject BarricadeRatiosConfig { get { return this[nameof(BarricadeRatiosConfig)].As<DataObject>(); } set { this["BarricadeRatiosConfig"] = value; } }
        public DataObject BifrostConfig { get { return this[nameof(BifrostConfig)].As<DataObject>(); } set { this["BifrostConfig"] = value; } }
        public Array<DataObject> ShieldResistanceTiers { get { return new Array<DataObject>(this[nameof(ShieldResistanceTiers)].Address); } }
        public Array<DataObject> ArmorResistanceTiers { get { return new Array<DataObject>(this[nameof(ArmorResistanceTiers)].Address); } }
        public Array<MinionWaveDataModel> MinionWaves { get { return new Array<MinionWaveDataModel>(this[nameof(MinionWaves)].Address); } }
        public Object Hazards { get { return this[nameof(Hazards)]; } set { this[nameof(Hazards)] = value; } }
        public Object Constructions { get { return this[nameof(Constructions)]; } set { this[nameof(Constructions)] = value; } }
        public Object Upgrades { get { return this[nameof(Upgrades)]; } set { this[nameof(Upgrades)] = value; } }
        public DataObject InputEffectsConfig { get { return this[nameof(InputEffectsConfig)].As<DataObject>(); } set { this["InputEffectsConfig"] = value; } }
        public GameDataVO VO { get { return this[nameof(VO)].As<GameDataVO>(); } set { this["VO"] = value; } }
        public Object AvatarCosmetics { get { return this[nameof(AvatarCosmetics)]; } set { this[nameof(AvatarCosmetics)] = value; } }
        public Object Achievements { get { return this[nameof(Achievements)]; } set { this[nameof(Achievements)] = value; } }
        public Object Animals { get { return this[nameof(Animals)]; } set { this[nameof(Animals)] = value; } }
        public Object AIBehaviours { get { return this[nameof(AIBehaviours)]; } set { this[nameof(AIBehaviours)] = value; } }
        public Object PingCommands { get { return this[nameof(PingCommands)]; } set { this[nameof(PingCommands)] = value; } }
        public Object AvatarIcons { get { return this[nameof(AvatarIcons)]; } set { this[nameof(AvatarIcons)] = value; } }
        public Object AvatarPets { get { return this[nameof(AvatarPets)]; } set { this[nameof(AvatarPets)] = value; } }
        public Array<DayCycleDataModel> DaysCycle { get { return new Array<DayCycleDataModel>(this[nameof(DaysCycle)].Address); } }
        public Object PlayerLevels { get { return this[nameof(PlayerLevels)]; } set { this[nameof(PlayerLevels)] = value; } }
        public Object SeasonUserLevels { get { return this[nameof(SeasonUserLevels)]; } set { this[nameof(SeasonUserLevels)] = value; } }
        public Array<ServerRegionModel> ServerRegions { get { return new Array<ServerRegionModel>(this[nameof(ServerRegions)].Address); } }
        public Object Blueprints { get { return this[nameof(Blueprints)]; } set { this[nameof(Blueprints)] = value; } }
        public Object GameEvents { get { return this[nameof(GameEvents)]; } set { this[nameof(GameEvents)] = value; } }
        public Object GameModes { get { return this[nameof(GameModes)]; } set { this[nameof(GameModes)] = value; } }
        public Object Quests { get { return this[nameof(Quests)]; } set { this[nameof(Quests)] = value; } }
        public Object Dialogs { get { return this[nameof(Dialogs)]; } set { this[nameof(Dialogs)] = value; } }
        public Object Ammunitions { get { return this[nameof(Ammunitions)]; } set { this[nameof(Ammunitions)] = value; } }
        public Object Modifiers { get { return this[nameof(Modifiers)]; } set { this[nameof(Modifiers)] = value; } }
        public Object Entitlements { get { return this[nameof(Entitlements)]; } set { this[nameof(Entitlements)] = value; } }
        public Object Challenges { get { return this[nameof(Challenges)]; } set { this[nameof(Challenges)] = value; } }
        public Object PlayerClasses { get { return this[nameof(PlayerClasses)]; } set { this[nameof(PlayerClasses)] = value; } }
        public DataObject FeatureConfig { get { return this[nameof(FeatureConfig)].As<DataObject>(); } set { this["FeatureConfig"] = value; } }
        public Object DataByClass { get { return this[nameof(DataByClass)]; } set { this[nameof(DataByClass)] = value; } }
        public GameDataVO ToVO() { return Invoke<GameDataVO>(nameof(ToVO)); }
        public void RefreshServerRegionsPing() { Invoke(nameof(RefreshServerRegionsPing)); }
        public void InitGameData(GameDataVO GameData, Array<SoftObjectPath> OutAssetPathsToLoad) { Invoke(nameof(InitGameData), GameData, OutAssetPathsToLoad); }
        public ContainerDataModel GetStaticContainerByContainerType(EContainerType ContainerType) { return Invoke<ContainerDataModel>(nameof(GetStaticContainerByContainerType), ContainerType); }
        public Object GetSeasonUserLevels() { return Invoke<Object>(nameof(GetSeasonUserLevels)); }
        public Array<QuestDataModel> GetQuests() { return Invoke<Array<QuestDataModel>>(nameof(GetQuests)); }
        public QuestDataModel GetQuestById(int QuestId) { return Invoke<QuestDataModel>(nameof(GetQuestById), QuestId); }
        public Object GetPlayerSkills() { return Invoke<Object>(nameof(GetPlayerSkills)); }
        public PlayerSkillDataModel GetPlayerSkillByClassAndCoordinate(int X, int Y, ESkillClass SkillClass) { return Invoke<PlayerSkillDataModel>(nameof(GetPlayerSkillByClassAndCoordinate), X, Y, SkillClass); }
        public Object GetPlayerLevels() { return Invoke<Object>(nameof(GetPlayerLevels)); }
        public PlayerLevelDataModel GetPlayerLevel(int ID) { return Invoke<PlayerLevelDataModel>(nameof(GetPlayerLevel), ID); }
        public PlayerClassDataModel GetPlayerClassBySkillClass(ESkillClass SkillClass) { return Invoke<PlayerClassDataModel>(nameof(GetPlayerClassBySkillClass), SkillClass); }
        public PlayerClassDataModel GetPlayerClassByEntitlement(int EntitlementID) { return Invoke<PlayerClassDataModel>(nameof(GetPlayerClassByEntitlement), EntitlementID); }
        public Object GetPingCommands() { return Invoke<Object>(nameof(GetPingCommands)); }
        public PingCommandDataModel GetPingcommand(int ID) { return Invoke<PingCommandDataModel>(nameof(GetPingcommand), ID); }
        public AmmunitionDataModel GetMunitionByItemId(int ItemId) { return Invoke<AmmunitionDataModel>(nameof(GetMunitionByItemId), ItemId); }
        public ModuleDataModel GetModuleByType(EPOIType ModuleType) { return Invoke<ModuleDataModel>(nameof(GetModuleByType), ModuleType); }
        public ModuleDataModel GetModule(int ID) { return Invoke<ModuleDataModel>(nameof(GetModule), ID); }
        public ModifierDataModel GetModifierByItemId(int ItemId) { return Invoke<ModifierDataModel>(nameof(GetModifierByItemId), ItemId); }
        public ModifierDataModel GetModifierById(int ModifierId) { return Invoke<ModifierDataModel>(nameof(GetModifierById), ModifierId); }
        public ModifierDataModel GetModifierByEntitlement(int EntitlementID) { return Invoke<ModifierDataModel>(nameof(GetModifierByEntitlement), EntitlementID); }
        public int GetHazardIdByActorClass(Object ActorClass) { return Invoke<int>(nameof(GetHazardIdByActorClass), ActorClass); }
        public HazardDataModel GetHazardById(int HazardId) { return Invoke<HazardDataModel>(nameof(GetHazardById), HazardId); }
        public GiantDataModel GetGiantModelByAnimalId(int AnimalId) { return Invoke<GiantDataModel>(nameof(GetGiantModelByAnimalId), AnimalId); }
        public GameModeDataModel GetGameModeByMode(EGameMode Mode) { return Invoke<GameModeDataModel>(nameof(GetGameModeByMode), Mode); }
        public GameEventDataModel GetGameEventById(int GameEventId) { return Invoke<GameEventDataModel>(nameof(GetGameEventById), GameEventId); }
        public int GetGameDurationInDays() { return Invoke<int>(nameof(GetGameDurationInDays)); }
        public EFeatureFlag GetFeatureFlag(EFeatures Feature) { return Invoke<EFeatureFlag>(nameof(GetFeatureFlag), Feature); }
        public EntitlementDataModel GetEntitlement(int EntitlementID) { return Invoke<EntitlementDataModel>(nameof(GetEntitlement), EntitlementID); }
        public DialogDataModel GetDialogById(int DialogId) { return Invoke<DialogDataModel>(nameof(GetDialogById), DialogId); }
        public Object GetDaysCycle(int Group) { return Invoke<Object>(nameof(GetDaysCycle), Group); }
        public Object GetDataVersion() { return Invoke<Object>(nameof(GetDataVersion)); }
        public GameSeasonDataModel GetCurrentSeason() { return Invoke<GameSeasonDataModel>(nameof(GetCurrentSeason)); }
        public ContentBundleDataModel GetContentBundleById(int ContentBundleId) { return Invoke<ContentBundleDataModel>(nameof(GetContentBundleById), ContentBundleId); }
        public Object GetContainers() { return Invoke<Object>(nameof(GetContainers)); }
        public ContainerDataModel GetContainer(int ID) { return Invoke<ContainerDataModel>(nameof(GetContainer), ID); }
        public Array<Object> GetConstructionRecipeTabNameList() { return Invoke<Array<Object>>(nameof(GetConstructionRecipeTabNameList)); }
        public ConstructionRecipeDataModel GetConstructionRecipeByUISlotIndex(int SlotIndex, Object TabName) { return Invoke<ConstructionRecipeDataModel>(nameof(GetConstructionRecipeByUISlotIndex), SlotIndex, TabName); }
        public ConstructionRecipeDataModel GetConstructionRecipeByItemId(int ItemId) { return Invoke<ConstructionRecipeDataModel>(nameof(GetConstructionRecipeByItemId), ItemId); }
        public Object GetCharacters() { return Invoke<Object>(nameof(GetCharacters)); }
        public CharacterDataModel GetCharacter(int ID) { return Invoke<CharacterDataModel>(nameof(GetCharacter), ID); }
        public Array<ChallengeDataModel> GetChallengesByCategory(EChallengeCategory Category) { return Invoke<Array<ChallengeDataModel>>(nameof(GetChallengesByCategory), Category); }
        public Object GetChallenges() { return Invoke<Object>(nameof(GetChallenges)); }
        public ChallengeDataModel GetChallengeById(int ChallengeId) { return Invoke<ChallengeDataModel>(nameof(GetChallengeById), ChallengeId); }
        public Object GetBlueprints() { return Invoke<Object>(nameof(GetBlueprints)); }
        public int GetBlueprintIdForRowAndRarity(int Row, EItemRarity Rarity) { return Invoke<int>(nameof(GetBlueprintIdForRowAndRarity), Row, Rarity); }
        public BlueprintDataModel GetBlueprintForRowAndRarity(Array<BlueprintDataModel> BlueprintsRow, int Row, EItemRarity Rarity) { return Invoke<BlueprintDataModel>(nameof(GetBlueprintForRowAndRarity), BlueprintsRow, Row, Rarity); }
        public BlueprintDataModel GetBlueprintByRecipeId(int RecipeId, EBlueprintTypes BlueprintType) { return Invoke<BlueprintDataModel>(nameof(GetBlueprintByRecipeId), RecipeId, BlueprintType); }
        public BlueprintDataModel GetBlueprintById(int BlueprintId) { return Invoke<BlueprintDataModel>(nameof(GetBlueprintById), BlueprintId); }
        public BiomeLevelDataModel GetBiomeLevelData(int BiomeId, int BiomeLevel) { return Invoke<BiomeLevelDataModel>(nameof(GetBiomeLevelData), BiomeId, BiomeLevel); }
        public Object GetAvatarPets() { return Invoke<Object>(nameof(GetAvatarPets)); }
        public AvatarPetDataModel GetAvatarPet(int ID) { return Invoke<AvatarPetDataModel>(nameof(GetAvatarPet), ID); }
        public Object GetAvatarIcons() { return Invoke<Object>(nameof(GetAvatarIcons)); }
        public AvatarIconDataModel GetAvatarIcon(int ID) { return Invoke<AvatarIconDataModel>(nameof(GetAvatarIcon), ID); }
        public Object GetAvatarCosmetics() { return Invoke<Object>(nameof(GetAvatarCosmetics)); }
        public AvatarCosmeticDataModel GetAvatarCosmeticByExternalId(int ExternalId, ECosmeticType CosmeticType) { return Invoke<AvatarCosmeticDataModel>(nameof(GetAvatarCosmeticByExternalId), ExternalId, CosmeticType); }
        public AvatarCosmeticDataModel GetAvatarCosmeticByEntitlement(int EntitlementID) { return Invoke<AvatarCosmeticDataModel>(nameof(GetAvatarCosmeticByEntitlement), EntitlementID); }
        public AvatarCosmeticDataModel GetAvatarCosmetic(int ID) { return Invoke<AvatarCosmeticDataModel>(nameof(GetAvatarCosmetic), ID); }
        public Object GetAnimals() { return Invoke<Object>(nameof(GetAnimals)); }
        public AnimalDataModel GetAnimal(int ID) { return Invoke<AnimalDataModel>(nameof(GetAnimal), ID); }
        public Array<CodexEntryDataModel> GetAllCodexEntries() { return Invoke<Array<CodexEntryDataModel>>(nameof(GetAllCodexEntries)); }
        public Array<ItemDataModel> GetAllBlueprintsFragments() { return Invoke<Array<ItemDataModel>>(nameof(GetAllBlueprintsFragments)); }
        public AIBehaviourDataModel GetAIBehaviourDataModel(int ID) { return Invoke<AIBehaviourDataModel>(nameof(GetAIBehaviourDataModel), ID); }
        public Object GetAchievements() { return Invoke<Object>(nameof(GetAchievements)); }
        public void DequeuePingRefreshList() { Invoke(nameof(DequeuePingRefreshList)); }
        public void AddAnimal(AnimalDataModel Model) { Invoke(nameof(AddAnimal), Model); }
    }
    public class LobbyDataModel : Object
    {
        public LobbyDataModel(ulong addr) : base(addr) { }
        public Object PlayerName { get { return this[nameof(PlayerName)]; } set { this[nameof(PlayerName)] = value; } }
        public UserVO VO { get { return this[nameof(VO)].As<UserVO>(); } set { this["VO"] = value; } }
        public void SortCosmeticsArray(ESortType sortType, Array<AvatarCosmeticDataModel> arrayToSort) { Invoke(nameof(SortCosmeticsArray), sortType, arrayToSort); }
        public void InitUser(UserVO User) { Invoke(nameof(InitUser), User); }
        public void Init() { Invoke(nameof(Init)); }
        public int GetUserXP() { return Invoke<int>(nameof(GetUserXP)); }
        public UserLevelDataModel GetUserLevelDataForXP(int XP) { return Invoke<UserLevelDataModel>(nameof(GetUserLevelDataForXP), XP); }
        public UserLevelDataModel GetUserLevelData() { return Invoke<UserLevelDataModel>(nameof(GetUserLevelData)); }
        public Object GetUserID() { return Invoke<Object>(nameof(GetUserID)); }
        public Array<AvatarCosmeticDataModel> GetTransmogByItemType(int ItemTypeId) { return Invoke<Array<AvatarCosmeticDataModel>>(nameof(GetTransmogByItemType), ItemTypeId); }
        public int GetSeasonUserXP() { return Invoke<int>(nameof(GetSeasonUserXP)); }
        public int GetSeasonUserLevelForXP(int XP) { return Invoke<int>(nameof(GetSeasonUserLevelForXP), XP); }
        public SeasonUserLevelDataModel GetSeasonUserLevelDataForXP(int XP) { return Invoke<SeasonUserLevelDataModel>(nameof(GetSeasonUserLevelDataForXP), XP); }
        public SeasonUserLevelDataModel GetSeasonUserLevelData() { return Invoke<SeasonUserLevelDataModel>(nameof(GetSeasonUserLevelData)); }
        public float GetSeasonLevelProgressForXP(int XP) { return Invoke<float>(nameof(GetSeasonLevelProgressForXP), XP); }
        public float GetPingForServerRegion(Object RegionName) { return Invoke<float>(nameof(GetPingForServerRegion), RegionName); }
        public Object GetPingCommands() { return Invoke<Object>(nameof(GetPingCommands)); }
        public PingCommandDataModel GetPingcommand(int ID) { return Invoke<PingCommandDataModel>(nameof(GetPingcommand), ID); }
        public float GetLevelProgressForXP(int XP) { return Invoke<float>(nameof(GetLevelProgressForXP), XP); }
        public int GetLevelForXP(int XP) { return Invoke<int>(nameof(GetLevelForXP), XP); }
        public EFeatureFlag GetFeatureFlag(EFeatures Feature) { return Invoke<EFeatureFlag>(nameof(GetFeatureFlag), Feature); }
        public int GetCurrentUserLevel() { return Invoke<int>(nameof(GetCurrentUserLevel)); }
        public int GetCurrentSeasonUserLevel() { return Invoke<int>(nameof(GetCurrentSeasonUserLevel)); }
        public Object GetAvatarIcons() { return Invoke<Object>(nameof(GetAvatarIcons)); }
        public AvatarIconDataModel GetAvatarIcon(int ID) { return Invoke<AvatarIconDataModel>(nameof(GetAvatarIcon), ID); }
        public Array<AvatarCosmeticDataModel> GetAvatarHeads() { return Invoke<Array<AvatarCosmeticDataModel>>(nameof(GetAvatarHeads)); }
        public Array<AvatarCosmeticDataModel> GetAvatarHairCuts() { return Invoke<Array<AvatarCosmeticDataModel>>(nameof(GetAvatarHairCuts)); }
        public Array<DataObject> GetAllServerRegions() { return Invoke<Array<DataObject>>(nameof(GetAllServerRegions)); }
        public Array<BlueprintDataModel> GetAllModifiersBlueprint() { return Invoke<Array<BlueprintDataModel>>(nameof(GetAllModifiersBlueprint)); }
        public Array<BlueprintDataModel> GetAllBlueprintsForCategory(EItemCategory Category) { return Invoke<Array<BlueprintDataModel>>(nameof(GetAllBlueprintsForCategory), Category); }
        public Array<AvatarCosmeticDataModel> FilterAvatarCosmetics(ECosmeticType Type) { return Invoke<Array<AvatarCosmeticDataModel>>(nameof(FilterAvatarCosmetics), Type); }
        public void AddXP(int EarnedXP, int TotalXP) { Invoke(nameof(AddXP), EarnedXP, TotalXP); }
    }
    public class DataModelBase : BifrostObject
    {
        public DataModelBase(ulong addr) : base(addr) { }
        public GameDataModel GameDataModel { get { return this[nameof(GameDataModel)].As<GameDataModel>(); } set { this["GameDataModel"] = value; } }
        public LobbyDataModel LobbyDataModel { get { return this[nameof(LobbyDataModel)].As<LobbyDataModel>(); } set { this["LobbyDataModel"] = value; } }
        public bool IsReady() { return Invoke<bool>(nameof(IsReady)); }
        public LobbyDataModel GetLobbyDataModel() { return Invoke<LobbyDataModel>(nameof(GetLobbyDataModel)); }
        public GameDataModel GetGameDataModel() { return Invoke<GameDataModel>(nameof(GetGameDataModel)); }
    }
    public class AchievementDataModel : DataModelBase
    {
        public AchievementDataModel(ulong addr) : base(addr) { }
        public bool GetValidatePreviousSteps() { return Invoke<bool>(nameof(GetValidatePreviousSteps)); }
        public EAchievementType GetType() { return Invoke<EAchievementType>(nameof(GetType)); }
        public float GetTargetValue() { return Invoke<float>(nameof(GetTargetValue)); }
        public Object GetSteamId() { return Invoke<Object>(nameof(GetSteamId)); }
        public Object GetStatName() { return Invoke<Object>(nameof(GetStatName)); }
        public Object GetPlatformId() { return Invoke<Object>(nameof(GetPlatformId)); }
        public int GetId() { return Invoke<int>(nameof(GetId)); }
        public EAchievementBehavior GetBehaviour() { return Invoke<EAchievementBehavior>(nameof(GetBehaviour)); }
    }
    public class AIBehaviourDataModel : DataModelBase
    {
        public AIBehaviourDataModel(ulong addr) : base(addr) { }
        public bool GetWalkWhenNearTarget() { return Invoke<bool>(nameof(GetWalkWhenNearTarget)); }
        public bool GetUseDistancePriority() { return Invoke<bool>(nameof(GetUseDistancePriority)); }
        public bool GetUseAggro() { return Invoke<bool>(nameof(GetUseAggro)); }
        public bool GetStartNeutral() { return Invoke<bool>(nameof(GetStartNeutral)); }
        public float GetPatrolRadius() { return Invoke<float>(nameof(GetPatrolRadius)); }
        public bool GetPackSharePerception() { return Invoke<bool>(nameof(GetPackSharePerception)); }
        public EAnimalState GetNightState() { return Invoke<EAnimalState>(nameof(GetNightState)); }
        public float GetMaxDistanceFromSpawn() { return Invoke<float>(nameof(GetMaxDistanceFromSpawn)); }
        public bool GetIsImmuneToAggro() { return Invoke<bool>(nameof(GetIsImmuneToAggro)); }
        public int GetId() { return Invoke<int>(nameof(GetId)); }
        public float GetGlobalCooldown() { return Invoke<float>(nameof(GetGlobalCooldown)); }
        public EAnimalState GetEveningState() { return Invoke<EAnimalState>(nameof(GetEveningState)); }
        public int GetDetectionRange() { return Invoke<int>(nameof(GetDetectionRange)); }
        public float GetDetectionHalfCone() { return Invoke<float>(nameof(GetDetectionHalfCone)); }
        public EAnimalState GetDayState() { return Invoke<EAnimalState>(nameof(GetDayState)); }
        public Array<int> GetChannelPriority() { return Invoke<Array<int>>(nameof(GetChannelPriority)); }
        public bool GetCanKite() { return Invoke<bool>(nameof(GetCanKite)); }
        public bool GetCanEvade() { return Invoke<bool>(nameof(GetCanEvade)); }
        public bool GetAttackOpportunityTarget() { return Invoke<bool>(nameof(GetAttackOpportunityTarget)); }
    }
    public class AmmunitionDataModel : DataModelBase
    {
        public AmmunitionDataModel(ulong addr) : base(addr) { }
        public AmmunitionDataVO VO { get { return this[nameof(VO)].As<AmmunitionDataVO>(); } set { this["VO"] = value; } }
        public Array<PerkDataModel> Perks { get { return new Array<PerkDataModel>(this[nameof(Perks)].Address); } }
        public float GetRagdollProjectionForce() { return Invoke<float>(nameof(GetRagdollProjectionForce)); }
        public float GetPushBackDuration() { return Invoke<float>(nameof(GetPushBackDuration)); }
        public float GetPushBackDistance() { return Invoke<float>(nameof(GetPushBackDistance)); }
        public int GetProjectileId() { return Invoke<int>(nameof(GetProjectileId)); }
        public ProjectileDataModel GetProjectile() { return Invoke<ProjectileDataModel>(nameof(GetProjectile)); }
        public Array<PerkDataModel> GetPerks() { return Invoke<Array<PerkDataModel>>(nameof(GetPerks)); }
        public int GetItemId() { return Invoke<int>(nameof(GetItemId)); }
        public bool GetIgnoreHitReaction() { return Invoke<bool>(nameof(GetIgnoreHitReaction)); }
        public int GetId() { return Invoke<int>(nameof(GetId)); }
        public bool GetGoesThroughShield() { return Invoke<bool>(nameof(GetGoesThroughShield)); }
        public int GetDamageTypeId() { return Invoke<int>(nameof(GetDamageTypeId)); }
        public float GetDamageModifier() { return Invoke<float>(nameof(GetDamageModifier)); }
        public bool GetCancelAttack() { return Invoke<bool>(nameof(GetCancelAttack)); }
        public float GetCameraShakeScale() { return Invoke<float>(nameof(GetCameraShakeScale)); }
        public AmmunitionDataModel CreateFromVO(Object Outer, AmmunitionDataVO InVO) { return Invoke<AmmunitionDataModel>(nameof(CreateFromVO), Outer, InVO); }
    }
    public class AnimalDataModel : DataModelBase
    {
        public AnimalDataModel(ulong addr) : base(addr) { }
        public Array<LootDataModel> LootTable { get { return new Array<LootDataModel>(this[nameof(LootTable)].Address); } }
        public Array<ResourceDataModel> Chests { get { return new Array<ResourceDataModel>(this[nameof(Chests)].Address); } }
        public AttackStatsDataModel TauntAttack { get { return this[nameof(TauntAttack)].As<AttackStatsDataModel>(); } set { this["TauntAttack"] = value; } }
        public int GetZOffset() { return Invoke<int>(nameof(GetZOffset)); }
        public int GetXPOnKill() { return Invoke<int>(nameof(GetXPOnKill)); }
        public int GetWeightedLootDataModelId() { return Invoke<int>(nameof(GetWeightedLootDataModelId)); }
        public WeightedLootDataModel GetWeightedLootDataModel() { return Invoke<WeightedLootDataModel>(nameof(GetWeightedLootDataModel)); }
        public AttackStatsDataModel GetTauntAttack() { return Invoke<AttackStatsDataModel>(nameof(GetTauntAttack)); }
        public float GetRotationSpeed() { return Invoke<float>(nameof(GetRotationSpeed)); }
        public int GetRespawnRate() { return Invoke<int>(nameof(GetRespawnRate)); }
        public Array<LootDataModel> GetLootTable() { return Invoke<Array<LootDataModel>>(nameof(GetLootTable)); }
        public int GetId() { return Invoke<int>(nameof(GetId)); }
        public EHealthBarColor GetEHealthBarColor() { return Invoke<EHealthBarColor>(nameof(GetEHealthBarColor)); }
        public int GetDefaultBehaviourId() { return Invoke<int>(nameof(GetDefaultBehaviourId)); }
        public bool GetCoopXp() { return Invoke<bool>(nameof(GetCoopXp)); }
        public Array<ResourceDataModel> GetChests() { return Invoke<Array<ResourceDataModel>>(nameof(GetChests)); }
        public CharacterDataModel GetCharacterModel() { return Invoke<CharacterDataModel>(nameof(GetCharacterModel)); }
        public int GetAudioDangerLevel() { return Invoke<int>(nameof(GetAudioDangerLevel)); }
        public Object GetActorTemplateClassPtr() { return Invoke<Object>(nameof(GetActorTemplateClassPtr)); }
        public AnimalDataModel CreateFromVO(Object Outer, AnimalDataVO InVO) { return Invoke<AnimalDataModel>(nameof(CreateFromVO), Outer, InVO); }
    }
    public class ArmorDataModel : DataModelBase
    {
        public ArmorDataModel(ulong addr) : base(addr) { }
        public Array<DamageValuesDataModel> ArmorStats { get { return new Array<DamageValuesDataModel>(this[nameof(ArmorStats)].Address); } }
        public Array<PerkDataModel> Perks { get { return new Array<PerkDataModel>(this[nameof(Perks)].Address); } }
        public Array<PerkDataModel> GetPerks() { return Invoke<Array<PerkDataModel>>(nameof(GetPerks)); }
        public int GetItemId() { return Invoke<int>(nameof(GetItemId)); }
        public int GetId() { return Invoke<int>(nameof(GetId)); }
        public int GetHotModifier() { return Invoke<int>(nameof(GetHotModifier)); }
        public EEquipmentElement GetElement() { return Invoke<EEquipmentElement>(nameof(GetElement)); }
        public int GetColdModifier() { return Invoke<int>(nameof(GetColdModifier)); }
        public Array<DamageValuesDataModel> GetArmorStats() { return Invoke<Array<DamageValuesDataModel>>(nameof(GetArmorStats)); }
        public ArmorDataModel CreateFromVO(Object Outer, ArmorDataVO InVO) { return Invoke<ArmorDataModel>(nameof(CreateFromVO), Outer, InVO); }
    }
    public class AttackDataModel : DataModelBase
    {
        public AttackDataModel(ulong addr) : base(addr) { }
        public Object GetWeaponAnimMontageObjectPtr() { return Invoke<Object>(nameof(GetWeaponAnimMontageObjectPtr)); }
        public bool GetTrackTargetDuringAnim() { return Invoke<bool>(nameof(GetTrackTargetDuringAnim)); }
        public bool GetIsHoldAttack() { return Invoke<bool>(nameof(GetIsHoldAttack)); }
        public int GetId() { return Invoke<int>(nameof(GetId)); }
        public bool GetAttackComeFromRight() { return Invoke<bool>(nameof(GetAttackComeFromRight)); }
        public Object GetAnimMontageObjectPtr() { return Invoke<Object>(nameof(GetAnimMontageObjectPtr)); }
        public float GetAngle() { return Invoke<float>(nameof(GetAngle)); }
        public AttackDataModel CreateFromVO(Object Outer, AttackDataVO InVO) { return Invoke<AttackDataModel>(nameof(CreateFromVO), Outer, InVO); }
    }
    public class AttackStatsDataModel : DataModelBase
    {
        public AttackStatsDataModel(ulong addr) : base(addr) { }
        public Array<DamageValuesDataModel> Damages { get { return new Array<DamageValuesDataModel>(this[nameof(Damages)].Address); } }
        public Array<PerkDataModel> Perks { get { return new Array<PerkDataModel>(this[nameof(Perks)].Address); } }
        public bool RequireShield() { return Invoke<bool>(nameof(RequireShield)); }
        public bool IsBeamAttack() { return Invoke<bool>(nameof(IsBeamAttack)); }
        public float GetStaggerDuration() { return Invoke<float>(nameof(GetStaggerDuration)); }
        public float GetStaggerDistance() { return Invoke<float>(nameof(GetStaggerDistance)); }
        public int GetSpecialPointGain() { return Invoke<int>(nameof(GetSpecialPointGain)); }
        public int GetSpecialPointCost() { return Invoke<int>(nameof(GetSpecialPointCost)); }
        public Object GetSlashVFXObjectPtr() { return Invoke<Object>(nameof(GetSlashVFXObjectPtr)); }
        public float GetRagdollProjectionForce() { return Invoke<float>(nameof(GetRagdollProjectionForce)); }
        public float GetPushBackDuration() { return Invoke<float>(nameof(GetPushBackDuration)); }
        public float GetPushBackDistance() { return Invoke<float>(nameof(GetPushBackDistance)); }
        public ProjectileDataModel GetProjectile() { return Invoke<ProjectileDataModel>(nameof(GetProjectile)); }
        public Array<PerkDataModel> GetPerks() { return Invoke<Array<PerkDataModel>>(nameof(GetPerks)); }
        public int GetMunitionItemId() { return Invoke<int>(nameof(GetMunitionItemId)); }
        public float GetMinRange() { return Invoke<float>(nameof(GetMinRange)); }
        public int GetMinGiantLevel() { return Invoke<int>(nameof(GetMinGiantLevel)); }
        public float GetMaxRange() { return Invoke<float>(nameof(GetMaxRange)); }
        public bool GetIsCanceledOnHit() { return Invoke<bool>(nameof(GetIsCanceledOnHit)); }
        public Object GetImpactObjectPtr() { return Invoke<Object>(nameof(GetImpactObjectPtr)); }
        public bool GetIgnoreHurtSFX() { return Invoke<bool>(nameof(GetIgnoreHurtSFX)); }
        public bool GetIgnoreHitReaction() { return Invoke<bool>(nameof(GetIgnoreHitReaction)); }
        public float GetIgnoreGlobalCooldown() { return Invoke<float>(nameof(GetIgnoreGlobalCooldown)); }
        public int GetId() { return Invoke<int>(nameof(GetId)); }
        public Object GetIconObjectPtr() { return Invoke<Object>(nameof(GetIconObjectPtr)); }
        public bool GetGoesThroughShield() { return Invoke<bool>(nameof(GetGoesThroughShield)); }
        public EEquipmentElement GetElement() { return Invoke<EEquipmentElement>(nameof(GetElement)); }
        public bool GetDoesIgnoreStack() { return Invoke<bool>(nameof(GetDoesIgnoreStack)); }
        public Object GetDisplayName() { return Invoke<Object>(nameof(GetDisplayName)); }
        public Array<DamageValuesDataModel> GetDamages() { return Invoke<Array<DamageValuesDataModel>>(nameof(GetDamages)); }
        public float GetCooldownVariation() { return Invoke<float>(nameof(GetCooldownVariation)); }
        public float GetCooldown() { return Invoke<float>(nameof(GetCooldown)); }
        public Array<int> GetChannels() { return Invoke<Array<int>>(nameof(GetChannels)); }
        public bool GetCancelAttack() { return Invoke<bool>(nameof(GetCancelAttack)); }
        public bool GetCanBeEnergized() { return Invoke<bool>(nameof(GetCanBeEnergized)); }
        public float GetCameraShakeScale() { return Invoke<float>(nameof(GetCameraShakeScale)); }
        public float GetCameraShakeOnMiss() { return Invoke<float>(nameof(GetCameraShakeOnMiss)); }
        public int GetBrawlerComboPoint() { return Invoke<int>(nameof(GetBrawlerComboPoint)); }
        public Object GetAudioName() { return Invoke<Object>(nameof(GetAudioName)); }
        public EAttackType GetAttackType() { return Invoke<EAttackType>(nameof(GetAttackType)); }
        public AttackDataModel GetAttackMove() { return Invoke<AttackDataModel>(nameof(GetAttackMove)); }
        public Array<EAITrigger> GetAITriggers() { return Invoke<Array<EAITrigger>>(nameof(GetAITriggers)); }
        public PerkDataModel FindPerkOfType(EPerkType PerkType) { return Invoke<PerkDataModel>(nameof(FindPerkOfType), PerkType); }
        public bool DoConsumeDurability() { return Invoke<bool>(nameof(DoConsumeDurability)); }
        public AttackStatsDataModel CreateFromVO(Object Outer, AttackStatsDataVO InVO) { return Invoke<AttackStatsDataModel>(nameof(CreateFromVO), Outer, InVO); }
    }
    public class AvatarCosmeticDataModel : DataModelBase
    {
        public AvatarCosmeticDataModel(ulong addr) : base(addr) { }
        public Color Color { get { return this[nameof(Color)].As<Color>(); } set { this["Color"] = value; } }
        public ECosmeticType GetType() { return Invoke<ECosmeticType>(nameof(GetType)); }
        public Object GetTextureObjectPtr() { return Invoke<Object>(nameof(GetTextureObjectPtr)); }
        public Object GetSubSkeletalMeshObjectPtr(EGender Gender) { return Invoke<Object>(nameof(GetSubSkeletalMeshObjectPtr), Gender); }
        public int GetSortOrder() { return Invoke<int>(nameof(GetSortOrder)); }
        public Object GetSkeletalMeshObjectPtr(EGender Gender) { return Invoke<Object>(nameof(GetSkeletalMeshObjectPtr), Gender); }
        public int GetRequiredEntitlementId() { return Invoke<int>(nameof(GetRequiredEntitlementId)); }
        public EItemRarity GetRarity() { return Invoke<EItemRarity>(nameof(GetRarity)); }
        public Object GetLocalizedName() { return Invoke<Object>(nameof(GetLocalizedName)); }
        public Object GetLocalizedDescription() { return Invoke<Object>(nameof(GetLocalizedDescription)); }
        public int GetId() { return Invoke<int>(nameof(GetId)); }
        public Object GetIconObjectPtr() { return Invoke<Object>(nameof(GetIconObjectPtr)); }
        public int GetExternalAssetId() { return Invoke<int>(nameof(GetExternalAssetId)); }
        public Object GetEmoteObjectPtr() { return Invoke<Object>(nameof(GetEmoteObjectPtr)); }
        public Color GetColor() { return Invoke<Color>(nameof(GetColor)); }
    }
    public class AvatarIconDataModel : DataModelBase
    {
        public AvatarIconDataModel(ulong addr) : base(addr) { }
        public Object GetSmallIconObjectPtr() { return Invoke<Object>(nameof(GetSmallIconObjectPtr)); }
        public Object GetPinIconObjectPtr() { return Invoke<Object>(nameof(GetPinIconObjectPtr)); }
        public Object GetLocalizedName() { return Invoke<Object>(nameof(GetLocalizedName)); }
        public Object GetLocalizedDescription() { return Invoke<Object>(nameof(GetLocalizedDescription)); }
        public int GetId() { return Invoke<int>(nameof(GetId)); }
        public Object GetIconObjectPtr() { return Invoke<Object>(nameof(GetIconObjectPtr)); }
    }
    public class AvatarPetDataModel : DataModelBase
    {
        public AvatarPetDataModel(ulong addr) : base(addr) { }
        public Object GetLocalizedName() { return Invoke<Object>(nameof(GetLocalizedName)); }
        public Object GetLocalizedDescription() { return Invoke<Object>(nameof(GetLocalizedDescription)); }
        public Object GetLobbyActorPtr() { return Invoke<Object>(nameof(GetLobbyActorPtr)); }
        public int GetId() { return Invoke<int>(nameof(GetId)); }
        public Object GetIconObjectPtr() { return Invoke<Object>(nameof(GetIconObjectPtr)); }
        public AnimalDataModel GetAnimalData() { return Invoke<AnimalDataModel>(nameof(GetAnimalData)); }
    }
    public class BiomeDataModel : DataModelBase
    {
        public BiomeDataModel(ulong addr) : base(addr) { }
        public RarityDataModel Rarity { get { return this[nameof(Rarity)].As<RarityDataModel>(); } set { this["Rarity"] = value; } }
        public Object GetDisplayName() { return Invoke<Object>(nameof(GetDisplayName)); }
    }
    public class BiomeLevelDataModel : DataModelBase
    {
        public BiomeLevelDataModel(ulong addr) : base(addr) { }
        public int GetPowerLevel() { return Invoke<int>(nameof(GetPowerLevel)); }
        public int GetBiomeLevel() { return Invoke<int>(nameof(GetBiomeLevel)); }
        public int GetBiomeId() { return Invoke<int>(nameof(GetBiomeId)); }
    }
    public class BlueprintDataModel : DataModelBase
    {
        public BlueprintDataModel(ulong addr) : base(addr) { }
        public CraftingRecipeDataModel CraftingRecipe { get { return this[nameof(CraftingRecipe)].As<CraftingRecipeDataModel>(); } set { this["CraftingRecipe"] = value; } }
        public ModifierDataModel Modifier { get { return this[nameof(Modifier)].As<ModifierDataModel>(); } set { this["Modifier"] = value; } }
        public int GetUnlockedRecipeId() { return Invoke<int>(nameof(GetUnlockedRecipeId)); }
        public CraftingRecipeDataModel GetUnlockedRecipe() { return Invoke<CraftingRecipeDataModel>(nameof(GetUnlockedRecipe)); }
        public ModifierDataModel GetUnlockedModifier() { return Invoke<ModifierDataModel>(nameof(GetUnlockedModifier)); }
        public int GetTreeCoordinateY() { return Invoke<int>(nameof(GetTreeCoordinateY)); }
        public ItemDataModel GetResultItem() { return Invoke<ItemDataModel>(nameof(GetResultItem)); }
        public EItemRarity GetRarity() { return Invoke<EItemRarity>(nameof(GetRarity)); }
        public Object GetLockedDescription() { return Invoke<Object>(nameof(GetLockedDescription)); }
        public bool GetIsLockedByDefault() { return Invoke<bool>(nameof(GetIsLockedByDefault)); }
        public int GetId() { return Invoke<int>(nameof(GetId)); }
        public Object GetDisplayName() { return Invoke<Object>(nameof(GetDisplayName)); }
        public EBlueprintTypes GetBlueprintType() { return Invoke<EBlueprintTypes>(nameof(GetBlueprintType)); }
    }
    public class BuildingDataModel : DataModelBase
    {
        public BuildingDataModel(ulong addr) : base(addr) { }
        public float GetStartingHealth() { return Invoke<float>(nameof(GetStartingHealth)); }
        public int GetId() { return Invoke<int>(nameof(GetId)); }
        public float GetHealth() { return Invoke<float>(nameof(GetHealth)); }
    }
    public class CaveDataModel : DataModelBase
    {
        public CaveDataModel(ulong addr) : base(addr) { }
        public bool IsEnable() { return Invoke<bool>(nameof(IsEnable)); }
        public int GetId() { return Invoke<int>(nameof(GetId)); }
        public Array<int> GetFloorIds() { return Invoke<Array<int>>(nameof(GetFloorIds)); }
        public ECaveType GetCaveType() { return Invoke<ECaveType>(nameof(GetCaveType)); }
        public Array<int> GetBiomeIds() { return Invoke<Array<int>>(nameof(GetBiomeIds)); }
        public Object GetActorTemplate() { return Invoke<Object>(nameof(GetActorTemplate)); }
    }
    public class ChallengeDataModel : DataModelBase
    {
        public ChallengeDataModel(ulong addr) : base(addr) { }
        public ChallengeDataVO VO { get { return this[nameof(VO)].As<ChallengeDataVO>(); } set { this["VO"] = value; } }
        public bool IsAutoClaim() { return Invoke<bool>(nameof(IsAutoClaim)); }
        public int GetSortOrder() { return Invoke<int>(nameof(GetSortOrder)); }
        public Array<RewardDataVO> GetRewards() { return Invoke<Array<RewardDataVO>>(nameof(GetRewards)); }
        public int GetId() { return Invoke<int>(nameof(GetId)); }
        public Object GetIcon() { return Invoke<Object>(nameof(GetIcon)); }
        public Object GetDisplayName() { return Invoke<Object>(nameof(GetDisplayName)); }
        public Object GetDescription() { return Invoke<Object>(nameof(GetDescription)); }
        public Array<ChallengeConditionDataVO> GetConditions() { return Invoke<Array<ChallengeConditionDataVO>>(nameof(GetConditions)); }
        public EChallengeCategory GetChallengeCategory() { return Invoke<EChallengeCategory>(nameof(GetChallengeCategory)); }
    }
    public class CharacterDataModel : DataModelBase
    {
        public CharacterDataModel(ulong addr) : base(addr) { }
        public AnimMontage HitReactionRight { get { return this[nameof(HitReactionRight)].As<AnimMontage>(); } set { this["HitReactionRight"] = value; } }
        public AnimMontage HitReactionLeft { get { return this[nameof(HitReactionLeft)].As<AnimMontage>(); } set { this["HitReactionLeft"] = value; } }
        public bool UseDownState() { return Invoke<bool>(nameof(UseDownState)); }
        public float GetWeigth() { return Invoke<float>(nameof(GetWeigth)); }
        public ECharacterType GetType() { return Invoke<ECharacterType>(nameof(GetType)); }
        public int GetStartingSpecialPoint() { return Invoke<int>(nameof(GetStartingSpecialPoint)); }
        public float GetStaggerDuration() { return Invoke<float>(nameof(GetStaggerDuration)); }
        public float GetSprintingSpeed() { return Invoke<float>(nameof(GetSprintingSpeed)); }
        public float GetShieldingSpeed() { return Invoke<float>(nameof(GetShieldingSpeed)); }
        public float GetRespawnTime() { return Invoke<float>(nameof(GetRespawnTime)); }
        public int GetMaxSpecialPoint() { return Invoke<int>(nameof(GetMaxSpecialPoint)); }
        public bool GetIsImmuneToPushBack() { return Invoke<bool>(nameof(GetIsImmuneToPushBack)); }
        public bool GetIsImmuneToCancel() { return Invoke<bool>(nameof(GetIsImmuneToCancel)); }
        public int GetInventoryId() { return Invoke<int>(nameof(GetInventoryId)); }
        public int GetId() { return Invoke<int>(nameof(GetId)); }
        public Array<int> GetHotPerkIds() { return Invoke<Array<int>>(nameof(GetHotPerkIds)); }
        public AnimMontage GetHitReactionRight() { return Invoke<AnimMontage>(nameof(GetHitReactionRight)); }
        public AnimMontage GetHitReactionLeft() { return Invoke<AnimMontage>(nameof(GetHitReactionLeft)); }
        public float GetHealth() { return Invoke<float>(nameof(GetHealth)); }
        public int GetEquipmentId() { return Invoke<int>(nameof(GetEquipmentId)); }
        public int GetDownStateStartingAmount() { return Invoke<int>(nameof(GetDownStateStartingAmount)); }
        public float GetDownStateDecayRate() { return Invoke<float>(nameof(GetDownStateDecayRate)); }
        public int GetDownStateDecayAmount() { return Invoke<int>(nameof(GetDownStateDecayAmount)); }
        public Object GetDisplayName() { return Invoke<Object>(nameof(GetDisplayName)); }
        public int GetDefaultWeaponId() { return Invoke<int>(nameof(GetDefaultWeaponId)); }
        public int GetDefaultHotResistance() { return Invoke<int>(nameof(GetDefaultHotResistance)); }
        public int GetDefaultColdResistance() { return Invoke<int>(nameof(GetDefaultColdResistance)); }
        public Array<int> GetColdPerkIds() { return Invoke<Array<int>>(nameof(GetColdPerkIds)); }
    }
    public class CodexEntryDataModel : DataModelBase
    {
        public CodexEntryDataModel(ulong addr) : base(addr) { }
        public void SortCodexEntityArray(Array<CodexEntryDataModel> arrayToSort) { Invoke(nameof(SortCodexEntityArray), arrayToSort); }
        public int GetTargetId() { return Invoke<int>(nameof(GetTargetId)); }
        public int GetSortOrder() { return Invoke<int>(nameof(GetSortOrder)); }
        public int GetRarityId() { return Invoke<int>(nameof(GetRarityId)); }
        public EItemRarity GetRarity() { return Invoke<EItemRarity>(nameof(GetRarity)); }
        public Object GetImage() { return Invoke<Object>(nameof(GetImage)); }
        public int GetId() { return Invoke<int>(nameof(GetId)); }
        public Object GetIcon() { return Invoke<Object>(nameof(GetIcon)); }
        public ECodexEntryType GetEntryType() { return Invoke<ECodexEntryType>(nameof(GetEntryType)); }
        public int GetElementId() { return Invoke<int>(nameof(GetElementId)); }
        public EEquipmentElement GetElement() { return Invoke<EEquipmentElement>(nameof(GetElement)); }
        public Object GetDisplayName() { return Invoke<Object>(nameof(GetDisplayName)); }
        public Object GetDescription() { return Invoke<Object>(nameof(GetDescription)); }
        public Array<int> GetBiomeIds() { return Invoke<Array<int>>(nameof(GetBiomeIds)); }
    }
    public class ConstructionRecipeDataModel : DataModelBase
    {
        public ConstructionRecipeDataModel(ulong addr) : base(addr) { }
        public HazardDataModel HazardDataModel { get { return this[nameof(HazardDataModel)].As<HazardDataModel>(); } set { this["HazardDataModel"] = value; } }
        public HazardDataModel CornerHazardDataModel { get { return this[nameof(CornerHazardDataModel)].As<HazardDataModel>(); } set { this["CornerHazardDataModel"] = value; } }
        public HazardDataModel AlternativeHazardDataModel { get { return this[nameof(AlternativeHazardDataModel)].As<HazardDataModel>(); } set { this["AlternativeHazardDataModel"] = value; } }
        public HazardDataModel CornerAlternativeHazardDataModel { get { return this[nameof(CornerAlternativeHazardDataModel)].As<HazardDataModel>(); } set { this["CornerAlternativeHazardDataModel"] = value; } }
        public Array<CraftingRecipeElementDataModel> RecipeElements { get { return new Array<CraftingRecipeElementDataModel>(this[nameof(RecipeElements)].Address); } }
        public bool HasDifferentCorner() { return Invoke<bool>(nameof(HasDifferentCorner)); }
        public bool GetUseGridValidation() { return Invoke<bool>(nameof(GetUseGridValidation)); }
        public int GetUISlotIndex() { return Invoke<int>(nameof(GetUISlotIndex)); }
        public bool GetSnapToGround() { return Invoke<bool>(nameof(GetSnapToGround)); }
        public int GetSizeY() { return Invoke<int>(nameof(GetSizeY)); }
        public int GetSize() { return Invoke<int>(nameof(GetSize)); }
        public Array<CraftingRecipeElementDataModel> GetRecipeElements() { return Invoke<Array<CraftingRecipeElementDataModel>>(nameof(GetRecipeElements)); }
        public Object GetRadialTabName() { return Invoke<Object>(nameof(GetRadialTabName)); }
        public bool GetOrientConstruction() { return Invoke<bool>(nameof(GetOrientConstruction)); }
        public int GetItemId() { return Invoke<int>(nameof(GetItemId)); }
        public int GetId() { return Invoke<int>(nameof(GetId)); }
        public Object GetIconObjectPtr() { return Invoke<Object>(nameof(GetIconObjectPtr)); }
        public HazardDataModel GetHazardDataModel() { return Invoke<HazardDataModel>(nameof(GetHazardDataModel)); }
        public int GetGridSize() { return Invoke<int>(nameof(GetGridSize)); }
        public HazardDataModel GetFlipHazardDataModel() { return Invoke<HazardDataModel>(nameof(GetFlipHazardDataModel)); }
        public Object GetDisplayName() { return Invoke<Object>(nameof(GetDisplayName)); }
        public HazardDataModel GetCornerHazardDataModel() { return Invoke<HazardDataModel>(nameof(GetCornerHazardDataModel)); }
        public HazardDataModel GetCornerFlipHazardDataModel() { return Invoke<HazardDataModel>(nameof(GetCornerFlipHazardDataModel)); }
        public HazardDataModel FindHazardModel(bool bIsCorner, bool bAlternative) { return Invoke<HazardDataModel>(nameof(FindHazardModel), bIsCorner, bAlternative); }
        public ConstructionRecipeDataModel CreateFromVO(Object Outer, ConstructionRecipeDataVO InVO) { return Invoke<ConstructionRecipeDataModel>(nameof(CreateFromVO), Outer, InVO); }
        public bool AllowBuildingOnFoundation() { return Invoke<bool>(nameof(AllowBuildingOnFoundation)); }
    }
    public class ConsumableDataModel : DataModelBase
    {
        public ConsumableDataModel(ulong addr) : base(addr) { }
        public Array<PerkDataModel> Perks { get { return new Array<PerkDataModel>(this[nameof(Perks)].Address); } }
        public Array<PerkDataModel> GetPerks() { return Invoke<Array<PerkDataModel>>(nameof(GetPerks)); }
        public int GetItemId() { return Invoke<int>(nameof(GetItemId)); }
        public int GetId() { return Invoke<int>(nameof(GetId)); }
        public Object GetAudioName() { return Invoke<Object>(nameof(GetAudioName)); }
    }
    public class ContainerDataModel : DataModelBase
    {
        public ContainerDataModel(ulong addr) : base(addr) { }
        public EContainerType GetType() { return Invoke<EContainerType>(nameof(GetType)); }
        public Array<ContainerSlotDataVO> GetSlots() { return Invoke<Array<ContainerSlotDataVO>>(nameof(GetSlots)); }
        public Array<ContainerSettingsDataVO> GetSettings() { return Invoke<Array<ContainerSettingsDataVO>>(nameof(GetSettings)); }
        public int GetId() { return Invoke<int>(nameof(GetId)); }
        public Object GetDisplayName() { return Invoke<Object>(nameof(GetDisplayName)); }
    }
    public class ContentBundleDataModel : DataModelBase
    {
        public ContentBundleDataModel(ulong addr) : base(addr) { }
        public int GetId() { return Invoke<int>(nameof(GetId)); }
        public Array<int> GetEntitlements() { return Invoke<Array<int>>(nameof(GetEntitlements)); }
        public Array<int> GetCosmetics() { return Invoke<Array<int>>(nameof(GetCosmetics)); }
        public Array<int> GetBlueprints() { return Invoke<Array<int>>(nameof(GetBlueprints)); }
    }
    public class CraftingRecipeDataModel : DataModelBase
    {
        public CraftingRecipeDataModel(ulong addr) : base(addr) { }
        public Array<CraftingRecipeElementDataModel> RecipeElements { get { return new Array<CraftingRecipeElementDataModel>(this[nameof(RecipeElements)].Address); } }
        public void SortRecipesArray(ESortType sortType, Array<CraftingRecipeDataModel> arrayToSort) { Invoke(nameof(SortRecipesArray), sortType, arrayToSort); }
        public int GetSortOrder() { return Invoke<int>(nameof(GetSortOrder)); }
        public ESellerType GetSellerType() { return Invoke<ESellerType>(nameof(GetSellerType)); }
        public int GetResultItemId() { return Invoke<int>(nameof(GetResultItemId)); }
        public ItemDataModel GetResultItem() { return Invoke<ItemDataModel>(nameof(GetResultItem)); }
        public Array<CraftingRecipeElementDataModel> GetRecipeElements() { return Invoke<Array<CraftingRecipeElementDataModel>>(nameof(GetRecipeElements)); }
        public int GetMinUpgradeLevel() { return Invoke<int>(nameof(GetMinUpgradeLevel)); }
        public int GetId() { return Invoke<int>(nameof(GetId)); }
        public Object GetDisplayName() { return Invoke<Object>(nameof(GetDisplayName)); }
        public Object GetAudioName() { return Invoke<Object>(nameof(GetAudioName)); }
    }
    public class CraftingRecipeElementDataModel : DataModelBase
    {
        public CraftingRecipeElementDataModel(ulong addr) : base(addr) { }
        public int GetItemId() { return Invoke<int>(nameof(GetItemId)); }
        public ItemDataModel GetItem() { return Invoke<ItemDataModel>(nameof(GetItem)); }
        public int GetCount() { return Invoke<int>(nameof(GetCount)); }
    }
    public class CreaturePackDataModel : DataModelBase
    {
        public CreaturePackDataModel(ulong addr) : base(addr) { }
        public int GetId() { return Invoke<int>(nameof(GetId)); }
        public Array<CreaturePackEntryDataVO> GetCreatures() { return Invoke<Array<CreaturePackEntryDataVO>>(nameof(GetCreatures)); }
    }
    public class DamageTypeDataModel : DataModelBase
    {
        public DamageTypeDataModel(ulong addr) : base(addr) { }
        public int GetId() { return Invoke<int>(nameof(GetId)); }
        public Object GetIconObjectPtr() { return Invoke<Object>(nameof(GetIconObjectPtr)); }
        public EEquipmentElement GetElement() { return Invoke<EEquipmentElement>(nameof(GetElement)); }
        public float GetDamageCap() { return Invoke<float>(nameof(GetDamageCap)); }
        public LinearColor GetColor() { return Invoke<LinearColor>(nameof(GetColor)); }
        public DamageTypeDataModel CreateFromVO(Object Outer, DamageTypeDataVO InVO) { return Invoke<DamageTypeDataModel>(nameof(CreateFromVO), Outer, InVO); }
    }
    public class DamageValuesDataModel : DataModelBase
    {
        public DamageValuesDataModel(ulong addr) : base(addr) { }
        public float GetValue() { return Invoke<float>(nameof(GetValue)); }
        public float GetMinValue() { return Invoke<float>(nameof(GetMinValue)); }
        public float GetMaxValue() { return Invoke<float>(nameof(GetMaxValue)); }
        public float GetGiantScaling() { return Invoke<float>(nameof(GetGiantScaling)); }
        public int GetDamageTypeId() { return Invoke<int>(nameof(GetDamageTypeId)); }
        public DamageValuesDataModel CreateFromVO(Object Outer, DamageValuesDataVO InVO) { return Invoke<DamageValuesDataModel>(nameof(CreateFromVO), Outer, InVO); }
    }
    public class DataModelInterface : Interface
    {
        public DataModelInterface(ulong addr) : base(addr) { }
    }
    public class DayCycleDataModel : DataModelBase
    {
        public DayCycleDataModel(ulong addr) : base(addr) { }
        public float GetWinterIntensity() { return Invoke<float>(nameof(GetWinterIntensity)); }
        public int GetTemperatureModifier() { return Invoke<int>(nameof(GetTemperatureModifier)); }
        public int GetSunsetStartTime() { return Invoke<int>(nameof(GetSunsetStartTime)); }
        public int GetSunriseStartTime() { return Invoke<int>(nameof(GetSunriseStartTime)); }
        public float GetSnowflakeIntensity() { return Invoke<float>(nameof(GetSnowflakeIntensity)); }
        public ESeason GetSeason() { return Invoke<ESeason>(nameof(GetSeason)); }
        public int GetNightStartTime() { return Invoke<int>(nameof(GetNightStartTime)); }
        public bool GetIsNightOnly() { return Invoke<bool>(nameof(GetIsNightOnly)); }
        public int GetId() { return Invoke<int>(nameof(GetId)); }
        public int GetGroup() { return Invoke<int>(nameof(GetGroup)); }
        public int GetDay() { return Invoke<int>(nameof(GetDay)); }
        public Array<DailyAnnouncementVO> GetDailyAnnouncements() { return Invoke<Array<DailyAnnouncementVO>>(nameof(GetDailyAnnouncements)); }
        public float GetBloodMoonIntensity() { return Invoke<float>(nameof(GetBloodMoonIntensity)); }
        public DayCycleDataModel CreateFromVO(Object Outer, DayCycleDataVO InVO) { return Invoke<DayCycleDataModel>(nameof(CreateFromVO), Outer, InVO); }
    }
    public class DialogDataModel : DataModelBase
    {
        public DialogDataModel(ulong addr) : base(addr) { }
        public int GetSpeakerIndex(int Index) { return Invoke<int>(nameof(GetSpeakerIndex), Index); }
        public Object GetNPCVO() { return Invoke<Object>(nameof(GetNPCVO)); }
        public Object GetNPCPortraitObjectPtr(int SpeakerIndex) { return Invoke<Object>(nameof(GetNPCPortraitObjectPtr), SpeakerIndex); }
        public Object GetNPCName(int SpeakerIndex) { return Invoke<Object>(nameof(GetNPCName), SpeakerIndex); }
        public int GetId() { return Invoke<int>(nameof(GetId)); }
        public int GetDialogLinesCount() { return Invoke<int>(nameof(GetDialogLinesCount)); }
        public Object GetDialogLine(int Index) { return Invoke<Object>(nameof(GetDialogLine), Index); }
    }
    public class DoorDataModel : DataModelBase
    {
        public DoorDataModel(ulong addr) : base(addr) { }
        public bool IsTriggerable() { return Invoke<bool>(nameof(IsTriggerable)); }
        public EDoorType GetType() { return Invoke<EDoorType>(nameof(GetType)); }
        public ESeason GetSeason() { return Invoke<ESeason>(nameof(GetSeason)); }
        public int GetId() { return Invoke<int>(nameof(GetId)); }
        public Object GetDisplayName() { return Invoke<Object>(nameof(GetDisplayName)); }
        public Object GetDescription() { return Invoke<Object>(nameof(GetDescription)); }
        public bool GetDefaultOpeningState() { return Invoke<bool>(nameof(GetDefaultOpeningState)); }
        public int GetContainerId() { return Invoke<int>(nameof(GetContainerId)); }
        public DoorDataModel CreateFromVO(Object Outer, DoorDataVO InVO) { return Invoke<DoorDataModel>(nameof(CreateFromVO), Outer, InVO); }
    }
    public class EntitlementDataModel : DataModelBase
    {
        public EntitlementDataModel(ulong addr) : base(addr) { }
        public EEntitlementType GetType() { return Invoke<EEntitlementType>(nameof(GetType)); }
        public int GetId() { return Invoke<int>(nameof(GetId)); }
    }
    public class FortificationDataModel : DataModelBase
    {
        public FortificationDataModel(ulong addr) : base(addr) { }
        public EFortificationType GetType() { return Invoke<EFortificationType>(nameof(GetType)); }
        public int GetId() { return Invoke<int>(nameof(GetId)); }
        public float GetHealth() { return Invoke<float>(nameof(GetHealth)); }
        public int GetDoorDataId() { return Invoke<int>(nameof(GetDoorDataId)); }
        public Object GetDisplayName() { return Invoke<Object>(nameof(GetDisplayName)); }
        public Object GetDescription() { return Invoke<Object>(nameof(GetDescription)); }
        public FortificationDataModel CreateFromVO(Object Outer, FortificationDataVO InVO) { return Invoke<FortificationDataModel>(nameof(CreateFromVO), Outer, InVO); }
    }
    public class GameEventDataModel : DataModelBase
    {
        public GameEventDataModel(ulong addr) : base(addr) { }
        public Array<LootDataModel> LootTable { get { return new Array<LootDataModel>(this[nameof(LootTable)].Address); } }
        public int GetXpOnCompletion() { return Invoke<int>(nameof(GetXpOnCompletion)); }
        public float GetStartTime() { return Invoke<float>(nameof(GetStartTime)); }
        public Object GetStartAnnouncements() { return Invoke<Object>(nameof(GetStartAnnouncements)); }
        public float GetProbability() { return Invoke<float>(nameof(GetProbability)); }
        public int GetMinStartDay() { return Invoke<int>(nameof(GetMinStartDay)); }
        public int GetMaxStartDay() { return Invoke<int>(nameof(GetMaxStartDay)); }
        public Array<LootDataModel> GetLootTable() { return Invoke<Array<LootDataModel>>(nameof(GetLootTable)); }
        public int GetId() { return Invoke<int>(nameof(GetId)); }
        public Object GetIcon() { return Invoke<Object>(nameof(GetIcon)); }
        public Object GetEventLogicTemplateClassPtr() { return Invoke<Object>(nameof(GetEventLogicTemplateClassPtr)); }
        public Object GetEndAnnouncements() { return Invoke<Object>(nameof(GetEndAnnouncements)); }
        public float GetDuration() { return Invoke<float>(nameof(GetDuration)); }
        public DataObject GetConfig() { return Invoke<DataObject>(nameof(GetConfig)); }
        public Object GetCompletedAnnouncements() { return Invoke<Object>(nameof(GetCompletedAnnouncements)); }
    }
    public class GameModeDataModel : DataModelBase
    {
        public GameModeDataModel(ulong addr) : base(addr) { }
        public float GetQuestGiverSpawnRatio() { return Invoke<float>(nameof(GetQuestGiverSpawnRatio)); }
        public EGameMode GetMode() { return Invoke<EGameMode>(nameof(GetMode)); }
        public int GetMinLevelRequired() { return Invoke<int>(nameof(GetMinLevelRequired)); }
        public bool GetIsSagaQuestActive() { return Invoke<bool>(nameof(GetIsSagaQuestActive)); }
        public bool GetIsEnabled() { return Invoke<bool>(nameof(GetIsEnabled)); }
        public bool GetIsDisplayed() { return Invoke<bool>(nameof(GetIsDisplayed)); }
        public int GetId() { return Invoke<int>(nameof(GetId)); }
        public bool GetDoSpawnMythBossModule() { return Invoke<bool>(nameof(GetDoSpawnMythBossModule)); }
        public bool GetDoSpawnBifrostModule() { return Invoke<bool>(nameof(GetDoSpawnBifrostModule)); }
        public DataObject GetDifficultySettingsIndexes() { return Invoke<DataObject>(nameof(GetDifficultySettingsIndexes)); }
        public DataObject GetDifficultySettings() { return Invoke<DataObject>(nameof(GetDifficultySettings)); }
        public int GetDaysCycleGroup() { return Invoke<int>(nameof(GetDaysCycleGroup)); }
        public bool GetCanDropCurrencies() { return Invoke<bool>(nameof(GetCanDropCurrencies)); }
        public bool DayCycleLoop() { return Invoke<bool>(nameof(DayCycleLoop)); }
    }
    public class GameSeasonDataModel : DataModelBase
    {
        public GameSeasonDataModel(ulong addr) : base(addr) { }
        public DateTime GetStartTime() { return Invoke<DateTime>(nameof(GetStartTime)); }
        public Timespan GetRemainingTime() { return Invoke<Timespan>(nameof(GetRemainingTime)); }
        public int GetId() { return Invoke<int>(nameof(GetId)); }
        public DateTime GetEndTime() { return Invoke<DateTime>(nameof(GetEndTime)); }
        public Object GetDisplayName() { return Invoke<Object>(nameof(GetDisplayName)); }
    }
    public class GiantDataModel : DataModelBase
    {
        public GiantDataModel(ulong addr) : base(addr) { }
        public Object GetMapIconGreyed() { return Invoke<Object>(nameof(GetMapIconGreyed)); }
        public Object GetMapIcon() { return Invoke<Object>(nameof(GetMapIcon)); }
        public int GetId() { return Invoke<int>(nameof(GetId)); }
        public Object GetIcon() { return Invoke<Object>(nameof(GetIcon)); }
        public EEquipmentElement GetElement() { return Invoke<EEquipmentElement>(nameof(GetElement)); }
        public Object GetDisplayName() { return Invoke<Object>(nameof(GetDisplayName)); }
        public AnimalDataModel GetAnimalData() { return Invoke<AnimalDataModel>(nameof(GetAnimalData)); }
        public Object GetActorTemplateClassPtr() { return Invoke<Object>(nameof(GetActorTemplateClassPtr)); }
        public bool CanSpawn() { return Invoke<bool>(nameof(CanSpawn)); }
    }
    public class HazardDataModel : DataModelBase
    {
        public HazardDataModel(ulong addr) : base(addr) { }
        public Array<LootDataModel> LootTable { get { return new Array<LootDataModel>(this[nameof(LootTable)].Address); } }
        public bool IsCaveEntrance() { return Invoke<bool>(nameof(IsCaveEntrance)); }
        public int GetXpOnInteract() { return Invoke<int>(nameof(GetXpOnInteract)); }
        public int GetWeightedLootId() { return Invoke<int>(nameof(GetWeightedLootId)); }
        public float GetRespawnRate() { return Invoke<float>(nameof(GetRespawnRate)); }
        public MaterialSourceDataModel GetMaterialSourceDataModel() { return Invoke<MaterialSourceDataModel>(nameof(GetMaterialSourceDataModel)); }
        public Object GetMapIconObjectPtr() { return Invoke<Object>(nameof(GetMapIconObjectPtr)); }
        public Array<LootDataModel> GetLootTable() { return Invoke<Array<LootDataModel>>(nameof(GetLootTable)); }
        public float GetLifetime() { return Invoke<float>(nameof(GetLifetime)); }
        public int GetId() { return Invoke<int>(nameof(GetId)); }
        public float GetHealth() { return Invoke<float>(nameof(GetHealth)); }
        public Object GetDisplayName() { return Invoke<Object>(nameof(GetDisplayName)); }
        public int GetDetectionRangeSquared() { return Invoke<int>(nameof(GetDetectionRangeSquared)); }
        public int GetDetectionRange() { return Invoke<int>(nameof(GetDetectionRange)); }
        public Array<int> GetDetectionChannels() { return Invoke<Array<int>>(nameof(GetDetectionChannels)); }
        public float GetDamageMultitplier() { return Invoke<float>(nameof(GetDamageMultitplier)); }
        public int GetContainerId() { return Invoke<int>(nameof(GetContainerId)); }
        public int GetChannel() { return Invoke<int>(nameof(GetChannel)); }
        public AttackStatsDataModel GetAttackStats() { return Invoke<AttackStatsDataModel>(nameof(GetAttackStats)); }
        public Object GetActorTemplateClassPtr() { return Invoke<Object>(nameof(GetActorTemplateClassPtr)); }
        public HazardDataModel CreateFromVO(Object Outer, HazardDataVO InVO) { return Invoke<HazardDataModel>(nameof(CreateFromVO), Outer, InVO); }
    }
    public class IAPPackDataModel : DataModelBase
    {
        public IAPPackDataModel(ulong addr) : base(addr) { }
        public int GetSortOrder() { return Invoke<int>(nameof(GetSortOrder)); }
        public RewardDataVO GetReward() { return Invoke<RewardDataVO>(nameof(GetReward)); }
        public Object GetPrice() { return Invoke<Object>(nameof(GetPrice)); }
        public Object GetName() { return Invoke<Object>(nameof(GetName)); }
        public Object GetLocalePrice(Object Currency) { return Invoke<Object>(nameof(GetLocalePrice), Currency); }
        public bool GetIsAvailable() { return Invoke<bool>(nameof(GetIsAvailable)); }
        public int GetId() { return Invoke<int>(nameof(GetId)); }
        public Object GetIcon() { return Invoke<Object>(nameof(GetIcon)); }
    }
    public class ItemDataModel : DataModelBase
    {
        public ItemDataModel(ulong addr) : base(addr) { }
        public bool IsHidden() { return Invoke<bool>(nameof(IsHidden)); }
        public ItemTypeDataModel GetType() { return Invoke<ItemTypeDataModel>(nameof(GetType)); }
        public int GetThunderEquippedPower() { return Invoke<int>(nameof(GetThunderEquippedPower)); }
        public ItemRarityDataModel GetRarityModel() { return Invoke<ItemRarityDataModel>(nameof(GetRarityModel)); }
        public int GetRarityId() { return Invoke<int>(nameof(GetRarityId)); }
        public EItemRarity GetRarity() { return Invoke<EItemRarity>(nameof(GetRarity)); }
        public int GetMaxStackPouch() { return Invoke<int>(nameof(GetMaxStackPouch)); }
        public Object GetLootBagBPNotInstanced() { return Invoke<Object>(nameof(GetLootBagBPNotInstanced)); }
        public Object GetLootBagBPInstanced() { return Invoke<Object>(nameof(GetLootBagBPInstanced)); }
        public bool GetIsInfinite() { return Invoke<bool>(nameof(GetIsInfinite)); }
        public int GetId() { return Invoke<int>(nameof(GetId)); }
        public Object GetIconObjectPtr() { return Invoke<Object>(nameof(GetIconObjectPtr)); }
        public int GetIceEquippedPower() { return Invoke<int>(nameof(GetIceEquippedPower)); }
        public int GetFireEquippedPower() { return Invoke<int>(nameof(GetFireEquippedPower)); }
        public bool GetExcludeFromLootEveryItem() { return Invoke<bool>(nameof(GetExcludeFromLootEveryItem)); }
        public int GetEquippedPower() { return Invoke<int>(nameof(GetEquippedPower)); }
        public int GetDurability() { return Invoke<int>(nameof(GetDurability)); }
        public Object GetDisplayName() { return Invoke<Object>(nameof(GetDisplayName)); }
        public Object GetDescription() { return Invoke<Object>(nameof(GetDescription)); }
        public int GetDarkEquippedPower() { return Invoke<int>(nameof(GetDarkEquippedPower)); }
        public Object GetAudioName() { return Invoke<Object>(nameof(GetAudioName)); }
        public Object GetAudioEventPickUp() { return Invoke<Object>(nameof(GetAudioEventPickUp)); }
        public Object GetActorTemplateClassPtr(bool bUseFemale) { return Invoke<Object>(nameof(GetActorTemplateClassPtr), bUseFemale); }
        public bool AlwaysSwitch() { return Invoke<bool>(nameof(AlwaysSwitch)); }
    }
    public class ItemRarityDataModel : DataModelBase
    {
        public ItemRarityDataModel(ulong addr) : base(addr) { }
        public Array<LootDataModel> SalvageLootTable { get { return new Array<LootDataModel>(this[nameof(SalvageLootTable)].Address); } }
        public Color Color { get { return this[nameof(Color)].As<Color>(); } set { this["Color"] = value; } }
        public Array<LootDataModel> GetSalvageLootTable() { return Invoke<Array<LootDataModel>>(nameof(GetSalvageLootTable)); }
        public int GetRepairCostPerPercentileTier() { return Invoke<int>(nameof(GetRepairCostPerPercentileTier)); }
        public int GetRepairBrokenCost() { return Invoke<int>(nameof(GetRepairBrokenCost)); }
        public EItemRarity GetRarity() { return Invoke<EItemRarity>(nameof(GetRarity)); }
        public float GetOfferingLootMultiplier() { return Invoke<float>(nameof(GetOfferingLootMultiplier)); }
        public float GetMaterialMultiplier() { return Invoke<float>(nameof(GetMaterialMultiplier)); }
        public int GetId() { return Invoke<int>(nameof(GetId)); }
        public int GetDismantleValuePerPercentileTier() { return Invoke<int>(nameof(GetDismantleValuePerPercentileTier)); }
        public Color GetColor() { return Invoke<Color>(nameof(GetColor)); }
        public Object GetAudioName() { return Invoke<Object>(nameof(GetAudioName)); }
    }
    public class ItemTypeDataModel : DataModelBase
    {
        public ItemTypeDataModel(ulong addr) : base(addr) { }
        public bool PlayerCanNotDrop() { return Invoke<bool>(nameof(PlayerCanNotDrop)); }
        public Object Name() { return Invoke<Object>(nameof(Name)); }
        public int GetId() { return Invoke<int>(nameof(GetId)); }
        public EItemCategory GetCategory() { return Invoke<EItemCategory>(nameof(GetCategory)); }
        public bool AlwaysEquipped() { return Invoke<bool>(nameof(AlwaysEquipped)); }
    }
    public class LocalePriceDataModel : DataModelBase
    {
        public LocalePriceDataModel(ulong addr) : base(addr) { }
        public int GetPrice() { return Invoke<int>(nameof(GetPrice)); }
        public Object GetCurrencySymbol() { return Invoke<Object>(nameof(GetCurrencySymbol)); }
        public Object GetCurrencyCode() { return Invoke<Object>(nameof(GetCurrencyCode)); }
    }
    public class LootDataModel : DataModelBase
    {
        public LootDataModel(ulong addr) : base(addr) { }
        public int GetMinCount() { return Invoke<int>(nameof(GetMinCount)); }
        public float GetMinChanceDurability() { return Invoke<float>(nameof(GetMinChanceDurability)); }
        public int GetMaxCount() { return Invoke<int>(nameof(GetMaxCount)); }
        public float GetMaxChanceDurability() { return Invoke<float>(nameof(GetMaxChanceDurability)); }
        public int GetItemId() { return Invoke<int>(nameof(GetItemId)); }
        public ItemDataModel GetItem() { return Invoke<ItemDataModel>(nameof(GetItem)); }
        public bool GetIsInstanced() { return Invoke<bool>(nameof(GetIsInstanced)); }
        public float GetChanceOfDrop() { return Invoke<float>(nameof(GetChanceOfDrop)); }
    }
    public class MaterialSourceDataModel : DataModelBase
    {
        public MaterialSourceDataModel(ulong addr) : base(addr) { }
        public Array<LootDataModel> LootTable { get { return new Array<LootDataModel>(this[nameof(LootTable)].Address); } }
        public int GetXPOnHarvest() { return Invoke<int>(nameof(GetXPOnHarvest)); }
        public int GetWeightedLootId() { return Invoke<int>(nameof(GetWeightedLootId)); }
        public int GetToolItemTypeId() { return Invoke<int>(nameof(GetToolItemTypeId)); }
        public int GetRespawnRate() { return Invoke<int>(nameof(GetRespawnRate)); }
        public int GetNightState() { return Invoke<int>(nameof(GetNightState)); }
        public EMaterialSourceTypes GetMaterialSourceTypes() { return Invoke<EMaterialSourceTypes>(nameof(GetMaterialSourceTypes)); }
        public Object GetMaterialSourceDisplayName() { return Invoke<Object>(nameof(GetMaterialSourceDisplayName)); }
        public Array<LootDataModel> GetLootTable() { return Invoke<Array<LootDataModel>>(nameof(GetLootTable)); }
        public int GetId() { return Invoke<int>(nameof(GetId)); }
        public float GetHoldToOpenTimer() { return Invoke<float>(nameof(GetHoldToOpenTimer)); }
        public EHarvestAnimType GetHarvestAnimType() { return Invoke<EHarvestAnimType>(nameof(GetHarvestAnimType)); }
        public int GetEveningState() { return Invoke<int>(nameof(GetEveningState)); }
        public int GetDayState() { return Invoke<int>(nameof(GetDayState)); }
        public int GetDawnState() { return Invoke<int>(nameof(GetDawnState)); }
        public Object GetActionText() { return Invoke<Object>(nameof(GetActionText)); }
    }
    public class MinionWaveDataModel : DataModelBase
    {
        public MinionWaveDataModel(ulong addr) : base(addr) { }
        public int GetId() { return Invoke<int>(nameof(GetId)); }
        public int GetGroup() { return Invoke<int>(nameof(GetGroup)); }
        public Array<MinionWaveCreatureEntryDataVO> CreatureEntries() { return Invoke<Array<MinionWaveCreatureEntryDataVO>>(nameof(CreatureEntries)); }
    }
    public class ModifierDataModel : DataModelBase
    {
        public ModifierDataModel(ulong addr) : base(addr) { }
        public Array<PerkDataModel> Perks { get { return new Array<PerkDataModel>(this[nameof(Perks)].Address); } }
        public int GetRequiredEntitlementId() { return Invoke<int>(nameof(GetRequiredEntitlementId)); }
        public Array<PerkDataModel> GetPerks() { return Invoke<Array<PerkDataModel>>(nameof(GetPerks)); }
        public Object GetLockedDescription() { return Invoke<Object>(nameof(GetLockedDescription)); }
        public int GetItemId() { return Invoke<int>(nameof(GetItemId)); }
        public ItemDataModel GetItemDataModel() { return Invoke<ItemDataModel>(nameof(GetItemDataModel)); }
        public int GetId() { return Invoke<int>(nameof(GetId)); }
        public ModifierDataModel CreateFromVO(Object Outer, ModifierDataVO InVO) { return Invoke<ModifierDataModel>(nameof(CreateFromVO), Outer, InVO); }
    }
    public class ModuleDataModel : DataModelBase
    {
        public ModuleDataModel(ulong addr) : base(addr) { }
        public ModuleDistributionTypeDataModel ModuleDistributionType { get { return this[nameof(ModuleDistributionType)].As<ModuleDistributionTypeDataModel>(); } set { this["ModuleDistributionType"] = value; } }
        public Object Creatures { get { return this[nameof(Creatures)]; } set { this[nameof(Creatures)] = value; } }
        public Object Chests { get { return this[nameof(Chests)]; } set { this[nameof(Chests)] = value; } }
        public bool IsUnique() { return Invoke<bool>(nameof(IsUnique)); }
        public int GetXPOnActivation() { return Invoke<int>(nameof(GetXPOnActivation)); }
        public Object GetTooltip() { return Invoke<Object>(nameof(GetTooltip)); }
        public Object GetSaveBlueprintClassPtr() { return Invoke<Object>(nameof(GetSaveBlueprintClassPtr)); }
        public EPOIType GetPOIType() { return Invoke<EPOIType>(nameof(GetPOIType)); }
        public int GetMainEntityDataId() { return Invoke<int>(nameof(GetMainEntityDataId)); }
        public EModuleLocationType GetLocationType() { return Invoke<EModuleLocationType>(nameof(GetLocationType)); }
        public Object GetInProgressIconObjectPtr() { return Invoke<Object>(nameof(GetInProgressIconObjectPtr)); }
        public int GetId() { return Invoke<int>(nameof(GetId)); }
        public Object GetIconObjectPtr() { return Invoke<Object>(nameof(GetIconObjectPtr)); }
        public Object GetDecalObjectPtr() { return Invoke<Object>(nameof(GetDecalObjectPtr)); }
        public Object GetCreatures() { return Invoke<Object>(nameof(GetCreatures)); }
        public Object GetCooldownIconObjectPtr() { return Invoke<Object>(nameof(GetCooldownIconObjectPtr)); }
        public Object GetCompletedIconObjectPtr() { return Invoke<Object>(nameof(GetCompletedIconObjectPtr)); }
        public Object GetChests() { return Invoke<Object>(nameof(GetChests)); }
        public ECaveType GetCaveType() { return Invoke<ECaveType>(nameof(GetCaveType)); }
    }
    public class ModuleDistributionTypeDataModel : DataModelBase
    {
        public ModuleDistributionTypeDataModel(ulong addr) : base(addr) { }
    }
    public class PerkDataModel : DataModelBase
    {
        public PerkDataModel(ulong addr) : base(addr) { }
        public EPerkType GetType() { return Invoke<EPerkType>(nameof(GetType)); }
        public Object GetStatusVFXClassPtr() { return Invoke<Object>(nameof(GetStatusVFXClassPtr)); }
        public Object GetStatusBPClassPtr() { return Invoke<Object>(nameof(GetStatusBPClassPtr)); }
        public PerkParametersDataVO GetParameters() { return Invoke<PerkParametersDataVO>(nameof(GetParameters)); }
        public int GetId() { return Invoke<int>(nameof(GetId)); }
        public Object GetIconObjectPtr() { return Invoke<Object>(nameof(GetIconObjectPtr)); }
        public Object GetDisplayName() { return Invoke<Object>(nameof(GetDisplayName)); }
        public Object GetAlertMessage() { return Invoke<Object>(nameof(GetAlertMessage)); }
        public PerkDataModel CreateFromVO(Object Outer, PerkDataVO InVO) { return Invoke<PerkDataModel>(nameof(CreateFromVO), Outer, InVO); }
    }
    public class PingCommandDataModel : DataModelBase
    {
        public PingCommandDataModel(ulong addr) : base(addr) { }
        public Object GetVoiceline() { return Invoke<Object>(nameof(GetVoiceline)); }
        public Object GetLocalizedName() { return Invoke<Object>(nameof(GetLocalizedName)); }
        public Object GetLocalizedDescription() { return Invoke<Object>(nameof(GetLocalizedDescription)); }
        public int GetId() { return Invoke<int>(nameof(GetId)); }
        public Object GetIconObjectPtr() { return Invoke<Object>(nameof(GetIconObjectPtr)); }
        public PingCommandDataModel CreateFromVO(Object Outer, PingCommandVO InVO) { return Invoke<PingCommandDataModel>(nameof(CreateFromVO), Outer, InVO); }
    }
    public class PlayerClassDataModel : DataModelBase
    {
        public PlayerClassDataModel(ulong addr) : base(addr) { }
        public ESkillClass GetSkillClass() { return Invoke<ESkillClass>(nameof(GetSkillClass)); }
        public int GetRequiredEntitlementId() { return Invoke<int>(nameof(GetRequiredEntitlementId)); }
        public int GetId() { return Invoke<int>(nameof(GetId)); }
    }
    public class PlayerLevelDataModel : DataModelBase
    {
        public PlayerLevelDataModel(ulong addr) : base(addr) { }
        public int GetRequiredXP() { return Invoke<int>(nameof(GetRequiredXP)); }
        public int GetPlayerSkillPoints() { return Invoke<int>(nameof(GetPlayerSkillPoints)); }
        public int GetId() { return Invoke<int>(nameof(GetId)); }
        public float GetHealthBonus() { return Invoke<float>(nameof(GetHealthBonus)); }
        public float GetDamageBonus() { return Invoke<float>(nameof(GetDamageBonus)); }
    }
    public class PlayerSkillDataModel : DataModelBase
    {
        public PlayerSkillDataModel(ulong addr) : base(addr) { }
        public Array<PerkDataModel> Perks { get { return new Array<PerkDataModel>(this[nameof(Perks)].Address); } }
        public bool IsPrimary() { return Invoke<bool>(nameof(IsPrimary)); }
        public int GetTreeCoordinateY() { return Invoke<int>(nameof(GetTreeCoordinateY)); }
        public int GetTreeCoordinateX() { return Invoke<int>(nameof(GetTreeCoordinateX)); }
        public ESkillClass GetSkillClass() { return Invoke<ESkillClass>(nameof(GetSkillClass)); }
        public Object GetShortDescription() { return Invoke<Object>(nameof(GetShortDescription)); }
        public int GetRequiredSkill() { return Invoke<int>(nameof(GetRequiredSkill)); }
        public Array<PerkDataModel> GetPerks() { return Invoke<Array<PerkDataModel>>(nameof(GetPerks)); }
        public Object GetLocalizedName() { return Invoke<Object>(nameof(GetLocalizedName)); }
        public Object GetLocalizedDescription() { return Invoke<Object>(nameof(GetLocalizedDescription)); }
        public int GetInvalidateSkill() { return Invoke<int>(nameof(GetInvalidateSkill)); }
        public int GetId() { return Invoke<int>(nameof(GetId)); }
        public Object GetIconObjectPtr() { return Invoke<Object>(nameof(GetIconObjectPtr)); }
        public int GetCost() { return Invoke<int>(nameof(GetCost)); }
    }
    public class ProjectileDataModel : DataModelBase
    {
        public ProjectileDataModel(ulong addr) : base(addr) { }
        public float GetTick() { return Invoke<float>(nameof(GetTick)); }
        public float GetSpeed() { return Invoke<float>(nameof(GetSpeed)); }
        public float GetSegmentLength() { return Invoke<float>(nameof(GetSegmentLength)); }
        public int GetSegmentCount() { return Invoke<int>(nameof(GetSegmentCount)); }
        public float GetRadius() { return Invoke<float>(nameof(GetRadius)); }
        public int GetProjectileCount() { return Invoke<int>(nameof(GetProjectileCount)); }
        public bool GetIsHoming() { return Invoke<bool>(nameof(GetIsHoming)); }
        public bool GetIsCapsule() { return Invoke<bool>(nameof(GetIsCapsule)); }
        public bool GetIncludeSelf() { return Invoke<bool>(nameof(GetIncludeSelf)); }
        public bool GetIgnoreMultiHit() { return Invoke<bool>(nameof(GetIgnoreMultiHit)); }
        public int GetId() { return Invoke<int>(nameof(GetId)); }
        public bool GetGoesThrough() { return Invoke<bool>(nameof(GetGoesThrough)); }
        public float GetDuration() { return Invoke<float>(nameof(GetDuration)); }
        public float GetDelay() { return Invoke<float>(nameof(GetDelay)); }
        public float GetColliderRadius() { return Invoke<float>(nameof(GetColliderRadius)); }
        public bool GetAutoTarget() { return Invoke<bool>(nameof(GetAutoTarget)); }
        public EAOEType GetAOEType() { return Invoke<EAOEType>(nameof(GetAOEType)); }
        public float GetAngle() { return Invoke<float>(nameof(GetAngle)); }
        public float GetAmplitudeArrow() { return Invoke<float>(nameof(GetAmplitudeArrow)); }
        public Object GetActorTemplateClassPtr() { return Invoke<Object>(nameof(GetActorTemplateClassPtr)); }
        public bool DoSpawnOnTarget() { return Invoke<bool>(nameof(DoSpawnOnTarget)); }
    }
    public class QuestDataModel : DataModelBase
    {
        public QuestDataModel(ulong addr) : base(addr) { }
        public Array<LootDataModel> LootTable { get { return new Array<LootDataModel>(this[nameof(LootTable)].Address); } }
        public bool IsContainerRelated() { return Invoke<bool>(nameof(IsContainerRelated)); }
        public bool IsAvailableAtQuestBoard() { return Invoke<bool>(nameof(IsAvailableAtQuestBoard)); }
        public int GetXpOnCompletion() { return Invoke<int>(nameof(GetXpOnCompletion)); }
        public EQuestType GetType() { return Invoke<EQuestType>(nameof(GetType)); }
        public Array<int> GetRequiredModulesId() { return Invoke<Array<int>>(nameof(GetRequiredModulesId)); }
        public EQuestIconType GetMapIconInProgress() { return Invoke<EQuestIconType>(nameof(GetMapIconInProgress)); }
        public EQuestIconType GetMapIconCooldown() { return Invoke<EQuestIconType>(nameof(GetMapIconCooldown)); }
        public EQuestIconType GetMapIconComplete() { return Invoke<EQuestIconType>(nameof(GetMapIconComplete)); }
        public EQuestIconType GetMapIconAvailable() { return Invoke<EQuestIconType>(nameof(GetMapIconAvailable)); }
        public bool GetLootToInventory() { return Invoke<bool>(nameof(GetLootToInventory)); }
        public Array<LootDataModel> GetLootTable() { return Invoke<Array<LootDataModel>>(nameof(GetLootTable)); }
        public Object GetLongDescription() { return Invoke<Object>(nameof(GetLongDescription)); }
        public int GetInProgressDialogId() { return Invoke<int>(nameof(GetInProgressDialogId)); }
        public int GetId() { return Invoke<int>(nameof(GetId)); }
        public Array<LootDataModel> GetFinalStepReward() { return Invoke<Array<LootDataModel>>(nameof(GetFinalStepReward)); }
        public int GetEstimatedTime() { return Invoke<int>(nameof(GetEstimatedTime)); }
        public Object GetDisplayName() { return Invoke<Object>(nameof(GetDisplayName)); }
        public EQuestDifficulty GetDifficulty() { return Invoke<EQuestDifficulty>(nameof(GetDifficulty)); }
        public int GetDialogId() { return Invoke<int>(nameof(GetDialogId)); }
        public Object GetDescriptionWithParams(Object Param) { return Invoke<Object>(nameof(GetDescriptionWithParams), Param); }
        public Object GetDescription() { return Invoke<Object>(nameof(GetDescription)); }
        public int GetCooldownDialogId() { return Invoke<int>(nameof(GetCooldownDialogId)); }
        public int GetCooldown() { return Invoke<int>(nameof(GetCooldown)); }
        public int GetCompleteDialogId() { return Invoke<int>(nameof(GetCompleteDialogId)); }
        public Array<int> GetBiomeIds() { return Invoke<Array<int>>(nameof(GetBiomeIds)); }
    }
    public class RarityDataModel : DataModelBase
    {
        public RarityDataModel(ulong addr) : base(addr) { }
        public int GetId() { return Invoke<int>(nameof(GetId)); }
    }
    public class ResourceDataModel : DataModelBase
    {
        public ResourceDataModel(ulong addr) : base(addr) { }
        public Object GetVariantClassPtr(int Index) { return Invoke<Object>(nameof(GetVariantClassPtr), Index); }
        public Object GetRandomVariantClassPtr() { return Invoke<Object>(nameof(GetRandomVariantClassPtr)); }
        public int GetMaterialSourceId() { return Invoke<int>(nameof(GetMaterialSourceId)); }
    }
    public class ResourceEntryDataModel : DataModelBase
    {
        public ResourceEntryDataModel(ulong addr) : base(addr) { }
        public RarityDataModel RarityModel { get { return this[nameof(RarityModel)].As<RarityDataModel>(); } set { this["RarityModel"] = value; } }
    }
    public class RewardDataModel : DataModelBase
    {
        public RewardDataModel(ulong addr) : base(addr) { }
    }
    public class SeasonUserLevelDataModel : DataModelBase
    {
        public SeasonUserLevelDataModel(ulong addr) : base(addr) { }
        public RewardDataVO GetReward() { return Invoke<RewardDataVO>(nameof(GetReward)); }
        public int GetRequiredXP() { return Invoke<int>(nameof(GetRequiredXP)); }
        public int GetId() { return Invoke<int>(nameof(GetId)); }
    }
    public class ServerRegionModel : DataModelBase
    {
        public ServerRegionModel(ulong addr) : base(addr) { }
        public ServerRegionVO ToVO() { return Invoke<ServerRegionVO>(nameof(ToVO)); }
        public void RefreshPing() { Invoke(nameof(RefreshPing)); }
        public Object GetUrl() { return Invoke<Object>(nameof(GetUrl)); }
        public float GetPing() { return Invoke<float>(nameof(GetPing)); }
    }
    public class ShieldDataModel : DataModelBase
    {
        public ShieldDataModel(ulong addr) : base(addr) { }
        public Object ShieldStats { get { return this[nameof(ShieldStats)]; } set { this[nameof(ShieldStats)] = value; } }
        public Array<DamageValuesDataModel> ArmorStats { get { return new Array<DamageValuesDataModel>(this[nameof(ArmorStats)].Address); } }
        public Object GetShieldStats() { return Invoke<Object>(nameof(GetShieldStats)); }
        public float GetRotationSpeed() { return Invoke<float>(nameof(GetRotationSpeed)); }
        public int GetItemId() { return Invoke<int>(nameof(GetItemId)); }
        public int GetId() { return Invoke<int>(nameof(GetId)); }
        public EEquipmentElement GetElement() { return Invoke<EEquipmentElement>(nameof(GetElement)); }
        public int GetCircleAttackStatId() { return Invoke<int>(nameof(GetCircleAttackStatId)); }
        public int GetAttackStatId() { return Invoke<int>(nameof(GetAttackStatId)); }
        public Array<DamageValuesDataModel> GetArmorStats() { return Invoke<Array<DamageValuesDataModel>>(nameof(GetArmorStats)); }
        public ShieldDataModel CreateFromVO(Object Outer, ShieldDataVO InVO) { return Invoke<ShieldDataModel>(nameof(CreateFromVO), Outer, InVO); }
    }
    public class ShopDataModel : DataModelBase
    {
        public ShopDataModel(ulong addr) : base(addr) { }
        public DateTime FeaturedEndTime { get { return this[nameof(FeaturedEndTime)].As<DateTime>(); } set { this["FeaturedEndTime"] = value; } }
        public DateTime RegularEndTime { get { return this[nameof(RegularEndTime)].As<DateTime>(); } set { this["RegularEndTime"] = value; } }
        public Array<ShopItemDataModel> FeaturedItems { get { return new Array<ShopItemDataModel>(this[nameof(FeaturedItems)].Address); } }
        public Array<ShopItemDataModel> RegularItems { get { return new Array<ShopItemDataModel>(this[nameof(RegularItems)].Address); } }
        public Array<IAPPackDataModel> IAPPacks { get { return new Array<IAPPackDataModel>(this[nameof(IAPPacks)].Address); } }
        public bool IsIAPEnable() { return Invoke<bool>(nameof(IsIAPEnable)); }
        public int GetRegularRemainingTime() { return Invoke<int>(nameof(GetRegularRemainingTime)); }
        public Timespan GetRegularRemainingDateTime() { return Invoke<Timespan>(nameof(GetRegularRemainingDateTime)); }
        public Array<ShopItemDataModel> GetRegularItems() { return Invoke<Array<ShopItemDataModel>>(nameof(GetRegularItems)); }
        public Array<IAPPackDataModel> GetIAPPacks() { return Invoke<Array<IAPPackDataModel>>(nameof(GetIAPPacks)); }
        public int GetFeaturedRemainingTime() { return Invoke<int>(nameof(GetFeaturedRemainingTime)); }
        public Timespan GetFeaturedRemainingDateTime() { return Invoke<Timespan>(nameof(GetFeaturedRemainingDateTime)); }
        public Array<ShopItemDataModel> GetFeaturedItems() { return Invoke<Array<ShopItemDataModel>>(nameof(GetFeaturedItems)); }
    }
    public class ShopItemDataModel : DataModelBase
    {
        public ShopItemDataModel(ulong addr) : base(addr) { }
        public AvatarCosmeticDataModel CosmeticItem { get { return this[nameof(CosmeticItem)].As<AvatarCosmeticDataModel>(); } set { this["CosmeticItem"] = value; } }
        public BlueprintDataModel BlueprintItem { get { return this[nameof(BlueprintItem)].As<BlueprintDataModel>(); } set { this["BlueprintItem"] = value; } }
        public EntitlementDataModel EntitlementItem { get { return this[nameof(EntitlementItem)].As<EntitlementDataModel>(); } set { this["EntitlementItem"] = value; } }
        public ERewardType GetRewardType() { return Invoke<ERewardType>(nameof(GetRewardType)); }
        public int GetPrice() { return Invoke<int>(nameof(GetPrice)); }
        public int GetOfferId() { return Invoke<int>(nameof(GetOfferId)); }
        public int GetItemId() { return Invoke<int>(nameof(GetItemId)); }
        public EntitlementDataModel GetEntitlementItem() { return Invoke<EntitlementDataModel>(nameof(GetEntitlementItem)); }
        public ECurrencyType GetCurrencyType() { return Invoke<ECurrencyType>(nameof(GetCurrencyType)); }
        public AvatarCosmeticDataModel GetCosmeticItem() { return Invoke<AvatarCosmeticDataModel>(nameof(GetCosmeticItem)); }
        public BlueprintDataModel GetBlueprintItem() { return Invoke<BlueprintDataModel>(nameof(GetBlueprintItem)); }
    }
    public class StarterKitDataModel : DataModelBase
    {
        public StarterKitDataModel(ulong addr) : base(addr) { }
        public int GetId() { return Invoke<int>(nameof(GetId)); }
        public StarterKitDataModel CreateFromVO(Object Outer, StarterKitDataVO InVO) { return Invoke<StarterKitDataModel>(nameof(CreateFromVO), Outer, InVO); }
    }
    public class TransmogDataModel : DataModelBase
    {
        public TransmogDataModel(ulong addr) : base(addr) { }
        public TransmogDataVO VO { get { return this[nameof(VO)].As<TransmogDataVO>(); } set { this["VO"] = value; } }
        public EStance GetStance() { return Invoke<EStance>(nameof(GetStance)); }
        public int GetItemTypeId() { return Invoke<int>(nameof(GetItemTypeId)); }
        public int GetId() { return Invoke<int>(nameof(GetId)); }
        public Object GetActorTemplateClassPtr(bool bUseFemale) { return Invoke<Object>(nameof(GetActorTemplateClassPtr), bUseFemale); }
        public int FindRequiredEntitlementId() { return Invoke<int>(nameof(FindRequiredEntitlementId)); }
        public TransmogDataModel CreateFromVO(Object Outer, TransmogDataVO InVO) { return Invoke<TransmogDataModel>(nameof(CreateFromVO), Outer, InVO); }
    }
    public class UpgradeDataModel : DataModelBase
    {
        public UpgradeDataModel(ulong addr) : base(addr) { }
        public UpgradeDataVO VO { get { return this[nameof(VO)].As<UpgradeDataVO>(); } set { this["VO"] = value; } }
        public int GetXPOnUpgrade() { return Invoke<int>(nameof(GetXPOnUpgrade)); }
        public int GetTargetId() { return Invoke<int>(nameof(GetTargetId)); }
        public int GetNextUpgradeId() { return Invoke<int>(nameof(GetNextUpgradeId)); }
        public int GetLevel() { return Invoke<int>(nameof(GetLevel)); }
        public int GetId() { return Invoke<int>(nameof(GetId)); }
        public int GetContainerId() { return Invoke<int>(nameof(GetContainerId)); }
    }
    public class UserLevelDataModel : DataModelBase
    {
        public UserLevelDataModel(ulong addr) : base(addr) { }
        public int GetRequiredXP() { return Invoke<int>(nameof(GetRequiredXP)); }
        public int GetId() { return Invoke<int>(nameof(GetId)); }
        public int GetCurrencyReward() { return Invoke<int>(nameof(GetCurrencyReward)); }
    }
    public class WeaponDataModel : DataModelBase
    {
        public WeaponDataModel(ulong addr) : base(addr) { }
        public Array<AttackStatsDataModel> BasicAttacks { get { return new Array<AttackStatsDataModel>(this[nameof(BasicAttacks)].Address); } }
        public Array<AttackStatsDataModel> SpecialAttacks { get { return new Array<AttackStatsDataModel>(this[nameof(SpecialAttacks)].Address); } }
        public Array<AttackStatsDataModel> AllAttacks { get { return new Array<AttackStatsDataModel>(this[nameof(AllAttacks)].Address); } }
        public AttackStatsDataModel HoldAttack { get { return this[nameof(HoldAttack)].As<AttackStatsDataModel>(); } set { this["HoldAttack"] = value; } }
        public Array<PerkDataModel> Perks { get { return new Array<PerkDataModel>(this[nameof(Perks)].Address); } }
        public AttackStatsDataModel TripwireAttack { get { return this[nameof(TripwireAttack)].As<AttackStatsDataModel>(); } set { this["TripwireAttack"] = value; } }
        public bool IsRangeWeapon() { return Invoke<bool>(nameof(IsRangeWeapon)); }
        public bool IsNextAttackEnergized(AttackStatsDataModel AttackStats) { return Invoke<bool>(nameof(IsNextAttackEnergized), AttackStats); }
        public bool IsMunitionAccepted(int MunitionItemId) { return Invoke<bool>(nameof(IsMunitionAccepted), MunitionItemId); }
        public AttackStatsDataModel GetTripwireAttack() { return Invoke<AttackStatsDataModel>(nameof(GetTripwireAttack)); }
        public EStance GetStance() { return Invoke<EStance>(nameof(GetStance)); }
        public Array<AttackStatsDataModel> GetSpecialAttacks() { return Invoke<Array<AttackStatsDataModel>>(nameof(GetSpecialAttacks)); }
        public float GetShortestAttackRange(int ChannelId) { return Invoke<float>(nameof(GetShortestAttackRange), ChannelId); }
        public float GetLongestAttackRangeForChannel(int Channel) { return Invoke<float>(nameof(GetLongestAttackRangeForChannel), Channel); }
        public int GetItemId() { return Invoke<int>(nameof(GetItemId)); }
        public ItemDataModel GetItemData() { return Invoke<ItemDataModel>(nameof(GetItemData)); }
        public bool GetIsTwoHanded() { return Invoke<bool>(nameof(GetIsTwoHanded)); }
        public int GetId() { return Invoke<int>(nameof(GetId)); }
        public EEquipmentElement GetElement() { return Invoke<EEquipmentElement>(nameof(GetElement)); }
        public Array<AttackStatsDataModel> GetBasicAttacks() { return Invoke<Array<AttackStatsDataModel>>(nameof(GetBasicAttacks)); }
        public Array<PerkDataModel> GetBasicAttackPerks() { return Invoke<Array<PerkDataModel>>(nameof(GetBasicAttackPerks)); }
        public float GetAutoAimRangeSqr() { return Invoke<float>(nameof(GetAutoAimRangeSqr)); }
        public float GetAutoAimAngleController() { return Invoke<float>(nameof(GetAutoAimAngleController)); }
        public float GetAutoAimAngle() { return Invoke<float>(nameof(GetAutoAimAngle)); }
        public Object GetAudioName() { return Invoke<Object>(nameof(GetAudioName)); }
        public AttackStatsDataModel GetAttackById(int ID) { return Invoke<AttackStatsDataModel>(nameof(GetAttackById), ID); }
        public Array<AttackStatsDataModel> GetAllAttacks() { return Invoke<Array<AttackStatsDataModel>>(nameof(GetAllAttacks)); }
        public AttackStatsDataModel FindBowInfiniteAttack() { return Invoke<AttackStatsDataModel>(nameof(FindBowInfiniteAttack)); }
        public WeaponDataModel CreateFromVO(Object Outer, WeaponDataVO InVO) { return Invoke<WeaponDataModel>(nameof(CreateFromVO), Outer, InVO); }
    }
    public class WeightedLootDataModel : DataModelBase
    {
        public WeightedLootDataModel(ulong addr) : base(addr) { }
        public WeightedLootDataVO VO { get { return this[nameof(VO)].As<WeightedLootDataVO>(); } set { this["VO"] = value; } }
        public bool IsInstanced() { return Invoke<bool>(nameof(IsInstanced)); }
        public Array<WeightedLootEntryVO> GetWeights() { return Invoke<Array<WeightedLootEntryVO>>(nameof(GetWeights)); }
        public int GetMinCountPerDrop() { return Invoke<int>(nameof(GetMinCountPerDrop)); }
        public int GetMaxCountPerDrop() { return Invoke<int>(nameof(GetMaxCountPerDrop)); }
        public Array<ItemDataModel> GetItemsByRarity(int RarityId) { return Invoke<Array<ItemDataModel>>(nameof(GetItemsByRarity), RarityId); }
        public Array<int> GetItemIds() { return Invoke<Array<int>>(nameof(GetItemIds)); }
        public int GetId() { return Invoke<int>(nameof(GetId)); }
        public int GetDropCount() { return Invoke<int>(nameof(GetDropCount)); }
        public float GetDropChances() { return Invoke<float>(nameof(GetDropChances)); }
        public WeightedLootDataModel CreateFromVO(Object Outer, WeightedLootDataVO InVO) { return Invoke<WeightedLootDataModel>(nameof(CreateFromVO), Outer, InVO); }
    }
    public class WorldVOUtil : Object
    {
        public WorldVOUtil(ulong addr) : base(addr) { }
        public DataObject ToDataObject(WorldVO Data, Object Filters) { return Invoke<DataObject>(nameof(ToDataObject), Data, Filters); }
        public WorldVO FromDataObject(DataObject Data) { return Invoke<WorldVO>(nameof(FromDataObject), Data); }
    }
    public enum EEntityActionType : int
    {
        None = 0,
        Create = 1,
        Add = 2,
        Update = 3,
        Delete = 4,
        EEntityActionType_MAX = 5,
    }
    public enum ECharacterMovementMode : int
    {
        Running = 0,
        Walking = 1,
        Crawling = 2,
        Ragdoll = 3,
        Falling = 4,
        Building = 5,
        ECharacterMovementMode_MAX = 6,
    }
    public class WorldVO : Object
    {
        public WorldVO(ulong addr) : base(addr) { }
        public Object ID { get { return this[nameof(ID)]; } set { this[nameof(ID)] = value; } }
        public Object Name { get { return this[nameof(Name)]; } set { this[nameof(Name)] = value; } }
        public WorldConfigVO Config { get { return this[nameof(Config)].As<WorldConfigVO>(); } set { this["Config"] = value; } }
        public EGameMode GameMode { get { return (EGameMode)this[nameof(GameMode)].GetValue<int>(); } set { this[nameof(GameMode)].SetValue<int>((int)value); } }
        public int MaxPlayers { get { return this[nameof(MaxPlayers)].GetValue<int>(); } set { this[nameof(MaxPlayers)].SetValue<int>(value); } }
        public bool bIsPrivate { get { return this[nameof(bIsPrivate)].Flag; } set { this[nameof(bIsPrivate)].Flag = value; } }
        public int Seed { get { return this[nameof(Seed)].GetValue<int>(); } set { this[nameof(Seed)].SetValue<int>(value); } }
        public int DayDuration { get { return this[nameof(DayDuration)].GetValue<int>(); } set { this[nameof(DayDuration)].SetValue<int>(value); } }
        public int StartingDayTime { get { return this[nameof(StartingDayTime)].GetValue<int>(); } set { this[nameof(StartingDayTime)].SetValue<int>(value); } }
        public WorldContentVO WorldContent { get { return this[nameof(WorldContent)].As<WorldContentVO>(); } set { this["WorldContent"] = value; } }
        public Object Context { get { return this[nameof(Context)]; } set { this[nameof(Context)] = value; } }
        public Array<UserInfosVO> UsersInfos { get { return new Array<UserInfosVO>(this[nameof(UsersInfos)].Address); } }
    }
    public class UserInfosVO : Object
    {
        public UserInfosVO(ulong addr) : base(addr) { }
        public Object ID { get { return this[nameof(ID)]; } set { this[nameof(ID)] = value; } }
        public Object Name { get { return this[nameof(Name)]; } set { this[nameof(Name)] = value; } }
        public int IconId { get { return this[nameof(IconId)].GetValue<int>(); } set { this[nameof(IconId)].SetValue<int>(value); } }
        public int UserXP { get { return this[nameof(UserXP)].GetValue<int>(); } set { this[nameof(UserXP)].SetValue<int>(value); } }
    }
    public class WorldContentVO : Object
    {
        public WorldContentVO(ulong addr) : base(addr) { }
        public int RegisteredPlayers { get { return this[nameof(RegisteredPlayers)].GetValue<int>(); } set { this[nameof(RegisteredPlayers)].SetValue<int>(value); } }
        public int GiantLevel { get { return this[nameof(GiantLevel)].GetValue<int>(); } set { this[nameof(GiantLevel)].SetValue<int>(value); } }
        public int SagaBossKillCount { get { return this[nameof(SagaBossKillCount)].GetValue<int>(); } set { this[nameof(SagaBossKillCount)].SetValue<int>(value); } }
        public Array<WorldGiantVO> SpawnedGiants { get { return new Array<WorldGiantVO>(this[nameof(SpawnedGiants)].Address); } }
        public Array<WorldPlayerVO> Players { get { return new Array<WorldPlayerVO>(this[nameof(Players)].Address); } }
        public Array<WorldPlayerVO> ExitedPlayers { get { return new Array<WorldPlayerVO>(this[nameof(ExitedPlayers)].Address); } }
        public Array<WorldCharacterVO> WorldCharacters { get { return new Array<WorldCharacterVO>(this[nameof(WorldCharacters)].Address); } }
        public Array<ContainerVO> Containers { get { return new Array<ContainerVO>(this[nameof(Containers)].Address); } }
        public Array<WorldContainerVO> WorldContainers { get { return new Array<WorldContainerVO>(this[nameof(WorldContainers)].Address); } }
        public int ConstructionCount { get { return this[nameof(ConstructionCount)].GetValue<int>(); } set { this[nameof(ConstructionCount)].SetValue<int>(value); } }
        public Array<ChunkVO> Chunks { get { return new Array<ChunkVO>(this[nameof(Chunks)].Address); } }
        public Array<RespawnTimerVO> RespawnTimers { get { return new Array<RespawnTimerVO>(this[nameof(RespawnTimers)].Address); } }
        public Array<RespawnTimerVO> ReplicatedRespawnTimers { get { return new Array<RespawnTimerVO>(this[nameof(ReplicatedRespawnTimers)].Address); } }
        public Array<WorldShrineVO> Shrines { get { return new Array<WorldShrineVO>(this[nameof(Shrines)].Address); } }
        public Array<GameEventVO> GameEvents { get { return new Array<GameEventVO>(this[nameof(GameEvents)].Address); } }
        public Array<QuestVO> Quests { get { return new Array<QuestVO>(this[nameof(Quests)].Address); } }
        public Array<CaveVO> Caves { get { return new Array<CaveVO>(this[nameof(Caves)].Address); } }
        public Array<UpgradeVO> Upgrades { get { return new Array<UpgradeVO>(this[nameof(Upgrades)].Address); } }
        public Array<byte> ExploredChunksCompressedBytes { get { return new Array<byte>(this[nameof(ExploredChunksCompressedBytes)].Address); } }
        public int CurrentlySpawnMinionCount { get { return this[nameof(CurrentlySpawnMinionCount)].GetValue<int>(); } set { this[nameof(CurrentlySpawnMinionCount)].SetValue<int>(value); } }
        public float YggdrasilRemainingHealth { get { return this[nameof(YggdrasilRemainingHealth)].GetValue<float>(); } set { this[nameof(YggdrasilRemainingHealth)].SetValue<float>(value); } }
        public int ElapsedTime { get { return this[nameof(ElapsedTime)].GetValue<int>(); } set { this[nameof(ElapsedTime)].SetValue<int>(value); } }
        public EWorldStatus Status { get { return (EWorldStatus)this[nameof(Status)].GetValue<int>(); } set { this[nameof(Status)].SetValue<int>((int)value); } }
        public bool bIsBifrostActivated { get { return this[nameof(bIsBifrostActivated)].Flag; } set { this[nameof(bIsBifrostActivated)].Flag = value; } }
    }
    public enum EWorldStatus : int
    {
        InProgress = 0,
        Destroyed = 1,
        Victory = 2,
        EWorldStatus_MAX = 3,
    }
    public class UpgradeVO : Object
    {
        public UpgradeVO(ulong addr) : base(addr) { }
        public Object ID { get { return this[nameof(ID)]; } set { this[nameof(ID)] = value; } }
        public int UpgradeDataId { get { return this[nameof(UpgradeDataId)].GetValue<int>(); } set { this[nameof(UpgradeDataId)].SetValue<int>(value); } }
        public int HighestCompletedUpgradeDataId { get { return this[nameof(HighestCompletedUpgradeDataId)].GetValue<int>(); } set { this[nameof(HighestCompletedUpgradeDataId)].SetValue<int>(value); } }
        public Object ContainerId { get { return this[nameof(ContainerId)]; } set { this[nameof(ContainerId)] = value; } }
    }
    public class CaveVO : Object
    {
        public CaveVO(ulong addr) : base(addr) { }
        public Object ID { get { return this[nameof(ID)]; } set { this[nameof(ID)] = value; } }
        public int CaveDataId { get { return this[nameof(CaveDataId)].GetValue<int>(); } set { this[nameof(CaveDataId)].SetValue<int>(value); } }
        public bool bIsFloor { get { return this[nameof(bIsFloor)].Flag; } set { this[nameof(bIsFloor)].Flag = value; } }
        public DataObject Save { get { return this[nameof(Save)].As<DataObject>(); } set { this["Save"] = value; } }
        public Array<HazardVO> Hazards { get { return new Array<HazardVO>(this[nameof(Hazards)].Address); } }
    }
    public class HazardVO : Object
    {
        public HazardVO(ulong addr) : base(addr) { }
        public Object ID { get { return this[nameof(ID)]; } set { this[nameof(ID)] = value; } }
        public int HazardDataId { get { return this[nameof(HazardDataId)].GetValue<int>(); } set { this[nameof(HazardDataId)].SetValue<int>(value); } }
        public int Health { get { return this[nameof(Health)].GetValue<int>(); } set { this[nameof(Health)].SetValue<int>(value); } }
        public Vector Location { get { return this[nameof(Location)].As<Vector>(); } set { this["Location"] = value; } }
        public float RotationYaw { get { return this[nameof(RotationYaw)].GetValue<float>(); } set { this[nameof(RotationYaw)].SetValue<float>(value); } }
        public float Scale { get { return this[nameof(Scale)].GetValue<float>(); } set { this[nameof(Scale)].SetValue<float>(value); } }
        public bool bIsXPGiven { get { return this[nameof(bIsXPGiven)].Flag; } set { this[nameof(bIsXPGiven)].Flag = value; } }
        public Object WorldContainerInstanceId { get { return this[nameof(WorldContainerInstanceId)]; } set { this[nameof(WorldContainerInstanceId)] = value; } }
        public EAdjustmentMethod AdjustmentMethod { get { return (EAdjustmentMethod)this[nameof(AdjustmentMethod)].GetValue<int>(); } set { this[nameof(AdjustmentMethod)].SetValue<int>((int)value); } }
    }
    public enum EAdjustmentMethod : int
    {
        AlwaysSpawn = 0,
        DontSpawnIfColliding = 1,
        AdjustIfPossibleButAlwaysSpawn = 2,
        AdjustIfPossibleButDontSpawnIfColliding = 3,
        EAdjustmentMethod_MAX = 4,
    }
    public class QuestVO : Object
    {
        public QuestVO(ulong addr) : base(addr) { }
        public Object ID { get { return this[nameof(ID)]; } set { this[nameof(ID)] = value; } }
        public int QuestDataId { get { return this[nameof(QuestDataId)].GetValue<int>(); } set { this[nameof(QuestDataId)].SetValue<int>(value); } }
        public Object PlayerId { get { return this[nameof(PlayerId)]; } set { this[nameof(PlayerId)] = value; } }
        public Object QuestGiverId { get { return this[nameof(QuestGiverId)]; } set { this[nameof(QuestGiverId)] = value; } }
        public Object NPCEntityId { get { return this[nameof(NPCEntityId)]; } set { this[nameof(NPCEntityId)] = value; } }
        public EQuestStatus Status { get { return (EQuestStatus)this[nameof(Status)].GetValue<int>(); } set { this[nameof(Status)].SetValue<int>((int)value); } }
        public DataObject Conditions { get { return this[nameof(Conditions)].As<DataObject>(); } set { this["Conditions"] = value; } }
        public DataObject Progression { get { return this[nameof(Progression)].As<DataObject>(); } set { this["Progression"] = value; } }
        public bool bIsDirty { get { return this[nameof(bIsDirty)].Flag; } set { this[nameof(bIsDirty)].Flag = value; } }
        public int CurrentProgression { get { return this[nameof(CurrentProgression)].GetValue<int>(); } set { this[nameof(CurrentProgression)].SetValue<int>(value); } }
        public int MaxProgression { get { return this[nameof(MaxProgression)].GetValue<int>(); } set { this[nameof(MaxProgression)].SetValue<int>(value); } }
        public int ActivationTime { get { return this[nameof(ActivationTime)].GetValue<int>(); } set { this[nameof(ActivationTime)].SetValue<int>(value); } }
        public int CooldownEndTime { get { return this[nameof(CooldownEndTime)].GetValue<int>(); } set { this[nameof(CooldownEndTime)].SetValue<int>(value); } }
        public bool bIsSaga { get { return this[nameof(bIsSaga)].Flag; } set { this[nameof(bIsSaga)].Flag = value; } }
    }
    public enum EQuestStatus : int
    {
        None = 0,
        Ready = 1,
        InProgress = 2,
        Complete = 3,
        InCooldown = 4,
        EQuestStatus_MAX = 5,
    }
    public class GameEventVO : Object
    {
        public GameEventVO(ulong addr) : base(addr) { }
        public Object ID { get { return this[nameof(ID)]; } set { this[nameof(ID)] = value; } }
        public float StartTime { get { return this[nameof(StartTime)].GetValue<float>(); } set { this[nameof(StartTime)].SetValue<float>(value); } }
        public int GameEventDataId { get { return this[nameof(GameEventDataId)].GetValue<int>(); } set { this[nameof(GameEventDataId)].SetValue<int>(value); } }
        public DataObject Save { get { return this[nameof(Save)].As<DataObject>(); } set { this["Save"] = value; } }
    }
    public class WorldShrineVO : Object
    {
        public WorldShrineVO(ulong addr) : base(addr) { }
        public Object ID { get { return this[nameof(ID)]; } set { this[nameof(ID)] = value; } }
        public bool bIsActive { get { return this[nameof(bIsActive)].Flag; } set { this[nameof(bIsActive)].Flag = value; } }
    }
    public class RespawnTimerVO : Object
    {
        public RespawnTimerVO(ulong addr) : base(addr) { }
        public Object ID { get { return this[nameof(ID)]; } set { this[nameof(ID)] = value; } }
        public float Timer { get { return this[nameof(Timer)].GetValue<float>(); } set { this[nameof(Timer)].SetValue<float>(value); } }
    }
    public class ChunkVO : Object
    {
        public ChunkVO(ulong addr) : base(addr) { }
        public Object ID { get { return this[nameof(ID)]; } set { this[nameof(ID)] = value; } }
        public Array<HazardVO> Hazards { get { return new Array<HazardVO>(this[nameof(Hazards)].Address); } }
        public Array<WorldCreatureVO> Creatures { get { return new Array<WorldCreatureVO>(this[nameof(Creatures)].Address); } }
    }
    public class WorldCreatureVO : Object
    {
        public WorldCreatureVO(ulong addr) : base(addr) { }
        public Object ID { get { return this[nameof(ID)]; } set { this[nameof(ID)] = value; } }
        public int CreatureId { get { return this[nameof(CreatureId)].GetValue<int>(); } set { this[nameof(CreatureId)].SetValue<int>(value); } }
        public Object PackId { get { return this[nameof(PackId)]; } set { this[nameof(PackId)] = value; } }
        public int AIBehaviourId { get { return this[nameof(AIBehaviourId)].GetValue<int>(); } set { this[nameof(AIBehaviourId)].SetValue<int>(value); } }
        public Vector Location { get { return this[nameof(Location)].As<Vector>(); } set { this["Location"] = value; } }
        public Vector OriginLocation { get { return this[nameof(OriginLocation)].As<Vector>(); } set { this["OriginLocation"] = value; } }
        public Vector OriginRotation { get { return this[nameof(OriginRotation)].As<Vector>(); } set { this["OriginRotation"] = value; } }
        public Array<ContainerVO> Containers { get { return new Array<ContainerVO>(this[nameof(Containers)].Address); } }
    }
    public class ContainerVO : Object
    {
        public ContainerVO(ulong addr) : base(addr) { }
        public Object ID { get { return this[nameof(ID)]; } set { this[nameof(ID)] = value; } }
        public int ContainerId { get { return this[nameof(ContainerId)].GetValue<int>(); } set { this[nameof(ContainerId)].SetValue<int>(value); } }
        public EContainerType Type { get { return (EContainerType)this[nameof(Type)].GetValue<int>(); } set { this[nameof(Type)].SetValue<int>((int)value); } }
        public Array<ContainerSlotVO> Slots { get { return new Array<ContainerSlotVO>(this[nameof(Slots)].Address); } }
        public int SelectedLoadout { get { return this[nameof(SelectedLoadout)].GetValue<int>(); } set { this[nameof(SelectedLoadout)].SetValue<int>(value); } }
        public bool bIsInstanced { get { return this[nameof(bIsInstanced)].Flag; } set { this[nameof(bIsInstanced)].Flag = value; } }
    }
    public class ContainerSlotVO : Object
    {
        public ContainerSlotVO(ulong addr) : base(addr) { }
        public Object ID { get { return this[nameof(ID)]; } set { this[nameof(ID)] = value; } }
        public ContainerSlotItemVO Item { get { return this[nameof(Item)].As<ContainerSlotItemVO>(); } set { this["Item"] = value; } }
        public int Count { get { return this[nameof(Count)].GetValue<int>(); } set { this[nameof(Count)].SetValue<int>(value); } }
        public int LoadoutIndex { get { return this[nameof(LoadoutIndex)].GetValue<int>(); } set { this[nameof(LoadoutIndex)].SetValue<int>(value); } }
    }
    public class ContainerSlotItemVO : Object
    {
        public ContainerSlotItemVO(ulong addr) : base(addr) { }
        public Object ID { get { return this[nameof(ID)]; } set { this[nameof(ID)] = value; } }
        public int ItemId { get { return this[nameof(ItemId)].GetValue<int>(); } set { this[nameof(ItemId)].SetValue<int>(value); } }
        public int Durability { get { return this[nameof(Durability)].GetValue<int>(); } set { this[nameof(Durability)].SetValue<int>(value); } }
    }
    public enum EContainerType : int
    {
        Generic = 0,
        InventoryPouch = 1,
        CommunityChest = 2,
        Offering = 4,
        NPCEquipment = 5,
        PlayerLoot = 7,
        Upgrade = 8,
        EContainerType_MAX = 9,
    }
    public class WorldContainerVO : Object
    {
        public WorldContainerVO(ulong addr) : base(addr) { }
        public Object ID { get { return this[nameof(ID)]; } set { this[nameof(ID)] = value; } }
        public Object DisplayName { get { return this[nameof(DisplayName)]; } set { this[nameof(DisplayName)] = value; } }
        public ContainerVO Container { get { return this[nameof(Container)].As<ContainerVO>(); } set { this["Container"] = value; } }
        public Vector Location { get { return this[nameof(Location)].As<Vector>(); } set { this["Location"] = value; } }
        public EWorldContainerType Type { get { return (EWorldContainerType)this[nameof(Type)].GetValue<int>(); } set { this[nameof(Type)].SetValue<int>((int)value); } }
        public Object ExternalId { get { return this[nameof(ExternalId)]; } set { this[nameof(ExternalId)] = value; } }
    }
    public enum EWorldContainerType : int
    {
        None = 0,
        PlayerLoot = 1,
        EWorldContainerType_MAX = 2,
    }
    public class WorldCharacterVO : Object
    {
        public WorldCharacterVO(ulong addr) : base(addr) { }
        public Object ID { get { return this[nameof(ID)]; } set { this[nameof(ID)] = value; } }
        public ESellerType Type { get { return (ESellerType)this[nameof(Type)].GetValue<int>(); } set { this[nameof(Type)].SetValue<int>((int)value); } }
        public float Cooldown { get { return this[nameof(Cooldown)].GetValue<float>(); } set { this[nameof(Cooldown)].SetValue<float>(value); } }
    }
    public enum ESellerType : int
    {
        None = 0,
        Blacksmith = 1,
        Tailor = 2,
        Druid = 3,
        Volva = 4,
        CultistPools = 5,
        CultistForest = 6,
        CultistGlacier = 7,
        CultistBeach = 8,
        CultistDesert = 9,
        BlacksmithPools = 10,
        BlacksmithForest = 11,
        BlacksmithGlacier = 12,
        BlacksmithBeach = 13,
        BlacksmithDesert = 14,
        TransformerPools = 15,
        TransformerForest = 16,
        TransformerGlacier = 17,
        TransformerBeach = 18,
        TransformerDesert = 19,
        Tinker = 20,
        FTUEBlacksmith = 21,
        FTUETinker = 22,
        ESellerType_MAX = 23,
    }
    public class WorldPlayerVO : Object
    {
        public WorldPlayerVO(ulong addr) : base(addr) { }
        public Object ID { get { return this[nameof(ID)]; } set { this[nameof(ID)] = value; } }
        public bool bIsAdmin { get { return this[nameof(bIsAdmin)].Flag; } set { this[nameof(bIsAdmin)].Flag = value; } }
        public bool bIsOnline { get { return this[nameof(bIsOnline)].Flag; } set { this[nameof(bIsOnline)].Flag = value; } }
        public float Health { get { return this[nameof(Health)].GetValue<float>(); } set { this[nameof(Health)].SetValue<float>(value); } }
        public int SpecialPoints { get { return this[nameof(SpecialPoints)].GetValue<int>(); } set { this[nameof(SpecialPoints)].SetValue<int>(value); } }
        public ESkillClass SelectedClass { get { return (ESkillClass)this[nameof(SelectedClass)].GetValue<int>(); } set { this[nameof(SelectedClass)].SetValue<int>((int)value); } }
        public Array<int> UnlockedSkills { get { return new Array<int>(this[nameof(UnlockedSkills)].Address); } }
        public Array<int> WishlistedRecipes { get { return new Array<int>(this[nameof(WishlistedRecipes)].Address); } }
        public int PlayerXP { get { return this[nameof(PlayerXP)].GetValue<int>(); } set { this[nameof(PlayerXP)].SetValue<int>(value); } }
        public Vector WorldPosition { get { return this[nameof(WorldPosition)].As<Vector>(); } set { this["WorldPosition"] = value; } }
        public Array<ContainerVO> Containers { get { return new Array<ContainerVO>(this[nameof(Containers)].Address); } }
        public bool bSawFTUE { get { return this[nameof(bSawFTUE)].Flag; } set { this[nameof(bSawFTUE)].Flag = value; } }
        public Vector RuneStoneGoBackPosition { get { return this[nameof(RuneStoneGoBackPosition)].As<Vector>(); } set { this["RuneStoneGoBackPosition"] = value; } }
        public bool bRuneStoneInGoBackMode { get { return this[nameof(bRuneStoneInGoBackMode)].Flag; } set { this[nameof(bRuneStoneInGoBackMode)].Flag = value; } }
        public int ConstructionCount { get { return this[nameof(ConstructionCount)].GetValue<int>(); } set { this[nameof(ConstructionCount)].SetValue<int>(value); } }
        public int AltarUseCount { get { return this[nameof(AltarUseCount)].GetValue<int>(); } set { this[nameof(AltarUseCount)].SetValue<int>(value); } }
        public Array<int> PersonalQuests { get { return new Array<int>(this[nameof(PersonalQuests)].Address); } }
    }
    public enum ESkillClass : int
    {
        Sharpshooter = 0,
        Scout = 1,
        Fighter = 2,
        Berserker = 3,
        Guardian = 4,
        Sentinel = 5,
        Warden = 6,
        Seer = 7,
        None = 254,
        ESkillClass_MAX = 255,
    }
    public class WorldGiantVO : Object
    {
        public WorldGiantVO(ulong addr) : base(addr) { }
        public Object ID { get { return this[nameof(ID)]; } set { this[nameof(ID)] = value; } }
        public int GiantId { get { return this[nameof(GiantId)].GetValue<int>(); } set { this[nameof(GiantId)].SetValue<int>(value); } }
        public float Health { get { return this[nameof(Health)].GetValue<float>(); } set { this[nameof(Health)].SetValue<float>(value); } }
        public Vector WorldPosition { get { return this[nameof(WorldPosition)].As<Vector>(); } set { this["WorldPosition"] = value; } }
        public int CurrentTargetIndex { get { return this[nameof(CurrentTargetIndex)].GetValue<int>(); } set { this[nameof(CurrentTargetIndex)].SetValue<int>(value); } }
        public int CurrentZoneIndex { get { return this[nameof(CurrentZoneIndex)].GetValue<int>(); } set { this[nameof(CurrentZoneIndex)].SetValue<int>(value); } }
        public int GiantCurrentPathIndex { get { return this[nameof(GiantCurrentPathIndex)].GetValue<int>(); } set { this[nameof(GiantCurrentPathIndex)].SetValue<int>(value); } }
        public float Delay { get { return this[nameof(Delay)].GetValue<float>(); } set { this[nameof(Delay)].SetValue<float>(value); } }
        public bool bHasBeenDiscovered { get { return this[nameof(bHasBeenDiscovered)].Flag; } set { this[nameof(bHasBeenDiscovered)].Flag = value; } }
        public Vector LastKnownPosition { get { return this[nameof(LastKnownPosition)].As<Vector>(); } set { this["LastKnownPosition"] = value; } }
    }
    public enum EGameMode : int
    {
        None = 0,
        Tutorial = 1,
        SeasonMulti = 2,
        Custom = 3,
        Creative = 4,
        SeasonSolo = 5,
        EGameMode_MAX = 6,
    }
    public class WorldConfigVO : Object
    {
        public WorldConfigVO(ulong addr) : base(addr) { }
        public int MapSize { get { return this[nameof(MapSize)].GetValue<int>(); } set { this[nameof(MapSize)].SetValue<int>(value); } }
        public int NPCDifficulty { get { return this[nameof(NPCDifficulty)].GetValue<int>(); } set { this[nameof(NPCDifficulty)].SetValue<int>(value); } }
        public int QuestsDifficulty { get { return this[nameof(QuestsDifficulty)].GetValue<int>(); } set { this[nameof(QuestsDifficulty)].SetValue<int>(value); } }
        public int EventsDifficulty { get { return this[nameof(EventsDifficulty)].GetValue<int>(); } set { this[nameof(EventsDifficulty)].SetValue<int>(value); } }
        public int CreaturesDifficulty { get { return this[nameof(CreaturesDifficulty)].GetValue<int>(); } set { this[nameof(CreaturesDifficulty)].SetValue<int>(value); } }
        public int MinionsDifficulty { get { return this[nameof(MinionsDifficulty)].GetValue<int>(); } set { this[nameof(MinionsDifficulty)].SetValue<int>(value); } }
        public int GiantsDifficulty { get { return this[nameof(GiantsDifficulty)].GetValue<int>(); } set { this[nameof(GiantsDifficulty)].SetValue<int>(value); } }
        public int MythBossDifficulty { get { return this[nameof(MythBossDifficulty)].GetValue<int>(); } set { this[nameof(MythBossDifficulty)].SetValue<int>(value); } }
        public int GiantsArrow { get { return this[nameof(GiantsArrow)].GetValue<int>(); } set { this[nameof(GiantsArrow)].SetValue<int>(value); } }
        public int YggdrasilDecay { get { return this[nameof(YggdrasilDecay)].GetValue<int>(); } set { this[nameof(YggdrasilDecay)].SetValue<int>(value); } }
        public int DeadLootChest { get { return this[nameof(DeadLootChest)].GetValue<int>(); } set { this[nameof(DeadLootChest)].SetValue<int>(value); } }
        public int XPDifficulty { get { return this[nameof(XPDifficulty)].GetValue<int>(); } set { this[nameof(XPDifficulty)].SetValue<int>(value); } }
        public int LootDifficulty { get { return this[nameof(LootDifficulty)].GetValue<int>(); } set { this[nameof(LootDifficulty)].SetValue<int>(value); } }
        public int SpawnGiants { get { return this[nameof(SpawnGiants)].GetValue<int>(); } set { this[nameof(SpawnGiants)].SetValue<int>(value); } }
        public int SpawnMinions { get { return this[nameof(SpawnMinions)].GetValue<int>(); } set { this[nameof(SpawnMinions)].SetValue<int>(value); } }
    }
    public enum EPlatformController : int
    {
        Unknown = 0,
        Keyboard = 1,
        GenericGamepad = 2,
        PlaystationGamepad = 3,
        XBoxGamepad = 4,
        EPlatformController_MAX = 5,
    }
    public enum ECurrencyType : int
    {
        Basic = 0,
        Victory = 1,
        ECurrencyType_MAX = 2,
    }
    public enum EStartupStates : int
    {
        NotStarted = 0,
        ServerInfosSet = 1,
        UserAuthenticated = 2,
        GameDataReady = 3,
        UserDataFetched = 4,
        Initialized = 5,
        EStartupStates_MAX = 6,
    }
    public enum EQuestIconType : int
    {
        None = 0,
        Ready = 1,
        InProgress = 2,
        Completed = 3,
        Cooldown = 4,
        EQuestIconType_MAX = 5,
    }
    public enum EMapPingType : int
    {
        TreasureMap = 0,
        RallyHorn = 1,
        EMapPingType_MAX = 2,
    }
    public enum EChallengeCategory : int
    {
        None = 0,
        Class = 1,
        Achievement = 2,
        Saga = 3,
        EChallengeCategory_MAX = 4,
    }
    public enum EChallengeType : int
    {
        None = 0,
        BifrostUseCount = 1,
        SurvivedDaysInSeason = 2,
        FastBlockCount = 3,
        FastKillEnemyCount = 4,
        RevealedAllShrineCount = 5,
        MaxGiantKillInASession = 6,
        TutorialCompleted = 7,
        CompleteAchievement = 8,
        CompleteAllChallengeInCategory = 9,
        FenrirKillCount = 10,
        EChallengeType_MAX = 11,
    }
    public enum EQuestDifficulty : int
    {
        None = 0,
        Easy = 1,
        Medium = 2,
        Hard = 3,
        EQuestDifficulty_MAX = 4,
    }
    public enum EBlueprintTypes : int
    {
        CraftingRecipe = 0,
        Modifier = 1,
        EBlueprintTypes_MAX = 2,
    }
    public enum EEntitlementType : int
    {
        Modifier = 0,
        Cosmetic = 1,
        StarterPack = 2,
        PlayerClass = 3,
        Transmog = 4,
        EEntitlementType_MAX = 5,
    }
    public enum ECheatServiceType : int
    {
        None = 0,
        EarnSeasonXP = 1,
        EarnBasicCurrency = 2,
        EarnVictoryCurrency = 3,
        UnlockEntitlement = 4,
        UnlockAllEntitlements = 5,
        AddExternalEntitlement = 6,
        ECheatServiceType_MAX = 7,
    }
    public enum EReportReason : int
    {
        Cheating = 0,
        Inactivity = 1,
        AbusiveLanguage = 2,
        EReportReason_MAX = 3,
    }
    public enum ECaveType : int
    {
        Passage = 0,
        Dungeon = 1,
        MythBoss = 2,
        ECaveType_MAX = 3,
    }
    public enum ERewardType : int
    {
        CosmeticItem = 0,
        BasicCurrency = 1,
        VictoryCurrency = 2,
        Blueprint = 3,
        Entitlement = 4,
        ContentBundle = 5,
        ERewardType_MAX = 6,
    }
    public enum EAchievementType : int
    {
        None = 0,
        SpendSouls = 1,
        MaxClass = 2,
        Revive = 3,
        ReachSeasonLevel = 4,
        WinSeasonPlay = 5,
        KillGiant = 6,
        KillMythBoss = 7,
        CompleteTutorial = 8,
        SurvivedDaysInEndless = 9,
        ConstructionsCountInCreative = 10,
        CraftItemRarity = 11,
        MaxSoulCount = 12,
        HasPet = 13,
        EAchievementType_MAX = 14,
    }
    public enum EAchievementBehavior : int
    {
        None = 0,
        Accumulate = 1,
        Reach = 2,
        EAchievementBehavior_MAX = 3,
    }
    public enum EQuestType : int
    {
        None = 0,
        KillCreatures = 1,
        DonateMaterials = 2,
        BuildHazards = 3,
        EnterCave = 4,
        KillGiant = 5,
        BuildHazard = 6,
        FeedYggdrasil = 7,
        SurviveNight = 8,
        CollectMaterials = 9,
        GiantSpawn = 10,
        TalkToNPC = 11,
        Neverending = 12,
        EQuestType_MAX = 13,
    }
    public enum ETemperatureType : int
    {
        Cold = 0,
        Confort = 1,
        Hot = 2,
        ETemperatureType_MAX = 3,
    }
    public enum EInputContextualAction : int
    {
        Interact = 0,
        InteractSecondary = 1,
        InteractCancel = 2,
        InteractDeconstruct = 3,
        InteractUpgrade = 4,
        EInputContextualAction_MAX = 5,
    }
    public enum EFootstepType : int
    {
        Walk = 0,
        Run = 1,
        EFootstepType_MAX = 2,
    }
    public enum ESeason : int
    {
        None = 0,
        Spring = 1,
        Summer = 2,
        Autumn = 3,
        Winter = 4,
        ESeason_MAX = 5,
    }
    public enum EAITrigger : int
    {
        AtWill = 0,
        OnHealthBelow50 = 1,
        IgnoreChannelForCasting = 2,
        Special = 3,
        EAITrigger_MAX = 4,
    }
    public enum EAnnouncementColor : int
    {
        Beige = 0,
        Orange = 1,
        Purple = 2,
        Red = 3,
        Gold = 4,
        Green = 5,
        EAnnouncementColor_MAX = 6,
    }
    public enum EHarvestAnimType : int
    {
        None = 0,
        Mining = 1,
        Cutting = 2,
        Collecting = 3,
        OpenChest = 4,
        EHarvestAnimType_MAX = 5,
    }
    public enum ECharacterAttackState : int
    {
        None = 0,
        Anticipation = 1,
        Execution = 2,
        Recovery = 3,
        ExecutionWithRotation = 4,
        ECharacterAttackState_MAX = 5,
    }
    public enum EStackableAction : int
    {
        None = 0,
        Attack = 1,
        Evade = 2,
        Harvest = 3,
        CollectLoot = 4,
        Interact = 5,
        EStackableAction_MAX = 6,
    }
    public enum EMoveMode : int
    {
        SourceToTarget = 0,
        TargetToSource = 1,
        EMoveMode_MAX = 2,
    }
    public enum ECameraZoomLevel : int
    {
        Zoom0 = 0,
        Zoom1 = 1,
        Zoom2 = 2,
        Zoom3 = 3,
        Shielding = 4,
        Giant = 5,
        Troll = 6,
        MythBoss = 7,
        ECameraZoomLevel_MAX = 8,
    }
    public enum EALSRotationMode : int
    {
        Velocity = 0,
        Looking = 1,
        LookingAtTarget = 2,
        LookAtDirection = 3,
        EALSRotationMode_MAX = 4,
    }
    public enum ERuntimePlatform : int
    {
        Desktop = 0,
        PS4 = 1,
        PS5 = 2,
        Switch = 3,
        XboxOne = 4,
        XboxSeriesX = 5,
        ERuntimePlatform_MAX = 6,
    }
    public enum EFeatures : int
    {
        SaveGame = 0,
        Autoshutdown = 1,
        EFeatures_MAX = 2,
    }
    public enum EFeatureFlag : int
    {
        Disabled = 0,
        EnabledLocal = 1,
        EnabledOnline = 2,
        EnabledEverywhere = 3,
        EFeatureFlag_MAX = 4,
    }
    public enum EGender : int
    {
        Male = 0,
        Female = 1,
        Any = 2,
        EGender_MAX = 3,
    }
    public enum EDoorType : int
    {
        None = 0,
        Fortification = 1,
        Bastion = 2,
        EDoorType_MAX = 3,
    }
    public enum EFortificationType : int
    {
        Gate = 0,
        Turret = 1,
        EFortificationType_MAX = 2,
    }
    public enum EMaterialSourceTypes : int
    {
        MiscMaterials = 0,
        Chest = 1,
        Tree = 2,
        Plant = 3,
        Mineral = 4,
        EMaterialSourceTypes_MAX = 5,
    }
    public enum EStance : int
    {
        Default = 0,
        TwoHanded = 1,
        SpearThrower = 2,
        NoWeapon = 3,
        Building = 4,
        Knife = 5,
        Bow = 6,
        EStance_MAX = 7,
    }
    public enum EEquipmentElement : int
    {
        None = 0,
        Physical = 1,
        Fire = 2,
        Ice = 3,
        Dark = 4,
        Thunder = 5,
        EEquipmentElement_MAX = 6,
    }
    public enum EItemRarity : int
    {
        None = 0,
        Common = 1,
        Uncommon = 2,
        Rare = 3,
        Epic = 4,
        Legendary = 5,
        Mythic = 6,
        MaterialTier1 = 7,
        MaterialTier2 = 8,
        MaterialTier3 = 9,
        MaterialTier4 = 10,
        MaterialTier5 = 11,
        MaterialTier6 = 12,
        MaterialTier7 = 13,
        GoldenHorn = 14,
        EItemRarity_MAX = 15,
    }
    public enum EServerMessageType : int
    {
        None = 0,
        UpdateUTCTime = 1,
        Maintenance = 2,
        UserXPEarned = 3,
        CurrencyChanged = 4,
        CosmeticsUnlocked = 5,
        BlueprintUnlocked = 6,
        EntitlementUnlocked = 7,
        ContentBundleUnlocked = 8,
        EServerMessageType_MAX = 9,
    }
    public enum EEnvironmentAlter : int
    {
        None = 0,
        Regular = 1,
        Snow = 2,
        Dry = 3,
        EEnvironmentAlter_MAX = 4,
    }
    public enum EModuleLocationType : int
    {
        None = 0,
        Regular = 1,
        OnRoad = 2,
        Isolated = 3,
        EModuleLocationType_MAX = 4,
    }
    public enum EPOIType : int
    {
        None = 0,
        Shrine = 1,
        Camp = 2,
        Ruin = 3,
        Village = 4,
        NPC = 5,
        Landmark = 6,
        Trap = 7,
        RampNorth = 8,
        RampSouth = 9,
        RampEast = 10,
        RampWest = 11,
        Extractor = 12,
        CaveEntrance = 13,
        Bridge = 14,
        Quest = 15,
        Dungeon = 16,
        MythBoss = 17,
        Bifrost = 18,
        EPOIType_MAX = 19,
    }
    public enum ECardinal : int
    {
        None = 0,
        North = 1,
        South = 2,
        East = 3,
        West = 4,
        ECardinal_MAX = 5,
    }
    public enum EPerkType : int
    {
        None = 0,
        DamageOverTime = 1,
        SpeedAlter = 2,
        ArmorAlter = 3,
        Stun = 4,
        Nullify = 5,
        ResistanceAlter = 6,
        Leap = 7,
        Damage = 8,
        SpecialPointGain = 9,
        LifeSteal = 10,
        Trail = 11,
        ElementalEfficiency = 12,
        ItemTypeEfficiency = 13,
        ItemCategoryDurabilityAlter = 14,
        Teleport = 15,
        MoveSpeedAlter = 16,
        Invincibility = 17,
        LastStand = 18,
        HealthPointAlter = 19,
        Bloodlust = 20,
        SkillPointGainAlter = 21,
        TargetTypeEfficiency = 22,
        SpiritedShrine = 23,
        SharpEyes = 24,
        EmpoweringTouch = 25,
        BulwarkStrike = 26,
        CleanSalvage = 27,
        UninterruptedRevive = 28,
        DamageAlter = 29,
        AttackOnDeath = 30,
        AttackOnHit = 31,
        Transformation = 32,
        Spawner = 33,
        ColdTemperatureModifier = 34,
        HotTemperatureModifier = 35,
        StickToTarget = 36,
        NightAura = 37,
        Attract = 38,
        SecondaryProjectile = 39,
        StatusWhileInAOE = 40,
        ChargedShots = 41,
        ShieldAggro = 42,
        BrawlerCombo = 43,
        SkillPointMaxAlter = 44,
        InventorySettingAlter = 45,
        TwoWayRuneStone = 46,
        Aggroed = 47,
        SwapReset = 48,
        ShieldCircle = 49,
        ShieldMana = 50,
        HitMana = 51,
        Freefall = 52,
        InvincibleRoll = 53,
        SelfRevive = 54,
        ResetRuneStoneInVillage = 55,
        VillageFastMove = 56,
        AttackSpeedAlter = 57,
        CraftingCostAlter = 58,
        FarShot = 59,
        AffectedByFarShot = 60,
        FastActivation = 61,
        RunestoneCooldownReplace = 62,
        AttackOverTime = 63,
        SpawnOnDeath = 64,
        ProjectileWaveRangeIncrease = 65,
        ResetRunestoneCooldown = 66,
        RepairEquipedItems = 67,
        ManaOverTime = 68,
        YggdrasilAttackExtraHP = 69,
        YggdrasilAttackExtraSP = 70,
        HealthOnRunestone = 71,
        ManaOnRunestone = 72,
        Shield360 = 73,
        ArrowPiercing = 74,
        SoulsGain = 75,
        KeepSoulOnDeath = 76,
        UndergroundArmorBonus = 77,
        LongRangeDamageBonus = 78,
        MunitionDamageBonus = 79,
        AOEHealOnReviving = 80,
        IdleHealthRegen = 81,
        SoulDamageBonus = 82,
        NakedDamageBonus = 83,
        NightSpeedBonus = 84,
        ColdHealthRegen = 85,
        IncreaseMaterialDrop = 86,
        IncreaseTreasureXP = 87,
        AttackOnLightAttack = 88,
        HotSpeedBonus = 89,
        AttackOnKill = 90,
        AttackOnBlock = 91,
        DamageBonusOnSpAtPercent = 92,
        HealOnHarvest = 93,
        KeepPercentMaterialOnDeath = 94,
        AttackOnEvade = 95,
        GoldenHornOnBifrostUse = 96,
        SoulDrainForSp = 97,
        AttackOnDeconstruct = 98,
        TriggeredTrapDamageBonus = 99,
        RepairDiscount = 100,
        DamageMultiplierBonus = 101,
        ApplyStatusWhileInAura = 102,
        JumpBack = 103,
        ExtraZoomLevel = 104,
        DecayingSlow = 105,
        MunitionSpeedAlter = 106,
        RecoverMunitions = 107,
        RespawnTotem = 108,
        LightAttackKnockbackAlter = 109,
        IncreaseMaterialFromCreatureType = 110,
        IncreaseMaterialFromResourceType = 111,
        DecoyRoll = 112,
        DoubleMeleeLightAttackHit = 113,
        EnergizedAttack = 114,
        ManaOnAttackHit = 115,
        AttackOnComboFilled = 116,
        StunResistance = 117,
        SlowResistance = 118,
        HighestDamageChanceAlter = 119,
        TauntPull = 120,
        GuardianMeter = 121,
        ApplyStatusWhileShieldUp = 122,
        ShieldBlocksPiercingAttack = 123,
        SentinelShieldTotalDefense = 124,
        DamageReceivedMultiplierBonusOnPerkTagOwner = 125,
        AddItems = 126,
        SoulSellingMultiplierBonus = 127,
        SoulBuyingMultiplierDiscount = 128,
        YggdrasilSeedling = 129,
        DamageReceivedMultiplierBonus = 130,
        YggdrasilSeedlingAdditionalPerks = 131,
        ReviveSpeedMultiplier = 132,
        ApplyStatusOnLightAttack = 133,
        RevealPOI = 134,
        ArmorMultiplierBonus = 135,
        ResistPerkByTag = 136,
        AttackOnLightAttackHit = 137,
        ResistPushBack = 138,
        GainSoulsOnAttack = 139,
        LoseSoulsOnHit = 140,
        EPerkType_MAX = 141,
    }
    public enum ERespawnMode : int
    {
        None = 0,
        Regular = 1,
        Custom = 2,
        ERespawnMode_MAX = 3,
    }
    public enum ECharacterType : int
    {
        None = 0,
        Player = 1,
        Creature = 2,
        Animal = 3,
        Minion = 4,
        Giant = 5,
        MythBoss = 6,
        NPC = 7,
        Elite = 8,
        ECharacterType_MAX = 9,
    }
    public enum ESortType : int
    {
        PowerDesc = 0,
        PowerAsc = 1,
        AZ = 2,
        ZA = 3,
        ESortType_MAX = 4,
    }
    public enum ECosmeticType : int
    {
        SkinTone = 0,
        HairColor = 1,
        Head = 2,
        Haircut = 3,
        Portrait = 4,
        Emote = 5,
        Command = 6,
        Pet = 7,
        Transmog = 8,
        StarterKit = 9,
        ECosmeticType_MAX = 10,
    }
    public enum EAttackType : int
    {
        Melee = 0,
        AOE = 1,
        Projectile = 2,
        Self = 3,
        EAttackType_MAX = 4,
    }
    public enum EHealthBarColor : int
    {
        Normal = 0,
        Boss = 1,
        Troll = 2,
        None = 3,
        EHealthBarColor_MAX = 4,
    }
    public enum EAnimalState : int
    {
        Guarding = 0,
        Hidden = 1,
        AttackYggdrasil = 2,
        Patrol = 3,
        Flee = 4,
        Idle = 5,
        ZoneGuarding = 6,
        FlyAway = 7,
        FollowPlayer = 8,
        EAnimalState_MAX = 9,
    }
    public enum ECodexEntryType : int
    {
        Vegetal = 0,
        Mineral = 1,
        Creature = 2,
        Giant = 3,
        Boss = 4,
        NPC = 5,
        POI = 6,
        ECodexEntryType_MAX = 7,
    }
    public enum EDayTimeSegment : int
    {
        Dawn = 0,
        Day = 1,
        Evening = 2,
        Night = 3,
        Unknown = 4,
        EDayTimeSegment_MAX = 5,
    }
    public enum EItemCategory : int
    {
        None = 0,
        Weapon = 1,
        Shield = 2,
        Armor = 3,
        Tool = 4,
        Material = 5,
        Essence = 6,
        Consumable = 7,
        Blueprints = 8,
        Munition = 9,
        Construction = 10,
        Modifiers = 11,
        Currency = 12,
        EItemCategory_MAX = 13,
    }
    public enum EAlertColor : int
    {
        Red = 0,
        Green = 1,
        Blue = 2,
        Gold = 3,
        Pink = 4,
        EAlertColor_MAX = 5,
    }
    public class UserAvatarVO : Object
    {
        public UserAvatarVO(ulong addr) : base(addr) { }
        public Object ID { get { return this[nameof(ID)]; } set { this[nameof(ID)] = value; } }
        public int CharacterId { get { return this[nameof(CharacterId)].GetValue<int>(); } set { this[nameof(CharacterId)].SetValue<int>(value); } }
        public int Gender { get { return this[nameof(Gender)].GetValue<int>(); } set { this[nameof(Gender)].SetValue<int>(value); } }
        public int SkinToneId { get { return this[nameof(SkinToneId)].GetValue<int>(); } set { this[nameof(SkinToneId)].SetValue<int>(value); } }
        public int HairColorId { get { return this[nameof(HairColorId)].GetValue<int>(); } set { this[nameof(HairColorId)].SetValue<int>(value); } }
        public int HeadCosmeticId { get { return this[nameof(HeadCosmeticId)].GetValue<int>(); } set { this[nameof(HeadCosmeticId)].SetValue<int>(value); } }
        public int HaircutCosmeticId { get { return this[nameof(HaircutCosmeticId)].GetValue<int>(); } set { this[nameof(HaircutCosmeticId)].SetValue<int>(value); } }
        public int IconId { get { return this[nameof(IconId)].GetValue<int>(); } set { this[nameof(IconId)].SetValue<int>(value); } }
        public int PetId { get { return this[nameof(PetId)].GetValue<int>(); } set { this[nameof(PetId)].SetValue<int>(value); } }
        public Array<int> Emotes { get { return new Array<int>(this[nameof(Emotes)].Address); } }
        public Array<int> Commands { get { return new Array<int>(this[nameof(Commands)].Address); } }
        public int StarterKit { get { return this[nameof(StarterKit)].GetValue<int>(); } set { this[nameof(StarterKit)].SetValue<int>(value); } }
        public Array<int> Transmogs { get { return new Array<int>(this[nameof(Transmogs)].Address); } }
    }
    public class UserVO : Object
    {
        public UserVO(ulong addr) : base(addr) { }
        public Object ID { get { return this[nameof(ID)]; } set { this[nameof(ID)] = value; } }
        public Object Name { get { return this[nameof(Name)]; } set { this[nameof(Name)] = value; } }
        public Object CurrencyCode { get { return this[nameof(CurrencyCode)]; } set { this[nameof(CurrencyCode)] = value; } }
        public UserAvatarVO Avatar { get { return this[nameof(Avatar)].As<UserAvatarVO>(); } set { this["Avatar"] = value; } }
        public int XP { get { return this[nameof(XP)].GetValue<int>(); } set { this[nameof(XP)].SetValue<int>(value); } }
        public int SeasonXP { get { return this[nameof(SeasonXP)].GetValue<int>(); } set { this[nameof(SeasonXP)].SetValue<int>(value); } }
        public Array<int> Currencies { get { return new Array<int>(this[nameof(Currencies)].Address); } }
        public Array<int> PurchasedCosmetics { get { return new Array<int>(this[nameof(PurchasedCosmetics)].Address); } }
        public Array<int> UnlockedBlueprints { get { return new Array<int>(this[nameof(UnlockedBlueprints)].Address); } }
        public Array<int> OwnedEntitlements { get { return new Array<int>(this[nameof(OwnedEntitlements)].Address); } }
        public Array<int> ContentBundles { get { return new Array<int>(this[nameof(ContentBundles)].Address); } }
        public Array<int> ClaimedChallenges { get { return new Array<int>(this[nameof(ClaimedChallenges)].Address); } }
        public UserDataVO UserData { get { return this[nameof(UserData)].As<UserDataVO>(); } set { this["UserData"] = value; } }
    }
    public class UserDataVO : Object
    {
        public UserDataVO(ulong addr) : base(addr) { }
        public bool bHasSeenTutorial { get { return this[nameof(bHasSeenTutorial)].Flag; } set { this[nameof(bHasSeenTutorial)].Flag = value; } }
        public int TotalSoulsSpent { get { return this[nameof(TotalSoulsSpent)].GetValue<int>(); } set { this[nameof(TotalSoulsSpent)].SetValue<int>(value); } }
        public int HasMaxedSharpshooter { get { return this[nameof(HasMaxedSharpshooter)].GetValue<int>(); } set { this[nameof(HasMaxedSharpshooter)].SetValue<int>(value); } }
        public int HasMaxedScout { get { return this[nameof(HasMaxedScout)].GetValue<int>(); } set { this[nameof(HasMaxedScout)].SetValue<int>(value); } }
        public int HasMaxedFighter { get { return this[nameof(HasMaxedFighter)].GetValue<int>(); } set { this[nameof(HasMaxedFighter)].SetValue<int>(value); } }
        public int HasMaxedBerserker { get { return this[nameof(HasMaxedBerserker)].GetValue<int>(); } set { this[nameof(HasMaxedBerserker)].SetValue<int>(value); } }
        public int HasMaxedGuardian { get { return this[nameof(HasMaxedGuardian)].GetValue<int>(); } set { this[nameof(HasMaxedGuardian)].SetValue<int>(value); } }
        public int HasMaxedSentinel { get { return this[nameof(HasMaxedSentinel)].GetValue<int>(); } set { this[nameof(HasMaxedSentinel)].SetValue<int>(value); } }
        public int HasMaxedWarden { get { return this[nameof(HasMaxedWarden)].GetValue<int>(); } set { this[nameof(HasMaxedWarden)].SetValue<int>(value); } }
        public int HasMaxedSeer { get { return this[nameof(HasMaxedSeer)].GetValue<int>(); } set { this[nameof(HasMaxedSeer)].SetValue<int>(value); } }
        public int MaxUserLevelReached { get { return this[nameof(MaxUserLevelReached)].GetValue<int>(); } set { this[nameof(MaxUserLevelReached)].SetValue<int>(value); } }
        public int HasRevivedPlayer { get { return this[nameof(HasRevivedPlayer)].GetValue<int>(); } set { this[nameof(HasRevivedPlayer)].SetValue<int>(value); } }
        public int HasRevivedNPC { get { return this[nameof(HasRevivedNPC)].GetValue<int>(); } set { this[nameof(HasRevivedNPC)].SetValue<int>(value); } }
        public int HasCompletedSeason { get { return this[nameof(HasCompletedSeason)].GetValue<int>(); } set { this[nameof(HasCompletedSeason)].SetValue<int>(value); } }
        public int HasKillGiantIce { get { return this[nameof(HasKillGiantIce)].GetValue<int>(); } set { this[nameof(HasKillGiantIce)].SetValue<int>(value); } }
        public int HasKillGiantFire { get { return this[nameof(HasKillGiantFire)].GetValue<int>(); } set { this[nameof(HasKillGiantFire)].SetValue<int>(value); } }
        public int HasKillGiantThunder { get { return this[nameof(HasKillGiantThunder)].GetValue<int>(); } set { this[nameof(HasKillGiantThunder)].SetValue<int>(value); } }
        public int HasKillGiantDark { get { return this[nameof(HasKillGiantDark)].GetValue<int>(); } set { this[nameof(HasKillGiantDark)].SetValue<int>(value); } }
        public int HasKillMythBoss { get { return this[nameof(HasKillMythBoss)].GetValue<int>(); } set { this[nameof(HasKillMythBoss)].SetValue<int>(value); } }
        public int HasCompletedTutorial { get { return this[nameof(HasCompletedTutorial)].GetValue<int>(); } set { this[nameof(HasCompletedTutorial)].SetValue<int>(value); } }
        public int SurvivedDaysInEndless { get { return this[nameof(SurvivedDaysInEndless)].GetValue<int>(); } set { this[nameof(SurvivedDaysInEndless)].SetValue<int>(value); } }
        public int ConstructionsCountInCreative { get { return this[nameof(ConstructionsCountInCreative)].GetValue<int>(); } set { this[nameof(ConstructionsCountInCreative)].SetValue<int>(value); } }
        public int HasCraftCommon { get { return this[nameof(HasCraftCommon)].GetValue<int>(); } set { this[nameof(HasCraftCommon)].SetValue<int>(value); } }
        public int HasCraftUncommon { get { return this[nameof(HasCraftUncommon)].GetValue<int>(); } set { this[nameof(HasCraftUncommon)].SetValue<int>(value); } }
        public int HasCraftRare { get { return this[nameof(HasCraftRare)].GetValue<int>(); } set { this[nameof(HasCraftRare)].SetValue<int>(value); } }
        public int HasCraftEpic { get { return this[nameof(HasCraftEpic)].GetValue<int>(); } set { this[nameof(HasCraftEpic)].SetValue<int>(value); } }
        public int HasCraftLegendary { get { return this[nameof(HasCraftLegendary)].GetValue<int>(); } set { this[nameof(HasCraftLegendary)].SetValue<int>(value); } }
        public int HasCraftMythic { get { return this[nameof(HasCraftMythic)].GetValue<int>(); } set { this[nameof(HasCraftMythic)].SetValue<int>(value); } }
        public int MaxSoulCount { get { return this[nameof(MaxSoulCount)].GetValue<int>(); } set { this[nameof(MaxSoulCount)].SetValue<int>(value); } }
        public int HasPet { get { return this[nameof(HasPet)].GetValue<int>(); } set { this[nameof(HasPet)].SetValue<int>(value); } }
        public Array<int> CompletedChallenges { get { return new Array<int>(this[nameof(CompletedChallenges)].Address); } }
        public int BifrostUseCount { get { return this[nameof(BifrostUseCount)].GetValue<int>(); } set { this[nameof(BifrostUseCount)].SetValue<int>(value); } }
        public int FastKillEnemyCount { get { return this[nameof(FastKillEnemyCount)].GetValue<int>(); } set { this[nameof(FastKillEnemyCount)].SetValue<int>(value); } }
        public int RevealedAllShrineCount { get { return this[nameof(RevealedAllShrineCount)].GetValue<int>(); } set { this[nameof(RevealedAllShrineCount)].SetValue<int>(value); } }
        public int FastBlockCount { get { return this[nameof(FastBlockCount)].GetValue<int>(); } set { this[nameof(FastBlockCount)].SetValue<int>(value); } }
        public int SurvivedDaysInSeason { get { return this[nameof(SurvivedDaysInSeason)].GetValue<int>(); } set { this[nameof(SurvivedDaysInSeason)].SetValue<int>(value); } }
        public int MaxGiantKillInASession { get { return this[nameof(MaxGiantKillInASession)].GetValue<int>(); } set { this[nameof(MaxGiantKillInASession)].SetValue<int>(value); } }
        public int FenrirKillCount { get { return this[nameof(FenrirKillCount)].GetValue<int>(); } set { this[nameof(FenrirKillCount)].SetValue<int>(value); } }
    }
    public class AchievementsDataVO : Object
    {
        public AchievementsDataVO(ulong addr) : base(addr) { }
        public int ID { get { return this[nameof(ID)].GetValue<int>(); } set { this[nameof(ID)].SetValue<int>(value); } }
        public Object SteamId { get { return this[nameof(SteamId)]; } set { this[nameof(SteamId)] = value; } }
        public Object PS4Id { get { return this[nameof(PS4Id)]; } set { this[nameof(PS4Id)] = value; } }
        public Object PS5Id { get { return this[nameof(PS5Id)]; } set { this[nameof(PS5Id)] = value; } }
        public EAchievementType AchievementType { get { return (EAchievementType)this[nameof(AchievementType)].GetValue<int>(); } set { this[nameof(AchievementType)].SetValue<int>((int)value); } }
        public EAchievementBehavior AchievementBehavior { get { return (EAchievementBehavior)this[nameof(AchievementBehavior)].GetValue<int>(); } set { this[nameof(AchievementBehavior)].SetValue<int>((int)value); } }
        public bool bValidatePreviousSteps { get { return this[nameof(bValidatePreviousSteps)].Flag; } set { this[nameof(bValidatePreviousSteps)].Flag = value; } }
        public Object StatName { get { return this[nameof(StatName)]; } set { this[nameof(StatName)] = value; } }
        public float TargetValue { get { return this[nameof(TargetValue)].GetValue<float>(); } set { this[nameof(TargetValue)].SetValue<float>(value); } }
    }
    public class AIBehaviourDataVO : Object
    {
        public AIBehaviourDataVO(ulong addr) : base(addr) { }
        public int ID { get { return this[nameof(ID)].GetValue<int>(); } set { this[nameof(ID)].SetValue<int>(value); } }
        public EAnimalState DayState { get { return (EAnimalState)this[nameof(DayState)].GetValue<int>(); } set { this[nameof(DayState)].SetValue<int>((int)value); } }
        public EAnimalState EveningState { get { return (EAnimalState)this[nameof(EveningState)].GetValue<int>(); } set { this[nameof(EveningState)].SetValue<int>((int)value); } }
        public EAnimalState NightState { get { return (EAnimalState)this[nameof(NightState)].GetValue<int>(); } set { this[nameof(NightState)].SetValue<int>((int)value); } }
        public Array<int> ChannelPriority { get { return new Array<int>(this[nameof(ChannelPriority)].Address); } }
        public int DetectionRange { get { return this[nameof(DetectionRange)].GetValue<int>(); } set { this[nameof(DetectionRange)].SetValue<int>(value); } }
        public float DetectionHalfCone { get { return this[nameof(DetectionHalfCone)].GetValue<float>(); } set { this[nameof(DetectionHalfCone)].SetValue<float>(value); } }
        public float GlobalCooldown { get { return this[nameof(GlobalCooldown)].GetValue<float>(); } set { this[nameof(GlobalCooldown)].SetValue<float>(value); } }
        public float PatrolRadius { get { return this[nameof(PatrolRadius)].GetValue<float>(); } set { this[nameof(PatrolRadius)].SetValue<float>(value); } }
        public float MaxDistanceFromSpawn { get { return this[nameof(MaxDistanceFromSpawn)].GetValue<float>(); } set { this[nameof(MaxDistanceFromSpawn)].SetValue<float>(value); } }
        public bool bUseAggro { get { return this[nameof(bUseAggro)].Flag; } set { this[nameof(bUseAggro)].Flag = value; } }
        public bool bIsImmuneToAggro { get { return this[nameof(bIsImmuneToAggro)].Flag; } set { this[nameof(bIsImmuneToAggro)].Flag = value; } }
        public bool bAttackOpportunityTarget { get { return this[nameof(bAttackOpportunityTarget)].Flag; } set { this[nameof(bAttackOpportunityTarget)].Flag = value; } }
        public bool bUseDistancePriority { get { return this[nameof(bUseDistancePriority)].Flag; } set { this[nameof(bUseDistancePriority)].Flag = value; } }
        public bool bCanEvade { get { return this[nameof(bCanEvade)].Flag; } set { this[nameof(bCanEvade)].Flag = value; } }
        public bool bCanKite { get { return this[nameof(bCanKite)].Flag; } set { this[nameof(bCanKite)].Flag = value; } }
        public bool bWalkWhenNearTarget { get { return this[nameof(bWalkWhenNearTarget)].Flag; } set { this[nameof(bWalkWhenNearTarget)].Flag = value; } }
        public bool bStartNeutral { get { return this[nameof(bStartNeutral)].Flag; } set { this[nameof(bStartNeutral)].Flag = value; } }
        public bool bPackSharePerception { get { return this[nameof(bPackSharePerception)].Flag; } set { this[nameof(bPackSharePerception)].Flag = value; } }
    }
    public class AmmunitionDataVO : Object
    {
        public AmmunitionDataVO(ulong addr) : base(addr) { }
        public int ID { get { return this[nameof(ID)].GetValue<int>(); } set { this[nameof(ID)].SetValue<int>(value); } }
        public int ItemId { get { return this[nameof(ItemId)].GetValue<int>(); } set { this[nameof(ItemId)].SetValue<int>(value); } }
        public float DamageModifier { get { return this[nameof(DamageModifier)].GetValue<float>(); } set { this[nameof(DamageModifier)].SetValue<float>(value); } }
        public int DamageTypeOverride { get { return this[nameof(DamageTypeOverride)].GetValue<int>(); } set { this[nameof(DamageTypeOverride)].SetValue<int>(value); } }
        public Array<int> PerkIds { get { return new Array<int>(this[nameof(PerkIds)].Address); } }
        public int ProjectileId { get { return this[nameof(ProjectileId)].GetValue<int>(); } set { this[nameof(ProjectileId)].SetValue<int>(value); } }
        public bool bGoesThroughShield { get { return this[nameof(bGoesThroughShield)].Flag; } set { this[nameof(bGoesThroughShield)].Flag = value; } }
        public bool bCancelAttack { get { return this[nameof(bCancelAttack)].Flag; } set { this[nameof(bCancelAttack)].Flag = value; } }
        public bool bIgnoreHitReaction { get { return this[nameof(bIgnoreHitReaction)].Flag; } set { this[nameof(bIgnoreHitReaction)].Flag = value; } }
        public float PushBackDistance { get { return this[nameof(PushBackDistance)].GetValue<float>(); } set { this[nameof(PushBackDistance)].SetValue<float>(value); } }
        public float PushBackDuration { get { return this[nameof(PushBackDuration)].GetValue<float>(); } set { this[nameof(PushBackDuration)].SetValue<float>(value); } }
        public float RagdollProjectionForce { get { return this[nameof(RagdollProjectionForce)].GetValue<float>(); } set { this[nameof(RagdollProjectionForce)].SetValue<float>(value); } }
        public float CameraShakeScale { get { return this[nameof(CameraShakeScale)].GetValue<float>(); } set { this[nameof(CameraShakeScale)].SetValue<float>(value); } }
    }
    public class AnimalDataVO : Object
    {
        public AnimalDataVO(ulong addr) : base(addr) { }
        public int ID { get { return this[nameof(ID)].GetValue<int>(); } set { this[nameof(ID)].SetValue<int>(value); } }
        public int CharacterId { get { return this[nameof(CharacterId)].GetValue<int>(); } set { this[nameof(CharacterId)].SetValue<int>(value); } }
        public int DefaultBehaviourId { get { return this[nameof(DefaultBehaviourId)].GetValue<int>(); } set { this[nameof(DefaultBehaviourId)].SetValue<int>(value); } }
        public Array<LootDataVO> LootTable { get { return new Array<LootDataVO>(this[nameof(LootTable)].Address); } }
        public int WeightedLoots { get { return this[nameof(WeightedLoots)].GetValue<int>(); } set { this[nameof(WeightedLoots)].SetValue<int>(value); } }
        public int XPOnKill { get { return this[nameof(XPOnKill)].GetValue<int>(); } set { this[nameof(XPOnKill)].SetValue<int>(value); } }
        public bool bCoopXp { get { return this[nameof(bCoopXp)].Flag; } set { this[nameof(bCoopXp)].Flag = value; } }
        public Array<int> Chests { get { return new Array<int>(this[nameof(Chests)].Address); } }
        public EHealthBarColor HealthBarColor { get { return (EHealthBarColor)this[nameof(HealthBarColor)].GetValue<int>(); } set { this[nameof(HealthBarColor)].SetValue<int>((int)value); } }
        public float RotationSpeed { get { return this[nameof(RotationSpeed)].GetValue<float>(); } set { this[nameof(RotationSpeed)].SetValue<float>(value); } }
        public int ZOffset { get { return this[nameof(ZOffset)].GetValue<int>(); } set { this[nameof(ZOffset)].SetValue<int>(value); } }
        public Object ActorTemplate { get { return this[nameof(ActorTemplate)]; } set { this[nameof(ActorTemplate)] = value; } }
        public int RespawnRate { get { return this[nameof(RespawnRate)].GetValue<int>(); } set { this[nameof(RespawnRate)].SetValue<int>(value); } }
        public int AudioDangerLevel { get { return this[nameof(AudioDangerLevel)].GetValue<int>(); } set { this[nameof(AudioDangerLevel)].SetValue<int>(value); } }
        public int TauntAttackStatsId { get { return this[nameof(TauntAttackStatsId)].GetValue<int>(); } set { this[nameof(TauntAttackStatsId)].SetValue<int>(value); } }
    }
    public class LootDataVO : Object
    {
        public LootDataVO(ulong addr) : base(addr) { }
        public int ItemId { get { return this[nameof(ItemId)].GetValue<int>(); } set { this[nameof(ItemId)].SetValue<int>(value); } }
        public float ChanceOfDrop { get { return this[nameof(ChanceOfDrop)].GetValue<float>(); } set { this[nameof(ChanceOfDrop)].SetValue<float>(value); } }
        public int MinCount { get { return this[nameof(MinCount)].GetValue<int>(); } set { this[nameof(MinCount)].SetValue<int>(value); } }
        public int MaxCount { get { return this[nameof(MaxCount)].GetValue<int>(); } set { this[nameof(MaxCount)].SetValue<int>(value); } }
        public int MinChanceDurability { get { return this[nameof(MinChanceDurability)].GetValue<int>(); } set { this[nameof(MinChanceDurability)].SetValue<int>(value); } }
        public int MaxChanceDurability { get { return this[nameof(MaxChanceDurability)].GetValue<int>(); } set { this[nameof(MaxChanceDurability)].SetValue<int>(value); } }
        public bool bIsInstanced { get { return this[nameof(bIsInstanced)].Flag; } set { this[nameof(bIsInstanced)].Flag = value; } }
    }
    public class ArmorDataVO : Object
    {
        public ArmorDataVO(ulong addr) : base(addr) { }
        public int ID { get { return this[nameof(ID)].GetValue<int>(); } set { this[nameof(ID)].SetValue<int>(value); } }
        public int ItemId { get { return this[nameof(ItemId)].GetValue<int>(); } set { this[nameof(ItemId)].SetValue<int>(value); } }
        public int ColdModifier { get { return this[nameof(ColdModifier)].GetValue<int>(); } set { this[nameof(ColdModifier)].SetValue<int>(value); } }
        public int HotModifier { get { return this[nameof(HotModifier)].GetValue<int>(); } set { this[nameof(HotModifier)].SetValue<int>(value); } }
        public Array<DamageValuesDataVO> ArmorStats { get { return new Array<DamageValuesDataVO>(this[nameof(ArmorStats)].Address); } }
        public Array<int> PerkIds { get { return new Array<int>(this[nameof(PerkIds)].Address); } }
        public EEquipmentElement Element { get { return (EEquipmentElement)this[nameof(Element)].GetValue<int>(); } set { this[nameof(Element)].SetValue<int>((int)value); } }
    }
    public class DamageValuesDataVO : Object
    {
        public DamageValuesDataVO(ulong addr) : base(addr) { }
        public int DamageTypeId { get { return this[nameof(DamageTypeId)].GetValue<int>(); } set { this[nameof(DamageTypeId)].SetValue<int>(value); } }
        public float Value { get { return this[nameof(Value)].GetValue<float>(); } set { this[nameof(Value)].SetValue<float>(value); } }
        public float MinValue { get { return this[nameof(MinValue)].GetValue<float>(); } set { this[nameof(MinValue)].SetValue<float>(value); } }
        public float MaxValue { get { return this[nameof(MaxValue)].GetValue<float>(); } set { this[nameof(MaxValue)].SetValue<float>(value); } }
        public float GiantLevelScaling { get { return this[nameof(GiantLevelScaling)].GetValue<float>(); } set { this[nameof(GiantLevelScaling)].SetValue<float>(value); } }
    }
    public class AttackDataVO : Object
    {
        public AttackDataVO(ulong addr) : base(addr) { }
        public int ID { get { return this[nameof(ID)].GetValue<int>(); } set { this[nameof(ID)].SetValue<int>(value); } }
        public int Angle { get { return this[nameof(Angle)].GetValue<int>(); } set { this[nameof(Angle)].SetValue<int>(value); } }
        public Object AnimMontage { get { return this[nameof(AnimMontage)]; } set { this[nameof(AnimMontage)] = value; } }
        public Object WeaponAnimMontage { get { return this[nameof(WeaponAnimMontage)]; } set { this[nameof(WeaponAnimMontage)] = value; } }
        public bool bTrackTargetDuringAnim { get { return this[nameof(bTrackTargetDuringAnim)].Flag; } set { this[nameof(bTrackTargetDuringAnim)].Flag = value; } }
        public bool bAttackComesFromRight { get { return this[nameof(bAttackComesFromRight)].Flag; } set { this[nameof(bAttackComesFromRight)].Flag = value; } }
        public bool bIsHoldAttack { get { return this[nameof(bIsHoldAttack)].Flag; } set { this[nameof(bIsHoldAttack)].Flag = value; } }
    }
    public class AttackStatsDataVO : Object
    {
        public AttackStatsDataVO(ulong addr) : base(addr) { }
        public int ID { get { return this[nameof(ID)].GetValue<int>(); } set { this[nameof(ID)].SetValue<int>(value); } }
        public Object DisplayName { get { return this[nameof(DisplayName)]; } set { this[nameof(DisplayName)] = value; } }
        public int AttackMoveId { get { return this[nameof(AttackMoveId)].GetValue<int>(); } set { this[nameof(AttackMoveId)].SetValue<int>(value); } }
        public EAttackType AttackType { get { return (EAttackType)this[nameof(AttackType)].GetValue<int>(); } set { this[nameof(AttackType)].SetValue<int>((int)value); } }
        public int ProjectileId { get { return this[nameof(ProjectileId)].GetValue<int>(); } set { this[nameof(ProjectileId)].SetValue<int>(value); } }
        public Array<int> AITriggers { get { return new Array<int>(this[nameof(AITriggers)].Address); } }
        public Array<int> Channels { get { return new Array<int>(this[nameof(Channels)].Address); } }
        public Array<DamageValuesDataVO> Damages { get { return new Array<DamageValuesDataVO>(this[nameof(Damages)].Address); } }
        public EEquipmentElement Element { get { return (EEquipmentElement)this[nameof(Element)].GetValue<int>(); } set { this[nameof(Element)].SetValue<int>((int)value); } }
        public Array<int> PerkIds { get { return new Array<int>(this[nameof(PerkIds)].Address); } }
        public int MunitionItemId { get { return this[nameof(MunitionItemId)].GetValue<int>(); } set { this[nameof(MunitionItemId)].SetValue<int>(value); } }
        public int SpecialPointGain { get { return this[nameof(SpecialPointGain)].GetValue<int>(); } set { this[nameof(SpecialPointGain)].SetValue<int>(value); } }
        public int SpecialPointCost { get { return this[nameof(SpecialPointCost)].GetValue<int>(); } set { this[nameof(SpecialPointCost)].SetValue<int>(value); } }
        public int BrawlerComboPoint { get { return this[nameof(BrawlerComboPoint)].GetValue<int>(); } set { this[nameof(BrawlerComboPoint)].SetValue<int>(value); } }
        public int MinRange { get { return this[nameof(MinRange)].GetValue<int>(); } set { this[nameof(MinRange)].SetValue<int>(value); } }
        public int MaxRange { get { return this[nameof(MaxRange)].GetValue<int>(); } set { this[nameof(MaxRange)].SetValue<int>(value); } }
        public float CameraShakeScale { get { return this[nameof(CameraShakeScale)].GetValue<float>(); } set { this[nameof(CameraShakeScale)].SetValue<float>(value); } }
        public float CameraShakeOnMiss { get { return this[nameof(CameraShakeOnMiss)].GetValue<float>(); } set { this[nameof(CameraShakeOnMiss)].SetValue<float>(value); } }
        public bool bShakeOnMiss { get { return this[nameof(bShakeOnMiss)].Flag; } set { this[nameof(bShakeOnMiss)].Flag = value; } }
        public float PushBackDistance { get { return this[nameof(PushBackDistance)].GetValue<float>(); } set { this[nameof(PushBackDistance)].SetValue<float>(value); } }
        public float PushBackDuration { get { return this[nameof(PushBackDuration)].GetValue<float>(); } set { this[nameof(PushBackDuration)].SetValue<float>(value); } }
        public float StaggerDistance { get { return this[nameof(StaggerDistance)].GetValue<float>(); } set { this[nameof(StaggerDistance)].SetValue<float>(value); } }
        public float StaggerDuration { get { return this[nameof(StaggerDuration)].GetValue<float>(); } set { this[nameof(StaggerDuration)].SetValue<float>(value); } }
        public float RagdollProjectionForce { get { return this[nameof(RagdollProjectionForce)].GetValue<float>(); } set { this[nameof(RagdollProjectionForce)].SetValue<float>(value); } }
        public float Cooldown { get { return this[nameof(Cooldown)].GetValue<float>(); } set { this[nameof(Cooldown)].SetValue<float>(value); } }
        public float CooldownVariation { get { return this[nameof(CooldownVariation)].GetValue<float>(); } set { this[nameof(CooldownVariation)].SetValue<float>(value); } }
        public bool bIgnoreGlobalCooldown { get { return this[nameof(bIgnoreGlobalCooldown)].Flag; } set { this[nameof(bIgnoreGlobalCooldown)].Flag = value; } }
        public bool bRequireShield { get { return this[nameof(bRequireShield)].Flag; } set { this[nameof(bRequireShield)].Flag = value; } }
        public int MinGiantLevel { get { return this[nameof(MinGiantLevel)].GetValue<int>(); } set { this[nameof(MinGiantLevel)].SetValue<int>(value); } }
        public bool bGoesThroughShield { get { return this[nameof(bGoesThroughShield)].Flag; } set { this[nameof(bGoesThroughShield)].Flag = value; } }
        public bool bDoNotConsumeDurability { get { return this[nameof(bDoNotConsumeDurability)].Flag; } set { this[nameof(bDoNotConsumeDurability)].Flag = value; } }
        public bool bCancelAttack { get { return this[nameof(bCancelAttack)].Flag; } set { this[nameof(bCancelAttack)].Flag = value; } }
        public bool bIsCanceledOnHit { get { return this[nameof(bIsCanceledOnHit)].Flag; } set { this[nameof(bIsCanceledOnHit)].Flag = value; } }
        public bool bIgnoreStack { get { return this[nameof(bIgnoreStack)].Flag; } set { this[nameof(bIgnoreStack)].Flag = value; } }
        public bool bIgnoreHitReaction { get { return this[nameof(bIgnoreHitReaction)].Flag; } set { this[nameof(bIgnoreHitReaction)].Flag = value; } }
        public bool bIsBeamAttack { get { return this[nameof(bIsBeamAttack)].Flag; } set { this[nameof(bIsBeamAttack)].Flag = value; } }
        public bool bCanBeEnergized { get { return this[nameof(bCanBeEnergized)].Flag; } set { this[nameof(bCanBeEnergized)].Flag = value; } }
        public Object SlashVFX { get { return this[nameof(SlashVFX)]; } set { this[nameof(SlashVFX)] = value; } }
        public Object ImpactVFX { get { return this[nameof(ImpactVFX)]; } set { this[nameof(ImpactVFX)] = value; } }
        public Object Icon { get { return this[nameof(Icon)]; } set { this[nameof(Icon)] = value; } }
        public bool bIgnoreHurtSFX { get { return this[nameof(bIgnoreHurtSFX)].Flag; } set { this[nameof(bIgnoreHurtSFX)].Flag = value; } }
        public Object AttackAudioName { get { return this[nameof(AttackAudioName)]; } set { this[nameof(AttackAudioName)] = value; } }
    }
    public class AvatarCosmeticDataVO : Object
    {
        public AvatarCosmeticDataVO(ulong addr) : base(addr) { }
        public int ID { get { return this[nameof(ID)].GetValue<int>(); } set { this[nameof(ID)].SetValue<int>(value); } }
        public Object Name { get { return this[nameof(Name)]; } set { this[nameof(Name)] = value; } }
        public Object Description { get { return this[nameof(Description)]; } set { this[nameof(Description)] = value; } }
        public int RequiredEntitlementId { get { return this[nameof(RequiredEntitlementId)].GetValue<int>(); } set { this[nameof(RequiredEntitlementId)].SetValue<int>(value); } }
        public EItemRarity ItemRarity { get { return (EItemRarity)this[nameof(ItemRarity)].GetValue<int>(); } set { this[nameof(ItemRarity)].SetValue<int>((int)value); } }
        public int SortOrder { get { return this[nameof(SortOrder)].GetValue<int>(); } set { this[nameof(SortOrder)].SetValue<int>(value); } }
        public Object Icon { get { return this[nameof(Icon)]; } set { this[nameof(Icon)] = value; } }
        public ECosmeticType CosmeticType { get { return (ECosmeticType)this[nameof(CosmeticType)].GetValue<int>(); } set { this[nameof(CosmeticType)].SetValue<int>((int)value); } }
        public int ExternalAssetId { get { return this[nameof(ExternalAssetId)].GetValue<int>(); } set { this[nameof(ExternalAssetId)].SetValue<int>(value); } }
        public Object MeshMale { get { return this[nameof(MeshMale)]; } set { this[nameof(MeshMale)] = value; } }
        public Object MeshFemale { get { return this[nameof(MeshFemale)]; } set { this[nameof(MeshFemale)] = value; } }
        public Object SubMeshMale { get { return this[nameof(SubMeshMale)]; } set { this[nameof(SubMeshMale)] = value; } }
        public Object SubMeshFemale { get { return this[nameof(SubMeshFemale)]; } set { this[nameof(SubMeshFemale)] = value; } }
        public Object Texture { get { return this[nameof(Texture)]; } set { this[nameof(Texture)] = value; } }
        public Object EmoteMontage { get { return this[nameof(EmoteMontage)]; } set { this[nameof(EmoteMontage)] = value; } }
        public Object Color { get { return this[nameof(Color)]; } set { this[nameof(Color)] = value; } }
    }
    public class AvatarIconDataVO : Object
    {
        public AvatarIconDataVO(ulong addr) : base(addr) { }
        public int ID { get { return this[nameof(ID)].GetValue<int>(); } set { this[nameof(ID)].SetValue<int>(value); } }
        public Object Name { get { return this[nameof(Name)]; } set { this[nameof(Name)] = value; } }
        public Object Description { get { return this[nameof(Description)]; } set { this[nameof(Description)] = value; } }
        public Object Icon { get { return this[nameof(Icon)]; } set { this[nameof(Icon)] = value; } }
        public Object SmallIcon { get { return this[nameof(SmallIcon)]; } set { this[nameof(SmallIcon)] = value; } }
        public Object PinIcon { get { return this[nameof(PinIcon)]; } set { this[nameof(PinIcon)] = value; } }
    }
    public class AvatarPetDataVO : Object
    {
        public AvatarPetDataVO(ulong addr) : base(addr) { }
        public int ID { get { return this[nameof(ID)].GetValue<int>(); } set { this[nameof(ID)].SetValue<int>(value); } }
        public Object Name { get { return this[nameof(Name)]; } set { this[nameof(Name)] = value; } }
        public Object Description { get { return this[nameof(Description)]; } set { this[nameof(Description)] = value; } }
        public Object Icon { get { return this[nameof(Icon)]; } set { this[nameof(Icon)] = value; } }
        public int AnimalId { get { return this[nameof(AnimalId)].GetValue<int>(); } set { this[nameof(AnimalId)].SetValue<int>(value); } }
        public Object LobbyActor { get { return this[nameof(LobbyActor)]; } set { this[nameof(LobbyActor)] = value; } }
    }
    public class BiomeDataVO : Object
    {
        public BiomeDataVO(ulong addr) : base(addr) { }
        public int ID { get { return this[nameof(ID)].GetValue<int>(); } set { this[nameof(ID)].SetValue<int>(value); } }
        public Object DisplayName { get { return this[nameof(DisplayName)]; } set { this[nameof(DisplayName)] = value; } }
        public int RarityId { get { return this[nameof(RarityId)].GetValue<int>(); } set { this[nameof(RarityId)].SetValue<int>(value); } }
        public Array<int> ModuleIds { get { return new Array<int>(this[nameof(ModuleIds)].Address); } }
        public Array<BiomeTypeRuleDataVO> BiomeTypeRules { get { return new Array<BiomeTypeRuleDataVO>(this[nameof(BiomeTypeRules)].Address); } }
        public float ResourcesDensity { get { return this[nameof(ResourcesDensity)].GetValue<float>(); } set { this[nameof(ResourcesDensity)].SetValue<float>(value); } }
        public float PacksSpacing { get { return this[nameof(PacksSpacing)].GetValue<float>(); } set { this[nameof(PacksSpacing)].SetValue<float>(value); } }
        public Array<int> TemperatureModifiers { get { return new Array<int>(this[nameof(TemperatureModifiers)].Address); } }
    }
    public class BiomeTypeRuleDataVO : Object
    {
        public BiomeTypeRuleDataVO(ulong addr) : base(addr) { }
        public float Chance { get { return this[nameof(Chance)].GetValue<float>(); } set { this[nameof(Chance)].SetValue<float>(value); } }
        public Array<BiomeTypePairDataVO> BiomeTypes { get { return new Array<BiomeTypePairDataVO>(this[nameof(BiomeTypes)].Address); } }
        public int MinWeight { get { return this[nameof(MinWeight)].GetValue<int>(); } set { this[nameof(MinWeight)].SetValue<int>(value); } }
        public int MaxWeight { get { return this[nameof(MaxWeight)].GetValue<int>(); } set { this[nameof(MaxWeight)].SetValue<int>(value); } }
        public bool bIsMonoRegion { get { return this[nameof(bIsMonoRegion)].Flag; } set { this[nameof(bIsMonoRegion)].Flag = value; } }
        public bool bAllowLairAndDungeon { get { return this[nameof(bAllowLairAndDungeon)].Flag; } set { this[nameof(bAllowLairAndDungeon)].Flag = value; } }
        public Array<int> ExcludedGroundLevels { get { return new Array<int>(this[nameof(ExcludedGroundLevels)].Address); } }
    }
    public class BiomeTypePairDataVO : Object
    {
        public BiomeTypePairDataVO(ulong addr) : base(addr) { }
        public int BiomeType { get { return this[nameof(BiomeType)].GetValue<int>(); } set { this[nameof(BiomeType)].SetValue<int>(value); } }
        public int Weight { get { return this[nameof(Weight)].GetValue<int>(); } set { this[nameof(Weight)].SetValue<int>(value); } }
    }
    public class BiomeLevelDataVO : Object
    {
        public BiomeLevelDataVO(ulong addr) : base(addr) { }
        public int ID { get { return this[nameof(ID)].GetValue<int>(); } set { this[nameof(ID)].SetValue<int>(value); } }
        public int BiomeId { get { return this[nameof(BiomeId)].GetValue<int>(); } set { this[nameof(BiomeId)].SetValue<int>(value); } }
        public int BiomeLevel { get { return this[nameof(BiomeLevel)].GetValue<int>(); } set { this[nameof(BiomeLevel)].SetValue<int>(value); } }
        public int PowerLevel { get { return this[nameof(PowerLevel)].GetValue<int>(); } set { this[nameof(PowerLevel)].SetValue<int>(value); } }
    }
    public class BiomeRestrictionVO : Object
    {
        public BiomeRestrictionVO(ulong addr) : base(addr) { }
        public int BiomeId { get { return this[nameof(BiomeId)].GetValue<int>(); } set { this[nameof(BiomeId)].SetValue<int>(value); } }
        public int BiomeLevel { get { return this[nameof(BiomeLevel)].GetValue<int>(); } set { this[nameof(BiomeLevel)].SetValue<int>(value); } }
    }
    public class BlueprintDataVO : Object
    {
        public BlueprintDataVO(ulong addr) : base(addr) { }
        public int ID { get { return this[nameof(ID)].GetValue<int>(); } set { this[nameof(ID)].SetValue<int>(value); } }
        public bool bIsLockedByDefault { get { return this[nameof(bIsLockedByDefault)].Flag; } set { this[nameof(bIsLockedByDefault)].Flag = value; } }
        public Object LockedDescription { get { return this[nameof(LockedDescription)]; } set { this[nameof(LockedDescription)] = value; } }
        public Object TechTreeBranchName { get { return this[nameof(TechTreeBranchName)]; } set { this[nameof(TechTreeBranchName)] = value; } }
        public int UnlockedRecipeId { get { return this[nameof(UnlockedRecipeId)].GetValue<int>(); } set { this[nameof(UnlockedRecipeId)].SetValue<int>(value); } }
        public int VerticalOrder { get { return this[nameof(VerticalOrder)].GetValue<int>(); } set { this[nameof(VerticalOrder)].SetValue<int>(value); } }
    }
    public class BuildingDataVO : Object
    {
        public BuildingDataVO(ulong addr) : base(addr) { }
        public int ID { get { return this[nameof(ID)].GetValue<int>(); } set { this[nameof(ID)].SetValue<int>(value); } }
        public float Health { get { return this[nameof(Health)].GetValue<float>(); } set { this[nameof(Health)].SetValue<float>(value); } }
        public float StartingHealth { get { return this[nameof(StartingHealth)].GetValue<float>(); } set { this[nameof(StartingHealth)].SetValue<float>(value); } }
    }
    public class CaveDataVO : Object
    {
        public CaveDataVO(ulong addr) : base(addr) { }
        public int ID { get { return this[nameof(ID)].GetValue<int>(); } set { this[nameof(ID)].SetValue<int>(value); } }
        public bool bEnable { get { return this[nameof(bEnable)].Flag; } set { this[nameof(bEnable)].Flag = value; } }
        public Object ActorTemplate { get { return this[nameof(ActorTemplate)]; } set { this[nameof(ActorTemplate)] = value; } }
        public ECaveType CaveType { get { return (ECaveType)this[nameof(CaveType)].GetValue<int>(); } set { this[nameof(CaveType)].SetValue<int>((int)value); } }
        public Array<int> Floors { get { return new Array<int>(this[nameof(Floors)].Address); } }
        public Array<int> BiomeIds { get { return new Array<int>(this[nameof(BiomeIds)].Address); } }
    }
    public class ChallengeConditionDataVO : Object
    {
        public ChallengeConditionDataVO(ulong addr) : base(addr) { }
        public EChallengeType ChallengeType { get { return (EChallengeType)this[nameof(ChallengeType)].GetValue<int>(); } set { this[nameof(ChallengeType)].SetValue<int>((int)value); } }
        public int Count { get { return this[nameof(Count)].GetValue<int>(); } set { this[nameof(Count)].SetValue<int>(value); } }
    }
    public class ChallengeDataVO : Object
    {
        public ChallengeDataVO(ulong addr) : base(addr) { }
        public int ID { get { return this[nameof(ID)].GetValue<int>(); } set { this[nameof(ID)].SetValue<int>(value); } }
        public int SortOrder { get { return this[nameof(SortOrder)].GetValue<int>(); } set { this[nameof(SortOrder)].SetValue<int>(value); } }
        public Object DisplayName { get { return this[nameof(DisplayName)]; } set { this[nameof(DisplayName)] = value; } }
        public Object Description { get { return this[nameof(Description)]; } set { this[nameof(Description)] = value; } }
        public Object Icon { get { return this[nameof(Icon)]; } set { this[nameof(Icon)] = value; } }
        public bool bAutoClaim { get { return this[nameof(bAutoClaim)].Flag; } set { this[nameof(bAutoClaim)].Flag = value; } }
        public Array<RewardDataVO> Rewards { get { return new Array<RewardDataVO>(this[nameof(Rewards)].Address); } }
        public EChallengeCategory ChallengeCategory { get { return (EChallengeCategory)this[nameof(ChallengeCategory)].GetValue<int>(); } set { this[nameof(ChallengeCategory)].SetValue<int>((int)value); } }
        public Array<ChallengeConditionDataVO> Conditions { get { return new Array<ChallengeConditionDataVO>(this[nameof(Conditions)].Address); } }
    }
    public class RewardDataVO : Object
    {
        public RewardDataVO(ulong addr) : base(addr) { }
        public ERewardType RewardType { get { return (ERewardType)this[nameof(RewardType)].GetValue<int>(); } set { this[nameof(RewardType)].SetValue<int>((int)value); } }
        public int Value { get { return this[nameof(Value)].GetValue<int>(); } set { this[nameof(Value)].SetValue<int>(value); } }
        public Object Icon { get { return this[nameof(Icon)]; } set { this[nameof(Icon)] = value; } }
    }
    public class CharacterDataVO : Object
    {
        public CharacterDataVO(ulong addr) : base(addr) { }
        public int ID { get { return this[nameof(ID)].GetValue<int>(); } set { this[nameof(ID)].SetValue<int>(value); } }
        public Object Name { get { return this[nameof(Name)]; } set { this[nameof(Name)] = value; } }
        public int Type { get { return this[nameof(Type)].GetValue<int>(); } set { this[nameof(Type)].SetValue<int>(value); } }
        public float SprintingSpeed { get { return this[nameof(SprintingSpeed)].GetValue<float>(); } set { this[nameof(SprintingSpeed)].SetValue<float>(value); } }
        public float ShieldingSpeed { get { return this[nameof(ShieldingSpeed)].GetValue<float>(); } set { this[nameof(ShieldingSpeed)].SetValue<float>(value); } }
        public float Health { get { return this[nameof(Health)].GetValue<float>(); } set { this[nameof(Health)].SetValue<float>(value); } }
        public int MaxSpecialPoint { get { return this[nameof(MaxSpecialPoint)].GetValue<int>(); } set { this[nameof(MaxSpecialPoint)].SetValue<int>(value); } }
        public int StartingSpecialPoint { get { return this[nameof(StartingSpecialPoint)].GetValue<int>(); } set { this[nameof(StartingSpecialPoint)].SetValue<int>(value); } }
        public bool bUseDownState { get { return this[nameof(bUseDownState)].Flag; } set { this[nameof(bUseDownState)].Flag = value; } }
        public int DownStateStartingAmount { get { return this[nameof(DownStateStartingAmount)].GetValue<int>(); } set { this[nameof(DownStateStartingAmount)].SetValue<int>(value); } }
        public float DownStateDecayRate { get { return this[nameof(DownStateDecayRate)].GetValue<float>(); } set { this[nameof(DownStateDecayRate)].SetValue<float>(value); } }
        public int DownStateDecayAmount { get { return this[nameof(DownStateDecayAmount)].GetValue<int>(); } set { this[nameof(DownStateDecayAmount)].SetValue<int>(value); } }
        public float RespawnTime { get { return this[nameof(RespawnTime)].GetValue<float>(); } set { this[nameof(RespawnTime)].SetValue<float>(value); } }
        public float StaggerDuration { get { return this[nameof(StaggerDuration)].GetValue<float>(); } set { this[nameof(StaggerDuration)].SetValue<float>(value); } }
        public bool bIsImmuneToPushBack { get { return this[nameof(bIsImmuneToPushBack)].Flag; } set { this[nameof(bIsImmuneToPushBack)].Flag = value; } }
        public bool bIsImmuneToCancel { get { return this[nameof(bIsImmuneToCancel)].Flag; } set { this[nameof(bIsImmuneToCancel)].Flag = value; } }
        public int InventoryId { get { return this[nameof(InventoryId)].GetValue<int>(); } set { this[nameof(InventoryId)].SetValue<int>(value); } }
        public int EquipmentId { get { return this[nameof(EquipmentId)].GetValue<int>(); } set { this[nameof(EquipmentId)].SetValue<int>(value); } }
        public int DefaultWeaponId { get { return this[nameof(DefaultWeaponId)].GetValue<int>(); } set { this[nameof(DefaultWeaponId)].SetValue<int>(value); } }
        public float Weight { get { return this[nameof(Weight)].GetValue<float>(); } set { this[nameof(Weight)].SetValue<float>(value); } }
        public Object HitReactionRight { get { return this[nameof(HitReactionRight)]; } set { this[nameof(HitReactionRight)] = value; } }
        public Object HitReactionLeft { get { return this[nameof(HitReactionLeft)]; } set { this[nameof(HitReactionLeft)] = value; } }
        public int DefaultColdResistance { get { return this[nameof(DefaultColdResistance)].GetValue<int>(); } set { this[nameof(DefaultColdResistance)].SetValue<int>(value); } }
        public int DefaultHotResistance { get { return this[nameof(DefaultHotResistance)].GetValue<int>(); } set { this[nameof(DefaultHotResistance)].SetValue<int>(value); } }
        public Array<int> ColdPerkIds { get { return new Array<int>(this[nameof(ColdPerkIds)].Address); } }
        public Array<int> ConfortPerkIds { get { return new Array<int>(this[nameof(ConfortPerkIds)].Address); } }
        public Array<int> HotPerkIds { get { return new Array<int>(this[nameof(HotPerkIds)].Address); } }
    }
    public class CodexEntryDataVO : Object
    {
        public CodexEntryDataVO(ulong addr) : base(addr) { }
        public int ID { get { return this[nameof(ID)].GetValue<int>(); } set { this[nameof(ID)].SetValue<int>(value); } }
        public Object DisplayName { get { return this[nameof(DisplayName)]; } set { this[nameof(DisplayName)] = value; } }
        public Object Description { get { return this[nameof(Description)]; } set { this[nameof(Description)] = value; } }
        public int SortOrder { get { return this[nameof(SortOrder)].GetValue<int>(); } set { this[nameof(SortOrder)].SetValue<int>(value); } }
        public ECodexEntryType EntryType { get { return (ECodexEntryType)this[nameof(EntryType)].GetValue<int>(); } set { this[nameof(EntryType)].SetValue<int>((int)value); } }
        public int RarityId { get { return this[nameof(RarityId)].GetValue<int>(); } set { this[nameof(RarityId)].SetValue<int>(value); } }
        public int ElementID { get { return this[nameof(ElementID)].GetValue<int>(); } set { this[nameof(ElementID)].SetValue<int>(value); } }
        public Array<int> BiomeIds { get { return new Array<int>(this[nameof(BiomeIds)].Address); } }
        public int TargetId { get { return this[nameof(TargetId)].GetValue<int>(); } set { this[nameof(TargetId)].SetValue<int>(value); } }
        public Object Icon { get { return this[nameof(Icon)]; } set { this[nameof(Icon)] = value; } }
        public Object Image { get { return this[nameof(Image)]; } set { this[nameof(Image)] = value; } }
    }
    public class ConfigDataVO : Object
    {
        public ConfigDataVO(ulong addr) : base(addr) { }
        public Object ID { get { return this[nameof(ID)]; } set { this[nameof(ID)] = value; } }
        public DataObject Config { get { return this[nameof(Config)].As<DataObject>(); } set { this["Config"] = value; } }
    }
    public class ConstructionRecipeDataVO : Object
    {
        public ConstructionRecipeDataVO(ulong addr) : base(addr) { }
        public int ID { get { return this[nameof(ID)].GetValue<int>(); } set { this[nameof(ID)].SetValue<int>(value); } }
        public Object DisplayName { get { return this[nameof(DisplayName)]; } set { this[nameof(DisplayName)] = value; } }
        public Object RadialTabName { get { return this[nameof(RadialTabName)]; } set { this[nameof(RadialTabName)] = value; } }
        public int ItemId { get { return this[nameof(ItemId)].GetValue<int>(); } set { this[nameof(ItemId)].SetValue<int>(value); } }
        public int UISlotIndex { get { return this[nameof(UISlotIndex)].GetValue<int>(); } set { this[nameof(UISlotIndex)].SetValue<int>(value); } }
        public Array<CraftingRecipeElementDataVO> RecipeElements { get { return new Array<CraftingRecipeElementDataVO>(this[nameof(RecipeElements)].Address); } }
        public int HazardId { get { return this[nameof(HazardId)].GetValue<int>(); } set { this[nameof(HazardId)].SetValue<int>(value); } }
        public int CornerHazardId { get { return this[nameof(CornerHazardId)].GetValue<int>(); } set { this[nameof(CornerHazardId)].SetValue<int>(value); } }
        public int FlippedHazardId { get { return this[nameof(FlippedHazardId)].GetValue<int>(); } set { this[nameof(FlippedHazardId)].SetValue<int>(value); } }
        public int FlippedCornerHazardId { get { return this[nameof(FlippedCornerHazardId)].GetValue<int>(); } set { this[nameof(FlippedCornerHazardId)].SetValue<int>(value); } }
        public int Size { get { return this[nameof(Size)].GetValue<int>(); } set { this[nameof(Size)].SetValue<int>(value); } }
        public int SizeY { get { return this[nameof(SizeY)].GetValue<int>(); } set { this[nameof(SizeY)].SetValue<int>(value); } }
        public int GridSize { get { return this[nameof(GridSize)].GetValue<int>(); } set { this[nameof(GridSize)].SetValue<int>(value); } }
        public Object Icon { get { return this[nameof(Icon)]; } set { this[nameof(Icon)] = value; } }
        public bool bOrientConstruction { get { return this[nameof(bOrientConstruction)].Flag; } set { this[nameof(bOrientConstruction)].Flag = value; } }
        public bool bUseGridValidation { get { return this[nameof(bUseGridValidation)].Flag; } set { this[nameof(bUseGridValidation)].Flag = value; } }
        public bool bSnapToGround { get { return this[nameof(bSnapToGround)].Flag; } set { this[nameof(bSnapToGround)].Flag = value; } }
        public bool bAllowBuildingOnFondation { get { return this[nameof(bAllowBuildingOnFondation)].Flag; } set { this[nameof(bAllowBuildingOnFondation)].Flag = value; } }
        public int GroundOffset { get { return this[nameof(GroundOffset)].GetValue<int>(); } set { this[nameof(GroundOffset)].SetValue<int>(value); } }
    }
    public class CraftingRecipeElementDataVO : Object
    {
        public CraftingRecipeElementDataVO(ulong addr) : base(addr) { }
        public int ID { get { return this[nameof(ID)].GetValue<int>(); } set { this[nameof(ID)].SetValue<int>(value); } }
        public int Count { get { return this[nameof(Count)].GetValue<int>(); } set { this[nameof(Count)].SetValue<int>(value); } }
    }
    public class ConsumableDataVO : Object
    {
        public ConsumableDataVO(ulong addr) : base(addr) { }
        public int ID { get { return this[nameof(ID)].GetValue<int>(); } set { this[nameof(ID)].SetValue<int>(value); } }
        public int ItemId { get { return this[nameof(ItemId)].GetValue<int>(); } set { this[nameof(ItemId)].SetValue<int>(value); } }
        public Array<int> PerkIds { get { return new Array<int>(this[nameof(PerkIds)].Address); } }
        public Object AudioName { get { return this[nameof(AudioName)]; } set { this[nameof(AudioName)] = value; } }
    }
    public class ContainerDataVO : Object
    {
        public ContainerDataVO(ulong addr) : base(addr) { }
        public int ID { get { return this[nameof(ID)].GetValue<int>(); } set { this[nameof(ID)].SetValue<int>(value); } }
        public Object DisplayName { get { return this[nameof(DisplayName)]; } set { this[nameof(DisplayName)] = value; } }
        public EContainerType Type { get { return (EContainerType)this[nameof(Type)].GetValue<int>(); } set { this[nameof(Type)].SetValue<int>((int)value); } }
        public Array<ContainerSettingsDataVO> Settings { get { return new Array<ContainerSettingsDataVO>(this[nameof(Settings)].Address); } }
        public Array<ContainerSlotDataVO> Slots { get { return new Array<ContainerSlotDataVO>(this[nameof(Slots)].Address); } }
    }
    public class ContainerSlotDataVO : Object
    {
        public ContainerSlotDataVO(ulong addr) : base(addr) { }
        public int ItemId { get { return this[nameof(ItemId)].GetValue<int>(); } set { this[nameof(ItemId)].SetValue<int>(value); } }
        public int Count { get { return this[nameof(Count)].GetValue<int>(); } set { this[nameof(Count)].SetValue<int>(value); } }
        public bool bIsEquiped { get { return this[nameof(bIsEquiped)].Flag; } set { this[nameof(bIsEquiped)].Flag = value; } }
        public bool bIsEquipedSecondary { get { return this[nameof(bIsEquipedSecondary)].Flag; } set { this[nameof(bIsEquipedSecondary)].Flag = value; } }
        public bool bIsRequired { get { return this[nameof(bIsRequired)].Flag; } set { this[nameof(bIsRequired)].Flag = value; } }
    }
    public class ContainerSettingsDataVO : Object
    {
        public ContainerSettingsDataVO(ulong addr) : base(addr) { }
        public EItemCategory ItemCategory { get { return (EItemCategory)this[nameof(ItemCategory)].GetValue<int>(); } set { this[nameof(ItemCategory)].SetValue<int>((int)value); } }
        public int ItemTypeId { get { return this[nameof(ItemTypeId)].GetValue<int>(); } set { this[nameof(ItemTypeId)].SetValue<int>(value); } }
        public int ItemId { get { return this[nameof(ItemId)].GetValue<int>(); } set { this[nameof(ItemId)].SetValue<int>(value); } }
        public int MaxStackPouch { get { return this[nameof(MaxStackPouch)].GetValue<int>(); } set { this[nameof(MaxStackPouch)].SetValue<int>(value); } }
        public int MaxStackPouchBonus { get { return this[nameof(MaxStackPouchBonus)].GetValue<int>(); } set { this[nameof(MaxStackPouchBonus)].SetValue<int>(value); } }
        public int MaxStacks { get { return this[nameof(MaxStacks)].GetValue<int>(); } set { this[nameof(MaxStacks)].SetValue<int>(value); } }
        public int MaxStacksByItem { get { return this[nameof(MaxStacksByItem)].GetValue<int>(); } set { this[nameof(MaxStacksByItem)].SetValue<int>(value); } }
        public int Equipable { get { return this[nameof(Equipable)].GetValue<int>(); } set { this[nameof(Equipable)].SetValue<int>(value); } }
        public int LoadoutCount { get { return this[nameof(LoadoutCount)].GetValue<int>(); } set { this[nameof(LoadoutCount)].SetValue<int>(value); } }
        public int DefaultItemId { get { return this[nameof(DefaultItemId)].GetValue<int>(); } set { this[nameof(DefaultItemId)].SetValue<int>(value); } }
        public bool bAutoEquipOverrideDefaultItem { get { return this[nameof(bAutoEquipOverrideDefaultItem)].Flag; } set { this[nameof(bAutoEquipOverrideDefaultItem)].Flag = value; } }
    }
    public class ContentBundleDataVO : Object
    {
        public ContentBundleDataVO(ulong addr) : base(addr) { }
        public int ID { get { return this[nameof(ID)].GetValue<int>(); } set { this[nameof(ID)].SetValue<int>(value); } }
        public bool bIsDefaultContent { get { return this[nameof(bIsDefaultContent)].Flag; } set { this[nameof(bIsDefaultContent)].Flag = value; } }
        public Object ExternalId { get { return this[nameof(ExternalId)]; } set { this[nameof(ExternalId)] = value; } }
        public Array<int> CosmeticsIds { get { return new Array<int>(this[nameof(CosmeticsIds)].Address); } }
        public Array<int> EntitlementIds { get { return new Array<int>(this[nameof(EntitlementIds)].Address); } }
        public Array<int> BlueprintsIds { get { return new Array<int>(this[nameof(BlueprintsIds)].Address); } }
        public Array<RewardDataVO> Rewards { get { return new Array<RewardDataVO>(this[nameof(Rewards)].Address); } }
    }
    public class CraftingRecipeDataVO : Object
    {
        public CraftingRecipeDataVO(ulong addr) : base(addr) { }
        public int ID { get { return this[nameof(ID)].GetValue<int>(); } set { this[nameof(ID)].SetValue<int>(value); } }
        public int SortOrder { get { return this[nameof(SortOrder)].GetValue<int>(); } set { this[nameof(SortOrder)].SetValue<int>(value); } }
        public Object DisplayName { get { return this[nameof(DisplayName)]; } set { this[nameof(DisplayName)] = value; } }
        public ESellerType Seller { get { return (ESellerType)this[nameof(Seller)].GetValue<int>(); } set { this[nameof(Seller)].SetValue<int>((int)value); } }
        public Array<CraftingRecipeElementDataVO> RecipeElements { get { return new Array<CraftingRecipeElementDataVO>(this[nameof(RecipeElements)].Address); } }
        public int ResultItemId { get { return this[nameof(ResultItemId)].GetValue<int>(); } set { this[nameof(ResultItemId)].SetValue<int>(value); } }
        public int MinUpgradeLevel { get { return this[nameof(MinUpgradeLevel)].GetValue<int>(); } set { this[nameof(MinUpgradeLevel)].SetValue<int>(value); } }
        public Object AudioName { get { return this[nameof(AudioName)]; } set { this[nameof(AudioName)] = value; } }
    }
    public class CreaturePackDataVO : Object
    {
        public CreaturePackDataVO(ulong addr) : base(addr) { }
        public int ID { get { return this[nameof(ID)].GetValue<int>(); } set { this[nameof(ID)].SetValue<int>(value); } }
        public Array<CreaturePackEntryDataVO> Creatures { get { return new Array<CreaturePackEntryDataVO>(this[nameof(Creatures)].Address); } }
    }
    public class CreaturePackEntryDataVO : Object
    {
        public CreaturePackEntryDataVO(ulong addr) : base(addr) { }
        public int CreatureId { get { return this[nameof(CreatureId)].GetValue<int>(); } set { this[nameof(CreatureId)].SetValue<int>(value); } }
        public int AIBehaviourId { get { return this[nameof(AIBehaviourId)].GetValue<int>(); } set { this[nameof(AIBehaviourId)].SetValue<int>(value); } }
        public int MinCount { get { return this[nameof(MinCount)].GetValue<int>(); } set { this[nameof(MinCount)].SetValue<int>(value); } }
        public int MaxCount { get { return this[nameof(MaxCount)].GetValue<int>(); } set { this[nameof(MaxCount)].SetValue<int>(value); } }
    }
    public class CreaturePackVO : Object
    {
        public CreaturePackVO(ulong addr) : base(addr) { }
        public Object ID { get { return this[nameof(ID)]; } set { this[nameof(ID)] = value; } }
        public int CreaturePackDataId { get { return this[nameof(CreaturePackDataId)].GetValue<int>(); } set { this[nameof(CreaturePackDataId)].SetValue<int>(value); } }
        public Object SummonerId { get { return this[nameof(SummonerId)]; } set { this[nameof(SummonerId)] = value; } }
        public Array<Object> Creatures { get { return new Array<Object>(this[nameof(Creatures)].Address); } }
    }
    public class DailyAnnouncementVO : Object
    {
        public DailyAnnouncementVO(ulong addr) : base(addr) { }
        public float Time { get { return this[nameof(Time)].GetValue<float>(); } set { this[nameof(Time)].SetValue<float>(value); } }
        public Object Text { get { return this[nameof(Text)]; } set { this[nameof(Text)] = value; } }
        public EAnnouncementColor AnnoucementColor { get { return (EAnnouncementColor)this[nameof(AnnoucementColor)].GetValue<int>(); } set { this[nameof(AnnoucementColor)].SetValue<int>((int)value); } }
    }
    public class DamageTypeDataVO : Object
    {
        public DamageTypeDataVO(ulong addr) : base(addr) { }
        public int ID { get { return this[nameof(ID)].GetValue<int>(); } set { this[nameof(ID)].SetValue<int>(value); } }
        public EEquipmentElement Element { get { return (EEquipmentElement)this[nameof(Element)].GetValue<int>(); } set { this[nameof(Element)].SetValue<int>((int)value); } }
        public float DamageCap { get { return this[nameof(DamageCap)].GetValue<float>(); } set { this[nameof(DamageCap)].SetValue<float>(value); } }
        public Object Color { get { return this[nameof(Color)]; } set { this[nameof(Color)] = value; } }
        public Object Icon { get { return this[nameof(Icon)]; } set { this[nameof(Icon)] = value; } }
    }
    public class DayCycleDataVO : Object
    {
        public DayCycleDataVO(ulong addr) : base(addr) { }
        public int ID { get { return this[nameof(ID)].GetValue<int>(); } set { this[nameof(ID)].SetValue<int>(value); } }
        public int Day { get { return this[nameof(Day)].GetValue<int>(); } set { this[nameof(Day)].SetValue<int>(value); } }
        public int Group { get { return this[nameof(Group)].GetValue<int>(); } set { this[nameof(Group)].SetValue<int>(value); } }
        public ESeason Season { get { return (ESeason)this[nameof(Season)].GetValue<int>(); } set { this[nameof(Season)].SetValue<int>((int)value); } }
        public bool bNightOnly { get { return this[nameof(bNightOnly)].Flag; } set { this[nameof(bNightOnly)].Flag = value; } }
        public int SunriseStartTime { get { return this[nameof(SunriseStartTime)].GetValue<int>(); } set { this[nameof(SunriseStartTime)].SetValue<int>(value); } }
        public int SunsetStartTime { get { return this[nameof(SunsetStartTime)].GetValue<int>(); } set { this[nameof(SunsetStartTime)].SetValue<int>(value); } }
        public int NightStartTime { get { return this[nameof(NightStartTime)].GetValue<int>(); } set { this[nameof(NightStartTime)].SetValue<int>(value); } }
        public float WinterIntensity { get { return this[nameof(WinterIntensity)].GetValue<float>(); } set { this[nameof(WinterIntensity)].SetValue<float>(value); } }
        public float SnowflakeIntensity { get { return this[nameof(SnowflakeIntensity)].GetValue<float>(); } set { this[nameof(SnowflakeIntensity)].SetValue<float>(value); } }
        public float BloodMoonIntensity { get { return this[nameof(BloodMoonIntensity)].GetValue<float>(); } set { this[nameof(BloodMoonIntensity)].SetValue<float>(value); } }
        public Array<DailyAnnouncementVO> DailyAnnouncements { get { return new Array<DailyAnnouncementVO>(this[nameof(DailyAnnouncements)].Address); } }
        public int TemperatureModifier { get { return this[nameof(TemperatureModifier)].GetValue<int>(); } set { this[nameof(TemperatureModifier)].SetValue<int>(value); } }
    }
    public class DialogLineDataVO : Object
    {
        public DialogLineDataVO(ulong addr) : base(addr) { }
        public int SpeakerIndex { get { return this[nameof(SpeakerIndex)].GetValue<int>(); } set { this[nameof(SpeakerIndex)].SetValue<int>(value); } }
        public Object DialogLine { get { return this[nameof(DialogLine)]; } set { this[nameof(DialogLine)] = value; } }
    }
    public class DialogVO : Object
    {
        public DialogVO(ulong addr) : base(addr) { }
        public int ID { get { return this[nameof(ID)].GetValue<int>(); } set { this[nameof(ID)].SetValue<int>(value); } }
        public Array<Object> NPCNames { get { return new Array<Object>(this[nameof(NPCNames)].Address); } }
        public Array<Object> NPCPortraits { get { return new Array<Object>(this[nameof(NPCPortraits)].Address); } }
        public Array<DialogLineDataVO> DialogLines { get { return new Array<DialogLineDataVO>(this[nameof(DialogLines)].Address); } }
        public Object NPCVO { get { return this[nameof(NPCVO)]; } set { this[nameof(NPCVO)] = value; } }
    }
    public class DoorDataVO : Object
    {
        public DoorDataVO(ulong addr) : base(addr) { }
        public int ID { get { return this[nameof(ID)].GetValue<int>(); } set { this[nameof(ID)].SetValue<int>(value); } }
        public Object DisplayName { get { return this[nameof(DisplayName)]; } set { this[nameof(DisplayName)] = value; } }
        public Object Description { get { return this[nameof(Description)]; } set { this[nameof(Description)] = value; } }
        public EDoorType Type { get { return (EDoorType)this[nameof(Type)].GetValue<int>(); } set { this[nameof(Type)].SetValue<int>((int)value); } }
        public int ContainerId { get { return this[nameof(ContainerId)].GetValue<int>(); } set { this[nameof(ContainerId)].SetValue<int>(value); } }
        public ESeason Season { get { return (ESeason)this[nameof(Season)].GetValue<int>(); } set { this[nameof(Season)].SetValue<int>((int)value); } }
        public bool bIsTriggerable { get { return this[nameof(bIsTriggerable)].Flag; } set { this[nameof(bIsTriggerable)].Flag = value; } }
        public bool bDefaultOpeningState { get { return this[nameof(bDefaultOpeningState)].Flag; } set { this[nameof(bDefaultOpeningState)].Flag = value; } }
    }
    public class EntitlementDataVO : Object
    {
        public EntitlementDataVO(ulong addr) : base(addr) { }
        public int ID { get { return this[nameof(ID)].GetValue<int>(); } set { this[nameof(ID)].SetValue<int>(value); } }
        public EEntitlementType Type { get { return (EEntitlementType)this[nameof(Type)].GetValue<int>(); } set { this[nameof(Type)].SetValue<int>((int)value); } }
    }
    public class FortificationDataVO : Object
    {
        public FortificationDataVO(ulong addr) : base(addr) { }
        public int ID { get { return this[nameof(ID)].GetValue<int>(); } set { this[nameof(ID)].SetValue<int>(value); } }
        public Object DisplayName { get { return this[nameof(DisplayName)]; } set { this[nameof(DisplayName)] = value; } }
        public Object Description { get { return this[nameof(Description)]; } set { this[nameof(Description)] = value; } }
        public float Health { get { return this[nameof(Health)].GetValue<float>(); } set { this[nameof(Health)].SetValue<float>(value); } }
        public int DoorId { get { return this[nameof(DoorId)].GetValue<int>(); } set { this[nameof(DoorId)].SetValue<int>(value); } }
        public EFortificationType Type { get { return (EFortificationType)this[nameof(Type)].GetValue<int>(); } set { this[nameof(Type)].SetValue<int>((int)value); } }
    }
    public class MappedDataStruct : Object
    {
        public MappedDataStruct(ulong addr) : base(addr) { }
        public Object MappedData { get { return this[nameof(MappedData)]; } set { this[nameof(MappedData)] = value; } }
        public Array<DataModelBase> SortedData { get { return new Array<DataModelBase>(this[nameof(SortedData)].Address); } }
    }
    public class GameDataVO : Object
    {
        public GameDataVO(ulong addr) : base(addr) { }
        public int VersionNumber { get { return this[nameof(VersionNumber)].GetValue<int>(); } set { this[nameof(VersionNumber)].SetValue<int>(value); } }
        public bool bForceRefreshCache { get { return this[nameof(bForceRefreshCache)].Flag; } set { this[nameof(bForceRefreshCache)].Flag = value; } }
        public Array<AchievementsDataVO> Achievements { get { return new Array<AchievementsDataVO>(this[nameof(Achievements)].Address); } }
        public Array<AIBehaviourDataVO> AIBehaviours { get { return new Array<AIBehaviourDataVO>(this[nameof(AIBehaviours)].Address); } }
        public Array<AmmunitionDataVO> Ammunitions { get { return new Array<AmmunitionDataVO>(this[nameof(Ammunitions)].Address); } }
        public Array<AnimalDataVO> Animals { get { return new Array<AnimalDataVO>(this[nameof(Animals)].Address); } }
        public Array<ArmorDataVO> Armors { get { return new Array<ArmorDataVO>(this[nameof(Armors)].Address); } }
        public Array<AttackDataVO> Attacks { get { return new Array<AttackDataVO>(this[nameof(Attacks)].Address); } }
        public Array<AttackStatsDataVO> AttackStats { get { return new Array<AttackStatsDataVO>(this[nameof(AttackStats)].Address); } }
        public Array<AvatarCosmeticDataVO> AvatarCosmetics { get { return new Array<AvatarCosmeticDataVO>(this[nameof(AvatarCosmetics)].Address); } }
        public Array<AvatarIconDataVO> AvatarIcons { get { return new Array<AvatarIconDataVO>(this[nameof(AvatarIcons)].Address); } }
        public Array<AvatarPetDataVO> AvatarPets { get { return new Array<AvatarPetDataVO>(this[nameof(AvatarPets)].Address); } }
        public Array<CaveDataVO> Caves { get { return new Array<CaveDataVO>(this[nameof(Caves)].Address); } }
        public Array<BiomeDataVO> Biomes { get { return new Array<BiomeDataVO>(this[nameof(Biomes)].Address); } }
        public Array<BiomeLevelDataVO> BiomeLevels { get { return new Array<BiomeLevelDataVO>(this[nameof(BiomeLevels)].Address); } }
        public Array<BlueprintDataVO> Blueprints { get { return new Array<BlueprintDataVO>(this[nameof(Blueprints)].Address); } }
        public Array<BuildingDataVO> Buildings { get { return new Array<BuildingDataVO>(this[nameof(Buildings)].Address); } }
        public Array<ChallengeDataVO> Challenges { get { return new Array<ChallengeDataVO>(this[nameof(Challenges)].Address); } }
        public Array<CharacterDataVO> Characters { get { return new Array<CharacterDataVO>(this[nameof(Characters)].Address); } }
        public Array<CodexEntryDataVO> CodexEntries { get { return new Array<CodexEntryDataVO>(this[nameof(CodexEntries)].Address); } }
        public Array<ConfigDataVO> Config { get { return new Array<ConfigDataVO>(this[nameof(Config)].Address); } }
        public Array<ConstructionRecipeDataVO> ConstructionRecipes { get { return new Array<ConstructionRecipeDataVO>(this[nameof(ConstructionRecipes)].Address); } }
        public Array<ConsumableDataVO> Consumables { get { return new Array<ConsumableDataVO>(this[nameof(Consumables)].Address); } }
        public Array<ContainerDataVO> Containers { get { return new Array<ContainerDataVO>(this[nameof(Containers)].Address); } }
        public Array<ContentBundleDataVO> ContentBundles { get { return new Array<ContentBundleDataVO>(this[nameof(ContentBundles)].Address); } }
        public Array<CraftingRecipeDataVO> CraftingRecipes { get { return new Array<CraftingRecipeDataVO>(this[nameof(CraftingRecipes)].Address); } }
        public Array<CreaturePackDataVO> CreaturePacks { get { return new Array<CreaturePackDataVO>(this[nameof(CreaturePacks)].Address); } }
        public Array<DamageTypeDataVO> DamageTypes { get { return new Array<DamageTypeDataVO>(this[nameof(DamageTypes)].Address); } }
        public Array<DayCycleDataVO> DaysCycle { get { return new Array<DayCycleDataVO>(this[nameof(DaysCycle)].Address); } }
        public Array<DialogVO> Dialogs { get { return new Array<DialogVO>(this[nameof(Dialogs)].Address); } }
        public Array<DoorDataVO> Doors { get { return new Array<DoorDataVO>(this[nameof(Doors)].Address); } }
        public Array<EntitlementDataVO> Entitlements { get { return new Array<EntitlementDataVO>(this[nameof(Entitlements)].Address); } }
        public Array<FortificationDataVO> Fortifications { get { return new Array<FortificationDataVO>(this[nameof(Fortifications)].Address); } }
        public Array<GameModeDataVO> GameModes { get { return new Array<GameModeDataVO>(this[nameof(GameModes)].Address); } }
        public Array<GiantDataVO> Giants { get { return new Array<GiantDataVO>(this[nameof(Giants)].Address); } }
        public Array<GameEventDataVO> GameEvents { get { return new Array<GameEventDataVO>(this[nameof(GameEvents)].Address); } }
        public Array<HazardDataVO> Hazards { get { return new Array<HazardDataVO>(this[nameof(Hazards)].Address); } }
        public Array<ItemDataVO> Items { get { return new Array<ItemDataVO>(this[nameof(Items)].Address); } }
        public Array<ItemRarityDataVO> ItemRarities { get { return new Array<ItemRarityDataVO>(this[nameof(ItemRarities)].Address); } }
        public Array<ItemTypeDataVO> ItemTypes { get { return new Array<ItemTypeDataVO>(this[nameof(ItemTypes)].Address); } }
        public Array<MaterialSourceDataVO> MaterialSources { get { return new Array<MaterialSourceDataVO>(this[nameof(MaterialSources)].Address); } }
        public Array<MinionWaveDataVO> MinionWaves { get { return new Array<MinionWaveDataVO>(this[nameof(MinionWaves)].Address); } }
        public Array<ModifierDataVO> Modifiers { get { return new Array<ModifierDataVO>(this[nameof(Modifiers)].Address); } }
        public Array<ModuleDataVO> Modules { get { return new Array<ModuleDataVO>(this[nameof(Modules)].Address); } }
        public Array<ModuleDistributionTypeDataVO> ModuleDistributionTypes { get { return new Array<ModuleDistributionTypeDataVO>(this[nameof(ModuleDistributionTypes)].Address); } }
        public Array<PerkDataVO> Perks { get { return new Array<PerkDataVO>(this[nameof(Perks)].Address); } }
        public Array<PingCommandVO> PingCommands { get { return new Array<PingCommandVO>(this[nameof(PingCommands)].Address); } }
        public Array<PlayerLevelVO> PlayerLevels { get { return new Array<PlayerLevelVO>(this[nameof(PlayerLevels)].Address); } }
        public Array<PlayerClassDataVO> PlayerClasses { get { return new Array<PlayerClassDataVO>(this[nameof(PlayerClasses)].Address); } }
        public Array<PlayerSkillVO> PlayerSkills { get { return new Array<PlayerSkillVO>(this[nameof(PlayerSkills)].Address); } }
        public Array<ProjectileDataVO> Projectiles { get { return new Array<ProjectileDataVO>(this[nameof(Projectiles)].Address); } }
        public Array<QuestDataVO> Quests { get { return new Array<QuestDataVO>(this[nameof(Quests)].Address); } }
        public Array<RarityDataVO> Rarities { get { return new Array<RarityDataVO>(this[nameof(Rarities)].Address); } }
        public Array<ResourceDataVO> Resources { get { return new Array<ResourceDataVO>(this[nameof(Resources)].Address); } }
        public Array<ResourcesEntryDataVO> ResourcesEntries { get { return new Array<ResourcesEntryDataVO>(this[nameof(ResourcesEntries)].Address); } }
        public Array<ShieldDataVO> Shields { get { return new Array<ShieldDataVO>(this[nameof(Shields)].Address); } }
        public Array<StarterKitDataVO> StarterKits { get { return new Array<StarterKitDataVO>(this[nameof(StarterKits)].Address); } }
        public Array<TransmogDataVO> Transmogs { get { return new Array<TransmogDataVO>(this[nameof(Transmogs)].Address); } }
        public Array<UserLevelVO> UserLevels { get { return new Array<UserLevelVO>(this[nameof(UserLevels)].Address); } }
        public Array<SeasonUserLevelVO> SeasonUserLevels { get { return new Array<SeasonUserLevelVO>(this[nameof(SeasonUserLevels)].Address); } }
        public Array<UpgradeDataVO> Upgrades { get { return new Array<UpgradeDataVO>(this[nameof(Upgrades)].Address); } }
        public Array<WeaponDataVO> Weapons { get { return new Array<WeaponDataVO>(this[nameof(Weapons)].Address); } }
        public Array<WeightedLootDataVO> WeightedLoots { get { return new Array<WeightedLootDataVO>(this[nameof(WeightedLoots)].Address); } }
    }
    public class WeightedLootDataVO : Object
    {
        public WeightedLootDataVO(ulong addr) : base(addr) { }
        public int ID { get { return this[nameof(ID)].GetValue<int>(); } set { this[nameof(ID)].SetValue<int>(value); } }
        public float DropChance { get { return this[nameof(DropChance)].GetValue<float>(); } set { this[nameof(DropChance)].SetValue<float>(value); } }
        public int DropCount { get { return this[nameof(DropCount)].GetValue<int>(); } set { this[nameof(DropCount)].SetValue<int>(value); } }
        public bool bIsInstanced { get { return this[nameof(bIsInstanced)].Flag; } set { this[nameof(bIsInstanced)].Flag = value; } }
        public int MinCountPerDrop { get { return this[nameof(MinCountPerDrop)].GetValue<int>(); } set { this[nameof(MinCountPerDrop)].SetValue<int>(value); } }
        public int MaxCountPerDrop { get { return this[nameof(MaxCountPerDrop)].GetValue<int>(); } set { this[nameof(MaxCountPerDrop)].SetValue<int>(value); } }
        public Array<WeightedLootEntryVO> Weights { get { return new Array<WeightedLootEntryVO>(this[nameof(Weights)].Address); } }
        public Array<int> ItemIds { get { return new Array<int>(this[nameof(ItemIds)].Address); } }
    }
    public class WeightedLootEntryVO : Object
    {
        public WeightedLootEntryVO(ulong addr) : base(addr) { }
        public int RarityId { get { return this[nameof(RarityId)].GetValue<int>(); } set { this[nameof(RarityId)].SetValue<int>(value); } }
        public int Weight { get { return this[nameof(Weight)].GetValue<int>(); } set { this[nameof(Weight)].SetValue<int>(value); } }
    }
    public class WeaponDataVO : Object
    {
        public WeaponDataVO(ulong addr) : base(addr) { }
        public int ID { get { return this[nameof(ID)].GetValue<int>(); } set { this[nameof(ID)].SetValue<int>(value); } }
        public int ItemId { get { return this[nameof(ItemId)].GetValue<int>(); } set { this[nameof(ItemId)].SetValue<int>(value); } }
        public Array<int> LightAttacks { get { return new Array<int>(this[nameof(LightAttacks)].Address); } }
        public Array<int> HeavyAttacks { get { return new Array<int>(this[nameof(HeavyAttacks)].Address); } }
        public int TripwireAttack { get { return this[nameof(TripwireAttack)].GetValue<int>(); } set { this[nameof(TripwireAttack)].SetValue<int>(value); } }
        public int HoldAttack { get { return this[nameof(HoldAttack)].GetValue<int>(); } set { this[nameof(HoldAttack)].SetValue<int>(value); } }
        public Array<int> AcceptedMunition { get { return new Array<int>(this[nameof(AcceptedMunition)].Address); } }
        public bool bTwoHand { get { return this[nameof(bTwoHand)].Flag; } set { this[nameof(bTwoHand)].Flag = value; } }
        public bool bLightAttacksUseAmmunition { get { return this[nameof(bLightAttacksUseAmmunition)].Flag; } set { this[nameof(bLightAttacksUseAmmunition)].Flag = value; } }
        public EEquipmentElement Element { get { return (EEquipmentElement)this[nameof(Element)].GetValue<int>(); } set { this[nameof(Element)].SetValue<int>((int)value); } }
        public EStance Stance { get { return (EStance)this[nameof(Stance)].GetValue<int>(); } set { this[nameof(Stance)].SetValue<int>((int)value); } }
        public Object AudioName { get { return this[nameof(AudioName)]; } set { this[nameof(AudioName)] = value; } }
        public float AutoAimRangeSqr { get { return this[nameof(AutoAimRangeSqr)].GetValue<float>(); } set { this[nameof(AutoAimRangeSqr)].SetValue<float>(value); } }
        public float AutoAimAngle { get { return this[nameof(AutoAimAngle)].GetValue<float>(); } set { this[nameof(AutoAimAngle)].SetValue<float>(value); } }
        public float AutoAimAngleController { get { return this[nameof(AutoAimAngleController)].GetValue<float>(); } set { this[nameof(AutoAimAngleController)].SetValue<float>(value); } }
    }
    public class UpgradeDataVO : Object
    {
        public UpgradeDataVO(ulong addr) : base(addr) { }
        public int ID { get { return this[nameof(ID)].GetValue<int>(); } set { this[nameof(ID)].SetValue<int>(value); } }
        public int ContainerId { get { return this[nameof(ContainerId)].GetValue<int>(); } set { this[nameof(ContainerId)].SetValue<int>(value); } }
        public int Level { get { return this[nameof(Level)].GetValue<int>(); } set { this[nameof(Level)].SetValue<int>(value); } }
        public int XPOnUpgrade { get { return this[nameof(XPOnUpgrade)].GetValue<int>(); } set { this[nameof(XPOnUpgrade)].SetValue<int>(value); } }
        public int NextUpgradeId { get { return this[nameof(NextUpgradeId)].GetValue<int>(); } set { this[nameof(NextUpgradeId)].SetValue<int>(value); } }
        public int TargetId { get { return this[nameof(TargetId)].GetValue<int>(); } set { this[nameof(TargetId)].SetValue<int>(value); } }
    }
    public class SeasonUserLevelVO : Object
    {
        public SeasonUserLevelVO(ulong addr) : base(addr) { }
        public int ID { get { return this[nameof(ID)].GetValue<int>(); } set { this[nameof(ID)].SetValue<int>(value); } }
        public int RequiredXP { get { return this[nameof(RequiredXP)].GetValue<int>(); } set { this[nameof(RequiredXP)].SetValue<int>(value); } }
        public RewardDataVO Reward { get { return this[nameof(Reward)].As<RewardDataVO>(); } set { this["Reward"] = value; } }
    }
    public class UserLevelVO : Object
    {
        public UserLevelVO(ulong addr) : base(addr) { }
        public int ID { get { return this[nameof(ID)].GetValue<int>(); } set { this[nameof(ID)].SetValue<int>(value); } }
        public int RequiredXP { get { return this[nameof(RequiredXP)].GetValue<int>(); } set { this[nameof(RequiredXP)].SetValue<int>(value); } }
        public int CurrencyReward { get { return this[nameof(CurrencyReward)].GetValue<int>(); } set { this[nameof(CurrencyReward)].SetValue<int>(value); } }
    }
    public class TransmogDataVO : Object
    {
        public TransmogDataVO(ulong addr) : base(addr) { }
        public int ID { get { return this[nameof(ID)].GetValue<int>(); } set { this[nameof(ID)].SetValue<int>(value); } }
        public int ItemTypeId { get { return this[nameof(ItemTypeId)].GetValue<int>(); } set { this[nameof(ItemTypeId)].SetValue<int>(value); } }
        public Object ActorTemplate { get { return this[nameof(ActorTemplate)]; } set { this[nameof(ActorTemplate)] = value; } }
        public Object FemaleActorTemplate { get { return this[nameof(FemaleActorTemplate)]; } set { this[nameof(FemaleActorTemplate)] = value; } }
        public EStance Stance { get { return (EStance)this[nameof(Stance)].GetValue<int>(); } set { this[nameof(Stance)].SetValue<int>((int)value); } }
    }
    public class StarterKitDataVO : Object
    {
        public StarterKitDataVO(ulong addr) : base(addr) { }
        public int ID { get { return this[nameof(ID)].GetValue<int>(); } set { this[nameof(ID)].SetValue<int>(value); } }
        public Array<ContainerSlotDataVO> Slots { get { return new Array<ContainerSlotDataVO>(this[nameof(Slots)].Address); } }
    }
    public class ShieldDataVO : Object
    {
        public ShieldDataVO(ulong addr) : base(addr) { }
        public int ID { get { return this[nameof(ID)].GetValue<int>(); } set { this[nameof(ID)].SetValue<int>(value); } }
        public int ItemId { get { return this[nameof(ItemId)].GetValue<int>(); } set { this[nameof(ItemId)].SetValue<int>(value); } }
        public Array<DamageValuesDataVO> ShieldStats { get { return new Array<DamageValuesDataVO>(this[nameof(ShieldStats)].Address); } }
        public int AttackStatId { get { return this[nameof(AttackStatId)].GetValue<int>(); } set { this[nameof(AttackStatId)].SetValue<int>(value); } }
        public int CircleAttackStatId { get { return this[nameof(CircleAttackStatId)].GetValue<int>(); } set { this[nameof(CircleAttackStatId)].SetValue<int>(value); } }
        public float RotationSpeed { get { return this[nameof(RotationSpeed)].GetValue<float>(); } set { this[nameof(RotationSpeed)].SetValue<float>(value); } }
        public EEquipmentElement Element { get { return (EEquipmentElement)this[nameof(Element)].GetValue<int>(); } set { this[nameof(Element)].SetValue<int>((int)value); } }
    }
    public class ResourcesEntryDataVO : Object
    {
        public ResourcesEntryDataVO(ulong addr) : base(addr) { }
        public int ID { get { return this[nameof(ID)].GetValue<int>(); } set { this[nameof(ID)].SetValue<int>(value); } }
        public int BiomeId { get { return this[nameof(BiomeId)].GetValue<int>(); } set { this[nameof(BiomeId)].SetValue<int>(value); } }
        public int BiomeLevel { get { return this[nameof(BiomeLevel)].GetValue<int>(); } set { this[nameof(BiomeLevel)].SetValue<int>(value); } }
        public int Type { get { return this[nameof(Type)].GetValue<int>(); } set { this[nameof(Type)].SetValue<int>(value); } }
        public int ResourceId { get { return this[nameof(ResourceId)].GetValue<int>(); } set { this[nameof(ResourceId)].SetValue<int>(value); } }
        public int RarityId { get { return this[nameof(RarityId)].GetValue<int>(); } set { this[nameof(RarityId)].SetValue<int>(value); } }
    }
    public class ResourceDataVO : Object
    {
        public ResourceDataVO(ulong addr) : base(addr) { }
        public int ID { get { return this[nameof(ID)].GetValue<int>(); } set { this[nameof(ID)].SetValue<int>(value); } }
        public int MaterialSourceId { get { return this[nameof(MaterialSourceId)].GetValue<int>(); } set { this[nameof(MaterialSourceId)].SetValue<int>(value); } }
        public bool bIsGrouped { get { return this[nameof(bIsGrouped)].Flag; } set { this[nameof(bIsGrouped)].Flag = value; } }
        public bool bIsCoastal { get { return this[nameof(bIsCoastal)].Flag; } set { this[nameof(bIsCoastal)].Flag = value; } }
        public bool bIsCloseToRiver { get { return this[nameof(bIsCloseToRiver)].Flag; } set { this[nameof(bIsCloseToRiver)].Flag = value; } }
        public bool bIsDownCliff { get { return this[nameof(bIsDownCliff)].Flag; } set { this[nameof(bIsDownCliff)].Flag = value; } }
        public int Radius { get { return this[nameof(Radius)].GetValue<int>(); } set { this[nameof(Radius)].SetValue<int>(value); } }
        public int XYOffset { get { return this[nameof(XYOffset)].GetValue<int>(); } set { this[nameof(XYOffset)].SetValue<int>(value); } }
        public int ZOffset { get { return this[nameof(ZOffset)].GetValue<int>(); } set { this[nameof(ZOffset)].SetValue<int>(value); } }
        public Array<Object> Variants { get { return new Array<Object>(this[nameof(Variants)].Address); } }
    }
    public class RarityDataVO : Object
    {
        public RarityDataVO(ulong addr) : base(addr) { }
        public int ID { get { return this[nameof(ID)].GetValue<int>(); } set { this[nameof(ID)].SetValue<int>(value); } }
        public int ResourceWeight { get { return this[nameof(ResourceWeight)].GetValue<int>(); } set { this[nameof(ResourceWeight)].SetValue<int>(value); } }
        public int BiomeWeight { get { return this[nameof(BiomeWeight)].GetValue<int>(); } set { this[nameof(BiomeWeight)].SetValue<int>(value); } }
    }
    public class QuestDataVO : Object
    {
        public QuestDataVO(ulong addr) : base(addr) { }
        public int ID { get { return this[nameof(ID)].GetValue<int>(); } set { this[nameof(ID)].SetValue<int>(value); } }
        public Object Name { get { return this[nameof(Name)]; } set { this[nameof(Name)] = value; } }
        public Object Description { get { return this[nameof(Description)]; } set { this[nameof(Description)] = value; } }
        public Object LongDescription { get { return this[nameof(LongDescription)]; } set { this[nameof(LongDescription)] = value; } }
        public Array<int> BiomeIds { get { return new Array<int>(this[nameof(BiomeIds)].Address); } }
        public Array<int> RequiredModulesId { get { return new Array<int>(this[nameof(RequiredModulesId)].Address); } }
        public int RelatedModuleId { get { return this[nameof(RelatedModuleId)].GetValue<int>(); } set { this[nameof(RelatedModuleId)].SetValue<int>(value); } }
        public EQuestType Type { get { return (EQuestType)this[nameof(Type)].GetValue<int>(); } set { this[nameof(Type)].SetValue<int>((int)value); } }
        public Array<LootDataVO> LootTable { get { return new Array<LootDataVO>(this[nameof(LootTable)].Address); } }
        public bool bLootToInventory { get { return this[nameof(bLootToInventory)].Flag; } set { this[nameof(bLootToInventory)].Flag = value; } }
        public int XPOnCompletion { get { return this[nameof(XPOnCompletion)].GetValue<int>(); } set { this[nameof(XPOnCompletion)].SetValue<int>(value); } }
        public int NextQuestId { get { return this[nameof(NextQuestId)].GetValue<int>(); } set { this[nameof(NextQuestId)].SetValue<int>(value); } }
        public bool bAvailableAtQuestBoard { get { return this[nameof(bAvailableAtQuestBoard)].Flag; } set { this[nameof(bAvailableAtQuestBoard)].Flag = value; } }
        public DataObject Conditions { get { return this[nameof(Conditions)].As<DataObject>(); } set { this["Conditions"] = value; } }
        public int DialogId { get { return this[nameof(DialogId)].GetValue<int>(); } set { this[nameof(DialogId)].SetValue<int>(value); } }
        public int InProgressDialogId { get { return this[nameof(InProgressDialogId)].GetValue<int>(); } set { this[nameof(InProgressDialogId)].SetValue<int>(value); } }
        public int CompleteDialogId { get { return this[nameof(CompleteDialogId)].GetValue<int>(); } set { this[nameof(CompleteDialogId)].SetValue<int>(value); } }
        public int CooldownDialogId { get { return this[nameof(CooldownDialogId)].GetValue<int>(); } set { this[nameof(CooldownDialogId)].SetValue<int>(value); } }
        public int Cooldown { get { return this[nameof(Cooldown)].GetValue<int>(); } set { this[nameof(Cooldown)].SetValue<int>(value); } }
        public EQuestIconType IconAvailableType { get { return (EQuestIconType)this[nameof(IconAvailableType)].GetValue<int>(); } set { this[nameof(IconAvailableType)].SetValue<int>((int)value); } }
        public EQuestIconType IconInProgressType { get { return (EQuestIconType)this[nameof(IconInProgressType)].GetValue<int>(); } set { this[nameof(IconInProgressType)].SetValue<int>((int)value); } }
        public EQuestIconType IconCompleteType { get { return (EQuestIconType)this[nameof(IconCompleteType)].GetValue<int>(); } set { this[nameof(IconCompleteType)].SetValue<int>((int)value); } }
        public EQuestIconType IconCooldownType { get { return (EQuestIconType)this[nameof(IconCooldownType)].GetValue<int>(); } set { this[nameof(IconCooldownType)].SetValue<int>((int)value); } }
        public int EstimatedTime { get { return this[nameof(EstimatedTime)].GetValue<int>(); } set { this[nameof(EstimatedTime)].SetValue<int>(value); } }
        public EQuestDifficulty Difficulty { get { return (EQuestDifficulty)this[nameof(Difficulty)].GetValue<int>(); } set { this[nameof(Difficulty)].SetValue<int>((int)value); } }
    }
    public class ProjectileDataVO : Object
    {
        public ProjectileDataVO(ulong addr) : base(addr) { }
        public int ID { get { return this[nameof(ID)].GetValue<int>(); } set { this[nameof(ID)].SetValue<int>(value); } }
        public Object Name { get { return this[nameof(Name)]; } set { this[nameof(Name)] = value; } }
        public float ColliderRadius { get { return this[nameof(ColliderRadius)].GetValue<float>(); } set { this[nameof(ColliderRadius)].SetValue<float>(value); } }
        public float Radius { get { return this[nameof(Radius)].GetValue<float>(); } set { this[nameof(Radius)].SetValue<float>(value); } }
        public int SegmentCount { get { return this[nameof(SegmentCount)].GetValue<int>(); } set { this[nameof(SegmentCount)].SetValue<int>(value); } }
        public float SegmentLength { get { return this[nameof(SegmentLength)].GetValue<float>(); } set { this[nameof(SegmentLength)].SetValue<float>(value); } }
        public bool bIsCapsule { get { return this[nameof(bIsCapsule)].Flag; } set { this[nameof(bIsCapsule)].Flag = value; } }
        public int AOEType { get { return this[nameof(AOEType)].GetValue<int>(); } set { this[nameof(AOEType)].SetValue<int>(value); } }
        public float Speed { get { return this[nameof(Speed)].GetValue<float>(); } set { this[nameof(Speed)].SetValue<float>(value); } }
        public int ProjectileCount { get { return this[nameof(ProjectileCount)].GetValue<int>(); } set { this[nameof(ProjectileCount)].SetValue<int>(value); } }
        public float Angle { get { return this[nameof(Angle)].GetValue<float>(); } set { this[nameof(Angle)].SetValue<float>(value); } }
        public float Tick { get { return this[nameof(Tick)].GetValue<float>(); } set { this[nameof(Tick)].SetValue<float>(value); } }
        public float Duration { get { return this[nameof(Duration)].GetValue<float>(); } set { this[nameof(Duration)].SetValue<float>(value); } }
        public float Delay { get { return this[nameof(Delay)].GetValue<float>(); } set { this[nameof(Delay)].SetValue<float>(value); } }
        public bool bResolvedInTemplate { get { return this[nameof(bResolvedInTemplate)].Flag; } set { this[nameof(bResolvedInTemplate)].Flag = value; } }
        public Object ActorTemplate { get { return this[nameof(ActorTemplate)]; } set { this[nameof(ActorTemplate)] = value; } }
        public bool bShouldPrepare { get { return this[nameof(bShouldPrepare)].Flag; } set { this[nameof(bShouldPrepare)].Flag = value; } }
        public bool bIsHoming { get { return this[nameof(bIsHoming)].Flag; } set { this[nameof(bIsHoming)].Flag = value; } }
        public bool bAutoTarget { get { return this[nameof(bAutoTarget)].Flag; } set { this[nameof(bAutoTarget)].Flag = value; } }
        public bool bDoSpawnOnTarget { get { return this[nameof(bDoSpawnOnTarget)].Flag; } set { this[nameof(bDoSpawnOnTarget)].Flag = value; } }
        public bool bIgnoreMultiHit { get { return this[nameof(bIgnoreMultiHit)].Flag; } set { this[nameof(bIgnoreMultiHit)].Flag = value; } }
        public bool bIncludeSelf { get { return this[nameof(bIncludeSelf)].Flag; } set { this[nameof(bIncludeSelf)].Flag = value; } }
        public bool bGoesThrough { get { return this[nameof(bGoesThrough)].Flag; } set { this[nameof(bGoesThrough)].Flag = value; } }
        public float AmplitudeArrow { get { return this[nameof(AmplitudeArrow)].GetValue<float>(); } set { this[nameof(AmplitudeArrow)].SetValue<float>(value); } }
    }
    public class PlayerSkillVO : Object
    {
        public PlayerSkillVO(ulong addr) : base(addr) { }
        public int ID { get { return this[nameof(ID)].GetValue<int>(); } set { this[nameof(ID)].SetValue<int>(value); } }
        public Object Name { get { return this[nameof(Name)]; } set { this[nameof(Name)] = value; } }
        public Object ShortDescription { get { return this[nameof(ShortDescription)]; } set { this[nameof(ShortDescription)] = value; } }
        public Object Description { get { return this[nameof(Description)]; } set { this[nameof(Description)] = value; } }
        public ESkillClass SkillClass { get { return (ESkillClass)this[nameof(SkillClass)].GetValue<int>(); } set { this[nameof(SkillClass)].SetValue<int>((int)value); } }
        public Array<int> PerkIds { get { return new Array<int>(this[nameof(PerkIds)].Address); } }
        public Object Icon { get { return this[nameof(Icon)]; } set { this[nameof(Icon)] = value; } }
        public int RequiredSkillId { get { return this[nameof(RequiredSkillId)].GetValue<int>(); } set { this[nameof(RequiredSkillId)].SetValue<int>(value); } }
        public int InvalidateSkillId { get { return this[nameof(InvalidateSkillId)].GetValue<int>(); } set { this[nameof(InvalidateSkillId)].SetValue<int>(value); } }
        public int TreeCoordinateX { get { return this[nameof(TreeCoordinateX)].GetValue<int>(); } set { this[nameof(TreeCoordinateX)].SetValue<int>(value); } }
        public int TreeCoordinateY { get { return this[nameof(TreeCoordinateY)].GetValue<int>(); } set { this[nameof(TreeCoordinateY)].SetValue<int>(value); } }
        public int Cost { get { return this[nameof(Cost)].GetValue<int>(); } set { this[nameof(Cost)].SetValue<int>(value); } }
        public bool bIsPrimary { get { return this[nameof(bIsPrimary)].Flag; } set { this[nameof(bIsPrimary)].Flag = value; } }
    }
    public class PlayerClassDataVO : Object
    {
        public PlayerClassDataVO(ulong addr) : base(addr) { }
        public int ID { get { return this[nameof(ID)].GetValue<int>(); } set { this[nameof(ID)].SetValue<int>(value); } }
        public ESkillClass SkillClass { get { return (ESkillClass)this[nameof(SkillClass)].GetValue<int>(); } set { this[nameof(SkillClass)].SetValue<int>((int)value); } }
        public int RequiredEntitlementId { get { return this[nameof(RequiredEntitlementId)].GetValue<int>(); } set { this[nameof(RequiredEntitlementId)].SetValue<int>(value); } }
    }
    public class PlayerLevelVO : Object
    {
        public PlayerLevelVO(ulong addr) : base(addr) { }
        public int ID { get { return this[nameof(ID)].GetValue<int>(); } set { this[nameof(ID)].SetValue<int>(value); } }
        public int RequiredXP { get { return this[nameof(RequiredXP)].GetValue<int>(); } set { this[nameof(RequiredXP)].SetValue<int>(value); } }
        public int PlayerSkillPoints { get { return this[nameof(PlayerSkillPoints)].GetValue<int>(); } set { this[nameof(PlayerSkillPoints)].SetValue<int>(value); } }
        public float HealthBonus { get { return this[nameof(HealthBonus)].GetValue<float>(); } set { this[nameof(HealthBonus)].SetValue<float>(value); } }
        public float DamageBonus { get { return this[nameof(DamageBonus)].GetValue<float>(); } set { this[nameof(DamageBonus)].SetValue<float>(value); } }
    }
    public class PingCommandVO : Object
    {
        public PingCommandVO(ulong addr) : base(addr) { }
        public int ID { get { return this[nameof(ID)].GetValue<int>(); } set { this[nameof(ID)].SetValue<int>(value); } }
        public Object Name { get { return this[nameof(Name)]; } set { this[nameof(Name)] = value; } }
        public Object Description { get { return this[nameof(Description)]; } set { this[nameof(Description)] = value; } }
        public Object Icon { get { return this[nameof(Icon)]; } set { this[nameof(Icon)] = value; } }
        public Object VoiceLine { get { return this[nameof(VoiceLine)]; } set { this[nameof(VoiceLine)] = value; } }
    }
    public class PerkDataVO : Object
    {
        public PerkDataVO(ulong addr) : base(addr) { }
        public int ID { get { return this[nameof(ID)].GetValue<int>(); } set { this[nameof(ID)].SetValue<int>(value); } }
        public Object DisplayName { get { return this[nameof(DisplayName)]; } set { this[nameof(DisplayName)] = value; } }
        public Object AlertMessage { get { return this[nameof(AlertMessage)]; } set { this[nameof(AlertMessage)] = value; } }
        public EPerkType Type { get { return (EPerkType)this[nameof(Type)].GetValue<int>(); } set { this[nameof(Type)].SetValue<int>((int)value); } }
        public PerkParametersDataVO Parameters { get { return this[nameof(Parameters)].As<PerkParametersDataVO>(); } set { this["Parameters"] = value; } }
        public Object StatusBP { get { return this[nameof(StatusBP)]; } set { this[nameof(StatusBP)] = value; } }
        public Object StatusVFX { get { return this[nameof(StatusVFX)]; } set { this[nameof(StatusVFX)] = value; } }
        public Object Icon { get { return this[nameof(Icon)]; } set { this[nameof(Icon)] = value; } }
    }
    public class PerkParametersDataVO : Object
    {
        public PerkParametersDataVO(ulong addr) : base(addr) { }
        public int AnimalId { get { return this[nameof(AnimalId)].GetValue<int>(); } set { this[nameof(AnimalId)].SetValue<int>(value); } }
        public int CreaturePackId { get { return this[nameof(CreaturePackId)].GetValue<int>(); } set { this[nameof(CreaturePackId)].SetValue<int>(value); } }
        public int AIBehaviourId { get { return this[nameof(AIBehaviourId)].GetValue<int>(); } set { this[nameof(AIBehaviourId)].SetValue<int>(value); } }
        public int DamageTypeId { get { return this[nameof(DamageTypeId)].GetValue<int>(); } set { this[nameof(DamageTypeId)].SetValue<int>(value); } }
        public int ItemTypeId { get { return this[nameof(ItemTypeId)].GetValue<int>(); } set { this[nameof(ItemTypeId)].SetValue<int>(value); } }
        public int ItemCategoryId { get { return this[nameof(ItemCategoryId)].GetValue<int>(); } set { this[nameof(ItemCategoryId)].SetValue<int>(value); } }
        public Array<int> ItemIds { get { return new Array<int>(this[nameof(ItemIds)].Address); } }
        public int CharacterType { get { return this[nameof(CharacterType)].GetValue<int>(); } set { this[nameof(CharacterType)].SetValue<int>(value); } }
        public int MaterialSourceType { get { return this[nameof(MaterialSourceType)].GetValue<int>(); } set { this[nameof(MaterialSourceType)].SetValue<int>(value); } }
        public int Chance { get { return this[nameof(Chance)].GetValue<int>(); } set { this[nameof(Chance)].SetValue<int>(value); } }
        public float Delay { get { return this[nameof(Delay)].GetValue<float>(); } set { this[nameof(Delay)].SetValue<float>(value); } }
        public float FirstDelay { get { return this[nameof(FirstDelay)].GetValue<float>(); } set { this[nameof(FirstDelay)].SetValue<float>(value); } }
        public float Duration { get { return this[nameof(Duration)].GetValue<float>(); } set { this[nameof(Duration)].SetValue<float>(value); } }
        public float Tick { get { return this[nameof(Tick)].GetValue<float>(); } set { this[nameof(Tick)].SetValue<float>(value); } }
        public float Value { get { return this[nameof(Value)].GetValue<float>(); } set { this[nameof(Value)].SetValue<float>(value); } }
        public int Count { get { return this[nameof(Count)].GetValue<int>(); } set { this[nameof(Count)].SetValue<int>(value); } }
        public float Decay { get { return this[nameof(Decay)].GetValue<float>(); } set { this[nameof(Decay)].SetValue<float>(value); } }
        public int AttackStatId { get { return this[nameof(AttackStatId)].GetValue<int>(); } set { this[nameof(AttackStatId)].SetValue<int>(value); } }
        public Array<int> AttackStatsId { get { return new Array<int>(this[nameof(AttackStatsId)].Address); } }
        public float MinRange { get { return this[nameof(MinRange)].GetValue<float>(); } set { this[nameof(MinRange)].SetValue<float>(value); } }
        public float MaxRange { get { return this[nameof(MaxRange)].GetValue<float>(); } set { this[nameof(MaxRange)].SetValue<float>(value); } }
        public bool bCanStack { get { return this[nameof(bCanStack)].Flag; } set { this[nameof(bCanStack)].Flag = value; } }
        public int MaxStack { get { return this[nameof(MaxStack)].GetValue<int>(); } set { this[nameof(MaxStack)].SetValue<int>(value); } }
        public bool bUseStackAsDamageMultiplier { get { return this[nameof(bUseStackAsDamageMultiplier)].Flag; } set { this[nameof(bUseStackAsDamageMultiplier)].Flag = value; } }
        public int DamageBonusPerMultiplier { get { return this[nameof(DamageBonusPerMultiplier)].GetValue<int>(); } set { this[nameof(DamageBonusPerMultiplier)].SetValue<int>(value); } }
        public float LingeringDelay { get { return this[nameof(LingeringDelay)].GetValue<float>(); } set { this[nameof(LingeringDelay)].SetValue<float>(value); } }
        public bool bTargetSelf { get { return this[nameof(bTargetSelf)].Flag; } set { this[nameof(bTargetSelf)].Flag = value; } }
        public bool bRefresh { get { return this[nameof(bRefresh)].Flag; } set { this[nameof(bRefresh)].Flag = value; } }
        public bool bHasInitialMultiplierBonus { get { return this[nameof(bHasInitialMultiplierBonus)].Flag; } set { this[nameof(bHasInitialMultiplierBonus)].Flag = value; } }
        public Array<int> AppliedPerkIds { get { return new Array<int>(this[nameof(AppliedPerkIds)].Address); } }
        public Array<int> AffectedChannels { get { return new Array<int>(this[nameof(AffectedChannels)].Address); } }
        public Array<int> ImmuneCharacterTypes { get { return new Array<int>(this[nameof(ImmuneCharacterTypes)].Address); } }
        public Array<Object> Tags { get { return new Array<Object>(this[nameof(Tags)].Address); } }
        public Array<Object> TagsRequired { get { return new Array<Object>(this[nameof(TagsRequired)].Address); } }
        public bool bIsDebuff { get { return this[nameof(bIsDebuff)].Flag; } set { this[nameof(bIsDebuff)].Flag = value; } }
        public bool bIgnoreHitReaction { get { return this[nameof(bIgnoreHitReaction)].Flag; } set { this[nameof(bIgnoreHitReaction)].Flag = value; } }
        public bool bDoNotClearOnDeath { get { return this[nameof(bDoNotClearOnDeath)].Flag; } set { this[nameof(bDoNotClearOnDeath)].Flag = value; } }
        public bool bCenterOnRagdoll { get { return this[nameof(bCenterOnRagdoll)].Flag; } set { this[nameof(bCenterOnRagdoll)].Flag = value; } }
        public Object SFX { get { return this[nameof(SFX)]; } set { this[nameof(SFX)] = value; } }
        public int POIType { get { return this[nameof(POIType)].GetValue<int>(); } set { this[nameof(POIType)].SetValue<int>(value); } }
    }
    public class ModuleDistributionTypeDataVO : Object
    {
        public ModuleDistributionTypeDataVO(ulong addr) : base(addr) { }
        public int ID { get { return this[nameof(ID)].GetValue<int>(); } set { this[nameof(ID)].SetValue<int>(value); } }
        public int POIType { get { return this[nameof(POIType)].GetValue<int>(); } set { this[nameof(POIType)].SetValue<int>(value); } }
        public int LocationType { get { return this[nameof(LocationType)].GetValue<int>(); } set { this[nameof(LocationType)].SetValue<int>(value); } }
        public bool bIsUnique { get { return this[nameof(bIsUnique)].Flag; } set { this[nameof(bIsUnique)].Flag = value; } }
        public int MinSpacing { get { return this[nameof(MinSpacing)].GetValue<int>(); } set { this[nameof(MinSpacing)].SetValue<int>(value); } }
        public int MaxSpacing { get { return this[nameof(MaxSpacing)].GetValue<int>(); } set { this[nameof(MaxSpacing)].SetValue<int>(value); } }
        public int MinDistFromVillage { get { return this[nameof(MinDistFromVillage)].GetValue<int>(); } set { this[nameof(MinDistFromVillage)].SetValue<int>(value); } }
        public int MaxDistFromVillage { get { return this[nameof(MaxDistFromVillage)].GetValue<int>(); } set { this[nameof(MaxDistFromVillage)].SetValue<int>(value); } }
        public Array<int> Levels { get { return new Array<int>(this[nameof(Levels)].Address); } }
        public bool bHaveShrineNearby { get { return this[nameof(bHaveShrineNearby)].Flag; } set { this[nameof(bHaveShrineNearby)].Flag = value; } }
        public int XPOnActivation { get { return this[nameof(XPOnActivation)].GetValue<int>(); } set { this[nameof(XPOnActivation)].SetValue<int>(value); } }
        public Object Tooltip { get { return this[nameof(Tooltip)]; } set { this[nameof(Tooltip)] = value; } }
    }
    public class ModuleDataVO : Object
    {
        public ModuleDataVO(ulong addr) : base(addr) { }
        public int ID { get { return this[nameof(ID)].GetValue<int>(); } set { this[nameof(ID)].SetValue<int>(value); } }
        public int ModuleDistributionTypeId { get { return this[nameof(ModuleDistributionTypeId)].GetValue<int>(); } set { this[nameof(ModuleDistributionTypeId)].SetValue<int>(value); } }
        public Array<PoiContentTableDataVO> Creatures { get { return new Array<PoiContentTableDataVO>(this[nameof(Creatures)].Address); } }
        public Array<PoiContentTableDataVO> Chests { get { return new Array<PoiContentTableDataVO>(this[nameof(Chests)].Address); } }
        public Object SaveBlueprint { get { return this[nameof(SaveBlueprint)]; } set { this[nameof(SaveBlueprint)] = value; } }
        public Object Icon { get { return this[nameof(Icon)]; } set { this[nameof(Icon)] = value; } }
        public Object CooldownIcon { get { return this[nameof(CooldownIcon)]; } set { this[nameof(CooldownIcon)] = value; } }
        public Object CompletedIcon { get { return this[nameof(CompletedIcon)]; } set { this[nameof(CompletedIcon)] = value; } }
        public Object InProgressIcon { get { return this[nameof(InProgressIcon)]; } set { this[nameof(InProgressIcon)] = value; } }
        public Object Decal { get { return this[nameof(Decal)]; } set { this[nameof(Decal)] = value; } }
        public int MainEntityDataId { get { return this[nameof(MainEntityDataId)].GetValue<int>(); } set { this[nameof(MainEntityDataId)].SetValue<int>(value); } }
    }
    public class PoiContentTableDataVO : Object
    {
        public PoiContentTableDataVO(ulong addr) : base(addr) { }
        public int Level { get { return this[nameof(Level)].GetValue<int>(); } set { this[nameof(Level)].SetValue<int>(value); } }
        public Array<PoiContentTableEntryDataVO> Entries { get { return new Array<PoiContentTableEntryDataVO>(this[nameof(Entries)].Address); } }
    }
    public class PoiContentTableEntryDataVO : Object
    {
        public PoiContentTableEntryDataVO(ulong addr) : base(addr) { }
        public int ContentId { get { return this[nameof(ContentId)].GetValue<int>(); } set { this[nameof(ContentId)].SetValue<int>(value); } }
        public int AIBehaviourId { get { return this[nameof(AIBehaviourId)].GetValue<int>(); } set { this[nameof(AIBehaviourId)].SetValue<int>(value); } }
        public int MinCount { get { return this[nameof(MinCount)].GetValue<int>(); } set { this[nameof(MinCount)].SetValue<int>(value); } }
        public int MaxCount { get { return this[nameof(MaxCount)].GetValue<int>(); } set { this[nameof(MaxCount)].SetValue<int>(value); } }
        public bool bIsBoss { get { return this[nameof(bIsBoss)].Flag; } set { this[nameof(bIsBoss)].Flag = value; } }
        public bool bIsElite { get { return this[nameof(bIsElite)].Flag; } set { this[nameof(bIsElite)].Flag = value; } }
        public bool bIsRange { get { return this[nameof(bIsRange)].Flag; } set { this[nameof(bIsRange)].Flag = value; } }
    }
    public class ModifierDataVO : Object
    {
        public ModifierDataVO(ulong addr) : base(addr) { }
        public int ID { get { return this[nameof(ID)].GetValue<int>(); } set { this[nameof(ID)].SetValue<int>(value); } }
        public int ItemId { get { return this[nameof(ItemId)].GetValue<int>(); } set { this[nameof(ItemId)].SetValue<int>(value); } }
        public Array<int> PerkIds { get { return new Array<int>(this[nameof(PerkIds)].Address); } }
        public int RequiredEntitlementId { get { return this[nameof(RequiredEntitlementId)].GetValue<int>(); } set { this[nameof(RequiredEntitlementId)].SetValue<int>(value); } }
        public Object LockedDescription { get { return this[nameof(LockedDescription)]; } set { this[nameof(LockedDescription)] = value; } }
    }
    public class MinionWaveDataVO : Object
    {
        public MinionWaveDataVO(ulong addr) : base(addr) { }
        public int ID { get { return this[nameof(ID)].GetValue<int>(); } set { this[nameof(ID)].SetValue<int>(value); } }
        public int Group { get { return this[nameof(Group)].GetValue<int>(); } set { this[nameof(Group)].SetValue<int>(value); } }
        public Array<MinionWaveCreatureEntryDataVO> Creatures { get { return new Array<MinionWaveCreatureEntryDataVO>(this[nameof(Creatures)].Address); } }
    }
    public class MinionWaveCreatureEntryDataVO : Object
    {
        public MinionWaveCreatureEntryDataVO(ulong addr) : base(addr) { }
        public int CreatureId { get { return this[nameof(CreatureId)].GetValue<int>(); } set { this[nameof(CreatureId)].SetValue<int>(value); } }
        public float MinInterval { get { return this[nameof(MinInterval)].GetValue<float>(); } set { this[nameof(MinInterval)].SetValue<float>(value); } }
        public float MaxInterval { get { return this[nameof(MaxInterval)].GetValue<float>(); } set { this[nameof(MaxInterval)].SetValue<float>(value); } }
        public int MaxPerNight { get { return this[nameof(MaxPerNight)].GetValue<int>(); } set { this[nameof(MaxPerNight)].SetValue<int>(value); } }
    }
    public class MaterialSourceDataVO : Object
    {
        public MaterialSourceDataVO(ulong addr) : base(addr) { }
        public int ID { get { return this[nameof(ID)].GetValue<int>(); } set { this[nameof(ID)].SetValue<int>(value); } }
        public Object DisplayName { get { return this[nameof(DisplayName)]; } set { this[nameof(DisplayName)] = value; } }
        public Object ActionText { get { return this[nameof(ActionText)]; } set { this[nameof(ActionText)] = value; } }
        public int XPOnHarvest { get { return this[nameof(XPOnHarvest)].GetValue<int>(); } set { this[nameof(XPOnHarvest)].SetValue<int>(value); } }
        public EMaterialSourceTypes MaterialSourceType { get { return (EMaterialSourceTypes)this[nameof(MaterialSourceType)].GetValue<int>(); } set { this[nameof(MaterialSourceType)].SetValue<int>((int)value); } }
        public EHarvestAnimType HarvestAnimType { get { return (EHarvestAnimType)this[nameof(HarvestAnimType)].GetValue<int>(); } set { this[nameof(HarvestAnimType)].SetValue<int>((int)value); } }
        public Object Icon { get { return this[nameof(Icon)]; } set { this[nameof(Icon)] = value; } }
        public Array<LootDataVO> LootTable { get { return new Array<LootDataVO>(this[nameof(LootTable)].Address); } }
        public int WeightedLoots { get { return this[nameof(WeightedLoots)].GetValue<int>(); } set { this[nameof(WeightedLoots)].SetValue<int>(value); } }
        public int DawnState { get { return this[nameof(DawnState)].GetValue<int>(); } set { this[nameof(DawnState)].SetValue<int>(value); } }
        public int DayState { get { return this[nameof(DayState)].GetValue<int>(); } set { this[nameof(DayState)].SetValue<int>(value); } }
        public int EveningState { get { return this[nameof(EveningState)].GetValue<int>(); } set { this[nameof(EveningState)].SetValue<int>(value); } }
        public int NightState { get { return this[nameof(NightState)].GetValue<int>(); } set { this[nameof(NightState)].SetValue<int>(value); } }
        public int ToolItemTypeId { get { return this[nameof(ToolItemTypeId)].GetValue<int>(); } set { this[nameof(ToolItemTypeId)].SetValue<int>(value); } }
        public float HoldToOpenTimer { get { return this[nameof(HoldToOpenTimer)].GetValue<float>(); } set { this[nameof(HoldToOpenTimer)].SetValue<float>(value); } }
        public int RespawnRate { get { return this[nameof(RespawnRate)].GetValue<int>(); } set { this[nameof(RespawnRate)].SetValue<int>(value); } }
    }
    public class ItemTypeDataVO : Object
    {
        public ItemTypeDataVO(ulong addr) : base(addr) { }
        public int ID { get { return this[nameof(ID)].GetValue<int>(); } set { this[nameof(ID)].SetValue<int>(value); } }
        public Object Name { get { return this[nameof(Name)]; } set { this[nameof(Name)] = value; } }
        public bool bPlayerCanNotDrop { get { return this[nameof(bPlayerCanNotDrop)].Flag; } set { this[nameof(bPlayerCanNotDrop)].Flag = value; } }
        public bool bAlwaysEquipped { get { return this[nameof(bAlwaysEquipped)].Flag; } set { this[nameof(bAlwaysEquipped)].Flag = value; } }
        public EItemCategory Category { get { return (EItemCategory)this[nameof(Category)].GetValue<int>(); } set { this[nameof(Category)].SetValue<int>((int)value); } }
    }
    public class ItemRarityDataVO : Object
    {
        public ItemRarityDataVO(ulong addr) : base(addr) { }
        public int ID { get { return this[nameof(ID)].GetValue<int>(); } set { this[nameof(ID)].SetValue<int>(value); } }
        public EItemRarity ItemRarity { get { return (EItemRarity)this[nameof(ItemRarity)].GetValue<int>(); } set { this[nameof(ItemRarity)].SetValue<int>((int)value); } }
        public Array<LootDataVO> SalvageLootTable { get { return new Array<LootDataVO>(this[nameof(SalvageLootTable)].Address); } }
        public int RepairBrokenCost { get { return this[nameof(RepairBrokenCost)].GetValue<int>(); } set { this[nameof(RepairBrokenCost)].SetValue<int>(value); } }
        public int RepairCostPerPercentileTier { get { return this[nameof(RepairCostPerPercentileTier)].GetValue<int>(); } set { this[nameof(RepairCostPerPercentileTier)].SetValue<int>(value); } }
        public int DismantleValuePerPercentileTier { get { return this[nameof(DismantleValuePerPercentileTier)].GetValue<int>(); } set { this[nameof(DismantleValuePerPercentileTier)].SetValue<int>(value); } }
        public float MaterialMultiplier { get { return this[nameof(MaterialMultiplier)].GetValue<float>(); } set { this[nameof(MaterialMultiplier)].SetValue<float>(value); } }
        public float OfferingLootMultiplier { get { return this[nameof(OfferingLootMultiplier)].GetValue<float>(); } set { this[nameof(OfferingLootMultiplier)].SetValue<float>(value); } }
        public Object Color { get { return this[nameof(Color)]; } set { this[nameof(Color)] = value; } }
        public Object AudioName { get { return this[nameof(AudioName)]; } set { this[nameof(AudioName)] = value; } }
    }
    public class ItemDataVO : Object
    {
        public ItemDataVO(ulong addr) : base(addr) { }
        public int ID { get { return this[nameof(ID)].GetValue<int>(); } set { this[nameof(ID)].SetValue<int>(value); } }
        public Object DisplayName { get { return this[nameof(DisplayName)]; } set { this[nameof(DisplayName)] = value; } }
        public int ItemRarityId { get { return this[nameof(ItemRarityId)].GetValue<int>(); } set { this[nameof(ItemRarityId)].SetValue<int>(value); } }
        public int MaxStackPouch { get { return this[nameof(MaxStackPouch)].GetValue<int>(); } set { this[nameof(MaxStackPouch)].SetValue<int>(value); } }
        public int EquippedPower { get { return this[nameof(EquippedPower)].GetValue<int>(); } set { this[nameof(EquippedPower)].SetValue<int>(value); } }
        public int FireEquippedPower { get { return this[nameof(FireEquippedPower)].GetValue<int>(); } set { this[nameof(FireEquippedPower)].SetValue<int>(value); } }
        public int IceEquippedPower { get { return this[nameof(IceEquippedPower)].GetValue<int>(); } set { this[nameof(IceEquippedPower)].SetValue<int>(value); } }
        public int DarkEquippedPower { get { return this[nameof(DarkEquippedPower)].GetValue<int>(); } set { this[nameof(DarkEquippedPower)].SetValue<int>(value); } }
        public int ThunderEquippedPower { get { return this[nameof(ThunderEquippedPower)].GetValue<int>(); } set { this[nameof(ThunderEquippedPower)].SetValue<int>(value); } }
        public Object Description { get { return this[nameof(Description)]; } set { this[nameof(Description)] = value; } }
        public Object Icon { get { return this[nameof(Icon)]; } set { this[nameof(Icon)] = value; } }
        public int ItemTypeId { get { return this[nameof(ItemTypeId)].GetValue<int>(); } set { this[nameof(ItemTypeId)].SetValue<int>(value); } }
        public Object ActorTemplate { get { return this[nameof(ActorTemplate)]; } set { this[nameof(ActorTemplate)] = value; } }
        public Object FemaleActorTemplate { get { return this[nameof(FemaleActorTemplate)]; } set { this[nameof(FemaleActorTemplate)] = value; } }
        public Object LootBagBPNotInstanced { get { return this[nameof(LootBagBPNotInstanced)]; } set { this[nameof(LootBagBPNotInstanced)] = value; } }
        public Object LootBagBPInstanced { get { return this[nameof(LootBagBPInstanced)]; } set { this[nameof(LootBagBPInstanced)] = value; } }
        public int Durability { get { return this[nameof(Durability)].GetValue<int>(); } set { this[nameof(Durability)].SetValue<int>(value); } }
        public Object AudioName { get { return this[nameof(AudioName)]; } set { this[nameof(AudioName)] = value; } }
        public bool bHidden { get { return this[nameof(bHidden)].Flag; } set { this[nameof(bHidden)].Flag = value; } }
        public bool bIsInfinite { get { return this[nameof(bIsInfinite)].Flag; } set { this[nameof(bIsInfinite)].Flag = value; } }
        public bool bExcludeFromLootEveryItem { get { return this[nameof(bExcludeFromLootEveryItem)].Flag; } set { this[nameof(bExcludeFromLootEveryItem)].Flag = value; } }
        public bool bAlwaysSwitch { get { return this[nameof(bAlwaysSwitch)].Flag; } set { this[nameof(bAlwaysSwitch)].Flag = value; } }
    }
    public class HazardDataVO : Object
    {
        public HazardDataVO(ulong addr) : base(addr) { }
        public int ID { get { return this[nameof(ID)].GetValue<int>(); } set { this[nameof(ID)].SetValue<int>(value); } }
        public Object DisplayName { get { return this[nameof(DisplayName)]; } set { this[nameof(DisplayName)] = value; } }
        public float RespawnRate { get { return this[nameof(RespawnRate)].GetValue<float>(); } set { this[nameof(RespawnRate)].SetValue<float>(value); } }
        public float Lifetime { get { return this[nameof(Lifetime)].GetValue<float>(); } set { this[nameof(Lifetime)].SetValue<float>(value); } }
        public float Health { get { return this[nameof(Health)].GetValue<float>(); } set { this[nameof(Health)].SetValue<float>(value); } }
        public int AttackStatId { get { return this[nameof(AttackStatId)].GetValue<int>(); } set { this[nameof(AttackStatId)].SetValue<int>(value); } }
        public float DamageMultiplier { get { return this[nameof(DamageMultiplier)].GetValue<float>(); } set { this[nameof(DamageMultiplier)].SetValue<float>(value); } }
        public bool bDoCountInCampCompletion { get { return this[nameof(bDoCountInCampCompletion)].Flag; } set { this[nameof(bDoCountInCampCompletion)].Flag = value; } }
        public Object ActorTemplate { get { return this[nameof(ActorTemplate)]; } set { this[nameof(ActorTemplate)] = value; } }
        public int Channel { get { return this[nameof(Channel)].GetValue<int>(); } set { this[nameof(Channel)].SetValue<int>(value); } }
        public Object MapIcon { get { return this[nameof(MapIcon)]; } set { this[nameof(MapIcon)] = value; } }
        public int XpOnInteract { get { return this[nameof(XpOnInteract)].GetValue<int>(); } set { this[nameof(XpOnInteract)].SetValue<int>(value); } }
        public int GiantDetectionRange { get { return this[nameof(GiantDetectionRange)].GetValue<int>(); } set { this[nameof(GiantDetectionRange)].SetValue<int>(value); } }
        public Array<int> DetectionChannels { get { return new Array<int>(this[nameof(DetectionChannels)].Address); } }
        public int ContainerId { get { return this[nameof(ContainerId)].GetValue<int>(); } set { this[nameof(ContainerId)].SetValue<int>(value); } }
        public Array<LootDataVO> LootTable { get { return new Array<LootDataVO>(this[nameof(LootTable)].Address); } }
        public int WeightedLoots { get { return this[nameof(WeightedLoots)].GetValue<int>(); } set { this[nameof(WeightedLoots)].SetValue<int>(value); } }
        public bool bIsCaveEntrance { get { return this[nameof(bIsCaveEntrance)].Flag; } set { this[nameof(bIsCaveEntrance)].Flag = value; } }
        public int MaterialSourceId { get { return this[nameof(MaterialSourceId)].GetValue<int>(); } set { this[nameof(MaterialSourceId)].SetValue<int>(value); } }
        public int PerkId { get { return this[nameof(PerkId)].GetValue<int>(); } set { this[nameof(PerkId)].SetValue<int>(value); } }
    }
    public class GameEventDataVO : Object
    {
        public GameEventDataVO(ulong addr) : base(addr) { }
        public int ID { get { return this[nameof(ID)].GetValue<int>(); } set { this[nameof(ID)].SetValue<int>(value); } }
        public int MinStartDay { get { return this[nameof(MinStartDay)].GetValue<int>(); } set { this[nameof(MinStartDay)].SetValue<int>(value); } }
        public int MaxStartDay { get { return this[nameof(MaxStartDay)].GetValue<int>(); } set { this[nameof(MaxStartDay)].SetValue<int>(value); } }
        public float StartTime { get { return this[nameof(StartTime)].GetValue<float>(); } set { this[nameof(StartTime)].SetValue<float>(value); } }
        public float Duration { get { return this[nameof(Duration)].GetValue<float>(); } set { this[nameof(Duration)].SetValue<float>(value); } }
        public float Probability { get { return this[nameof(Probability)].GetValue<float>(); } set { this[nameof(Probability)].SetValue<float>(value); } }
        public Object StartAnnouncements { get { return this[nameof(StartAnnouncements)]; } set { this[nameof(StartAnnouncements)] = value; } }
        public Object CompletedAnnouncements { get { return this[nameof(CompletedAnnouncements)]; } set { this[nameof(CompletedAnnouncements)] = value; } }
        public Object EndAnnouncements { get { return this[nameof(EndAnnouncements)]; } set { this[nameof(EndAnnouncements)] = value; } }
        public int XPOnCompletion { get { return this[nameof(XPOnCompletion)].GetValue<int>(); } set { this[nameof(XPOnCompletion)].SetValue<int>(value); } }
        public Array<LootDataVO> LootTable { get { return new Array<LootDataVO>(this[nameof(LootTable)].Address); } }
        public Object EventLogicTemplate { get { return this[nameof(EventLogicTemplate)]; } set { this[nameof(EventLogicTemplate)] = value; } }
        public DataObject Config { get { return this[nameof(Config)].As<DataObject>(); } set { this["Config"] = value; } }
        public Object MapIcon { get { return this[nameof(MapIcon)]; } set { this[nameof(MapIcon)] = value; } }
    }
    public class GiantDataVO : Object
    {
        public GiantDataVO(ulong addr) : base(addr) { }
        public int ID { get { return this[nameof(ID)].GetValue<int>(); } set { this[nameof(ID)].SetValue<int>(value); } }
        public Object DisplayName { get { return this[nameof(DisplayName)]; } set { this[nameof(DisplayName)] = value; } }
        public int AnimalId { get { return this[nameof(AnimalId)].GetValue<int>(); } set { this[nameof(AnimalId)].SetValue<int>(value); } }
        public Object Icon { get { return this[nameof(Icon)]; } set { this[nameof(Icon)] = value; } }
        public Object ActorTemplate { get { return this[nameof(ActorTemplate)]; } set { this[nameof(ActorTemplate)] = value; } }
        public bool bCanSpawn { get { return this[nameof(bCanSpawn)].Flag; } set { this[nameof(bCanSpawn)].Flag = value; } }
        public EEquipmentElement Element { get { return (EEquipmentElement)this[nameof(Element)].GetValue<int>(); } set { this[nameof(Element)].SetValue<int>((int)value); } }
        public Object MapIcon { get { return this[nameof(MapIcon)]; } set { this[nameof(MapIcon)] = value; } }
        public Object MapIconGreyed { get { return this[nameof(MapIconGreyed)]; } set { this[nameof(MapIconGreyed)] = value; } }
    }
    public class GameModeDataVO : Object
    {
        public GameModeDataVO(ulong addr) : base(addr) { }
        public int ID { get { return this[nameof(ID)].GetValue<int>(); } set { this[nameof(ID)].SetValue<int>(value); } }
        public EGameMode Mode { get { return (EGameMode)this[nameof(Mode)].GetValue<int>(); } set { this[nameof(Mode)].SetValue<int>((int)value); } }
        public int MinLevelRequired { get { return this[nameof(MinLevelRequired)].GetValue<int>(); } set { this[nameof(MinLevelRequired)].SetValue<int>(value); } }
        public bool bIsDisplayed { get { return this[nameof(bIsDisplayed)].Flag; } set { this[nameof(bIsDisplayed)].Flag = value; } }
        public bool bIsEnabled { get { return this[nameof(bIsEnabled)].Flag; } set { this[nameof(bIsEnabled)].Flag = value; } }
        public bool bCanDropCurrencies { get { return this[nameof(bCanDropCurrencies)].Flag; } set { this[nameof(bCanDropCurrencies)].Flag = value; } }
        public int DaysCycleGroup { get { return this[nameof(DaysCycleGroup)].GetValue<int>(); } set { this[nameof(DaysCycleGroup)].SetValue<int>(value); } }
        public bool bDayCycleLoop { get { return this[nameof(bDayCycleLoop)].Flag; } set { this[nameof(bDayCycleLoop)].Flag = value; } }
        public DataObject DifficultySettings { get { return this[nameof(DifficultySettings)].As<DataObject>(); } set { this["DifficultySettings"] = value; } }
        public DataObject DifficultySettingsIndexes { get { return this[nameof(DifficultySettingsIndexes)].As<DataObject>(); } set { this["DifficultySettingsIndexes"] = value; } }
        public DataObject ContentSettings { get { return this[nameof(ContentSettings)].As<DataObject>(); } set { this["ContentSettings"] = value; } }
    }
    public class WorldContentSettings : Object
    {
        public WorldContentSettings(ulong addr) : base(addr) { }
        public bool bDoSpawnMythBossModule { get { return this[nameof(bDoSpawnMythBossModule)].Flag; } set { this[nameof(bDoSpawnMythBossModule)].Flag = value; } }
        public bool bDoSpawnBifrostModule { get { return this[nameof(bDoSpawnBifrostModule)].Flag; } set { this[nameof(bDoSpawnBifrostModule)].Flag = value; } }
        public float QuestGiverSpawnRatio { get { return this[nameof(QuestGiverSpawnRatio)].GetValue<float>(); } set { this[nameof(QuestGiverSpawnRatio)].SetValue<float>(value); } }
        public bool bIsSagaQuestActive { get { return this[nameof(bIsSagaQuestActive)].Flag; } set { this[nameof(bIsSagaQuestActive)].Flag = value; } }
    }
    public class IAPPackVO : Object
    {
        public IAPPackVO(ulong addr) : base(addr) { }
        public int ID { get { return this[nameof(ID)].GetValue<int>(); } set { this[nameof(ID)].SetValue<int>(value); } }
        public Object DisplayName { get { return this[nameof(DisplayName)]; } set { this[nameof(DisplayName)] = value; } }
        public bool bIsAvailable { get { return this[nameof(bIsAvailable)].Flag; } set { this[nameof(bIsAvailable)].Flag = value; } }
        public RewardDataVO Reward { get { return this[nameof(Reward)].As<RewardDataVO>(); } set { this["Reward"] = value; } }
        public Object SteamStoreId { get { return this[nameof(SteamStoreId)]; } set { this[nameof(SteamStoreId)] = value; } }
        public Object Price { get { return this[nameof(Price)]; } set { this[nameof(Price)] = value; } }
        public Array<LocalePriceVO> LocalePrices { get { return new Array<LocalePriceVO>(this[nameof(LocalePrices)].Address); } }
        public int SortOrder { get { return this[nameof(SortOrder)].GetValue<int>(); } set { this[nameof(SortOrder)].SetValue<int>(value); } }
        public Object Icon { get { return this[nameof(Icon)]; } set { this[nameof(Icon)] = value; } }
    }
    public class LocalePriceVO : Object
    {
        public LocalePriceVO(ulong addr) : base(addr) { }
        public Object CurrencyCode { get { return this[nameof(CurrencyCode)]; } set { this[nameof(CurrencyCode)] = value; } }
        public Object CurrencySymbol { get { return this[nameof(CurrencySymbol)]; } set { this[nameof(CurrencySymbol)] = value; } }
        public int Price { get { return this[nameof(Price)].GetValue<int>(); } set { this[nameof(Price)].SetValue<int>(value); } }
    }
    public class LobbyDataVO : Object
    {
        public LobbyDataVO(ulong addr) : base(addr) { }
        public Array<CharacterDataVO> Characters { get { return new Array<CharacterDataVO>(this[nameof(Characters)].Address); } }
        public Array<ConfigDataVO> Config { get { return new Array<ConfigDataVO>(this[nameof(Config)].Address); } }
        public Array<AvatarCosmeticDataVO> AvatarCosmetics { get { return new Array<AvatarCosmeticDataVO>(this[nameof(AvatarCosmetics)].Address); } }
        public Array<AvatarIconDataVO> AvatarIcons { get { return new Array<AvatarIconDataVO>(this[nameof(AvatarIcons)].Address); } }
        public Array<BlueprintDataVO> Blueprints { get { return new Array<BlueprintDataVO>(this[nameof(Blueprints)].Address); } }
        public Array<PingCommandVO> PingCommands { get { return new Array<PingCommandVO>(this[nameof(PingCommands)].Address); } }
        public Array<UserLevelVO> UserLevels { get { return new Array<UserLevelVO>(this[nameof(UserLevels)].Address); } }
    }
    public class MinionWaveEntryDataVO : Object
    {
        public MinionWaveEntryDataVO(ulong addr) : base(addr) { }
        public int CreatureId { get { return this[nameof(CreatureId)].GetValue<int>(); } set { this[nameof(CreatureId)].SetValue<int>(value); } }
        public int Weight { get { return this[nameof(Weight)].GetValue<int>(); } set { this[nameof(Weight)].SetValue<int>(value); } }
    }
    public class ServerRegionVO : Object
    {
        public ServerRegionVO(ulong addr) : base(addr) { }
        public Object RegionName { get { return this[nameof(RegionName)]; } set { this[nameof(RegionName)] = value; } }
        public Object URL { get { return this[nameof(URL)]; } set { this[nameof(URL)] = value; } }
        public float Ping { get { return this[nameof(Ping)].GetValue<float>(); } set { this[nameof(Ping)].SetValue<float>(value); } }
    }
    public class ShopItemVO : Object
    {
        public ShopItemVO(ulong addr) : base(addr) { }
        public int ID { get { return this[nameof(ID)].GetValue<int>(); } set { this[nameof(ID)].SetValue<int>(value); } }
        public RewardDataVO Reward { get { return this[nameof(Reward)].As<RewardDataVO>(); } set { this["Reward"] = value; } }
        public int Price { get { return this[nameof(Price)].GetValue<int>(); } set { this[nameof(Price)].SetValue<int>(value); } }
        public ECurrencyType CurrencyType { get { return (ECurrencyType)this[nameof(CurrencyType)].GetValue<int>(); } set { this[nameof(CurrencyType)].SetValue<int>((int)value); } }
    }
    public class ShopVO : Object
    {
        public ShopVO(ulong addr) : base(addr) { }
        public Array<ShopItemVO> FeaturedItems { get { return new Array<ShopItemVO>(this[nameof(FeaturedItems)].Address); } }
        public Array<ShopItemVO> RegularItems { get { return new Array<ShopItemVO>(this[nameof(RegularItems)].Address); } }
        public Array<IAPPackVO> IAPPacks { get { return new Array<IAPPackVO>(this[nameof(IAPPacks)].Address); } }
        public bool bIsIAPEnable { get { return this[nameof(bIsIAPEnable)].Flag; } set { this[nameof(bIsIAPEnable)].Flag = value; } }
        public int FeaturedRemainingTime { get { return this[nameof(FeaturedRemainingTime)].GetValue<int>(); } set { this[nameof(FeaturedRemainingTime)].SetValue<int>(value); } }
        public int RegularRemainingTime { get { return this[nameof(RegularRemainingTime)].GetValue<int>(); } set { this[nameof(RegularRemainingTime)].SetValue<int>(value); } }
    }
    public class UserBlueprintVO : Object
    {
        public UserBlueprintVO(ulong addr) : base(addr) { }
        public int BlueprintId { get { return this[nameof(BlueprintId)].GetValue<int>(); } set { this[nameof(BlueprintId)].SetValue<int>(value); } }
        public int Amount { get { return this[nameof(Amount)].GetValue<int>(); } set { this[nameof(Amount)].SetValue<int>(value); } }
    }
    public class WorldMaterialSourceVO : Object
    {
        public WorldMaterialSourceVO(ulong addr) : base(addr) { }
        public Object ID { get { return this[nameof(ID)]; } set { this[nameof(ID)] = value; } }
        public int MaterialSourceId { get { return this[nameof(MaterialSourceId)].GetValue<int>(); } set { this[nameof(MaterialSourceId)].SetValue<int>(value); } }
    }
}
