using System;

namespace Es3
{
    class Program
    {
        static void Main(string[] args)
        {
            //Casting
            int a = 2;
            long b = a; //cast implicito

            int c;
            long d = 9999999999;
            //c = d; dà errore! c'è bisogno di un casting esplicito --> da un contenitore grande a un contenitore più piccolo --> potenziale perdita di informazione
            c = (int)d;
            //possibilità di utilizzare .Convert per numeri piccoli ma dà errore per numeri grandi (exception)
            Console.WriteLine(c);

            string s = "123";
            //int n = (int)s; non si può fare il casting diretto tra un intero e una string e viceversa. C'è bisogno di un converter.
            int n = int.Parse(s);
            //int n = Convert.ToInt32(s);
            Console.WriteLine(n);


            string s1 = "3.89";
            //double m = double.Parse(s1);
            double m = Convert.ToDouble(s1);
            Console.WriteLine($"String to double {m}");


            Genere gen = Genere.femmina;
            int f = (int)gen;
            int m1 = 1;
            Genere gen1 = (Genere)m1;
        }
    }

    enum Genere
    {   //se non metto l'assegnazione parte da 0
        maschio = 1,
        femmina = 2
    }
}
