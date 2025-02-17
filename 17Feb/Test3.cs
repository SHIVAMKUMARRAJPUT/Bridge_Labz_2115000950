using System;

class Test3{
    public static void Print(){
        Pair<int, string> pair = new Pair<int, string>(1, "One");
        Console.WriteLine("Key: " + pair.GetKey() + ", Value: " + pair.GetValue());
    }

    class Pair<T1, T2>{
        private T1 key;
        private T2 value;

        public Pair(T1 key, T2 value){
            this.key = key;
            this.value = value;
        }

        public T1 GetKey(){
            return key;
        }

        public T2 GetValue() {
            return value;
        }
    }
}
