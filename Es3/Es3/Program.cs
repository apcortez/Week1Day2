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
            Console.WriteLine(c);

            string s = "123";
            //int n = (int)s; non si può fare il casting diretto tra un intero e una string e viceversa. C'è bisogno di un converter.
            int n = int.Parse(s);
            Console.WriteLine(n);
        }
    }
}
