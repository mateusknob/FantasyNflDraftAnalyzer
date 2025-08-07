using Newtonsoft.Json;

namespace DraftAnalyzer.Models
{
    public class Metadata2025
    {
        [JsonProperty("auto_continue")]
        public string AutoContinue { get; set; }

        [JsonProperty("copy_from_league_id")]
        public string CopyFromLeagueId { get; set; }

        [JsonProperty("keeper_deadline")]
        public string KeeperDeadline { get; set; }

        [JsonProperty("latest_league_winner_roster_id")]
        public string LatestLeagueWinnerRosterId { get; set; }

        [JsonProperty("division_1")]
        public string Division1 { get; set; }

        [JsonProperty("division_1_avatar")]
        public string Division1Avatar { get; set; }

        [JsonProperty("division_2")]
        public string Division2 { get; set; }

        [JsonProperty("division_2_avatar")]
        public string Division2Avatar { get; set; }

        [JsonProperty("division_3")]
        public string Division3 { get; set; }

        [JsonProperty("division_3_avatar")]
        public string Division3Avatar { get; set; }
    }

    public class League2025
    {
        [JsonProperty("season_type")]
        public string SeasonType { get; set; }

        [JsonProperty("avatar")]
        public string Avatar { get; set; }

        [JsonProperty("metadata")]
        public Metadata2025 Metadata { get; set; }

        [JsonProperty("previous_league_id")]
        public string PreviousLeagueId { get; set; }

        [JsonProperty("shard")]
        public int Shard { get; set; }

        [JsonProperty("scoring_settings")]
        public ScoringSettings2025 ScoringSettings { get; set; }

        [JsonProperty("group_id")]
        public object GroupId { get; set; }

        [JsonProperty("sport")]
        public string Sport { get; set; }

        [JsonProperty("league_id")]
        public string LeagueId { get; set; }

        [JsonProperty("status")]
        public string Status { get; set; }

        [JsonProperty("last_author_id")]
        public string LastAuthorId { get; set; }

        [JsonProperty("last_message_time")]
        public object LastMessageTime { get; set; }

        [JsonProperty("last_author_display_name")]
        public string LastAuthorDisplayName { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("last_pinned_message_id")]
        public object LastPinnedMessageId { get; set; }

        [JsonProperty("last_author_avatar")]
        public string LastAuthorAvatar { get; set; }

        [JsonProperty("last_message_attachment")]
        public object LastMessageAttachment { get; set; }

        [JsonProperty("bracket_id")]
        public object BracketId { get; set; }

        [JsonProperty("last_message_id")]
        public string LastMessageId { get; set; }

        [JsonProperty("company_id")]
        public object CompanyId { get; set; }

        [JsonProperty("loser_bracket_id")]
        public object LoserBracketId { get; set; }

        [JsonProperty("last_read_id")]
        public string LastReadId { get; set; }

        [JsonProperty("display_order")]
        public int DisplayOrder { get; set; }

        [JsonProperty("roster_positions")]
        public List<string> RosterPositions { get; set; }

        [JsonProperty("total_rosters")]
        public int TotalRosters { get; set; }

        [JsonProperty("season")]
        public string Season { get; set; }

        [JsonProperty("last_message_text_map")]
        public object LastMessageTextMap { get; set; }

        [JsonProperty("bracket_overrides_id")]
        public object BracketOverridesId { get; set; }

        [JsonProperty("draft_id")]
        public string DraftId { get; set; }

        [JsonProperty("settings")]
        public Settings2025 Settings { get; set; }

        [JsonProperty("last_transaction_id")]
        public long? LastTransactionId { get; set; }

        [JsonProperty("last_author_is_bot")]
        public string LastAuthorIsBot { get; set; }

        [JsonProperty("loser_bracket_overrides_id")]
        public object LoserBracketOverridesId { get; set; }
    }

    public class ScoringSettings2025
    {
        [JsonProperty("sack")]
        public double Sack { get; set; }

        [JsonProperty("fgm_40_49")]
        public double Fgm4049 { get; set; }

        [JsonProperty("pass_int")]
        public double PassInt { get; set; }

        [JsonProperty("pts_allow_0")]
        public double PtsAllow0 { get; set; }

        [JsonProperty("pass_2pt")]
        public double Pass2pt { get; set; }

        [JsonProperty("st_td")]
        public double StTd { get; set; }

        [JsonProperty("rec_td")]
        public double RecTd { get; set; }

        [JsonProperty("fgm_30_39")]
        public double Fgm3039 { get; set; }

        [JsonProperty("fgm_50_59")]
        public double Fgm5059 { get; set; }

        [JsonProperty("xpmiss")]
        public double Xpmiss { get; set; }

        [JsonProperty("rush_td")]
        public double RushTd { get; set; }

        [JsonProperty("rec_2pt")]
        public double Rec2pt { get; set; }

        [JsonProperty("st_fum_rec")]
        public double StFumRec { get; set; }

        [JsonProperty("fgmiss")]
        public double Fgmiss { get; set; }

        [JsonProperty("ff")]
        public double Ff { get; set; }

        [JsonProperty("rec")]
        public double Rec { get; set; }

        [JsonProperty("pts_allow_14_20")]
        public double PtsAllow1420 { get; set; }

        [JsonProperty("fgm_0_19")]
        public double Fgm019 { get; set; }

