namespace czerwiec2023
{
    public class SitoEratostenesa
    {
        public void WypelnienieTablicy(bool[] tablicaWszystkieLiczby)
        {
            for (int i = 0; i < tablicaWszystkieLiczby.Length; i++)
            {
                tablicaWszystkieLiczby[i] = true;
            }
        }

        public void Sito(bool[] tablicaWszystkieLiczby)
        {
            for(int i = 0 ; i < Math.Sqrt(tablicaWszystkieLiczby.Length) ; i++)
            {
                if (i <= 1)
                {
                    tablicaWszystkieLiczby[i] = false;
                }
                else
                {
                    if (tablicaWszystkieLiczby[i])
                    {
                        for (int j = i*i ; j < tablicaWszystkieLiczby.Length; j += i)
                        {
                            tablicaWszystkieLiczby[j] = false;
                        }
                    }
                }              
            }
        }
    }

    public class Program
    {
        public static void Main(string[] args)
        {
            bool[] tablicaLiczb = new bool[100];
            
            SitoEratostenesa sitoEratostenesa = new();

            sitoEratostenesa.WypelnienieTablicy(tablicaLiczb);

            sitoEratostenesa.Sito(tablicaLiczb);

            for (int i = 0 ; i < tablicaLiczb.Length; i++)
            {
                if (tablicaLiczb[i])
                {
                    Console.Write($"{i}, ");
                }
            }
        }
    }
}