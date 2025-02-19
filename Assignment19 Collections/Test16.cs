using System;
using System.Collections.Generic;

class InsurancePolicy
{
    public string PolicyNumber { get; set; }
    public string CoverageType { get; set; }
    public DateTime ExpiryDate { get; set; }

    public override bool Equals(object obj)
    {
        if (obj is InsurancePolicy policy)
        {
            return PolicyNumber == policy.PolicyNumber;
        }
        return false;
    }

    public override int GetHashCode()
    {
        return PolicyNumber.GetHashCode();
    }
}

class Test16
{
    private HashSet<InsurancePolicy> policySet = new HashSet<InsurancePolicy>();
    private LinkedList<InsurancePolicy> orderedPolicies = new LinkedList<InsurancePolicy>();
    private SortedSet<InsurancePolicy> sortedPolicies = new SortedSet<InsurancePolicy>(Comparer<InsurancePolicy>.Create((a, b) => a.ExpiryDate.CompareTo(b.ExpiryDate)));

    public void AddPolicy(InsurancePolicy policy)
    {
        if (!policySet.Contains(policy))
        {
            policySet.Add(policy);
            orderedPolicies.AddLast(policy);
            sortedPolicies.Add(policy);
        }
    }

    public void print()
    {
        Console.WriteLine("All Unique Policies:");
        foreach (var policy in policySet)
        {
            Console.WriteLine($"Policy Number: {policy.PolicyNumber}, Coverage: {policy.CoverageType}, Expiry: {policy.ExpiryDate.ToShortDateString()}");
        }
    }

    public static void Print()
    {
        Test16 system = new Test16();
        system.AddPolicy(new InsurancePolicy { PolicyNumber = "P100", CoverageType = "Health", ExpiryDate = DateTime.Now.AddDays(20) });
        system.AddPolicy(new InsurancePolicy { PolicyNumber = "P200", CoverageType = "Auto", ExpiryDate = DateTime.Now.AddDays(40) });

        system.print();
    }
}
