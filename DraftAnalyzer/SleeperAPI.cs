using DraftAnalyzer.Models;
using Newtonsoft.Json;

namespace DraftAnalyzer
{
    public static class SleeperAPI
    {
        private static string BASE_URL = "https://api.sleeper.app/v1/";

        public static string GetUserId(string userName)
        {
            using HttpClient client = new HttpClient();
            {
                var response = client.GetAsync($"{BASE_URL}/user/{userName}").Result;

                response.EnsureSuccessStatusCode();

                var responseBody = response.Content.ReadAsStringAsync().Result;

                var obj = JsonConvert.DeserializeObject<User>(responseBody);

                return obj.UserId;
            }
        }

        public static List<League2024> GetLeagues2024(string userId)
        {
            using HttpClient client = new HttpClient();
            {
                var response = client.GetAsync($"{BASE_URL}/user/{userId}/leagues/nfl/2024").Result;

                response.EnsureSuccessStatusCode();

                var responseBody = response.Content.ReadAsStringAsync().Result;

                var obj = JsonConvert.DeserializeObject<List<League2024>>(responseBody);

                return obj;
            }
        }

        public static List<League2025> GetLeagues2025(string userId)
        {
            using HttpClient client = new HttpClient();
            {
                var response = client.GetAsync($"{BASE_URL}/user/{userId}/leagues/nfl/2025").Result;

                response.EnsureSuccessStatusCode();

                var responseBody = response.Content.ReadAsStringAsync().Result;

                var obj = JsonConvert.DeserializeObject<List<League2025>>(responseBody);

                return obj;
            }
        }

        public static List<DraftPick> GetDraftDetails(string draftId)
        {
            using HttpClient client = new HttpClient();
            {
                var response = client.GetAsync($"{BASE_URL}/draft/{draftId}/picks").Result;

                response.EnsureSuccessStatusCode();

                var responseBody = response.Content.ReadAsStringAsync().Result;

                var obj = JsonConvert.DeserializeObject<List<DraftPick>>(responseBody);

                return obj;
            }
        }
    }
}
