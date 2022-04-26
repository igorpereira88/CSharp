namespace Pratica._1.Logica.Estrutura_While
{
    public class Exercicio2
    {
         /*
         Escreva um programa para ler as coordenadas (X,Y) de uma quantidade indeterminada de pontos no sistema
         cartesiano. Para cada ponto escrever o quadrante a que ele pertence. O algoritmo será encerrado quando pelo
         menos uma de duas coordenadas for NULA (nesta situação sem escrever mensagem alguma).
         */
        public void QuadrantePlanoCartesiano()
        {

            int eixoX, eixoY;
            string[] valores = Console.ReadLine().Split(' ');
            eixoX = int.Parse(valores[0]);
            eixoY = int.Parse(valores[1]);

            while (eixoX != 0 && eixoY != 0)
            {
                if (eixoX > 0 && eixoY > 0)
                {
                    Console.WriteLine("primeiro");
                } 
                else if (eixoX < 0 && eixoY > 0)
                {
                    Console.WriteLine("segundo");
                }
                else if (eixoX < 0 && eixoY < 0)
                {
                    Console.WriteLine("terceiro");
                }
                else
                {
                    Console.WriteLine("quarto");
                }

                valores = Console.ReadLine().Split(' ');
                eixoX = int.Parse(valores[0]);
                eixoY = int.Parse(valores[1]);
            }
            
        }
    }
}
