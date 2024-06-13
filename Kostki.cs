namespace RzucanieKostka
{
    public class Kostka
    {
        public int oczka;

        public static Dictionary<int, int> liczby = new Dictionary<int, int>()
        {
            {1, 0},
            {2, 0},
            {3, 0},
            {4, 0},
            {5, 0},
            {6, 0},
        };
        public Kostka()
        {
            Random rnd = new Random();
            this.oczka = rnd.Next(6)+1;
        }

        public static int SumaOczek(List<Kostka> kostkaList)
        {
            int suma = 0;
            
            foreach (Kostka kostka in kostkaList) 
            {
                liczby[kostka.oczka] += 1;
            }

            foreach (var item in liczby)
            {
                if (item.Value > 1)
                {
                    suma += (item.Value * item.Key);
                }
            }
            return suma;
        }
    }

    public class Program
    {
        public static void Main(string[] args)
        {
            List<Kostka> kostki = new List<Kostka>();
            int ilosc_kostek = 0;

            Console.WriteLine("Podaj ilość kostek");
            do
            {           
                ilosc_kostek = Int32.Parse(Console.ReadLine());
            } while (ilosc_kostek < 3 || ilosc_kostek > 10);


            for (int i = 0; i < ilosc_kostek; i++)
            {
                kostki.Add(new Kostka());
            }

            for(int i = 0;i < ilosc_kostek; i++)
            {
                Console.WriteLine($"Kostka {i + 1}: {kostki[i].oczka}");
            }

            Console.WriteLine($"Liczba uzyskanych punnktów: {Kostka.SumaOczek(kostki)}");
        }
    }
}