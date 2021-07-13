using System;

namespace Esercitazione1
{
    class Program
    {
        static void Main(string[] args)
        {
            //Scrivere un programma che consente all'utente di inserire due numeri,
            //scegliere che operazione compiere tra i due numeri e stampare il risultato.
            //A questo punto, l'utente deve poter ricominciare dall'inserimento dei numeri,
            //finchè non sceglie di uscire.
            bool scelta;
            double risultato =0;
            do
            {
                Console.WriteLine("Scegliere due numeri");
                Console.WriteLine("Scegli il primo numero: ");
                int n1 = int.Parse(Console.ReadLine());
                Console.WriteLine("Segli il secondo numero: ");
                int n2 = int.Parse(Console.ReadLine());
                Console.WriteLine("Inserisci l'operatore da utilizzare tra: + - * /");
                string operatore = Console.ReadLine();
                
                switch (operatore)
                {
                    case "+":
                        risultato = n1 + n2;
                        break;
                    case "-":
                        risultato = n1 - n2;
                        break;
                    case "*":
                        risultato = n1 * n2;
                        break;
                    case "/":
                        risultato =(double)n1 / n2;
                        break;
                    default:
                        Console.WriteLine("Operatore scelto non valido");
                        break;

                }
                Console.WriteLine($"Il risultato dell'operazione fra i due numeri è {risultato}. \t {n1}{operatore}{n2}={risultato}");
                Console.WriteLine("Vuoi continuare? true/false");
                string risp = Console.ReadLine();
                scelta = bool.Parse(risp);
            } while (scelta);

        }
    }
}
