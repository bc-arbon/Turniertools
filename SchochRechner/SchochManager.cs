﻿using Newtonsoft.Json;
using SchochRechner.Logic;
using SchochRechner.ObjectModel;

namespace SchochRechner
{
    internal class SchochManager
    {
        public SchochManager()
        {
            this.AddExampleData();
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

        public void AddEntry(int round, int team1, int team2, int games1, int games2, int sets1, int sets2)
        {
            this.Entries.Add(new Entry { Round = round, Team1 = team1, Team2 = team2, GamesTeam1 = games1, GamesTeam2 = games2, SetsTeam1 = sets1, SetsTeam2 = sets2 } );            
        }

        public void DeleteEntry(Entry entry)
        {
            this.Entries.Remove(entry);
        }

        public void CalculateRanking()
        {
            // Clear all stats first
            foreach (var team in this.Teams)
            {
                team.GameWins = 0;
                team.GameLosses = 0;
                team.SetWins = 0;
                team.SetLosses = 0;
                team.Opponents.Clear();
            }

            // Calculate win/loss
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
                    if (oppTeam != null)
                    {
                        team.Buchholz += oppTeam.GameWins;
                    }
                }
            }

            // Calculate FBHZ
            foreach (var team in this.Teams)
            {
                team.Feinbuchholz = 0;
                foreach (var opp in team.Opponents)
                {
                    var oppTeam = this.Teams.Find(x => x.Id == opp);
                    if (oppTeam != null)
                    {
                        team.Feinbuchholz += oppTeam.Buchholz;
                    }
                }
            }

            this.Teams.Sort(new SchochComparer());
        }

        public void AddExampleData()
        {
            this.Teams.Clear();
            this.Entries.Clear();

            this.AddTeam(1, "awit drop");
            this.AddTeam(2, "awit smash");
            this.AddTeam(3, "Beni&Sandro Crushers");
            this.AddTeam(4, "Eigentlich Unihockeyaner");
            this.AddTeam(5, "famafa");
            this.AddTeam(6, "gegengegen");
            this.AddTeam(7, "High-Fly");
            this.AddTeam(8, "it takes drüü");
            this.AddTeam(9, "No pina no gain");
            this.AddTeam(10, "OBD Connection");
            this.AddTeam(11, "PHTG Badminton");
            this.AddTeam(12, "Pläuschler");
            this.AddTeam(13, "ReLuk");
            this.AddTeam(14, "Röhner");
            this.AddTeam(15, "S.I.D.O.");
            this.AddTeam(16, "Vier Schläger für ein Halleluja");
            this.AddTeam(17, "VIVA");
            this.AddTeam(18, "Pausenfüller");

            // Runde 1
            this.AddEntry(1, 2, 3, 0, 2, 0, 4);
            this.AddEntry(1, 6, 4, 2, 0, 4, 2);
            this.AddEntry(1, 10, 8, 0, 2, 1, 4);
            this.AddEntry(1, 14, 11, 0, 2, 0, 4);
            this.AddEntry(1, 9, 7, 0, 2, 1, 4);
            this.AddEntry(1, 13, 1, 0, 2, 1, 4);
            this.AddEntry(1, 18, 17, 0, 2, 0, 4);
            this.AddEntry(1, 12, 16, 1, 1, 2, 2);
            this.AddEntry(1, 15, 5, 0, 2, 0, 4);

            // Runde 2
            this.AddEntry(2, 8, 11, 2, 0, 4, 0);
            this.AddEntry(2, 5, 3, 1, 1, 2, 2);
            this.AddEntry(2, 1, 17, 0, 2, 2, 4);
            this.AddEntry(2, 16, 4, 1, 1, 2, 2);
            this.AddEntry(2, 15, 18, 1, 1, 2, 2);
            this.AddEntry(2, 7, 6, 2, 0, 4, 2);
            this.AddEntry(2, 12, 10, 2, 0, 4, 0);
            this.AddEntry(2, 13, 9, 2, 0, 4, 2);
            this.AddEntry(2, 14, 2, 2, 0, 4, 1);

            // Runde 3
            this.AddEntry(3, 1, 6, 2, 0, 4, 1);
            this.AddEntry(3, 17, 8, 0, 2, 1, 4);
            this.AddEntry(3, 15, 4, 2, 0, 4, 0);
            this.AddEntry(3, 18, 9, 0, 2, 2, 4);
            this.AddEntry(3, 11, 16, 1, 1, 3, 3);
            this.AddEntry(3, 13, 14, 0, 2, 2, 4);
            this.AddEntry(3, 5, 12, 2, 0, 4, 0);
            this.AddEntry(3, 3, 7, 0, 2, 0, 4);
            this.AddEntry(3, 10, 2, 2, 0, 4, 0);

            // Runde 4
            this.AddEntry(4, 10, 9, 0, 2, 1, 4);
            this.AddEntry(4, 2, 18, 0, 2, 0, 4);
            this.AddEntry(4, 7, 8, 0, 2, 2, 4);
            this.AddEntry(4, 3, 16, 0, 2, 2, 4);
            this.AddEntry(4, 12, 6, 2, 0, 4, 0);
            this.AddEntry(4, 5, 1, 1, 1, 2, 2);
            this.AddEntry(4, 14, 17, 0, 2, 0, 4);
            this.AddEntry(4, 13, 4, 2, 0, 4, 1);
            this.AddEntry(4, 11, 15, 1, 1, 3, 3);

            // Runde 5
            this.AddEntry(5, 11, 13, 1, 1, 2, 2);
            this.AddEntry(5, 15, 14, 2, 0, 4, 2);
            this.AddEntry(5, 4, 2, 2, 0, 4, 0);
            this.AddEntry(5, 17, 7, 2, 0, 4, 0);
            this.AddEntry(5, 1, 12, 2, 0, 4, 2);
            this.AddEntry(5, 5, 8, 1, 1, 3, 3);
            this.AddEntry(5, 6, 10, 1, 1, 2, 2);
            this.AddEntry(5, 16, 9, 2, 0, 4, 0);
            this.AddEntry(5, 3, 18, 0, 2, 2, 4);

            this.CalculateRanking();
        }
    }
}
