using SchochRechner.ObjectModel;
using System.Net.NetworkInformation;

namespace SchochRechner.Logic
{
    internal static class Helpers
    {
        public static Entry CreateEntry(FrmEntry frmEntry)
        {
            var entry = new Entry();
            entry.Round = frmEntry.Round;
            entry.Team1 = frmEntry.Team1;
            entry.Team2 = frmEntry.Team2;
            entry.Games1 = frmEntry.Games1;
            entry.Games2 = frmEntry.Games2;
            entry.Sets1 = frmEntry.Sets1;
            entry.Sets2 = frmEntry.Sets2;
            entry.Points1 = frmEntry.Points1;
            entry.Points2 = frmEntry.Points2;
            entry.Single11 = frmEntry.Single11;
            entry.Single12 = frmEntry.Single12;
            entry.Single21 = frmEntry.Single21;
            entry.Single22 = frmEntry.Single22;
            entry.Single31 = frmEntry.Single31;
            entry.Single32 = frmEntry.Single32;
            entry.Double11 = frmEntry.Double11;
            entry.Double12 = frmEntry.Double12;
            entry.Double21 = frmEntry.Double21;
            entry.Double22 = frmEntry.Double22;
            entry.Double31 = frmEntry.Double31;
            entry.Double32 = frmEntry.Double32;
            return entry;
        }

        public static void UpdateEntry(Entry entry, FrmEntry frmEntry)
        {
            entry.Round = frmEntry.Round;
            entry.Team1 = frmEntry.Team1;
            entry.Team2 = frmEntry.Team2;
            entry.Games1 = frmEntry.Games1;
            entry.Games2 = frmEntry.Games2;
            entry.Sets1 = frmEntry.Sets1;
            entry.Sets2 = frmEntry.Sets2;
            entry.Points1 = frmEntry.Points1;
            entry.Points2 = frmEntry.Points2;
            entry.Single11 = frmEntry.Single11;
            entry.Single12 = frmEntry.Single12;
            entry.Single21 = frmEntry.Single21;
            entry.Single22 = frmEntry.Single22;
            entry.Single31 = frmEntry.Single31;
            entry.Single32 = frmEntry.Single32;
            entry.Double11 = frmEntry.Double11;
            entry.Double12 = frmEntry.Double12;
            entry.Double21 = frmEntry.Double21;
            entry.Double22 = frmEntry.Double22;
            entry.Double31 = frmEntry.Double31;
            entry.Double32 = frmEntry.Double32;
        }

        public static string OpponentsAsList(List<int> opponents)
        {
            var result = "";
            //opponents.Sort();
            foreach (var opponent in opponents)
            {
                if (opponent < 10)
                {
                    result += " ";
                }

                result += opponent.ToString() + " ";
            }

            if (string.IsNullOrEmpty(result))
            {
                return result;
            }
            else
            {
                return result.Substring(0, result.Length - 1);
            }
        }

        private static Random rng = new Random();
        public static void Shuffle<T>(this IList<T> list)
        {
            int n = list.Count;
            while (n > 1)
            {
                n--;
                int k = rng.Next(n + 1);
                T value = list[k];
                list[k] = list[n];
                list[n] = value;
            }
        }

