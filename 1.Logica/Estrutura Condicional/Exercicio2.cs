namespace Pratica._1.Logica.Estrutura_Condicional
{
    //Fazer um programa para ler um número inteiro e dizer se este número é par ou ímpar.
    public class Exercicio2
    {
        public void NumeroParImpar()
        {
            int numero;

            numero = int.Parse(Console.ReadLine());

            if (numero % 2 == 0)
                Console.WriteLine("PAR");
            else
                Console.WriteLine("IMPAR");
        }
    }
}
