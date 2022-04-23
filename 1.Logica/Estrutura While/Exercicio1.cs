namespace Pratica._1.Logica.Estrutura_While
{
    public class Exercicio1
    {
        public void ValidaSenha()
        {
            int senha = int.Parse(Console.ReadLine());             

            while(senha != 2002)
            {
                Console.WriteLine("Senha invalida");
                senha = int.Parse(Console.ReadLine());
            }
            Console.WriteLine("Acesso permitido");
        }
    }
}
