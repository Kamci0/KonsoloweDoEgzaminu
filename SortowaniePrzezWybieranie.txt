namespace czerwiec2021
{
    public class Sortowanie
    {
        public int[] tablicaDoPosortowania = new int[10];

        public int WartoscMaksymalna(int[] tablicaDoSzukania)
        {
            int max = tablicaDoSzukania[0];

            for (int i = 1; i < tablicaDoSzukania.Length; i++)
            {
                if (tablicaDoSzukania [i] > max){
                    max = tablicaDoSzukania[i];
                }
            }
                return max;
        }

        public void SortowanieTablicyPrzezWybieranie()
        {
           for(int i = 0 ; i < tablicaDoPosortowania.Length ; i++)
            {
                int minIndex = i;
                for (int j = i ; j <tablicaDoPosortowania.Length ; j++)
                {
                    if(tablicaDoPosortowania[j] < tablicaDoPosortowania[minIndex]) 
                    { 
                        minIndex = j;
                    }
                }

                (tablicaDoPosortowania[minIndex], tablicaDoPosortowania[i]) = (tablicaDoPosortowania[i], tablicaDoPosortowania[minIndex]);
            }
        }
    }

    public class SortowaniePrzezWybieranie
    {
         public static void Main(string[] args)
        {
            Sortowanie sortowanie = new();

            Console.WriteLine("Wpisz kolejne elementy tablicy");

            for (int i = 0; i < sortowanie.tablicaDoPosortowania.Length; i++)
            {
                sortowanie.tablicaDoPosortowania[i] = Int32.Parse(Console.ReadLine());
            }


            Console.WriteLine("Wpisana nieposotrowana tablica:");
            foreach (int element in sortowanie.tablicaDoPosortowania)
            {
                Console.Write($"{element}, ");
            }
            Console.WriteLine();

            Console.WriteLine($"Maksymalna wartość w tablicy: {sortowanie.WartoscMaksymalna(sortowanie.tablicaDoPosortowania)}");

            sortowanie.SortowanieTablicyPrzezWybieranie();

            Console.WriteLine("Wpisana tablica po sortowaniu:");
            foreach (int element in sortowanie.tablicaDoPosortowania)
            {
                Console.Write($"{element}, ");
            }
            Console.WriteLine();
        }
    }

}