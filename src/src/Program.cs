﻿namespace src
{/*11. int type da 1 ta 4 xonali son berilgan. Shu sonni 
  birlar va o'nlar xonasidagi raqamlarni o'zaro almashtirib ekranga chiqaring.
*/
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("sonni kiriting");
            var number = Convert.ToInt32(Console.ReadLine());
            var ones = number % 10;
            var tens = number / 10 % 10;
            var hundreds = number / 100 % 10;
            var thousands = number / 1000 % 10;
            var results = ones + tens + hundreds + thousands;
            Console.WriteLine(results);
        }

    }
}