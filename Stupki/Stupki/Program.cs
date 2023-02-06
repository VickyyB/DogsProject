using System;

namespace Stupki
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();

            int obshtoStupki = 0;
            bool postignaCel = false;

            while (input != "Going home")
            {
                int stupki = int.Parse(input);
                obshtoStupki += stupki;

                if (obshtoStupki >= 10000)
                {
                    postignaCel = true;
                    break;
                }

                input = Console.ReadLine();
            }

            if (postignaCel)
            {
                int povecheStupki = obshtoStupki - 10000;

                Console.WriteLine("Goal reached! Good job!");
                Console.WriteLine($"{povecheStupki} steps over the goal!");
            }
            else
            {
                int additionalStupki = int.Parse(Console.ReadLine());
                obshtoStupki += additionalStupki;

                if (obshtoStupki >= 10000)
                {
                    int povecheStupki = obshtoStupki - 10000;

                    Console.WriteLine("Goal reached! Good job!");
                    Console.WriteLine($"{povecheStupki} steps over the goal!");
                }
                else
                {
                    int stepsToGoal = 10000 - obshtoStupki;
                    Console.WriteLine($"{stepsToGoal} more steps to reach goal.");
                }
            }
        }
    }
}
