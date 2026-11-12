namespace ExerciciBase10ABase2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int numTemporal, numUsuari, resta1, resta2, resta3, resta4, resta5, resta6, resta7, resta8;
            Console.Write("Escriu un nombre enter: ");
            numUsuari = Convert.ToInt32(Console.ReadLine());
            numTemporal = numUsuari;
            if (numUsuari <= 255)
            {
                resta1 = numTemporal % 2;
                numTemporal = numTemporal / 2;
                resta2 = numTemporal % 2;
                numTemporal = numTemporal / 2;
                resta3 = numTemporal % 2;
                numTemporal = numTemporal / 2;
                resta4 = numTemporal % 2;
                numTemporal = numTemporal / 2;
                resta5 = numTemporal % 2;
                numTemporal = numTemporal / 2;
                resta6 = numTemporal % 2;
                numTemporal = numTemporal / 2;
                resta7 = numTemporal % 2;
                numTemporal = numTemporal / 2;
                resta8 = numTemporal % 2;
                numTemporal = numTemporal / 2;

                Console.WriteLine($"El número {numUsuari} és: " +
                    $"{resta8}{resta7}{resta6}{resta5}{resta4}{resta3}{resta2}{resta1}");
            }
            else
            {
                Console.WriteLine("El número ha de ser menor que 256");
            }

        }
    }
}
