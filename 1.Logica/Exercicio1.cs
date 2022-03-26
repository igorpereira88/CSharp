namespace Pratica.Logica
{
     /*
     Faça um programa para ler dois valores inteiros, e depois mostrar na tela a soma desses números com uma
     mensagem explicativa, conforme exemplos.
     */
    public class Exercicio1
    {
        public void Soma() {

            int x, y, soma;    
            
            x = int.Parse(Console.ReadLine());
            y = int.Parse(Console.ReadLine());

            soma = x + y;

            Console.WriteLine("SOMA = " +soma);
        }
        
        
    }
}
