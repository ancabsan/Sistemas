namespace HexadecimalABinari
{

    using System;

    namespace HexadecimalABinari
    {
        internal class Program
        {
            static void Main(string[] args)
            {
                hex2Bin();
            }

            static void hex2Bin()
            {
                char hex1, hex2;

                Console.Write("Entra un valor (0-F): ");
                string valor = Console.ReadLine() ?? "";

                if (valor.Length != 1)
                {
                    Console.WriteLine("Error");
                    return;
                }
                else
                {
                    hex1 = valor[0];

                    string bin1 = converteixABinari(hex1);

                    if (bin1 == "")
                    {
                        Console.WriteLine("Error: valor hexadecimal incorrecto");
                        return;
                    }

                    Console.Write("Entra un valor (0-F): ");
                    valor = Console.ReadLine() ?? "";

                    if (valor.Length != 1)
                    {
                        Console.WriteLine("Error");
                        return;
                    }
                    else
                    {
                        hex2 = valor[0];

                        string bin2 = converteixABinari(hex2);

                        if (bin2 == "")
                        {
                            Console.WriteLine("Error: valor hexadecimal incorrecto");
                            return;
                        }

                        Console.WriteLine(bin1);
                        Console.WriteLine(bin2);
                    }
                }
            }

            static string converteixABinari(char hex)
            {
                string res = "";
                hex = char.ToUpper(hex);

                if (hex == '0')
                    res = "0000";
                else if (hex == '1')
                    res = "0001";
                else if (hex == '2')
                    res = "0010";
                else if (hex == '3')
                    res = "0011";
                else if (hex == '4')
                    res = "0100";
                else if (hex == '5')
                    res = "0101";
                else if (hex == '6')
                    res = "0110";
                else if (hex == '7')
                    res = "0111";
                else if (hex == '8')
                    res = "1000";
                else if (hex == '9')
                    res = "1001";
                else if (hex == 'A')
                    res = "1010";
                else if (hex == 'B')
                    res = "1011";
                else if (hex == 'C')
                    res = "1100";
                else if (hex == 'D')
                    res = "1101";
                else if (hex == 'E')
                    res = "1110";
                else if (hex == 'F')
                    res = "1111";

                return res;
            }
        }
    }
}