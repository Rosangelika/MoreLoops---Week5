using System;

namespace DiceGame
{
    class Program
    {
        static void Main(string[] args)
        {
            //mängus osaleb kaks mängijat - arvuti (cpu) ja kasutaja (user);
            //mõlemad mängijad viskavad täringuid; 
            //programm kontrollib, kumb mängija viskas rohkem;
            //mängija, kes viskab rohkem on mängu võitja;
            //*täringuid visatakse kolm korda;
            //programm kuulutab võitjat.

            Random rnd = new Random();

            //arvuti vise
            int cpuRandom = 0;
            //kasutaja vise
            int userRandom = 0;

            //int cpuScore = 0;
            //int userScore = 0;

            int i = 0;
            int usersum = 0;
            int cpusum = 0;


            while (i < 3)
            {
                //arvuti vise
                cpuRandom = rnd.Next(1, 7);
                //kasutaja vise
                userRandom = rnd.Next(1, 7);

                cpusum = cpusum + cpuRandom;
                usersum = usersum + userRandom;

                /* if (cpuRandom < userRandom)
                {
                    userScore = userScore + 1;
                }
                else if (userRandom < cpuRandom)
                {
                    cpuScore = cpuScore + 1;
                }
                else if (userRandom == cpuRandom)
                {
                    userScore = userScore + 1;
                    cpuScore = cpuScore + 1;
                } */

                
                i++;
                Console.WriteLine($"Arvuti viskas {cpuRandom}. Kasutja viskas {userRandom}");
            }



            if (cpusum < usersum)
            {
                Console.WriteLine("Kasutaja on mängu võitnud. Palju õnne!");
                
            }
            else if (usersum < cpusum)
            {
                Console.WriteLine("Arvuti on mängu võitnud. Palju õnne!");
               
            }
            else if (usersum == cpusum)
            {
                Console.WriteLine("Viik!");
            }

            Console.WriteLine($"cpuScore is: {cpusum} && userScore: {usersum}");


        }
    }
}
