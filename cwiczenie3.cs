using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ćwiczenie3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] tab = { 5, 1, 21, 16, 27, 3, 6, 9, 14 };
            SortowanieBabelkowe(tab);

            Console.WriteLine("Posortowana tablica: ");
            WypiszTab(tab);

            Console.ReadKey();
        }

        static void SortowanieBabelkowe(int[] tab)
        {
            int n = tab.Length;
            bool czyZamiana;

            for (int i = 0; i < n; i++) 
            {
                czyZamiana = true;

                for (int j = 0; j < n - 1 - i; j++) 
                {
                    if (tab[j] > tab[j + 1])
                    {
                        ZamienElem(tab, j, j + 1);
                        czyZamiana = true;
                    }
                }
                if (!czyZamiana)
                    break;
            }
        }
        static void ZamienElem(int[] tab,int indeks1, int  indeks2)
        {
            int temp = tab[indeks1];
            tab[indeks1] = tab[indeks2];
            tab[indeks2] = temp;
        }
        static void WypiszTab(int[] tab) 
        {
            for (int i = 0;i < tab.Length;i++) 
            {
                Console.WriteLine(tab[i] + " ");
            }
            Console.WriteLine();
        }
    }
}
