namespace ConvertirEmmagatzematge
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double valor, bytes = 0, resultat;
            string? escala;
            bool escalaValida = true;
            Console.Write("Entra un valor: ");
            valor = Convert.ToDouble(Console.ReadLine());
            Console.Write("Entra una escala en mayús: ");
            escala = Console.ReadLine();
            
            if (escala == "KB")
            {
                bytes = 1000;
            }
            else if (escala == "MB")
            {
                bytes = Math.Pow(1000,2);
            }
            else if (escala == "GB")
            {
                bytes = Math.Pow(1000, 3);             
            }
            else if (escala == "TB")
            {
                bytes = Math.Pow(1000, 4);
            }
            else if (escala == "PB")
            {
                bytes = Math.Pow(1000, 5);  
            }
            else if (escala == "EB")
            {
                bytes = Math.Pow(1000, 6);
            }
            else
            {
                escalaValida = false;
                Console.WriteLine("Escala no vàlida");
            }

            if (escalaValida)
            {
                resultat = bytes * valor;
                Console.Write($"El valor introduït en bytes es: {resultat}");
            }
        }
    }
}
