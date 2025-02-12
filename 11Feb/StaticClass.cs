static class Parent  
{  
    public static void Show()  
    {  
        Console.WriteLine("Static Parent Class");
    }  
}  

class Child : Parent // ❌ Error: Cannot derive from static class
{  
}
