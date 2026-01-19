using System.Text.Json.Serialization;

namespace SwgohComlink.Client.Models.GameData;

public class GetGameDataResponse
{
    [JsonPropertyName("units")]
    public List<UnitDef> Units { get; set; }

    [JsonPropertyName("battleEnvironments")]
    public List<BattleEnvironment> BattleEnvironments { get; set; }

    [JsonPropertyName("xpTable")]
    public List<XpTable> XpTable { get; set; }

    [JsonPropertyName("material")]
    public List<CraftingMaterialDef> Material { get; set; }

    [JsonPropertyName("recipe")]
    public List<Recipe> Recipe { get; set; }

    [JsonPropertyName("statProgression")]
    public List<StatProgression> StatProgression { get; set; }

    [JsonPropertyName("category")]
    public List<Category> Category { get; set; }

    [JsonPropertyName("helpEntry")]
    public List<HelpEntry> HelpEntry { get; set; }

    [JsonPropertyName("challenge")]
    public List<Challenge> Challenge { get; set; }

    [JsonPropertyName("skill")]
    public List<SkillDefinition> Skill { get; set; }

    [JsonPropertyName("eventSampling")]
    public List<EventSampling> EventSampling { get; set; }

    [JsonPropertyName("equipment")]
    public List<EquipmentDef> Equipment { get; set; }

    [JsonPropertyName("warDefinition")]
    public List<WarDef> WarDefinition { get; set; }

    [JsonPropertyName("targetingSet")]
    public List<TargetingSet> TargetingSet { get; set; }

    [JsonPropertyName("ability")]
    public List<Ability> Ability { get; set; }

    [JsonPropertyName("effect")]
    public List<Effect> Effect { get; set; }

    [JsonPropertyName("requirement")]
    public List<Requirement> Requirement { get; set; }

    [JsonPropertyName("powerUpBundle")]
    public List<PowerUpBundle> PowerUpBundle { get; set; }

    [JsonPropertyName("guildBanner")]
    public GuildBannerDef GuildBanner { get; set; }

    [JsonPropertyName("raidConfig")]
    public List<GuildRaidConfig> RaidConfig { get; set; }

    [JsonPropertyName("guildRaid")]
    public List<GuildRaid> GuildRaid { get; set; }

    [JsonPropertyName("statModSet")]
    public List<StatModSetDefinition> StatModSet { get; set; }

    [JsonPropertyName("statMod")]
    public List<StatModDefinition> StatMod { get; set; }

    [JsonPropertyName("guildExchangeItem")]
    public List<GuildExchangeItem> GuildExchangeItem { get; set; }

    [JsonPropertyName("table")]
    public List<Table> Table { get; set; }

    [JsonPropertyName("unlockAnnouncementDefinition")]
    public List<UnlockAnnouncementDefinition> UnlockAnnouncementDefinition { get; set; }

    [JsonPropertyName("battleTargetingRule")]
    public List<EffectTarget> BattleTargetingRule { get; set; }

    [JsonPropertyName("territoryBattleDefinition")]
    public List<TerritoryBattleDefinition> TerritoryBattleDefinition { get; set; }

    [JsonPropertyName("territoryWarDefinition")]
    public List<TerritoryWarDefinition> TerritoryWarDefinition { get; set; }

    [JsonPropertyName("environmentCollection")]
    public List<EnvironmentCollection> EnvironmentCollection { get; set; }

    [JsonPropertyName("challengeStyle")]
    public List<ChallengeStyle> ChallengeStyle { get; set; }

    [JsonPropertyName("socialStatus")]
    public SocialStatus SocialStatus { get; set; }

    [JsonPropertyName("starterGuild")]
    public List<StarterGuildDef> StarterGuild { get; set; }

    [JsonPropertyName("playerTitle")]
    public List<PlayerTitleDefinition> PlayerTitle { get; set; }

    [JsonPropertyName("modRecommendation")]
    public List<ModRecommendation> ModRecommendation { get; set; }

    [JsonPropertyName("persistentVfx")]
    public List<PersistentVfx> PersistentVfx { get; set; }

    [JsonPropertyName("territoryTournamentDefinition")]
    public List<TerritoryTournamentDefinition> TerritoryTournamentDefinition { get; set; }

    [JsonPropertyName("eventBonus")]
    public List<EventBonus> EventBonus { get; set; }

    [JsonPropertyName("seasonDefinition")]
    public List<SeasonDefinition> SeasonDefinition { get; set; }

    [JsonPropertyName("playerPortrait")]
    public List<PlayerPortraitDefinition> PlayerPortrait { get; set; }

    [JsonPropertyName("timeZoneChangeConfig")]
    public TimeZoneChangeConfig TimeZoneChangeConfig { get; set; }

    [JsonPropertyName("effectIconPriority")]
    public List<string?> EffectIconPriority { get; set; }

    [JsonPropertyName("mysteryBox")]
    public List<MysteryBoxDefinition> MysteryBox { get; set; }

    [JsonPropertyName("mysteryStatMod")]
    public List<MysteryStatModDefinition> MysteryStatMod { get; set; }

