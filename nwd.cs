namespace styczen2023
{
    public class NWD
    {
        public int wyznaczNWD(int a, int b)
        {
            while (a != b)
            {
                if (a>b)
                {
                    a = a - b;
                }
                else
                {
                    b = b - a;
                }
            }
            return a;
        }
    }
    public class Program
    {
        public static void Main(string[] args)
        {
            NWD nwd = new();
            int a = 0;
            int b = 0;

            Console.WriteLine("Podaj a: ");
            a = Int32.Parse(Console.ReadLine());
            Console.WriteLine("Podaj b: ");
            b = Int32.Parse(Console.ReadLine());

            Console.WriteLine($"Największy wspólny dzielnik liczb: {a} i {b} to {nwd.wyznaczNWD(a,b)}");
        }
    }
}