
using System;
class Program
{
    static void Main(string[] args)
    {  
        //      Console.Write("Give me one number: ");
        //     string number = Console.ReadLine();
        //     float parsednumber = float.Parse(number); 
        //     Console.WriteLine($"your number,  {parsednumber}!");
        //     Console.Write("Give me second number: ");
        //     string number2 = Console.ReadLine();
        //     float parsednumber2 = float.Parse(number2);
        //     Console.WriteLine($"your number,  {parsednumber2}!");
            
        //     Console.WriteLine("Choose one of available operations [+, -,  *, /]");
        //     string operations = Console.ReadLine();
        //     Console.WriteLine($"You chosen this operation, {operations}!" );
            
        //       switch (operation)
        //     {
        //         case "+":
        //             Console.WriteLine($"Sum: {parsednumber + parsednumber2}");
        //             break;
        //         case "-":
        //             Console.WriteLine($"Sub: {parsednumber - parsednumber2}");
        //             break;
        //         case "*":
        //             Console.WriteLine($"Multiplication: {parsednumber * parsednumber2}");
        //             break;
        //         case "/":
        //             if (parsednumber2 != 0)
        //                 Console.WriteLine($"Division: {parsednumber / parsednumber2}");
        //             else
        //                 Console.WriteLine("Cannot divide by zero!");
        //             break;
        //         default:
        //             Console.WriteLine("Wrong operation provided");
        //             break;
        //   } 

        List <string> names = new List <string> { "Messi", "Ronaldo" , "Neymar" , "Lewandowski" , "Zidan"};

        foreach(string name in names )
        {
            Console.WriteLine($"Hello: {name}");
        }
        Console.WriteLine("**");
        for (int i = 0; i < names.Count; i++)
        {
             
             if(i % 2 == 0)
             {
                Console.WriteLine($"Hello: {names[i]}");
             }
        }
        
        //next lesson
        int[] multiples = new int[30];

        for (int i = 0; i < multiples.Length; i++)
        {
            multiples[i] = i * 3;
            Console.WriteLine($"Hello: {multiples[i]}");
        }

        int count = 7;

        while (count > 0 )
        {
            count--;
            Console.WriteLine($"Counting down: {count}");
        }

            Console.WriteLine($"Final: {count}");

        int sum = 0;
        int number = 1000;

        while (sum < 100)
        {
            sum = sum + number;
            number++;
        }  
        Console.WriteLine($"Sume: {number}");
        Console.WriteLine($"Sume: {sum}");
    }   

}