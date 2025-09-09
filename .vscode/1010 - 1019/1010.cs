using System; 

class URI {

  static void Main(string[] args)
  {

    string[] peca1 = Console.ReadLine().Split(' ');
    string[] peca2 = Console.ReadLine().Split(' ');

    int quant1 = Convert.ToInt32(peca1[1]);
    int quant2 = Convert.ToInt32(peca2[1]);

    double val1 = Convert.ToDouble(peca1[2]);
    double val2 = Convert.ToDouble(peca2[2]);

    double result = (quant1 * val1) + (quant2 * val2);

    Console.WriteLine($"VALOR A PAGAR: R$ {result:F2}");

    }

}