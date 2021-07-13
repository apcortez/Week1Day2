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
        }
    }
}
