class prob_04{
    public static void isPrime(){
        Console.Write("Enter a number greater than 1: ");
        int num = Convert.ToInt32(Console.ReadLine());
        if (num <= 1){
            Console.WriteLine("Prime numbers are greater than 1.");
            return;
        }
        bool isPrime = true;
        for (int i = 2; i < num; i++){
            if (num % i == 0){
                isPrime = false;
                break; 
            }
        }
        if (isPrime){
            Console.WriteLine($"{num} is a Prime Number.");
        }else{
            Console.WriteLine($"{num} is NOT a Prime Number.");
        }
    }

}