        public static Entry GenerateResult(Draw draw, int round)
        {
            var entry = new Entry();
            entry.Round = round;
            entry.Team1 = draw.Team1.Id;
            entry.Team2 = draw.Team2.Id;

            // 3-set single?
            var rand1 = rng.Next(0, 100);
            var isSingle3Sets = rand1 >= 75;
            var rand2 = rng.Next(0, 100);
            var isDouble3Sets = rand2 >= 75;

            entry.Single11 = rng.Next(0, 21);
            entry.Single12 = entry.Single11 == 21 ? rng.Next(0, 19) : 21;            

            if (isSingle3Sets)
            {
                entry.Single21 = entry.Single11 == 21 ? rng.Next(0, 19) : 21;
                entry.Single22 = entry.Single21 == 21 ? rng.Next(0, 19) : 21;
                entry.Single31 = rng.Next(0, 21);
                entry.Single32 = entry.Single31 == 21 ? rng.Next(0, 19) : 21;
            }
            else
            {
                entry.Single21 = entry.Single11 == 21 ? 21 : rng.Next(0, 19);
                entry.Single22 = entry.Single21 == 21 ? rng.Next(0, 19) : 21;
                entry.Single31 = -1;
                entry.Single32 = -1;
            }

            entry.Sets1 = entry.Single11 == 21 ? entry.Sets1 + 1 : entry.Sets1 + 0;
            entry.Sets1 = entry.Single21 == 21 ? entry.Sets1 + 1 : entry.Sets1 + 0;
            entry.Sets1 = entry.Single31 == 21 ? entry.Sets1 + 1 : entry.Sets1 + 0;
            entry.Sets2 = entry.Single12 == 21 ? entry.Sets2 + 1 : entry.Sets2 + 0;
            entry.Sets2 = entry.Single22 == 21 ? entry.Sets2 + 1 : entry.Sets2 + 0;
            entry.Sets2 = entry.Single32 == 21 ? entry.Sets2 + 1 : entry.Sets2 + 0;

            entry.Double11 = rng.Next(0, 21);
            entry.Double12 = entry.Double11 == 21 ? rng.Next(0, 19) : 21;

            if (isDouble3Sets)
            {
                entry.Double21 = entry.Double11 == 21 ? rng.Next(0, 19) : 21;
                entry.Double22 = entry.Double21 == 21 ? rng.Next(0, 19) : 21;
                entry.Double31 = rng.Next(0, 21);
                entry.Double32 = entry.Double31 == 21 ? rng.Next(0, 19) : 21;
            }
            else
            {
                entry.Double21 = entry.Double11 == 21 ? 21 : rng.Next(0, 19);
                entry.Double22 = entry.Double21 == 21 ? rng.Next(0, 19) : 21;
                entry.Double31 = -1;
                entry.Double32 = -1;
            }

            entry.Sets1 = entry.Double11 == 21 ? entry.Sets1 + 1 : entry.Sets1 + 0;
            entry.Sets1 = entry.Double21 == 21 ? entry.Sets1 + 1 : entry.Sets1 + 0;
            entry.Sets1 = entry.Double31 == 21 ? entry.Sets1 + 1 : entry.Sets1 + 0;
            entry.Sets2 = entry.Double12 == 21 ? entry.Sets2 + 1 : entry.Sets2 + 0;
            entry.Sets2 = entry.Double22 == 21 ? entry.Sets2 + 1 : entry.Sets2 + 0;
            entry.Sets2 = entry.Double32 == 21 ? entry.Sets2 + 1 : entry.Sets2 + 0;

            entry.Games1 = (entry.Single11 + entry.Single21 == 42 || entry.Single31 == 21) ? entry.Games1 + 1 : entry.Games1 + 0;
            entry.Games2 = (entry.Single12 + entry.Single22 == 42 || entry.Single32 == 21) ? entry.Games2 + 1 : entry.Games2 + 0;
            entry.Games1 = (entry.Double11 + entry.Double21 == 42 || entry.Double31 == 21) ? entry.Games1 + 1 : entry.Games1 + 0;
            entry.Games2 = (entry.Double12 + entry.Double22 == 42 || entry.Double32 == 21) ? entry.Games2 + 1 : entry.Games2 + 0;

            entry.Points1 = entry.Single11 + entry.Single21 + entry.Single31 + entry.Double11 + entry.Double21 + entry.Double31;
            entry.Points2 = entry.Single12 + entry.Single22 + entry.Single32 + entry.Double12 + entry.Double22 + entry.Double32;
            return entry;
        }

        public static int RandomPickTeam(int id1, int id2)
        {
            var rand = rng.Next(0, 100);
            return rand < 50 ? id1 : id2;
        }
    }
}
