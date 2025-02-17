using System;
using System.Collections.Generic;

class Test2{
    public static void Print(){
        GenericList<int> numbers = new GenericList<int>();
        numbers.Add(1);
        numbers.Add(2);
        numbers.Add(3);

        Console.WriteLine("Stored Integers:");
        numbers.Display();
    }

    class GenericList<T>{
        private List<T> items = new List<T>();

        public void Add(T item) {
            items.Add(item);
        }

        public void Display() {
            foreach (T item in items){
                Console.WriteLine(item);
            }
        }
    }
}
