namespace Mag
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string c1 = "s";
            string c2 = "s";
            string c3 = "n";
            string c4 = "n";
            int num = 0;

            if( c1 == "s")
            {
                num = 1;
            }
            if (c2 == "s")
            {
                num = num + 2;
            }
            if (c3 == "s")
            {
                num = num + 4;
            }
            if (c4 == "s")
            {
                num = num + 8;
            }

            Console.WriteLine($"Has pensat en el número ----> {num}!!!");
        }
    }
}
