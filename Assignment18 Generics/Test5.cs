using System;
using System.Collections.Generic;

public abstract class JobRole
{
    public abstract string GetRoleName();
}

public class SoftwareEngineer : JobRole
{
    public override string GetRoleName() => "Software Engineer";
}

public class DataScientist : JobRole
{
    public override string GetRoleName() => "Data Scientist";
}

public class Resume<T> where T : JobRole, new()
{
    public T Job;
    public string CandidateName;
    public string Skills;

    public Resume(string candidateName, string skills)
    {
        Job = new T();
        CandidateName = candidateName;
        Skills = skills;
    }

    public void DisplayResume()
    {
        Console.WriteLine($"Candidate: {CandidateName}, Role: {Job.GetRoleName()}, Skills: {Skills}");
    }
}

public static class ResumeScreeningSystem
{
    private static List<object> screenedResumes = new List<object>();

    public static void ProcessResume<T>(Resume<T> resume) where T : JobRole, new()
    {
        screenedResumes.Add(resume);
        Console.WriteLine("Resume successfully screened.");
    }

    public static void DisplayAllResumes()
    {
        foreach (var resume in screenedResumes)
        {
            ((dynamic)resume).DisplayResume();
        }
    }
}

class Test5
{
   public static void Print()
    {
        var resume1 = new Resume<SoftwareEngineer>("SKR", "C#, .NET, SQL");
        var resume2 = new Resume<DataScientist>("JK", "Python, Machine Learning, SQL");

        ResumeScreeningSystem.ProcessResume(resume1);
        ResumeScreeningSystem.ProcessResume(resume2);

        Console.WriteLine("\nAll Screened Resumes:");
        ResumeScreeningSystem.DisplayAllResumes();
    }
}
