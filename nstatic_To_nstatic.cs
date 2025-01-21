class nstatic_To_nstatic {
    void Method1() {
        Method2(); // Direct call
        this.Method2(); // Using this
    }
    void Method2() {
        Console.WriteLine("Non-Static Method 2");
    }
}
