using System;
using System.Collections.Generic;

class Test19
{
    private Dictionary<int, double> accountBalances = new Dictionary<int, double>();
    private SortedDictionary<int, double> sortedBalances = new SortedDictionary<int, double>();
    private Queue<int> withdrawalQueue = new Queue<int>();

    public void AddAccount(int accountId, double balance)
    {
        accountBalances[accountId] = balance;
        sortedBalances[accountId] = balance;
    }

    public void RequestWithdrawal(int accountId)
    {
        if (accountBalances.ContainsKey(accountId))
        {
            withdrawalQueue.Enqueue(accountId);
        }
    }

    public void print()
    {
        Console.WriteLine("Bank Accounts Sorted by Balance:");
        foreach (var entry in sortedBalances)
        {
            Console.WriteLine($"Account: {entry.Key}, Balance: Rs. {entry.Value}");
        }
    }

    public static void Print()
    {
        Test19 banking = new Test19();
        banking.AddAccount(101, 5000);
        banking.AddAccount(102, 3000);
        banking.RequestWithdrawal(101);

        banking.print();
    }
}
