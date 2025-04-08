
using System;
class Program
{
    static void Main(string[] args)
    {  
        Console.Write("Give me one number: ");
        string number = Console.ReadLine();
        int parsednumber = int.Parse(number); 
        Console.WriteLine($"your number,  {parsednumber}!");
        Console.Write("Give me second number: ");
        string number2 = Console.ReadLine();
        int parsednumber2 = int.Parse(number2);
        Console.WriteLine($"your number,  {parsednumber2}!");
        Console.WriteLine($"Sume,  {parsednumber + parsednumber2}!");
    }
}