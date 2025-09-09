using System; 

class URI {

  static void Main(string[] args)
  {

    int NumFuncionarios = Convert.ToInt32(Console.ReadLine());
    double HorasTrabalhadas = Convert.ToDouble(Console.ReadLine());
    double ValorPorHora = Convert.ToDouble(Console.ReadLine());

    Console.WriteLine($"NUMBER = {NumFuncionarios}");
    Console.WriteLine($"SALARY = U$ {HorasTrabalhadas * ValorPorHora:F2}");

    }

}