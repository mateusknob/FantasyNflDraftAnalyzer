using Newtonsoft.Json;

namespace DraftAnalyzer.Models
{
    public class PlayerMetadata
    {
        [JsonProperty("first_name")]
        public string FirstName { get; set; }

        [JsonProperty("injury_status")]
        public string InjuryStatus { get; set; }

        [JsonProperty("last_name")]
        public string LastName { get; set; }

        [JsonProperty("news_updated")]
        public string NewsUpdated { get; set; }

        [JsonProperty("number")]
        public string Number { get; set; }

        [JsonProperty("player_id")]
        public string PlayerId { get; set; }

        [JsonProperty("position")]
        public string Position { get; set; }

        [JsonProperty("sport")]
        public string Sport { get; set; }

        [JsonProperty("status")]
        public string Status { get; set; }

        [JsonProperty("team")]
        public string Team { get; set; }

        [JsonProperty("team_abbr")]
        public string TeamAbbreviation { get; set; }

        [JsonProperty("team_changed_at")]
        public string TeamChangedAt { get; set; }

        [JsonProperty("years_exp")]
        public string YearsExperience { get; set; }
    }

    public class DraftPick
    {
        [JsonProperty("draft_id")]
        public string DraftId { get; set; }

        [JsonProperty("draft_slot")]
        public int DraftSlot { get; set; }

        [JsonProperty("is_keeper")]
        public bool? IsKeeper { get; set; }

        [JsonProperty("metadata")]
        public PlayerMetadata Metadata { get; set; }

        [JsonProperty("pick_no")]
        public int PickNumber { get; set; }

        [JsonProperty("picked_by")]
        public string PickedBy { get; set; }

        [JsonProperty("player_id")]
        public string PlayerId { get; set; }

        [JsonProperty("reactions")]
        public object Reactions { get; set; }

        [JsonProperty("roster_id")]
        public int RosterId { get; set; }

        [JsonProperty("round")]
        public int Round { get; set; }
    }
}