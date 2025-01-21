class staticto static {
    static void Method1() {
        Method2(); // Direct call
        Example.Method2(); // Using class name
    }
    static void Method2() {
        Console.WriteLine("Static Method 2");
    }
}

