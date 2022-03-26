using System.Globalization;

namespace Pratica.Logica
{
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
