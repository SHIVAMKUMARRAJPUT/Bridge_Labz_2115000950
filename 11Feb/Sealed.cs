class BaseClass  
{  
    public virtual void Show()  
    {  
        Console.WriteLine("Base Class Method");  
    }  
}  

class DerivedClass : BaseClass  
{  
    public sealed override void Show()  
    {  
        Console.WriteLine("Sealed Method in Derived Class");  
    }  
}  

class AnotherClass : DerivedClass  
{  
    // public override void Show() ❌ (Error: Cannot override sealed method)  
}  
