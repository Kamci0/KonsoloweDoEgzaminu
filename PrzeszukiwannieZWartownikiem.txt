namespace czerwiec2022
{
    public class PrzeszukiwanieZWartownikiem 
    {
        public int[] tablicaDoPrzeszukiwania = new int[51];

        public PrzeszukiwanieZWartownikiem()
        {
            Random random = new();
            for (int i = 0; i < this.tablicaDoPrzeszukiwania.Length-1; i++)
            {
                this.tablicaDoPrzeszukiwania[i] = random.Next(0, 100);
            }
        }

        public int Przeszukiwanie(int szukanyElement)
        {
            int indexSzukanegoElementu = 0;
            this.tablicaDoPrzeszukiwania[50] = szukanyElement;

            for (int i = 0 ; i < tablicaDoPrzeszukiwania.Length; i++)
            {
                if (this.tablicaDoPrzeszukiwania[i] == szukanyElement)
                {
                    if(i == 50)
                    {
                        return -1;
                    }
                    indexSzukanegoElementu = i;
                    return indexSzukanegoElementu;
                }
            }
            return -1;
        }
    }


    public class Program
    {

        public static void Main(string[] args)
        {
            int szukanyElement = 0;
            int indexElementu = -1;

            Console.WriteLine("Podaj element do znalezienia w tablicy");
            szukanyElement = Int32.Parse(Console.ReadLine());

            PrzeszukiwanieZWartownikiem przeszukiwanieZWartownikiem = new();


            Console.WriteLine("Tablica, w której szukamy elementów");
            foreach(var item in przeszukiwanieZWartownikiem.tablicaDoPrzeszukiwania)
            {
                Console.Write($"{item}, ");
            }
            Console.WriteLine();


            indexElementu = przeszukiwanieZWartownikiem.Przeszukiwanie(szukanyElement);

            if(indexElementu < 0)
            {
                Console.WriteLine("Nie znaleziono elementu");
            }
            else
            {
                Console.WriteLine($"Szukany element znajduję się na indexie: {indexElementu}");
            }
        }
    }
}
