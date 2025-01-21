class nstaticTostatic {
    static void StaticMethod() {
        Console.WriteLine("Static Method");
    }
    void NonStaticMethod() {
        Example.StaticMethod(); // Calling static method
    }
}
