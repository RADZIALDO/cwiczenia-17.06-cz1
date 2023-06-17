using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ćwiczenie5
{
    internal class Program
    {
        static void Main()
        {
            int[] tab = { 5,1,6,9,3,12,20,7 };

            SortowanieWyb(tab);

            Console.WriteLine("Posortowana tablica:");
            WypiszTab(tab);

            Console.ReadKey();
        }

        static void SortowanieWyb(int[] tab)
        {
            int n = tab.Length;

            for (int i = 0; i < n - 1; i++)
            {
                int indeksMinimum = i;

                for (int j = i + 1; j < n; j++)
                {
                    if (tab[j] < tab[indeksMinimum])
                    {
                        indeksMinimum = j;
                    }
                }

                if (indeksMinimum != i)
                {
                    ZamienElem(tab, i, indeksMinimum);
                }
            }
        }

        static void ZamienElem(int[] tab, int indeks1, int indeks2)
        {
            int temp = tab[indeks1];
            tab[indeks1] = tab[indeks2];
            tab[indeks2] = temp;
        }

        static void WypiszTab(int[] tab)
        {
            for (int i = 0; i < tab.Length; i++)
            {
                Console.Write(tab[i] + " ");
            }
            Console.WriteLine();
        }
    }
}
