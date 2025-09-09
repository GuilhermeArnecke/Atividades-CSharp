using System; 

class URI {

  static void Main(string[] args)
  {

    const double pi = 3.14159;

    double raio = Convert.ToDouble(Console.ReadLine());
    double area = pi * (raio * raio);

    Console.WriteLine($"A={area:F4}");  

  }

}