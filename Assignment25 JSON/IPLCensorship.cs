using System;
using System.Collections.Generic;
using System.IO;
using Newtonsoft.Json;
using System.Linq;

class IPLCensorship
{
    public static void Print()
    {
        string jsonInputPath = "ipl_data.json";
        string csvInputPath = "ipl_data.csv";
        string jsonOutputPath = "ipl_data_censored.json";
        string csvOutputPath = "ipl_data_censored.csv";

        CreateSampleFiles(jsonInputPath, csvInputPath);

        // Process JSON
        if (File.Exists(jsonInputPath))
        {
            var matches = JsonConvert.DeserializeObject<List<Match>>(File.ReadAllText(jsonInputPath));
            matches.ForEach(CensorMatch);
            File.WriteAllText(jsonOutputPath, JsonConvert.SerializeObject(matches, Formatting.Indented));
            Console.WriteLine($"Censored JSON saved: {jsonOutputPath}");
        }

        // Process CSV
        if (File.Exists(csvInputPath))
        {
            var lines = File.ReadAllLines(csvInputPath).ToList();
            for (int i = 1; i < lines.Count; i++) // Skip header row
            {
                var columns = lines[i].Split(',');
                columns[1] = CensorTeamName(columns[1]); // team1
                columns[2] = CensorTeamName(columns[2]); // team2
                columns[5] = CensorTeamName(columns[5]); // winner
                columns[6] = "REDACTED"; // player_of_match
                lines[i] = string.Join(",", columns);
            }
            File.WriteAllLines(csvOutputPath, lines);
            Console.WriteLine($"Censored CSV saved: {csvOutputPath}");
        }
    }

    // Function to create sample JSON and CSV files if they do not exist
    static void CreateSampleFiles(string jsonPath, string csvPath)
    {
        if (!File.Exists(jsonPath))
        {
            var sampleJson = new List<Match>
            {
                new Match { match_id = 101, team1 = "Mumbai Indians", team2 = "Chennai Super Kings", score = new Dictionary<string, int> { {"Mumbai Indians", 178}, {"Chennai Super Kings", 182} }, winner = "Chennai Super Kings", player_of_match = "MS Dhoni" },
                new Match { match_id = 102, team1 = "Royal Challengers Bangalore", team2 = "Delhi Capitals", score = new Dictionary<string, int> { {"Royal Challengers Bangalore", 200}, {"Delhi Capitals", 190} }, winner = "Royal Challengers Bangalore", player_of_match = "Virat Kohli" }
            };
            File.WriteAllText(jsonPath, JsonConvert.SerializeObject(sampleJson, Formatting.Indented));
            Console.WriteLine($"Sample JSON file created: {jsonPath}");
        }

        if (!File.Exists(csvPath))
        {
            var sampleCsv = "match_id,team1,team2,score_team1,score_team2,winner,player_of_match\n" +
                            "101,Mumbai Indians,Chennai Super Kings,178,182,Chennai Super Kings,MS Dhoni\n" +
                            "102,Royal Challengers Bangalore,Delhi Capitals,200,190,Royal Challengers Bangalore,Virat Kohli";
            File.WriteAllText(csvPath, sampleCsv);
            Console.WriteLine($"Sample CSV file created: {csvPath}");
        }
    }

    // Match class for JSON parsing
    class Match
    {
        public int match_id { get; set; }
        public string team1 { get; set; }
        public string team2 { get; set; }
        public Dictionary<string, int> score { get; set; }
        public string winner { get; set; }
        public string player_of_match { get; set; }
    }

    // Censor match details
    static void CensorMatch(Match match)
    {
        match.team1 = CensorTeamName(match.team1);
        match.team2 = CensorTeamName(match.team2);
        match.winner = CensorTeamName(match.winner);
        match.player_of_match = "REDACTED";

        var censoredScore = new Dictionary<string, int>();
        foreach (var entry in match.score)
        {
            censoredScore[CensorTeamName(entry.Key)] = entry.Value;
        }
        match.score = censoredScore;
    }

    // Function to censor team names
    static string CensorTeamName(string teamName)
    {
        var words = teamName.Split(' ');
        if (words.Length > 1)
            words[1] = "***";
        return string.Join(" ", words);
    }
}
