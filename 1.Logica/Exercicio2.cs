using System.Globalization;

namespace Pratica.Logica
{
    public class Exercicio2
    {
        public void CalculaRaioCirculo()
        {
            double pi = 3.14159;
            double raioCirculo;
            double areaCirculo;

            raioCirculo = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            areaCirculo = pi * Math.Pow(raioCirculo, 2);

            Console.WriteLine("A = " + areaCirculo.ToString("F4", CultureInfo.InvariantCulture));
        }
        
    }
}
