using System;

namespace Programa_01
{
    class Program
    {
        static void Main(string[] args)
        {
            int nRandom;
            Random randomNum = new Random();
            nRandom = randomNum.Next(0, 999);
            Console.WriteLine("Random number is :{0}", nRandom);

            string evaluatation = nRandom > 500 ? "Grather  than 500" : "Less than 500";

            Console.WriteLine(evaluatation);

        }
    }
}
