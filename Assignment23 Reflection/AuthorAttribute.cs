using System;
using System.Reflection;
[AttributeUsage(AttributeTargets.Class)]
public class AuthorAttribute : Attribute
{
    public string Name { get; }
    
    public AuthorAttribute(string name)
    {
        Name = name;
    }
}