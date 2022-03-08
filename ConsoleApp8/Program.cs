using System;

namespace ConsoleApp8
{
    class Program
    {
        static void Main(string[] args)
        {
            int num = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine(NumLength(num));
        }
        static int NumLength(int num)
        { 
        int count = 0;
        int residue = 0;
            while (num>0)
            {
                residue = num % 10;
                num /= 10;
                count++;
            }            
            return count;
        }
    }
}
