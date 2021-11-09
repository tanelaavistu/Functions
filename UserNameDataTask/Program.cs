using System;

namespace UserNameDataTask
{
    class Program
    {
        static void Main(string[] args)
        {
            //programm küsib kasutajal sisestada eesnime
            //programm küsib kasutajal sisestada numbrid 1-3
            //kui kasutaja sisestab '1', siis kuvatakse eesnime tagurpidi
            //kui kasutaja sisestab '2', siis kuvatakse kasutaja eesnime esimest tähte
            //kui kasutaja sisestab '3', siis kuvatakse kasutaja eesnime pikkust
            Console.WriteLine("Sisesta oma eesnimi:");
            string userName = Console.ReadLine();
            Algus:
            Console.WriteLine("Sisesta valik 1-3:");
            char userChoice = Convert.ToChar(Console.ReadLine());
            switch (userChoice)
            {
                case '1':
                    ResultNum(userName);
                    break;
                case '2':
                    ResultFirst(userName);
                    break;
                case '3':
                    ResultBack(userName);
                    break;
                default:
                    Console.WriteLine("Vale väärtus!");
                    goto Algus;
            }


        }
        public static void ResultNum(string userInput)
        {
            Console.WriteLine($"Sinu eesnimes on {userInput.Length} sümbolit.");
        }
        public static void ResultFirst(string userInput)
        {
            Console.WriteLine($"Sinu eesnime esimene täht on {userInput[0]}");
        }
        public static void ResultBack(string userInput)
        {
            for (int i = userInput.Length - 1; i >= 0; i--)
            {
                Console.Write(userInput[i]);
            }
        }
    }
    }
