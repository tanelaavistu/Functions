﻿using System;

namespace UserNameData
{
    class Program
    {
        static void Main(string[] args)
        {
            //programm küsib kasutajalt eesnime
            //programm kuvab kasutaja eesnime pikkuse
            //programm kuvab kasutaja eesnime esimest tähte
            //programm kuvab kasutaja eesnime tagurpidi
            //main meetodis ei tohi olla rohkem kui kolm rida koodi
            Console.WriteLine("Sisesta oma eesnimi:");
            string userName = Console.ReadLine();
            GetUserNameData(userName);
        }

        public static void GetUserNameData(string userInput)
        {
            Console.WriteLine($"Sinu eesnimes on {userInput.Length} sümbolit.");
            Console.WriteLine($"Sinu eesnime esimene täht on {userInput[0]}");

            for (int i = userInput.Length - 1; i >= 0; i--)
            {
                Console.Write(userInput[i]);
            }
        }
    }
}
