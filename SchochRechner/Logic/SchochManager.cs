using Newtonsoft.Json;
using SchochRechner.ObjectModel;

namespace SchochRechner.Logic
{
    public class SchochManager
    {
        private string entriesFilepath = Path.Combine(Application.StartupPath, "entries.json");
        private string teamsFilepath = Path.Combine(Application.StartupPath, "teams.json");
        private string roundFilePath = Path.Combine(Application.StartupPath, "round.json");
        private readonly string groupsFilePath = Path.Combine(Application.StartupPath, "groups.json");
        private readonly string groupRoundsFilePath = Path.Combine(Application.StartupPath, "group-rounds.json");
        private readonly List<string> groups = new() {  };
        private readonly Dictionary<string, Round> rounds = new(StringComparer.OrdinalIgnoreCase);

        public List<Entry> Entries { get; } = new();
        public List<Team> Teams { get; } = new();
        public IReadOnlyList<string> Groups => this.groups;
        public string SelectedGroupName { get; set; }
        public List<Team> CurrentTeams => this.GetTeams(this.SelectedGroupName);
        public List<Entry> CurrentEntries => this.GetEntries(this.SelectedGroupName);
        public Round Round => this.GetRound(this.SelectedGroupName);

        public List<Team> GetTeams(string groupName)
        {
            return this.Teams
                .Where(team => string.Equals(team.GroupName, groupName, StringComparison.OrdinalIgnoreCase))
                .OrderBy(team => team, new SchochComparer())
                .ToList();
        }

        public List<Entry> GetEntries(string groupName)
        {
            return this.Entries
                .Where(entry => string.Equals(entry.GroupName, groupName, StringComparison.OrdinalIgnoreCase))
                .ToList();
        }

        public Round GetRoundForGroup(string groupName)
        {
            return this.GetRound(groupName);
        }