        [JsonProperty("int")]
        public double Int { get; set; }

        [JsonProperty("def_st_fum_rec")]
        public double DefStFumRec { get; set; }

        [JsonProperty("fum_lost")]
        public double FumLost { get; set; }

        [JsonProperty("pts_allow_1_6")]
        public double PtsAllow16 { get; set; }

        [JsonProperty("fgm_60p")]
        public double Fgm60p { get; set; }

        [JsonProperty("fgm_20_29")]
        public double Fgm2029 { get; set; }

        [JsonProperty("pts_allow_21_27")]
        public double PtsAllow2127 { get; set; }

        [JsonProperty("xpm")]
        public double Xpm { get; set; }

        [JsonProperty("rush_2pt")]
        public double Rush2pt { get; set; }

        [JsonProperty("fum_rec")]
        public double FumRec { get; set; }

        [JsonProperty("def_st_td")]
        public double DefStTd { get; set; }

        [JsonProperty("def_td")]
        public double DefTd { get; set; }

        [JsonProperty("safe")]
        public double Safe { get; set; }

        [JsonProperty("pass_yd")]
        public double PassYd { get; set; }

        [JsonProperty("blk_kick")]
        public double BlkKick { get; set; }

        [JsonProperty("pass_td")]
        public double PassTd { get; set; }

        [JsonProperty("rush_yd")]
        public double RushYd { get; set; }

        [JsonProperty("fum")]
        public double Fum { get; set; }

        [JsonProperty("pts_allow_28_34")]
        public double PtsAllow2834 { get; set; }

        [JsonProperty("pts_allow_35p")]
        public double PtsAllow35p { get; set; }

        [JsonProperty("fum_rec_td")]
        public double FumRecTd { get; set; }

        [JsonProperty("rec_yd")]
        public double RecYd { get; set; }

        [JsonProperty("def_st_ff")]
        public double DefStFf { get; set; }

        [JsonProperty("pts_allow_7_13")]
        public double PtsAllow713 { get; set; }

        [JsonProperty("st_ff")]
        public double StFf { get; set; }

        [JsonProperty("fgm_50p")]
        public double? Fgm50p { get; set; }

        [JsonProperty("tkl_loss")]
        public double? TklLoss { get; set; }

        [JsonProperty("fgm_yds")]
        public double? FgmYds { get; set; }

        [JsonProperty("pts_allow")]
        public double? PtsAllow { get; set; }

        [JsonProperty("fgmiss_30_39")]
        public double? Fgmiss3039 { get; set; }

        [JsonProperty("def_2pt")]
        public double? Def2pt { get; set; }

        [JsonProperty("fgmiss_20_29")]
        public double? Fgmiss2029 { get; set; }

        [JsonProperty("fgmiss_0_19")]
        public double? Fgmiss019 { get; set; }

        [JsonProperty("bonus_rec_te")]
        public double? BonusRecTe { get; set; }

        [JsonProperty("pass_sack")]
        public double? PassSack { get; set; }

        [JsonProperty("fgmiss_50p")]
        public double? Fgmiss50p { get; set; }

        [JsonProperty("fgm_yds_over_30")]
        public double? FgmYdsOver30 { get; set; }

        [JsonProperty("fgmiss_40_49")]
        public double? Fgmiss4049 { get; set; }
    }

    public class Settings2025
    {
        [JsonProperty("best_ball")]
        public int BestBall { get; set; }

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

        [JsonProperty("veto_votes_needed")]
        public int VetoVotesNeeded { get; set; }

        [JsonProperty("num_teams")]
        public int NumTeams { get; set; }

        [JsonProperty("daily_waivers_hour")]
        public int DailyWaiversHour { get; set; }

        [JsonProperty("playoff_type")]
        public int PlayoffType { get; set; }

        [JsonProperty("taxi_slots")]
        public int TaxiSlots { get; set; }

        [JsonProperty("sub_start_time_eligibility")]
        public int SubStartTimeEligibility { get; set; }

        [JsonProperty("daily_waivers_days")]
        public int DailyWaiversDays { get; set; }

        [JsonProperty("sub_lock_if_starter_active")]
        public int SubLockIfStarterActive { get; set; }

        [JsonProperty("playoff_week_start")]
        public int PlayoffWeekStart { get; set; }

        [JsonProperty("waiver_clear_days")]
        public int WaiverClearDays { get; set; }

        [JsonProperty("reserve_allow_doubtful")]
        public int ReserveAllowDoubtful { get; set; }

        [JsonProperty("commissioner_direct_invite")]
        public int CommissionerDirectInvite { get; set; }

        [JsonProperty("veto_auto_poll")]
        public int VetoAutoPoll { get; set; }

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

        [JsonProperty("veto_show_votes")]
        public int VetoShowVotes { get; set; }

        [JsonProperty("trade_deadline")]
        public int TradeDeadline { get; set; }

        [JsonProperty("taxi_years")]
        public int TaxiYears { get; set; }

        [JsonProperty("daily_waivers")]
        public int DailyWaivers { get; set; }

        [JsonProperty("faab_suggestions")]
        public int FaabSuggestions { get; set; }

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

        [JsonProperty("max_subs")]
        public int MaxSubs { get; set; }

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

        [JsonProperty("squads")]
        public int? Squads { get; set; }

        [JsonProperty("divisions")]
        public int? Divisions { get; set; }
    }
}