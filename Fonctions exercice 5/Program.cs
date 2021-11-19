using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fonctions_exercice_5
{
    class Program
    {
        static int abs(int n)
        {
            if (n < 0)
            {
                return -n;
            }
            else
            {
                return n;
            }
        }
        static void Main(string[] args)
        {
            int valeur;

            Console.WriteLine("saisir une valeur =");
            valeur = int.Parse(Console.ReadLine());
            Console.WriteLine("Sa valeur absolue est ="+ abs(valeur));
            Console.ReadLine();

        }
    }
}