        public void Load()
        {
            if (File.Exists(this.groupsFilePath))
            {
                var savedGroups = JsonConvert.DeserializeObject<List<string>>(File.ReadAllText(this.groupsFilePath));
                if (savedGroups != null && savedGroups.Count > 0)
                {
                    this.groups.Clear();
                    foreach (var groupName in savedGroups)
                    {
                        this.AddGroupIfMissing(groupName);
                    }
                }
            }

            if (File.Exists(this.entriesFilepath))
            {
                var content1 = File.ReadAllText(this.entriesFilepath);
                var newEntries = JsonConvert.DeserializeObject<List<Entry>>(content1);
                if (newEntries != null)
                {
                    this.Entries.Clear();
                    this.Entries.AddRange(newEntries);
                }
            }

            if (File.Exists(this.teamsFilepath))
            {
                var content2 = File.ReadAllText(this.teamsFilepath);
                var newTeams = JsonConvert.DeserializeObject<List<Team>>(content2);
                if (newTeams != null)
                {
                    this.Teams.Clear();
                    this.Teams.AddRange(newTeams);
                    foreach (var team in this.Teams)
                    {
                        team.GroupName = string.IsNullOrWhiteSpace(team.GroupName) ? "Allgemein" : team.GroupName;
                        this.AddGroupIfMissing(team.GroupName);
                    }
                }
            }

            foreach (var entry in this.Entries)
            {
                entry.GroupName = string.IsNullOrWhiteSpace(entry.GroupName) ? "Allgemein" : entry.GroupName;
                this.AddGroupIfMissing(entry.GroupName);
            }

            if (File.Exists(this.roundFilePath))
            {
                var content3 = File.ReadAllText(this.roundFilePath);
                var newRound = JsonConvert.DeserializeObject<Round>(content3);
                if (newRound != null)
                {
                    if (this.groups.Contains("Allgemein", StringComparer.OrdinalIgnoreCase))
                    {
                        var defaultRound = this.GetRound("Allgemein");
                        defaultRound.RoundActual = newRound.RoundActual;
                        defaultRound.Draws.AddRange(newRound.Draws);
                        this.FixTeamReferences(defaultRound, "Allgemein");
                    }
                }
            }

            if (File.Exists(this.groupRoundsFilePath))
            {
                var savedRounds = JsonConvert.DeserializeObject<Dictionary<string, Round>>(File.ReadAllText(this.groupRoundsFilePath));
                if (savedRounds != null)
                {
                    foreach (var groupRound in savedRounds)
                    {
                        this.AddGroupIfMissing(groupRound.Key);
                        this.rounds[groupRound.Key] = groupRound.Value;
                        this.FixTeamReferences(groupRound.Value, groupRound.Key);
                    }
                }
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

            if (File.Exists(this.roundFilePath))
            {
                var newFilePath = Path.Combine(Application.StartupPath, "round-" + suffix + ".json");
                if (!File.Exists(newFilePath))
                {
                    File.Move(this.roundFilePath, newFilePath);
                }
            }

            if (File.Exists(this.groupsFilePath))
            {
                var newFilePath = Path.Combine(Application.StartupPath, "groups-" + suffix + ".json");
                if (!File.Exists(newFilePath))
                {
                    File.Move(this.groupsFilePath, newFilePath);
                }
            }

            if (File.Exists(this.groupRoundsFilePath))
            {
                var newFilePath = Path.Combine(Application.StartupPath, "group-rounds-" + suffix + ".json");
                if (!File.Exists(newFilePath))
                {
                    File.Move(this.groupRoundsFilePath, newFilePath);
                }
            }

            var content1 = JsonConvert.SerializeObject(this.Entries, Formatting.Indented);
            File.WriteAllText(this.entriesFilepath, content1);

            var content2 = JsonConvert.SerializeObject(this.Teams, Formatting.Indented);
            File.WriteAllText(this.teamsFilepath, content2);

            var defaultRound = this.groups.Contains("Allgemein", StringComparer.OrdinalIgnoreCase)
                ? this.GetRound("Allgemein")
                : new Round();
            var content3 = JsonConvert.SerializeObject(defaultRound, Formatting.Indented);
            File.WriteAllText(this.roundFilePath, content3);

            File.WriteAllText(this.groupsFilePath, JsonConvert.SerializeObject(this.groups, Formatting.Indented));
            File.WriteAllText(this.groupRoundsFilePath, JsonConvert.SerializeObject(this.rounds, Formatting.Indented));
        }

        public void AddGroup(string groupName)
        {
            groupName = groupName?.Trim() ?? string.Empty;
            if (string.IsNullOrWhiteSpace(groupName))
            {
                throw new ArgumentException("Der Gruppenname darf nicht leer sein.", nameof(groupName));
            }

            if (this.groups.Any(existing => string.Equals(existing, groupName, StringComparison.OrdinalIgnoreCase)))
            {
                throw new ArgumentException("Diese Gruppe existiert bereits.", nameof(groupName));
            }

            this.groups.Add(groupName);
            this.GetRound(groupName);
        }

        public void SelectGroup(string groupName)
        {
            if (!this.groups.Any(existing => string.Equals(existing, groupName, StringComparison.OrdinalIgnoreCase)))
            {
                throw new ArgumentException("Die ausgewählte Gruppe existiert nicht.", nameof(groupName));
            }

            this.SelectedGroupName = this.groups.First(existing => string.Equals(existing, groupName, StringComparison.OrdinalIgnoreCase));
        }

        public void DeleteGroup(string groupName)
        {
            var groupIndex = this.groups.FindIndex(group => string.Equals(group, groupName, StringComparison.OrdinalIgnoreCase));
            if (groupIndex < 0)
            {
                throw new ArgumentException("Die zu löschende Gruppe existiert nicht.", nameof(groupName));
            }

            if (this.groups.Count == 1)
            {
                throw new InvalidOperationException("Die letzte Gruppe kann nicht gelöscht werden.");
            }

            var existingName = this.groups[groupIndex];
            this.groups.RemoveAt(groupIndex);
            this.Teams.RemoveAll(team => string.Equals(team.GroupName, existingName, StringComparison.OrdinalIgnoreCase));
            this.Entries.RemoveAll(entry => string.Equals(entry.GroupName, existingName, StringComparison.OrdinalIgnoreCase));
            this.rounds.Remove(existingName);

            if (string.Equals(this.SelectedGroupName, existingName, StringComparison.OrdinalIgnoreCase))
            {
                this.SelectedGroupName = this.groups[0];
            }
        }

        public void RenameGroup(string currentName, string newName)
        {
            newName = newName?.Trim() ?? string.Empty;
            if (string.IsNullOrWhiteSpace(newName))
            {
                throw new ArgumentException("Der Gruppenname darf nicht leer sein.", nameof(newName));
            }

            var groupIndex = this.groups.FindIndex(group => string.Equals(group, currentName, StringComparison.OrdinalIgnoreCase));
            if (groupIndex < 0)
            {
                throw new ArgumentException("Die umzubenennende Gruppe existiert nicht.", nameof(currentName));
            }

            if (this.groups.Where((_, index) => index != groupIndex)
                .Any(group => string.Equals(group, newName, StringComparison.OrdinalIgnoreCase)))
            {
                throw new ArgumentException("Diese Gruppe existiert bereits.", nameof(newName));
            }

            var oldName = this.groups[groupIndex];
            this.groups[groupIndex] = newName;
            foreach (var team in this.Teams.Where(team => string.Equals(team.GroupName, oldName, StringComparison.OrdinalIgnoreCase)))
            {
                team.GroupName = newName;
            }

            foreach (var entry in this.Entries.Where(entry => string.Equals(entry.GroupName, oldName, StringComparison.OrdinalIgnoreCase)))
            {
                entry.GroupName = newName;
            }

            var round = this.GetRound(oldName);
            this.rounds.Remove(oldName);
            this.rounds[newName] = round;

            if (string.Equals(this.SelectedGroupName, oldName, StringComparison.OrdinalIgnoreCase))
            {
                this.SelectedGroupName = newName;
            }
        }

        public void AddTeam(int id, string name)
        {
            this.AddTeam(id, name, this.SelectedGroupName);
        }

        public void AddTeam(int id, string name, string groupName)
        {
            if (this.Teams.Any(team => team.Id == id && string.Equals(team.GroupName, groupName, StringComparison.OrdinalIgnoreCase)))
            {
                throw new ArgumentException("Diese Team-ID wird in der Gruppe bereits verwendet.");
            }

            this.Teams.Add(new Team { Id = id, Name = name, GroupName = groupName });
        }

        public bool HasEntries(Team team)
        {
            return this.Entries.Any(entry => string.Equals(entry.GroupName, team.GroupName, StringComparison.OrdinalIgnoreCase)
                && (entry.Team1 == team.Id || entry.Team2 == team.Id));
        }

        public void UpdateTeam(Team team, int id, string name, string groupName)
        {
            if (this.Teams.Any(existing => existing != team && existing.Id == id
                && string.Equals(existing.GroupName, groupName, StringComparison.OrdinalIgnoreCase)))
            {
                throw new ArgumentException("Diese Team-ID wird in der Gruppe bereits verwendet.");
            }

            if (this.HasEntries(team) && team.Id != id)
            {
                throw new InvalidOperationException("Die ID eines Teams mit Resultaten kann nicht geändert werden.");
            }

            if (!string.Equals(team.GroupName, groupName, StringComparison.OrdinalIgnoreCase) && this.HasEntries(team))
            {
                throw new InvalidOperationException("Teams mit Resultaten können nicht in eine andere Gruppe verschoben werden.");
            }

            if (!string.Equals(team.GroupName, groupName, StringComparison.OrdinalIgnoreCase))
            {
                foreach (var round in this.rounds.Values)
                {
                    round.Draws.RemoveAll(draw => draw.Team1 == team || draw.Team2 == team);
                }
            }

            team.Id = id;
            team.Name = name;
            team.GroupName = groupName;
            this.AddGroupIfMissing(groupName);
        }

        public void DeleteTeam(Team team)
        {
            this.Teams.Remove(team);
        }

        public void AddEntry(Entry entry)
        {
            entry.GroupName = this.SelectedGroupName;
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
                    GroupName = this.SelectedGroupName,
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
            this.CalculateRanking(this.SelectedGroupName);
        }

        public void CalculateRanking(string groupName)
        {
            var teams = this.GetTeams(groupName);
            var entries = this.GetEntries(groupName);

            // Clear all stats first
            foreach (var team in teams)
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
            foreach (var entry in entries)
            {
                var team1 = teams.Find(x => x.Id == entry.Team1);
                var team2 = teams.Find(x => x.Id == entry.Team2);

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
            foreach (var team in teams)
            {
                team.Buchholz = 0;
                foreach (var opp in team.Opponents)
                {
                    var oppTeam = teams.Find(x => x.Id == opp);
                    if (oppTeam != null)
                    {
                        team.Buchholz += oppTeam.GamesWon;
                    }
                }
            }

            // Calculate FBHZ
            foreach (var team in teams)
            {
                team.Feinbuchholz = 0;
                foreach (var opp in team.Opponents)
                {
                    var oppTeam = teams.Find(x => x.Id == opp);
                    if (oppTeam != null)
                    {
                        team.Feinbuchholz += oppTeam.Buchholz;
                    }
                }
            }

            teams.Sort(new SchochComparer());
        }

        public void CreateDraw(int roundNumber)
        {
            this.Round.RoundActual = roundNumber;
            this.Round.Draws.Clear();
            var teams = this.CurrentTeams;

            var team1Index = 0;
            var team2Index = 0;
            var loopDetector2 = 1;

            while (teams.Count / 2 != this.Round.Draws.Count)
            {
                if (team1Index >= teams.Count)
                {
                    team1Index = 0;
                }

                var team1 = teams[team1Index];

                // Is this team already in the draw?
                if (this.AlreadyDrawn(this.Round.Draws, team1))
                {
                    team1Index++;
                    continue;
                }

                if (team2Index >= teams.Count)
                {
                    team2Index = 0;
                }

                var team2 = teams[team2Index];

                var opponentFound = false;
                var loopDetector = 0;                
                while (!opponentFound)
                {
                    loopDetector++;

                    // Is already in draw or same team
                    // or is the same team
                    // or has already played against this team
                    if (this.AlreadyDrawn(this.Round.Draws, team2)
                        || team1.Id == team2.Id
                        || team1.Opponents.Contains(team2.Id))
                    {
                        team2Index++;
                        if (team2Index >= teams.Count)
                        {
                            team2Index = 0;
                        }

                        team2 = teams[team2Index];

                        if (loopDetector > 50)
                        {
                            for (var i = 0; i < loopDetector2; i++)
                            {
                                this.Round.Draws.RemoveAt(this.Round.Draws.Count - 1);
                            }

                            loopDetector = 0;
                            loopDetector2++;
                        }

                        continue;
                    }

                    opponentFound = true;
                }

                // Add draw
                team1Index++;
                this.Round.Draws.Add(new Draw { Team1 = team1, Team2 = team2 });
            }
        }

        public void CreateDrawRandom(int roundNumber)
        {
            this.Round.RoundActual = roundNumber;
            this.Round.Draws.Clear();

            var randomizedList = this.CurrentTeams;
            randomizedList.Shuffle();

            for (var i = 0; i + 1 < randomizedList.Count; i += 2)
            {
                this.Round.Draws.Add(new Draw { Team1 = randomizedList[i], Team2 = randomizedList[i + 1] });
            }
        }

        public void SetRoundNumber(int roundNumber)
        {
            this.Round.RoundActual = roundNumber;
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

        private Round GetRound(string groupName)
        {
            if (string.IsNullOrEmpty(groupName))
            {
                groupName = this.groups.First();
            }

            if (!this.rounds.TryGetValue(groupName, out var round))
            {
                round = new Round();
                this.rounds[groupName] = round;
            }

            return round;
        }

        private void AddGroupIfMissing(string? groupName)
        {
            if (!string.IsNullOrWhiteSpace(groupName)
                && !this.groups.Any(existing => string.Equals(existing, groupName, StringComparison.OrdinalIgnoreCase)))
            {
                this.groups.Add(groupName);
            }
        }

        private void FixTeamReferences(Round round, string groupName)
        {
            foreach (var draw in round.Draws)
            {
                var team1Id = draw.Team1?.Id;
                var team2Id = draw.Team2?.Id;
                draw.Team1 = team1Id.HasValue
                    ? this.Teams.FirstOrDefault(team => team.Id == team1Id && string.Equals(team.GroupName, groupName, StringComparison.OrdinalIgnoreCase))
                    : null;
                draw.Team2 = team2Id.HasValue
                    ? this.Teams.FirstOrDefault(team => team.Id == team2Id && string.Equals(team.GroupName, groupName, StringComparison.OrdinalIgnoreCase))
                    : null;
            }
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