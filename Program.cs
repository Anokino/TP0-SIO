using System;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Bonjour, quel est ton nom ?");
            string nom;
            nom = Console.ReadLine();
            ///Console.WriteLine("Votre nom est " + nom);

            Console.WriteLine("Et ton prénom ?");
            string prenom;
            prenom = Console.ReadLine();
            Console.WriteLine("Donc tu t'appelles " + prenom + " " + nom);

            Console.Write("Ton année de naissance ?");
            int user_annee;
            user_annee = Convert.ToInt16(Console.ReadLine());
            ///Console.WriteLine("Votre année de naissance est " + user_annee);

            int user_mois;
            Console.WriteLine("Quel est ton mois de naissance ?");
            user_mois = Convert.ToInt16(Console.ReadLine());
            ///Console.WriteLine("Votre mois de naissance est " + user_mois);

            int user_jour;
            Console.WriteLine("Et quel est ton jour de naissance ?");
            user_jour = Convert.ToInt16(Console.ReadLine());
            ///Console.WriteLine("Votre jour de naisssance est " + user_jour);




            int sys_annee = DateTime.Now.Year;
            /// Console.WriteLine(sys_annee);

            ///DateTime d2 = DateTime.Now;
            ///Console.WriteLine(d2);

            int sys_mois = DateTime.Now.Month;
            ///Console.WriteLine(sys_mois);

            int sys_jour = DateTime.Now.Day;
            ///Console.WriteLine(sys_jour);

            int age = sys_annee - user_annee;
            int age_mois = sys_mois - user_mois;
           
            if (age_mois > 0) 
           
            {
                Console.WriteLine("\n Donc tu as " + age + " ans et ton anniversaire était il y a " + age_mois + " mois!");
            }

            else

            {
                age = age - 1;
                age_mois = user_mois - sys_mois;
                Console.WriteLine("\n Donc tu as " + age + " ans et ton anniversaire va être dans " + age_mois + " mois!");
            }

        }
    }
}
