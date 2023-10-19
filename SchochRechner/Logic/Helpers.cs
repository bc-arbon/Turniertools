using SchochRechner.ObjectModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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
    }
}
