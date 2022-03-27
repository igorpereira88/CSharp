namespace Pratica._1.Logica.Estrutura_Condicional
{
    //Fazer um programa para ler um número inteiro, e depois dizer se este número é negativo ou não.
    public class Exercicio1
    {
        public void LeNumeroInteiroNegativo()
        {
            int numero;

            numero = int.Parse(Console.ReadLine());

            if (numero < 0)
                Console.WriteLine("NEGATIVO");
            else
                Console.WriteLine("NÃO NEGATIVO");
        }
    }
}
