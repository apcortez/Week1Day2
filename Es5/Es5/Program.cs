﻿using System;

namespace Es5
{
    class Program
    {
        static void Main(string[] args)
        {
            //istruzioni di salto: break, continue. return

            for (int i = 4; i >= 0; i--) 
            {
                Console.Write($"{i}\t");
            }

            Console.WriteLine("\nEsempio con continue");
            for (int i = 4; i >= 0; i--)
            {
                if (i == 2)
                {
                    continue;
                }
                else
                { 
                    Console.Write($"{i}\t");
                }
            }
        }
    }
}
