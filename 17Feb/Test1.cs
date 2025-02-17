using System;
class Test1{
    public static void Print() {
        GenericClass<int> intObj = new GenericClass<int>(10);
        GenericClass<string> stringObj = new GenericClass<string>("Hello");
        GenericClass<double> doubleObj = new GenericClass<double>(3.14);

        Console.WriteLine("Integer Value: " + intObj.GetValue());
        Console.WriteLine("String Value: " + stringObj.GetValue());
        Console.WriteLine("Double Value: " + doubleObj.GetValue());
    }

    class GenericClass<T> {
        private T data;

        public GenericClass(T value){
            data = value;
        }

        public T GetValue() {
            return data;
        }
    }
}
