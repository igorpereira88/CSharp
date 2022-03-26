using System.Globalization;

namespace Pratica.Logica
{
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
