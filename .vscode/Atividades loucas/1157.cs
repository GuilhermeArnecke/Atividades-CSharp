using System;

class URI
{
    static void Main(string[] args)
    {
        int valor = Convert.ToInt32(Console.ReadLine());

        for (int i = 1; i <= valor; i++)
        {
            if (valor % i == 0)
            {
                Console.WriteLine(i);
            }
        }
    }
}