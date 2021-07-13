using System;

namespace Es2
{
    class Program
    {
        static void Main(string[] args)
        {
            bool x, y = true; //x = false in questo caso
            x = true;
            x = !y; //nega valore, x torna a false
            x = (18 > 9);

            x = true;
            y = false;
            bool z = x && y; //false
            z = x || y; //true

            int i, j;
            i = 2;
            j = i + 1; //3

            int a = 5;
            int b = 2;
            int c = a / b; //c = 2
            int r = a % b; // r = 1 

            double d = (double)a / b; //d = 2.5 = risultato con la virgola, senza casting il risultato viene solo 2

            int k = 23;
            //incremento
            //k = k + 1;
            //k++;
            k = i++; //k=3 i=3
            k = ++i; //k=3; i=4
            k += 3; //k =k+3
        }
    }
}
