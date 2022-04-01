namespace Pratica._1.Logica.Estrutura_Condicional
{
    public class Exercicio3
    {
        /*
        Leia 2 valores inteiros (A e B). Após, o programa deve mostrar uma mensagem "Sao Multiplos" ou "Nao sao
        Multiplos", indicando se os valores lidos são múltiplos entre si. Atenção: os números devem poder ser digitados em
        ordem crescente ou decrescente. 
        */
        public void NumerosMultiplos()
        {
            int valorA, valorB, maiorNumero, menorNumero, resultadoDivisao;

            string[] valores = Console.ReadLine().Split(' ');
            valorA = int.Parse(valores[0]);  
            valorB = int.Parse(valores[1]);

            if (valorA > valorB)
            {
                maiorNumero = valorA;
                menorNumero = valorB;
            }
            else
            {
                maiorNumero = valorB;
                menorNumero = valorA;
            }

            resultadoDivisao = maiorNumero / menorNumero;

            if (maiorNumero == resultadoDivisao * menorNumero)            
                Console.WriteLine("São Múltiplos");            
            else
                Console.WriteLine("Não são Múltiplos");

        }
    }
}
