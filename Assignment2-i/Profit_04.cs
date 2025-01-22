class Profit_04
{
     public static void profitLoss(){
        double currentPrice = 129;
        double sellingPrice = 191;
        double profit = sellingPrice - currentPrice ;
        double profitPercent = (profit / currentPrice) * 100;        
        Console.WriteLine($"The Cost Price is INR {currentPrice} and Selling Price is INR {sellingPrice }\nThe Profit is INR {profit} and the Profit Percentage is {profitPercent}");
     }
}