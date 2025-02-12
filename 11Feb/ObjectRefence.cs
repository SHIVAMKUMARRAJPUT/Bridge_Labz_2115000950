using System;
class Parent {
    public void Show() {
        Console.WriteLine("Parent class method");
    }
}

class Child : Parent {
    public void Display() {
        Console.WriteLine("Child class method");
    }
}
class Program {
    static void Main() {
        // Parent obj = new Child();  // ✅ Works (Upcasting)
        // obj.Display(); // ❌ Error: Parent reference can't access child methods
        Child childObj = new Child();  // ✅ Works normally
        childObj.Show();   // ✅ Access Parent method
        childObj.Display(); // ✅ Access Child method
    }
}