    [JsonPropertyName("cooldown")]
    public List<Cooldown> Cooldown { get; set; }

    [JsonPropertyName("dailyActionCap")]
    public List<DailyActionCap> DailyActionCap { get; set; }

    [JsonPropertyName("energyReward")]
    public List<EnergyRewardDefinition> EnergyReward { get; set; }

    [JsonPropertyName("seasonLeagueDefinition")]
    public List<SeasonLeagueDefinition> SeasonLeagueDefinition { get; set; }

    [JsonPropertyName("seasonDivisionDefinition")]
    public List<SeasonDivisionDefinition> SeasonDivisionDefinition { get; set; }

    [JsonPropertyName("seasonRewardTable")]
    public List<SeasonRewardTable> SeasonRewardTable { get; set; }

    [JsonPropertyName("relicTierDefinition")]
    public List<RelicTierDefinition> RelicTierDefinition { get; set; }

    [JsonPropertyName("scavengerConversionSet")]
    public List<ConversionSet> ScavengerConversionSet { get; set; }

    [JsonPropertyName("unitGuideDefinition")]
    public List<UnitGuideDefinition> UnitGuideDefinition { get; set; }

    [JsonPropertyName("galacticBundle")]
    public List<GalacticBundle> GalacticBundle { get; set; }

    [JsonPropertyName("linkedStoreItem")]
    public List<LinkedStoreItem> LinkedStoreItem { get; set; }

    [JsonPropertyName("territoryTournamentLeagueDefinition")]
    public List<TerritoryTournamentLeagueDefinition> TerritoryTournamentLeagueDefinition { get; set; }

    [JsonPropertyName("territoryTournamentDivisionDefinition")]
    public List<TerritoryTournamentDivisionDefinition> TerritoryTournamentDivisionDefinition { get; set; }

    [JsonPropertyName("savedSquadConfig")]
    public List<SaveSquadConfig> SavedSquadConfig { get; set; }

    [JsonPropertyName("guildRaidGlobalConfig")]
    public GuildRaidGlobalConfig GuildRaidGlobalConfig { get; set; }

    [JsonPropertyName("lightspeedToken")]
    public List<LightspeedTokenDefinition> LightspeedToken { get; set; }

    [JsonPropertyName("campaign")]
    public List<Campaign> Campaign { get; set; }

    [JsonPropertyName("conquestDefinition")]
    public List<ConquestDefinition> ConquestDefinition { get; set; }

    [JsonPropertyName("conquestMission")]
    public List<ConquestMission> ConquestMission { get; set; }

    [JsonPropertyName("artifactDefinition")]
    public List<ArtifactDefinition> ArtifactDefinition { get; set; }

    [JsonPropertyName("abilityDecisionTree")]
    public List<AbilityDecisionTree> AbilityDecisionTree { get; set; }

    [JsonPropertyName("consumableDefinition")]
    public List<ConsumableDefinition> ConsumableDefinition { get; set; }

    [JsonPropertyName("consumableType")]
    public List<ConsumableType> ConsumableType { get; set; }

    [JsonPropertyName("artifactTierDefinition")]
    public List<ArtifactTierDefinition> ArtifactTierDefinition { get; set; }

    [JsonPropertyName("consumableTierDefinition")]
    public List<ConsumableTierDefinition> ConsumableTierDefinition { get; set; }

    [JsonPropertyName("recommendedSquad")]
    public List<RecommendedSquad> RecommendedSquad { get; set; }

    [JsonPropertyName("unitGuideLayout")]
    public List<UnitGuideLayout> UnitGuideLayout { get; set; }

    [JsonPropertyName("dailyLoginRewardDefinition")]
    public List<DailyLoginRewardDefinition> DailyLoginRewardDefinition { get; set; }

    [JsonPropertyName("calendarCategoryDefinition")]
    public List<CalendarCategoryDefinition> CalendarCategoryDefinition { get; set; }

    [JsonPropertyName("territoryTournamentDailyRewardTable")]
    public TerritoryTournamentDailyRewardTable TerritoryTournamentDailyRewardTable { get; set; }

    [JsonPropertyName("datacronSet")]
    public List<DatacronSet> DatacronSet { get; set; }

    [JsonPropertyName("datacronTemplate")]
    public List<DatacronTemplate> DatacronTemplate { get; set; }

    [JsonPropertyName("datacronAffixTemplateSet")]
    public List<DatacronAffixTemplateSet> DatacronAffixTemplateSet { get; set; }

    [JsonPropertyName("datacronHelpEntry")]
    public List<DatacronHelpEntry> DatacronHelpEntry { get; set; }

    [JsonPropertyName("displayableEnemy")]
    public List<UnitDefPreview> DisplayableEnemy { get; set; }

    [JsonPropertyName("episodeDefinition")]
    public List<EpisodeDefinition> EpisodeDefinition { get; set; }

    [JsonPropertyName("linkingReward")]
    public BucketItem LinkingReward { get; set; }

    [JsonPropertyName("eraDefinition")]
    public List<EraDefinition> EraDefinition { get; set; }

}