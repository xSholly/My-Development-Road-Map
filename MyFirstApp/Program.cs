
using System;
class Program
{
    static void Main(string[] args) 
    {
       
        int moneyspend = 0;
        int price = 99;
        int money = 100;

        while (price + moneyspend <= money)
        {
            int moneyleft = money - moneyspend;
            if (price > moneyleft)
          {
                break;
           }
           Console.WriteLine($"Moneyleft: {moneyleft}, nextprice :{price}, aftertran:{moneyleft - price}");
            moneyspend = moneyspend + price;
            price++;
        }
        Console.WriteLine($"Final Price: {price}");
        Console.WriteLine($"Sume: {moneyspend}");
        






    }   

}