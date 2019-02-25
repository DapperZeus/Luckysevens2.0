using System;

namespace LuckySevens
{
    class Program
    {
        static void Main(string[] args)
        {
             int numberSevens = 0;
            Random rng = new Random();

            int dice1;
            int dice2;

            for (int i = 1; i <= 100; i++)
            {
                dice1 = rng.Next(1, 7);
                dice2 = rng.Next(1, 7);

                if (dice1 + dice2 == 7)
                numberSevens++;
            }

            Console.WriteLine("We rolled 100 times. Out of that 100 times, you rolled {0} sevens", numberSevens);
        }
    }
}
