using Newtonsoft.Json;
using SchochRechner.ObjectModel;

namespace SchochRechner
{
    internal class SchochManager
    {
        public SchochManager()
        {
            this.AddMockData();
        }

        public List<Entry> Entries { get; } = new();
        public List<Team> Teams { get; } = new();

        public void Load(string filepathEntries, string filepathTeams)
        {
            var content1 = File.ReadAllText(filepathEntries);
            var newEntries = JsonConvert.DeserializeObject<List<Entry>>(content1);
            if (newEntries != null)
            {
                this.Entries.Clear();
                this.Entries.AddRange(newEntries);
            }

            var content2 = File.ReadAllText(filepathTeams);
            var newTeams = JsonConvert.DeserializeObject<List<Team>>(content2);
            if (newTeams != null)
            {
                this.Teams.Clear();
                this.Teams.AddRange(newTeams);
            }
        }

        public void Save(string filePathEntries, string filepathTeams)
        {
            var content1 = JsonConvert.SerializeObject(this.Entries, Formatting.Indented);
            File.WriteAllText(filePathEntries, content1);

            var content2 = JsonConvert.SerializeObject(this.Teams, Formatting.Indented);
            File.WriteAllText(filepathTeams, content2);
        }

        public void AddTeam(int id, string name)
        {
            this.Teams.Add(new Team { Id = id, Name = name });
        }

        public void AddEntry(int team1, int team2, int games1, int games2, int sets1, int sets2)
        {
            this.Entries.Add(new Entry { Team1 = team1, Team2 = team2, GamesTeam1 = games1, GamesTeam2 = games2, SetsTeam1 = sets1, SetsTeam2 = sets2 } );
        }


        public void CalculateRanking()
        {
            foreach (var entry in this.Entries)
            {
                var team1 = this.Teams.Find(x => x.Id == entry.Team1);
                var team2 = this.Teams.Find(x => x.Id == entry.Team2);

                team1.GameWins += entry.GamesTeam1;
                team1.GameLosses += entry.GamesTeam2;
                team2.GameWins += entry.GamesTeam2;
                team2.GameLosses += entry.GamesTeam1;

                team1.SetWins += entry.SetsTeam1;
                team1.SetLosses += entry.SetsTeam2;
                team2.SetWins += entry.SetsTeam2;
                team2.SetLosses += entry.SetsTeam1;

                team1.Opponents.Add(team2.Id);
                team2.Opponents.Add(team1.Id);
            }

            // Calculate BHZ
            foreach (var team in this.Teams)
            {
                team.Buchholz = 0;
                foreach(var opp in team.Opponents)
                {
                    var oppTeam = this.Teams.Find(x => x.Id == opp);
                    team.Buchholz += oppTeam.GameWins;
                }
            }

            // Calculate FBHZ
            foreach (var team in this.Teams)
            {
                team.Feinbuchholz = 0;
                foreach (var opp in team.Opponents)
                {
                    var oppTeam = this.Teams.Find(x => x.Id == opp);
                    team.Feinbuchholz += oppTeam.Buchholz;
                }
            }
        }






        public void AddMockData()
        {
            this.AddTeam(1, "Viva");
            this.AddTeam(2, "Pläuschler");
            this.AddTeam(3, "Röhner");
            this.AddTeam(4, "Hubabuba");
            this.AddTeam(5, "Rollator");
            this.AddTeam(6, "Hoblaschorsch");

            this.AddEntry(1, 2, 2, 0, 4, 0);
            this.AddEntry(3, 4, 2, 0, 4, 1);
            this.AddEntry(5, 6, 0, 2, 4, 2);

            this.AddEntry(1, 4, 2, 0, 4, 2);
            this.AddEntry(2, 5, 1, 1, 2, 2);
            this.AddEntry(3, 6, 1, 1, 3, 3);

            this.CalculateRanking();
        }
    }
}
