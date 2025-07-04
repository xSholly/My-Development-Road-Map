
using System;
class Program
{
    static void Main(string[] args)
    {
       

        List<string> names = new List<string> { "Messi", "Ronaldo", "Neymar", "Lewandowski", "Zidan" };

        foreach (string name in names)
        {
            Console.WriteLine($"Hello: {name}");
        }
        Console.WriteLine("**");
        for (int i = 0; i < names.Count; i++)
        {

            if (i % 2 == 0)
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

        while (count > 0)
        {
            count--;
            Console.WriteLine($"Counting down: {count}");
        }

        Console.WriteLine($"Final: {count}");

    }   

}