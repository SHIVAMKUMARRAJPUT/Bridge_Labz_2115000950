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
        // **Upcasting (Implicit)**
        Parent obj = new Child();  // ✅ Upcasting (Child → Parent)
        obj.Show();  // ✅ Allowed (Parent method)
        // obj.Display(); // ❌ Not Allowed (Child method not accessible)

        // **Downcasting using 'is'**
        if (obj is Child) {
            Child childObj = (Child)obj;  // ✅ Explicit downcasting
            childObj.Display();  // ✅ Allowed
        }

        // **Downcasting using 'as'**
        Child childObj2 = obj as Child;  // ✅ Safe downcasting
        if (childObj2 != null) {
            childObj2.Display();  // ✅ Allowed
        }
    }
}
