using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AnnotationProject
{
    [Universal("Is this valid class")]
    internal class MyClass:BaseUser
    {
        [Universal("Name must be 2 character long", 2)]
        public string Name;
        
        [Universal("Username must have numeric value")]
        public string Username { get; set; }

        public MyClass(string name, String username) 
        {
            Name = name;
            Username = username;
        }

        [Universal("This method is allowed to execute.")]
        public void PrintDetails()  // ✅ Must be non-static
        {
            Console.WriteLine($"Name: {Name}, Username: {Username}");
        }

        public static void StaticMethod()
        {
            Console.WriteLine("This should not be executed.");
        }


    }
}
