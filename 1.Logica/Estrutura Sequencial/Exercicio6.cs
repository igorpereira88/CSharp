using System.Globalization;

namespace Pratica._1.Logica.Estrutura_Sequencial
{
    /*
    Fazer um programa que leia três valores com ponto flutuante de dupla precisão: A, B e C. Em seguida, calcule e
    mostre:
    a) a área do triângulo retângulo que tem A por base e C por altura.
    b) a área do círculo de raio C. (pi = 3.14159)
    c) a área do trapézio que tem A e B por bases e C por altura.
    d) a área do quadrado que tem lado B.
    e) a área do retângulo que tem lados A e B.
    */
    public class Exercicio6
    {
        public void CalculaValores()
        {
            double valorA, valorB, valorC, areaTrianguloRetangulo, areaCirculo, areaTrapezio, areaQuadrado, areaRetangulo;
            const double pi = 3.14159;

            string[] valores = Console.ReadLine().Split(' ');

            valorA = float.Parse(valores[0], CultureInfo.InvariantCulture);
            valorB = float.Parse(valores[1], CultureInfo.InvariantCulture);
            valorC = float.Parse(valores[2], CultureInfo.InvariantCulture);

            areaTrianguloRetangulo = (valorA * valorC) / 2;
            areaCirculo = pi * Math.Pow(valorC, 2);
            areaTrapezio = (valorA + valorB) * valorC / 2;
            areaQuadrado = valorB * valorB;
            areaRetangulo = valorA * valorB;

            Console.WriteLine("TRIÂNGULO: " +areaTrianguloRetangulo.ToString("F3", CultureInfo.InvariantCulture));
            Console.WriteLine("CÍRCULO: " +areaCirculo.ToString("F3", CultureInfo.InvariantCulture));
            Console.WriteLine("TRAPÉZIO: " +areaTrapezio.ToString("F3", CultureInfo.InvariantCulture));
            Console.WriteLine("QUADRADO: " +areaQuadrado.ToString("F3", CultureInfo.InvariantCulture));
            Console.WriteLine("RETÂNGULO: " +areaRetangulo.ToString("F3", CultureInfo.InvariantCulture));
        }
    }
}
