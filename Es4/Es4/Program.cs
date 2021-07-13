using System;

namespace Es4
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = 10;
            for (int i = 0; i < n; i++)
            {
                Console.WriteLine($"Valore: {i}");
            }

            //Se non si sanno quante iterazioni fare e c'è una condizione --> While
            Console.WriteLine("Inserisci un numero maggiore di 10");
            int num = int.Parse(Console.ReadLine());
            while (num < 10) 
            {
                Console.WriteLine("Errore! Inserisci un numero maggiore di 10");
                num = int.Parse(Console.ReadLine());
                
            }


            //entra almeno una volta nel do
            int num1;
            do
            {
                Console.WriteLine("Inserisci un numero maggiore di 5");
                 num1 = int.Parse(Console.ReadLine());

            }
            while (num1<5);
        }
    }
}
