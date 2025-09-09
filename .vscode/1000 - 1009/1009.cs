using System; 

class URI {

  static void Main(string[] args)
  {

    string nome = Console.ReadLine();
    double SalarioBase = Convert.ToDouble(Console.ReadLine());
    double Vendas = Convert.ToDouble(Console.ReadLine()) * 0.15;

    Console.WriteLine($"TOTAL = R$ {SalarioBase + Vendas:F2}");

    }

}