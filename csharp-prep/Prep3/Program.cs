using System;
using System.Linq.Expressions;

class Program
{

    public static void Loop() {
        Console.WriteLine("Input a Random Number 1 to 10");
        Boolean cont = true;
        int randNum = new Random().Next(1, 11);
        while (cont) {
            int picked = int.Parse(Console.ReadLine());
            if (randNum == picked) {Console.WriteLine("You got it!"); break;}
            if (randNum > picked) Console.WriteLine("Higher");
            if (randNum < picked) Console.WriteLine("Lower");
        }
    }
    static void Main(string[] args)
    {
        Loop();
    }
}