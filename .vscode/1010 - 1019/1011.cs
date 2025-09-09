using System; 

class URI {

    static void Main(string[] args)
    {

        const double pi = 3.14159;
        int raio = Convert.ToInt32(Console.ReadLine());
        double result = (4 / 3.0) * pi * (Math.Pow(raio, 3)); 

        Console.WriteLine($"VOLUME = {result:F3}");   

    }

}