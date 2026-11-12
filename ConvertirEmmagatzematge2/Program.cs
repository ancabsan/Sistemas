namespace ConvertirEmmagatzematge2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int valorOrigen = 12;
            string uOrigen = "MB", uDesti = "KB";
            double valorDesti = conversorUnitats(valorOrigen, uOrigen, uDesti);
            Console.WriteLine($"{valorOrigen} {uOrigen} = {valorDesti} {uDesti}");
        }
        static double conversorUnitats(double valor, string uOrigen, string uDesti)
        {
            //Precondició: uOrigen = KB,MB,GB
            //uDesti = KB,MB,GB,KiB,MiB,GiB
            Int64 resBytes = 0;
            double res = 0;

            // Baixar fins a bytes
            if (uOrigen == "KB")
            {
                resBytes = (Int64)valor * 1000;
            }
            else if(uOrigen == "MB")
            {
                resBytes = (Int64)(valor * Math.Pow(1000.0, 2.0));
            }
            else if (uOrigen == "GB")
            {
                resBytes = (Int64)(valor * Math.Pow(1000.0, 3.0));
            }

            if (uDesti == "KB")
            {
                res = resBytes / 1000.0;
            }
            else if (uDesti == "MB")
            {
                res = resBytes / 1000.0 / 1000.0;
            }
            else if (uDesti == "GB")
            {
                res = resBytes / Math.Pow(1000.0, 3);
            }
            else if (uDesti == "KiB")
            {
                res = resBytes / 1024.0;
            }
            else if (uDesti == "MiB")
            {
                res = resBytes / Math.Pow(1024.0, 2.0);
            }
            else if (uDesti == "GiB")
            {
                res = resBytes / Math.Pow(1024.0, 3.0);
            }

            return res;
        }
    }
}
