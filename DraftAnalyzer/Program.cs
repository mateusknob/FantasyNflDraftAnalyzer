using DraftAnalyzer.Models;

namespace DraftAnalyzer
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Insira o nome do usuário no sleeper:");

            var userName = Console.ReadLine();

            Console.WriteLine($"Analisando os dados de {userName}");

            var drafts = FetchDrafts(userName);

            AnalyzeDrafts(drafts);
        }

        static void AnalyzeDrafts(List<List<DraftPick>> draftResults)
        {
            var firstPickPositions = new List<string>();
            int qbEarly = 0, teEarly = 0;
            int wrRbOpening = 0;
            var qbRounds = new List<int>();
            var teRounds = new List<int>();
            var totalDrafts = draftResults.Count();
            
            Console.WriteLine($"Links dos drafts: ");

            foreach (var draft in draftResults)
            {
                Console.WriteLine($"https://sleeper.com/draft/nfl/{draft.First().DraftId}");

                firstPickPositions.Add(draft.First().Metadata.Position);

                // WR + RB nas duas primeiras rodadas
                if (draft.Count >= 2)
                {
                    var firstTwo = draft.Take(2).Select(p => p.Metadata.Position).ToHashSet();
                    if (firstTwo.Contains("RB") && firstTwo.Contains("WR"))
                        wrRbOpening++;
                }

                var firstQB = draft.FirstOrDefault(p => p.Metadata.Position == "QB");
                if (firstQB != null)
                {
                    qbRounds.Add(firstQB.Round);
                    if (firstQB.Round <= 4) qbEarly++;
                }

                var firstTE = draft.FirstOrDefault(p => p.Metadata.Position == "TE");
                if (firstTE != null)
                {
                    teRounds.Add(firstTE.Round);
                    if (firstTE.Round <= 5) teEarly++;
                }
            }

            Console.WriteLine($"\nTotal de drafts analisados: {totalDrafts}");
            Console.WriteLine("Primeira posição mais comum:");
            foreach (var kv in firstPickPositions.GroupBy(x => x).OrderByDescending(g => g.Count()))
                Console.WriteLine($" - {kv.Key}: {kv.Count()} vezes");

            Console.WriteLine($"\nAbriu com WR e RB: {wrRbOpening} de {totalDrafts}");
            Console.WriteLine($"Pegou QB antes da rodada 5: {qbEarly} de {totalDrafts}");
            Console.WriteLine($"Pegou TE antes da rodada 6: {teEarly} de {totalDrafts}");

            Console.WriteLine($"\nMédia de rodada do primeiro QB: {(qbRounds.Count > 0 ? qbRounds.Average().ToString("0.00") : "N/A")}");
            Console.WriteLine($"Média de rodada do primeiro TE: {(teRounds.Count > 0 ? teRounds.Average().ToString("0.00") : "N/A")}");
        }

        static List<List<DraftPick>> FetchDrafts(string userName)
        {
            var userId = SleeperAPI.GetUserId(userName);
            var leagues2024 = SleeperAPI.GetLeagues2024(userId);
            var leagues2025 = SleeperAPI.GetLeagues2025(userId);

            var drafts = new List<List<DraftPick>>();
            foreach (var league in leagues2024)
            {
                if (league.Settings.BestBall == 1 || league.Settings.NumTeams < 10 || league.Settings.NumTeams > 14 || league.Settings.Type != 0)
                    continue;

                var draft = SleeperAPI.GetDraftDetails(league.DraftId);
                if (!draft.Any(x => x.PickedBy == userId))
                    continue;

                drafts.Add(draft);
            }
            foreach (var league in leagues2025)
            {
                if (league.Settings.BestBall == 1 || league.Settings.NumTeams < 10 || league.Settings.NumTeams > 14 || league.Settings.Type != 0)
                    continue;

                var draft = SleeperAPI.GetDraftDetails(league.DraftId);
                if (!draft.Any(x => x.PickedBy == userId))
                    continue;

                drafts.Add(draft);
            }

            return drafts;
        }
    }
}
