using System;
using System.Collections.Generic;

class Test17
{
    private Dictionary<string, int> votes = new Dictionary<string, int>();
    private SortedDictionary<string, int> sortedVotes = new SortedDictionary<string, int>();
    private LinkedList<string> voteOrder = new LinkedList<string>();

    public void CastVote(string candidate)
    {
        if (!votes.ContainsKey(candidate))
        {
            votes[candidate] = 0;
        }
        votes[candidate]++;
        voteOrder.AddLast(candidate);
        sortedVotes[candidate] = votes[candidate];
    }

    public void print()
    {
        Console.WriteLine("Election Results:");
        foreach (var entry in sortedVotes)
        {
            Console.WriteLine($"Candidate: {entry.Key}, Votes: {entry.Value}");
        }
    }

    public static void Print()
    {
        Test17 voting = new Test17();
        voting.CastVote("Shivam");
        voting.CastVote("Ashish");
        voting.CastVote("Harshit");

        voting.print();
    }
}
