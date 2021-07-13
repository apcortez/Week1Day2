using System;

namespace Es3
{
    class Program
    {
        static void Main(string[] args)
        {
            //Espressioni condizionali
            Console.WriteLine("Inserisci un numero intero");
            int number = int.Parse(Console.ReadLine());

            if (number > 10)
            {
                Console.WriteLine("Il numero è maggiore di 10");
            }
            else
            {
                Console.WriteLine("Il numero è minore o uguale a 10");
            }

            if (number <= 10 && number >= 1)
            {
                Console.WriteLine("Il numero inserito è compreso tra 1 e 10");
            }
            else if (number <= 20 && number >= 11)
            {
                Console.WriteLine("Il numero inserito è compreso tra 11 e 20");
            }
            else {
                Console.WriteLine("Il numero è maggiore di 20");
            }
        }
    }
}
