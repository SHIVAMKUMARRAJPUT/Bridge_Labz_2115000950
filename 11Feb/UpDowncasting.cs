using System;
class UpDowncasting {
    public void Show() {
        Console.WriteLine("UpDowncasting class method");
    }
}

class Child : UpDowncasting {
    public void Display() {
        Console.WriteLine("Child class method");
    }
}

class Program {
    static void Main() {
        UpDowncasting obj = new Child();  // ✅ Upcasting
        Child childObj = (Child)obj;  // ✅ Downcasting (Explicit)
        
        childObj.Show();   // ✅ Access UpDowncasting method
        childObj.Display(); // ✅ Access Child method
    }
}
