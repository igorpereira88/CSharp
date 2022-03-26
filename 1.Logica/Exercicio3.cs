namespace Pratica.Logica
{
    public class Exercicio3
    {
        public void CalculaDiferenca()
        {
            int a, b, c, d, diferenca;

            a = int.Parse(Console.ReadLine());
            b = int.Parse(Console.ReadLine());
            c = int.Parse(Console.ReadLine());
            d = int.Parse(Console.ReadLine());

            diferenca = a * b - c * d;

            Console.WriteLine("DIFERENÇA = " + diferenca);
        }
    }
}
