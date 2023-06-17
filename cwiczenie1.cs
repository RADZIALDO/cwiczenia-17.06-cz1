namespace Ćwiczenie1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int rozmiar = 10;
            int[] tab = new int[rozmiar];

            Random random = new Random();
            for (int i = 0; i < rozmiar; i++) 
            {
                tab[i] = random.Next(1,100);
            }

            WypiszOdTylu(tab);

            Console.ReadKey();
        }

        static void WypiszOdTylu(int[] tab)
        {
            for (int i = tab.Length - 1; i >= 0; i--) 
            {
                Console.WriteLine(tab[i]);
            }
        }
    }
}