using System; 

class URI {

  static void Main(string[] args)
  {

    double a = Convert.ToDouble(Console.ReadLine());
    double b = Convert.ToDouble(Console.ReadLine());

    double peso1 = 3.5;
    double peso2 = 7.5;

    double result = ((a * peso1) + (b * peso2)) / (peso1 + peso2);

    Console.WriteLine($"MEDIA = {result:F5}");

    }

}