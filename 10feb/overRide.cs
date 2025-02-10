using System;
// TYPE #1
class Parent{
    public virtual void Show() // ✅ Virtual method
    {
        Console.WriteLine("Parent Show()");
    }
}
class Child : Parent{
    public override void Show() // ✅ Overriding the method
    {
        Console.WriteLine("Child Show()");
    }
}

class overRide{
    static void Main(){
        Parent obj = new Child();
        obj.Show(); // Output: Child Show()
    }
}



// TYPE #2
// class Parent
// {
//     public void Show() // ❌ Not virtual, cannot override
//     {
//         Console.WriteLine("Parent Show()");
//     }
// }

// class Child : Parent
// {
//     public override void Show() // ❌ ERROR: No virtual method to override
//     {
//         Console.WriteLine("Child Show()");
//     }
// }





// TYPE #3
// class Parent
// {
//     public void Show() // Not virtual
//     {
//         Console.WriteLine("Parent Show()");
//     }
// }

// class Child : Parent
// {
//     public void Show() // Hides the Parent's Show() method
        // it have different method in child class than the parent class
//     {
//         Console.WriteLine("Child Show()");
//     }
// }

// class Program
// {
//     static void Main()
//     {
//         Parent obj1 = new Parent();
//         obj1.Show(); // Output: Parent Show()

//         Child obj2 = new Child();
//         obj2.Show(); // Output: Child Show()

//         Parent obj3 = new Child();
//         obj3.Show(); // Output: Parent Show() (Method hiding, no polymorphism)
//     }
// }
