﻿using Newtonsoft.Json;
using SchochRechner.ObjectModel;
using System.Text;

namespace SchochRechner.Logic
{
    public class SchochManager
    {
        private string entriesFilepath = Path.Combine(Application.StartupPath, "entries.json");
        private string teamsFilepath = Path.Combine(Application.StartupPath, "teams.json");

        public List<Entry> Entries { get; } = new();
        public List<Team> Teams { get; } = new();

        public void Load()
        {
            if (!File.Exists(this.entriesFilepath) || !File.Exists(this.teamsFilepath))
            {
                return;
            }

            var content2 = File.ReadAllText(this.teamsFilepath);
            var newTeams = JsonConvert.DeserializeObject<List<Team>>(content2);
            if (newTeams != null)
            {
                this.Teams.Clear();
                this.Teams.AddRange(newTeams);
            }

            var content1 = File.ReadAllText(this.entriesFilepath);
            var newEntries = JsonConvert.DeserializeObject<List<Entry>>(content1);
            if (newEntries != null)
            {
                this.Entries.Clear();
                this.Entries.AddRange(newEntries);
            }
        }

        public void Save()
        {
            var suffix = DateTime.Now.ToString("yyyyMMdd-HHmmss");
            if (File.Exists(this.entriesFilepath))
            {
                var newFilePath = Path.Combine(Application.StartupPath, "entries-" + suffix + ".json");
                if (!File.Exists(newFilePath))
                {
                    File.Move(this.entriesFilepath, newFilePath);
                }
            }

            if (File.Exists(this.teamsFilepath))
            {
                var newFilePath = Path.Combine(Application.StartupPath, "teams-" + suffix + ".json");
                if (!File.Exists(newFilePath))
                {
                    File.Move(this.teamsFilepath, newFilePath);
                }
            }

            var content1 = JsonConvert.SerializeObject(this.Entries, Formatting.Indented);
            File.WriteAllText(this.entriesFilepath, content1);

            var content2 = JsonConvert.SerializeObject(this.Teams, Formatting.Indented);
            File.WriteAllText(this.teamsFilepath, content2);
        }

        public void AddTeam(int id, string name)
        {
            this.Teams.Add(new Team { Id = id, Name = name });
        }

        public void DeleteTeam(Team team)
        {
            this.Teams.Remove(team);
        }

        public void AddEntry(Entry entry)
        {
            this.Entries.Add(entry);
        }

        public void AddEntry(int round, int team1, int team2, int games1, int games2, int sets1, int sets2, int points1, int points2,
            int single11, int single12, int single21, int single22, int single31, int single32,
            int double11, int double12, int double21, int double22, int double31, int double32)
        {
            this.Entries.Add(
                new Entry
                {
                    Round = round,
                    Team1 = team1,
                    Team2 = team2,
                    Games1 = games1,
                    Games2 = games2,
                    Sets1 = sets1,
                    Sets2 = sets2,
                    Points1 = points1,
                    Points2 = points2,
                    Single11 = single11,
                    Single12 = single12,
                    Single21 = single21,
                    Single22 = single22,
                    Single31 = single31,
                    Single32 = single32,
                    Double11 = double11,
                    Double12 = double12,
                    Double21 = double21,
                    Double22 = double22,
                    Double31 = double31,
                    Double32 = double32
                });
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
                team.GamesWon = 0;
                team.GamesLost = 0;
                team.SetsWon = 0;
                team.SetsLost = 0;
                team.PointsWon = 0;
                team.PointsLost = 0;
                team.Opponents.Clear();
            }

