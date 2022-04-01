namespace Pratica._1.Logica.Estrutura_Condicional
{
    /*
     Leia a hora inicial e a hora final de um jogo. A seguir calcule a duração do jogo, sabendo que o mesmo pode
     começar em um dia e terminar em outro, tendo uma duração mínima de 1 hora e máxima de 24 horas.
    */
    public class Exercicio4
    {
        public void CalculaHoraJogo()
        {
            int horaInicial, horaFinal;

            string[] valores = Console.ReadLine().Split(' ');
            horaInicial = int.Parse(valores[0]);
            horaFinal = int.Parse(valores[1]);

            int duracao;

            if (horaInicial < horaFinal)
            {
                duracao = horaFinal - horaInicial;
            }
            else
            {
                duracao = 24 - horaInicial + horaFinal;
            }

            Console.WriteLine("O JOGO DUROU " +duracao+ " HORA(S)");
        }
    }
}
