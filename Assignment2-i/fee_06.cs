class fee_06
{
    public static void discount(){
        int fee = 125000;
        int discountPercent = 10;
        int discount = (fee * discountPercent) / 100;
        int finalFee = fee - discount;
        
        Console.WriteLine($"The discount amount is INR {discount} and final discounted fee is INR {finalFee}");
    }

}