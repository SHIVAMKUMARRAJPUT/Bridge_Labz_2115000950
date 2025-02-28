using System;
class CustomException:Exception{
    public CustomException(string s):base(s){

    }
}

class Program
{
    public static void Validate(int age){
        if(age<18){
            throw new CustomException("Kya be Lodee kaha 18 se kam hai tu abhi teri gaad faad di jayegi");
        }else{
            Console.WriteLine("Welcome Sir!");
        }
    }
    public static void Main(){

        int age =11;
        try{
        Validate(age);
        }catch(CustomException e){
            Console.WriteLine(e.Message);
        }
    }
}