﻿using System;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Bienvenue en SIO");
            bool trouvé = true;
            int i, j;
            i = 10;
            j = 8;
            Console.WriteLine(trouvé && i<5);
            Console.WriteLine(trouvé && ! (i<5));
            Console.WriteLine(trouvé || (j==2));
            Console.WriteLine((trouvé || (i==1)) && (j==1));
            Console.WriteLine(trouvé || ((i==1) && (j==i)));






        }
    }
}
