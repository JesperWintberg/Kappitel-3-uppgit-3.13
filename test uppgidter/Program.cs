using System;

namespace ____
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hur gammal är du?");
            int ålder = int.Parse(Console.ReadLine());

            if (ålder > 19)
            {
                Console.WriteLine("Du får tyvär inte vara med");
            }

            else if (ålder < 16)
            {
                Console.WriteLine("Du får tyvär inte vara med");
            }

            else
            {
                Console.WriteLine("Du får vara med");  
            }



        }
    }
}


