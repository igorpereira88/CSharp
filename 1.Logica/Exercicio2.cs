using System.Globalization;

namespace Pratica.Logica
{
    /*
    Faça um programa para ler o valor do raio de um círculo, e depois mostrar o valor da área deste círculo com quatro
    casas decimais conforme exemplos.
    Fórmula da área: area = π . raio2
    Considere o valor de π = 3.14159
    */
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
