using System.Globalization;

namespace Pratica._1.Logica.Estrutura_Condicional
{
    /*
     Com base na tabela abaixo, escreva um programa que leia o código de um item e a quantidade deste item. A
     seguir, calcule e mostre o valor da conta a pagar.
      Codigo    Especificação       Preço
        1       Cachorro Quente     R$ 4.00
        2       X-Salada            R$ 4.50
        3       X-Bacon             R$ 5.00
        4       Torrada simples     R$ 2.00
        5       Refrigerante        R$ 1.50
    */
    public class Exercicio5
    {
        public void ValorConta()
        {
            double valorItem, total; 

            string[] valores  = Console.ReadLine().Split(' ');
            int codigoItem = int.Parse(valores[0]);
            int quantidadeItem = int.Parse(valores[1]);
            valorItem = 0;

            if (codigoItem == 1)
                valorItem = 4.00;
            else if (codigoItem == 2)
                valorItem = 4.50;
            else if (codigoItem == 3)
                valorItem = 5.00;
            else if (codigoItem == 4)
                valorItem = 2.00;
            else if (codigoItem == 5)
                valorItem = 1.50;
            else
            {
                Console.WriteLine("Digite um código válido!");
                return;
            }                
            
            total = quantidadeItem * valorItem;

            Console.WriteLine("Total: R$ " +total.ToString("F2", CultureInfo.InvariantCulture));

        }
    }
}
