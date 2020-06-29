using System;

namespace HomeWork___Indexator_s
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] array = new int[10];
            for(int i = 0; i < 10; i++)
            {
                Console.Write("Please, enter ");Console.Write(i + 1);Console.WriteLine(" number");
                array[i] = int.Parse(Console.ReadLine());
            }
            for (int i = 0; i < 10; i++)
            {
                Console.WriteLine(i); 
            }
        }
    }
}
