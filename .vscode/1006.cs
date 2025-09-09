using System; 

class URI {

  static void Main(string[] args)
  {

    const double peso1 = 2.0;
    const double peso2 = 3.0;
    const double peso3 = 5.0;

    double a = Convert.ToDouble(Console.ReadLine());
    double b = Convert.ToDouble(Console.ReadLine());
    double c = Convert.ToDouble(Console.ReadLine());

    double result = ((a * peso1) + (b * peso2) + (c * peso3)) / (peso1 + peso2 + peso3);

    Console.WriteLine($"MEDIA = {result:F1}");

    }

}