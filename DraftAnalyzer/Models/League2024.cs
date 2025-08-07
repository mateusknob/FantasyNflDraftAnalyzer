using Newtonsoft.Json;

namespace DraftAnalyzer.Models
{
    public class League2024
    {
        [JsonProperty("last_author_display_name")]
        public string LastAuthorDisplayName { get; set; }

        [JsonProperty("last_transaction_id")]
        public string LastTransactionId { get; set; }

        [JsonProperty("previous_league_id")]
        public string PreviousLeagueId { get; set; }

        [JsonProperty("avatar")]
        public string Avatar { get; set; }

        [JsonProperty("metadata")]
        public Metadata2024 Metadata { get; set; }

        [JsonProperty("last_author_is_bot")]
        public string LastAuthorIsBot { get; set; }

        [JsonProperty("last_message_text_map")]
        public object LastMessageTextMap { get; set; }

        [JsonProperty("last_read_id")]
        public string LastReadId { get; set; }

        [JsonProperty("last_message_id")]
        public string LastMessageId { get; set; }

        [JsonProperty("last_author_id")]
        public string LastAuthorId { get; set; }

        [JsonProperty("last_pinned_message_id")]
        public string LastPinnedMessageId { get; set; }

        [JsonProperty("draft_id")]
        public string DraftId { get; set; }

        [JsonProperty("status")]
        public string Status { get; set; }

        [JsonProperty("company_id")]
        public string CompanyId { get; set; }

        [JsonProperty("roster_positions")]
        public List<string> RosterPositions { get; set; }

        [JsonProperty("last_author_avatar")]
        public string LastAuthorAvatar { get; set; }

        [JsonProperty("sport")]
        public string Sport { get; set; }

        [JsonProperty("bracket_id")]
        public string BracketId { get; set; }

        [JsonProperty("season")]
        public string Season { get; set; }

        [JsonProperty("league_id")]
        public string LeagueId { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("last_message_attachment")]
        public object LastMessageAttachment { get; set; }

        [JsonProperty("display_order")]
        public int DisplayOrder { get; set; }

        [JsonProperty("total_rosters")]
        public int TotalRosters { get; set; }

        [JsonProperty("loser_bracket_overrides_id")]
        public string LoserBracketOverridesId { get; set; }

        [JsonProperty("bracket_overrides_id")]
        public string BracketOverridesId { get; set; }

        [JsonProperty("group_id")]
        public string GroupId { get; set; }

        [JsonProperty("season_type")]
        public string SeasonType { get; set; }

        [JsonProperty("scoring_settings")]
        public Dictionary<string, double> ScoringSettings { get; set; }

        [JsonProperty("loser_bracket_id")]
        public string LoserBracketId { get; set; }

        [JsonProperty("settings")]
        public LeagueSettings2024 Settings { get; set; }

        [JsonProperty("shard")]
        public int Shard { get; set; }

        [JsonProperty("last_message_time")]
        public long LastMessageTime { get; set; }
    }

    public class Metadata2024
    {
        [JsonProperty("continued")]
        public string Continued { get; set; }

        [JsonProperty("copy_from_league_id")]
        public string CopyFromLeagueId { get; set; }

        [JsonProperty("keeper_deadline")]
        public string KeeperDeadline { get; set; }

        [JsonProperty("latest_league_winner_roster_id")]
        public string LatestLeagueWinnerRosterId { get; set; }
    }

    public class LeagueSettings2024
    {
        [JsonProperty("best_ball")]
        public int BestBall { get; set; }

        [JsonProperty("last_report")]
        public int LastReport { get; set; }

        [JsonProperty("waiver_budget")]
        public int WaiverBudget { get; set; }

        [JsonProperty("disable_adds")]
        public int DisableAdds { get; set; }

        [JsonProperty("capacity_override")]
        public int CapacityOverride { get; set; }

        [JsonProperty("waiver_bid_min")]
        public int WaiverBidMin { get; set; }

        [JsonProperty("taxi_deadline")]
        public int TaxiDeadline { get; set; }

        [JsonProperty("draft_rounds")]
        public int DraftRounds { get; set; }

        [JsonProperty("reserve_allow_na")]
        public int ReserveAllowNa { get; set; }

        [JsonProperty("start_week")]
        public int StartWeek { get; set; }

        [JsonProperty("playoff_seed_type")]
        public int PlayoffSeedType { get; set; }

        [JsonProperty("playoff_teams")]
        public int PlayoffTeams { get; set; }

        [JsonProperty("num_teams")]
        public int NumTeams { get; set; }

        [JsonProperty("daily_waivers_hour")]
        public int DailyWaiversHour { get; set; }

        [JsonProperty("playoff_type")]
        public int PlayoffType { get; set; }

        [JsonProperty("taxi_slots")]
        public int TaxiSlots { get; set; }

        [JsonProperty("last_scored_leg")]
        public int LastScoredLeg { get; set; }

        [JsonProperty("daily_waivers_days")]
        public int DailyWaiversDays { get; set; }

        [JsonProperty("playoff_week_start")]
        public int PlayoffWeekStart { get; set; }

        [JsonProperty("waiver_clear_days")]
        public int WaiverClearDays { get; set; }

        [JsonProperty("reserve_allow_doubtful")]
        public int ReserveAllowDoubtful { get; set; }

        [JsonProperty("commissioner_direct_invite")]
        public int CommissionerDirectInvite { get; set; }

        [JsonProperty("reserve_allow_dnr")]
        public int ReserveAllowDnr { get; set; }

        [JsonProperty("taxi_allow_vets")]
        public int TaxiAllowVets { get; set; }

        [JsonProperty("waiver_day_of_week")]
        public int WaiverDayOfWeek { get; set; }

        [JsonProperty("playoff_round_type")]
        public int PlayoffRoundType { get; set; }

        [JsonProperty("reserve_allow_out")]
        public int ReserveAllowOut { get; set; }

        [JsonProperty("reserve_allow_sus")]
        public int ReserveAllowSus { get; set; }

        [JsonProperty("trade_deadline")]
        public int TradeDeadline { get; set; }

        [JsonProperty("taxi_years")]
        public int TaxiYears { get; set; }

        [JsonProperty("daily_waivers")]
        public int DailyWaivers { get; set; }

        [JsonProperty("disable_trades")]
        public int DisableTrades { get; set; }

        [JsonProperty("pick_trading")]
        public int PickTrading { get; set; }

        [JsonProperty("type")]
        public int Type { get; set; }

        [JsonProperty("max_keepers")]
        public int MaxKeepers { get; set; }

        [JsonProperty("waiver_type")]
        public int WaiverType { get; set; }

        [JsonProperty("league_average_match")]
        public int LeagueAverageMatch { get; set; }

        [JsonProperty("trade_review_days")]
        public int TradeReviewDays { get; set; }

        [JsonProperty("bench_lock")]
        public int BenchLock { get; set; }

        [JsonProperty("offseason_adds")]
        public int OffseasonAdds { get; set; }

        [JsonProperty("leg")]
        public int Leg { get; set; }

        [JsonProperty("reserve_slots")]
        public int ReserveSlots { get; set; }

        [JsonProperty("reserve_allow_cov")]
        public int ReserveAllowCov { get; set; }

        [JsonProperty("daily_waivers_last_ran")]
        public int DailyWaiversLastRan { get; set; }
    }
}