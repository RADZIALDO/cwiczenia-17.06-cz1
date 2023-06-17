using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ćwiczenie2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] tab = { 5, 1, 8, 9, 15, 12, 2, 3 };
            int najwiekszy = NajwiekszyElem(tab);
            int najmniejszy = NajmniejszyElem(tab);

            Console.WriteLine($"Największy element: {najwiekszy}");
            Console.WriteLine($"Najmniejszy element: {najmniejszy}");


            Console.ReadKey();
        }

        static int NajwiekszyElem(int[] tab)
        {
            int najwiekszy = tab[0];

            for (int i = 1; i < tab.Length; i++)
            {
                if (tab[i] > najwiekszy)
                {
                    najwiekszy = tab[i];
                }
            }
            return najwiekszy;
        }
        static int NajmniejszyElem(int[] tab)
        {
            int najmniejszy = tab[0];

            for(int i = 1;i < tab.Length; i++)
            {
                if (tab[i] < najmniejszy)
                {
                    najmniejszy = tab[i];
                }
            }
            return najmniejszy;
        }
    }
}
