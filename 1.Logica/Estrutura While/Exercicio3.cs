namespace Pratica._1.Logica.Estrutura_While
{
    /*
    Um Posto de combustíveis deseja determinar qual de seus produtos tem a preferência de seus clientes. Escreva
    um algoritmo para ler o tipo de combustível abastecido (codificado da seguinte forma: 1.Álcool 2.Gasolina 3.Diesel
    4.Fim). Caso o usuário informe um código inválido (fora da faixa de 1 a 4) deve ser solicitado um novo código (até
    que seja válido). O programa será encerrado quando o código informado for o número 4. Deve ser escrito a
    mensagem: "MUITO OBRIGADO" e a quantidade de clientes que abasteceram cada tipo de combustível, conforme
    exemplo.
    */
    public class Exercicio3
    {
        public void Combustivel()
        {
            int codigoCombustivel, clienteGasolina=0, clienteDiesel=0, clienteAlcool=0;

            codigoCombustivel = int.Parse(Console.ReadLine());

            while (codigoCombustivel != 4)
            {
                if (codigoCombustivel == 1)
                {
                    clienteAlcool++;
                } 
                else if (codigoCombustivel == 2)
                {
                    clienteGasolina++;
                }
                else if (codigoCombustivel == 3)
                {
                    clienteDiesel++;
                }                                         

                codigoCombustivel = int.Parse(Console.ReadLine());                
            }

            Console.WriteLine("MUITO OBRIGADO");
            Console.WriteLine("Alcool: " + clienteAlcool);
            Console.WriteLine("Gasolina: " + clienteGasolina);
            Console.WriteLine("Diesel: " + clienteDiesel);
        }
    }
}
