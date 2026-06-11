using System;
namespace myApplication;

class Program
{
    public static void Main(string[] args)
    {
        int sum = 0;
        for (int i = 0; i <= 10; i++)
        {
            Console.WriteLine(i);
            sum += i;
        }
        Console.WriteLine("Sum of total tanural numbers : {0}",sum);
        Console.ReadLine();
    }
}

  