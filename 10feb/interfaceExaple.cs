using System;
interface IExample{
    void Function1();
    void Function2();
    void Function3();
    void Function4();
}

class Derived : IExample {
    public void Function1()
    {
        Console.WriteLine("Function1 implemented.");
    }
}


class interfaceExample{
    static void Main(){
        Derived obj = new Derived();
        obj.Function1();  //❌ give error beacause you have to implement all methods
        // obj.Function2();
        // obj.Function3();
        // obj.Function4();
    }
}
