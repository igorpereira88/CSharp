using System.Globalization;

namespace Pratica.Logica
{
    /*
    Fazer um programa que leia o número de um funcionário, seu número de horas trabalhadas, o valor que recebe por
    hora e calcula o salário desse funcionário. A seguir, mostre o número e o salário do funcionário, com duas casas
    decimais. 
    */
    public class Exercicio4
    {
        public void CalculaSalario()
        {
            int numeroFuncionario, horasTrabalhadas;
            double valorHora, salario;

            numeroFuncionario = int.Parse(Console.ReadLine());
            horasTrabalhadas = int.Parse(Console.ReadLine()); 
            valorHora = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            salario = valorHora * horasTrabalhadas;

            Console.WriteLine("NUMBER = " +numeroFuncionario);
            Console.WriteLine("SALARY = U$" + salario.ToString("F2", CultureInfo.InvariantCulture));
        }
    }
}
