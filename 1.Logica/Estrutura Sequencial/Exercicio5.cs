using System.Globalization;

namespace Pratica.Logica
{
    /*
    Fazer um programa para ler o código de uma peça 1, o número de peças 1, o valor unitário de cada peça 1, o
    código de uma peça 2, o número de peças 2 e o valor unitário de cada peça 2. Calcule e mostre o valor a ser pago. 
    */
    public class Exercicio5
    {
        public void ValorPeca()
        {
            int codigoPeca1, numeroPecas1, codigoPeca2, numeroPecas2;
            double valorUnitPeca1, valorUnitPeca2, valorTotal;

            string[] valores = Console.ReadLine().Split(' ');
            codigoPeca1 = int.Parse(valores[0]);
            numeroPecas1 = int.Parse(valores[1]);
            valorUnitPeca1 = double.Parse(valores[2], CultureInfo.InvariantCulture);

            valores = Console.ReadLine().Split(' ');
            codigoPeca2 = int.Parse(valores[0]);
            numeroPecas2 = int.Parse(valores[1]);
            valorUnitPeca2 = double.Parse(valores[2], CultureInfo.InvariantCulture);

            valorTotal = numeroPecas1 * valorUnitPeca1 + numeroPecas2 * valorUnitPeca2;
            Console.WriteLine("VALOR A PAGAR: R$" +valorTotal.ToString("F2", CultureInfo.InvariantCulture));
            
        }
    }
}
