using System;

namespace Es1
{
    class Program
    {
        static void Main(string[] args)
        {
            int age = 18;
            //age = null; dà errore

            bool y = true; //default false
            string s1 = "Hello";
            string s2 = null;
            string s3 = "";

            object obj1 = new object();
            object obj2 = null;
            object obj3 = obj1;
            //obj3 punta allo stesso spazio di obj1

            int numero = 20;
            var numero2 = 30;
            var s = "Ciao";
            //var s1 = null; dà errore perche non sa il tipo 

        }
    }
}
