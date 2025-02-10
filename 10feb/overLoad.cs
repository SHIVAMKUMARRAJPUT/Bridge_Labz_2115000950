// Method Overloading in Same Class
// as well as derived Class can be done
// in this specific way

using System;
class Parent{
    public void Show(){
        Console.WriteLine("Parent Show()");
    }
}
class Child : Parent{
    public void Show(int x) // Overloaded method in derived class
    {
        Console.WriteLine("Child Show(int)");
    }
}
class OverLoad{
    static void Main(){
        Child obj = new Child();
        obj.Show();    // Calls Parent's Show()
        obj.Show(10);  // Calls Child's Show(int)
    }
}



// class A{
//     public void Display() { } 
// }
// class B{
//     public void Display(int x) { } // 🚫 Not overloading, just a different method in another class
// }
