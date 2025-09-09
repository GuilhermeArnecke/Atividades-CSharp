using System; 

class URI {

  static void Main(string[] args)
  {

    string[] values = Control.ReadLine().Split(' ');

    double A = Convert.ToDouble(values[0]);
    double B = Convert.ToDouble(values[1]);
    double C = Convert.ToDouble(values[2]);

    Console.ReadLine($"TRIANGULO: {(A * C) / 2}");


    }

}