            // Calculate win/loss
            foreach (var entry in this.Entries)
            {
                var team1 = this.Teams.Find(x => x.Id == entry.Team1);
                var team2 = this.Teams.Find(x => x.Id == entry.Team2);

                if (team1 == null || team2 == null)
                {
                    continue;
                }

                team1.GamesWon += entry.Games1;
                team1.GamesLost += entry.Games2;
                team2.GamesWon += entry.Games2;
                team2.GamesLost += entry.Games1;

                team1.SetsWon += entry.Sets1;
                team1.SetsLost += entry.Sets2;
                team2.SetsWon += entry.Sets2;
                team2.SetsLost += entry.Sets1;

                team1.PointsWon += entry.Points1;
                team1.PointsLost += entry.Points2;
                team2.PointsWon += entry.Points2;
                team2.PointsLost += entry.Points1;

                team1.Opponents.Add(team2.Id);
                team2.Opponents.Add(team1.Id);
            }

            // Calculate BHZ
            foreach (var team in this.Teams)
            {
                team.Buchholz = 0;
                foreach (var opp in team.Opponents)
                {
                    var oppTeam = this.Teams.Find(x => x.Id == opp);
                    if (oppTeam != null)
                    {
                        team.Buchholz += oppTeam.GamesWon;
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

        public Round CreateDraw()
        {
            var round = new Round();
            var ranking = 0;

            // Determine the Freilos, but only if a freilos is present
            var hasFreilos = this.Teams.Where(x => x.Id == 99).ToArray();
            if (hasFreilos.Length > 0)
            {
                for (var i = this.Teams.Count - 1; i >= 0; i--)
                {
                    if (this.Teams[i].Id == 99)
                    {
                        continue;
                    }

                    if (!this.Teams[i].Opponents.Contains(99))
                    {
                        round.Draws.Add(new Draw { Team1 = this.Teams[i], Team2 = hasFreilos[0] });
                        break;
                    }
                }
            }

            // Determine all other draws
            foreach (var team in this.Teams)
            {
                try
                {
                    // Is this team already in the draw?
                    if (this.AlreadyDrawn(round.Draws, team))
                    {
                        ranking++;
                        continue;
                    }

                    // Find next opponent                
                    var opponentFound = false;
                    var i = ranking + 1;
                    var team2 = this.Teams[i];
                    while (!opponentFound)
                    {
                        // Is it the same team
                        if (team == team2)
                        {
                            i++;
                            if (i == this.Teams.Count)
                            {
                                i = 0;
                            }

                            team2 = this.Teams[i];
                            continue;
                        }

                        // Is already in draw
                        if (this.AlreadyDrawn(round.Draws, team2))
                        {
                            i++;
                            if (i == this.Teams.Count)
                            {
                                i = 0;
                            }

                            team2 = this.Teams[i];
                            continue;
                        }

                        // Had already played against this team
                        if (team.Opponents.Contains(team2.Id))
                        {
                            i++;
                            if (i == this.Teams.Count)
                            {
                                i = 0;
                            }

                            team2 = this.Teams[i];
                            continue;
                        }

                        opponentFound = true;
                    }

                    // Add draw
                    ranking++;
                    round.Draws.Add(new Draw { Team1 = team, Team2 = team2 });
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Öppis isch nöd guet (Auslosung ist nicht zu trauen):\n\n" + ex, "Fehler", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }

            return round;
        }

        public Round CreateDrawRandom()
        {
            var round = new Round();
            var randomizedList = this.Teams.ToList();
            randomizedList.Shuffle();

            for (var i = 0; i < randomizedList.Count; i++)
            {
                var team1 = randomizedList[i];

                // Is this team already in the draw?
                if (this.AlreadyDrawn(round.Draws, team1))
                {
                    continue;
                }

                // Find next opponent                
                var team2 = randomizedList[i + 1];

                // Add draw                
                round.Draws.Add(new Draw { Team1 = team1, Team2 = team2 });
            }

            return round;
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
            this.AddEntry(1, 2, 3, 2, 0, 4, 0, 84, 76, 21, 19, 21, 19, -1, -1, 21, 19, 21, 19, -1, -1);
            //this.AddEntry(1, 6, 4, 2, 0, 4, 2);
            //this.AddEntry(1, 10, 8, 0, 2, 1, 4);
            //this.AddEntry(1, 14, 11, 0, 2, 0, 4);
            //this.AddEntry(1, 9, 7, 0, 2, 1, 4);
            //this.AddEntry(1, 13, 1, 0, 2, 1, 4);
            //this.AddEntry(1, 18, 17, 0, 2, 0, 4);
            //this.AddEntry(1, 12, 16, 1, 1, 2, 2);
            //this.AddEntry(1, 15, 5, 0, 2, 0, 4);

            // Runde 2
            //this.AddEntry(2, 8, 11, 2, 0, 4, 0);
            //this.AddEntry(2, 5, 3, 1, 1, 2, 2);
            //this.AddEntry(2, 1, 17, 0, 2, 2, 4);
            //this.AddEntry(2, 16, 4, 1, 1, 2, 2);
            //this.AddEntry(2, 15, 18, 1, 1, 2, 2);
            //this.AddEntry(2, 7, 6, 2, 0, 4, 2);
            //this.AddEntry(2, 12, 10, 2, 0, 4, 0);
            //this.AddEntry(2, 13, 9, 2, 0, 4, 2);
            //this.AddEntry(2, 14, 2, 2, 0, 4, 1);

            // Runde 3
            //this.AddEntry(3, 1, 6, 2, 0, 4, 1);
            //this.AddEntry(3, 17, 8, 0, 2, 1, 4);
            //this.AddEntry(3, 15, 4, 2, 0, 4, 0);
            //this.AddEntry(3, 18, 9, 0, 2, 2, 4);
            //this.AddEntry(3, 11, 16, 1, 1, 3, 3);
            //this.AddEntry(3, 13, 14, 0, 2, 2, 4);
            //this.AddEntry(3, 5, 12, 2, 0, 4, 0);
            //this.AddEntry(3, 3, 7, 0, 2, 0, 4);
            //this.AddEntry(3, 10, 2, 2, 0, 4, 0);

            // Runde 4
            //this.AddEntry(4, 10, 9, 0, 2, 1, 4);
            //this.AddEntry(4, 2, 18, 0, 2, 0, 4);
            //this.AddEntry(4, 7, 8, 0, 2, 2, 4);
            //this.AddEntry(4, 3, 16, 0, 2, 2, 4);
            //this.AddEntry(4, 12, 6, 2, 0, 4, 0);
            //this.AddEntry(4, 5, 1, 1, 1, 2, 2);
            //this.AddEntry(4, 14, 17, 0, 2, 0, 4);
            //this.AddEntry(4, 13, 4, 2, 0, 4, 1);
            //this.AddEntry(4, 11, 15, 1, 1, 3, 3);

            // Runde 5
            //this.AddEntry(5, 11, 13, 1, 1, 2, 2);
            //this.AddEntry(5, 15, 14, 2, 0, 4, 2);
            //this.AddEntry(5, 4, 2, 2, 0, 4, 0);
            //this.AddEntry(5, 17, 7, 2, 0, 4, 0);
            //this.AddEntry(5, 1, 12, 2, 0, 4, 2);
            //this.AddEntry(5, 5, 8, 1, 1, 3, 3);
            //this.AddEntry(5, 6, 10, 1, 1, 2, 2);
            //this.AddEntry(5, 16, 9, 2, 0, 4, 0);
            //this.AddEntry(5, 3, 18, 0, 2, 2, 4);

            this.CalculateRanking();
        }

        public void AddExampleData2()
        {
            this.entriesFilepath = Path.Combine(Application.StartupPath, "sampledata", "entries-sample.json");
            this.teamsFilepath = Path.Combine(Application.StartupPath, "sampledata", "teams-sample.json");
            this.Load();

        }

        private bool AlreadyDrawn(List<Draw> draws, Team team)
        {
            var teamAlreadyDrawn = false;
            foreach (var draw in draws)
            {
                if (draw.Team1 == team || draw.Team2 == team)
                {
                    teamAlreadyDrawn = true;
                    break;
                }
            }

            return teamAlreadyDrawn;
        }
    }
}