using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ćwiczenie4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] tab = { 4, 8, 5, 9, 13, 5, 3, 1 };

            SortowanieWstaw(tab);

            Console.WriteLine("Posortowana tablica:");
            WypiszTablice(tab);

            Console.ReadKey();
        }
        static void SortowanieWstaw(int[] tab)
        {
            int n = tab.Length;

            for (int i = 1; i < n; i++) 
            {
                int aktualnyElem = tab[i];
                int j = i - 1;

                while(j >= 0 && tab[j] > aktualnyElem)
                {
                    tab[j + 1] = tab[j];
                    j--;
                }

                tab[j + 1] = aktualnyElem;
            }
        }
        static void WypiszTablice(int[] tablica)
        {
            for (int i = 0; i < tablica.Length; i++)
            {
                Console.Write(tablica[i] + " ");
            }
            Console.WriteLine();
        }
    }
}
