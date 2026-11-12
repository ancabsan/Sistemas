namespace Base10AHexadecimal
{
    internal class Program
    {
        static void Main(string[] args)
        {
            char h1, h2, h3, h4;
            int h1n = 0, h2n = 0, h3n = 0, h4n = 0;

            Console.WriteLine("No possis números que no siguin vàlids perque et donará 0");

            Console.Write("Digit 1: ");
            h1 = Convert.ToChar(Console.ReadLine()[0]);

            Console.Write("Digit 2: ");
            h2 = Convert.ToChar(Console.ReadLine()[0]);

            Console.Write("Digit 3: ");
            h3 = Convert.ToChar(Console.ReadLine()[0]);

            Console.Write("Digit 4: ");
            h4 = Convert.ToChar(Console.ReadLine()[0]);

            if ((h1 >= 'A' && h1 <= 'F') || (h1 >= '0' && h1 <= '9'))
                h1n = caracterHexAEnter(h1);


                if ((h2 >= 'A' && h2 <= 'F') || (h2 >= '0' && h2 <= '9'))
                h2n = caracterHexAEnter(h2);


                    if ((h3 >= 'A' && h3 <= 'F') || (h3 >= '0' && h3 <= '9'))
                    h3n = caracterHexAEnter(h3);


                        if ((h4 >= 'A' && h4 <= 'F') || (h4 >= '0' && h4 <= '9'))
                        h4n = caracterHexAEnter(h4);

            Console.WriteLine($"{h1n + h2n + h3n + h4n}");
            
        }
        static int caracterHexAEnter(char d1)
        {
            // Precondició: El valor sempre serà correcte.
            int d1n = 0;

            if ((d1 >= 'A' && d1 <= 'F') || (d1 >= '0' && d1 <= 9))
                if (d1 == 'A')
                {
                    d1n = 10;
                }
                else if (d1 == 'B')
                {
                    d1n = 11;
                }
                else if (d1 == 'C')
                {
                    d1n = 12;
                }
                else if (d1 == 'D')
                {
                    d1n = 13;
                }
                else if (d1 == 'E')
                {
                    d1n = 14;
                }
                else if (d1 == 'F')
                {
                    d1n = 15;
                }
                else
                {
                    d1n = d1 - '0';
                }
            return d1n;
        }
    }
}
