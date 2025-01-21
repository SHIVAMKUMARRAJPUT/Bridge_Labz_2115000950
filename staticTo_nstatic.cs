class staticTo_nstatic {
    void NonStaticMethod() {
        Console.WriteLine("Non-Static Method");
    }
    static void StaticMethod() {
        Example obj = new Example();
        obj.NonStaticMethod(); // Calling non-static method using object
    }
}
