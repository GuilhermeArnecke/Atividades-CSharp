using System;

class URI
{
    static void Main(string[] args)
    {
        int[] par = new int[5];
        int[] impar = new int[5];
        int countPar = 0;
        int countImpar = 0;

        for (int i = 0; i < 15; i++)
        {
            int value = Convert.ToInt32(Console.ReadLine());

            if (value % 2 == 0)
            {
                par[countPar] = value;
                countPar++;

                if (countPar == 5)
                {
                    for (int j = 0; j < 5; j++)
                        Console.WriteLine($"par[{j}] = {par[j]}");
                    countPar = 0;
                }
            }
            else
            {
                impar[countImpar] = value;
                countImpar++;

                if (countImpar == 5)
                {
                    for (int j = 0; j < 5; j++)
                        Console.WriteLine($"impar[{j}] = {impar[j]}");
                    countImpar = 0;
                }
            }
        }

        for (int i = 0; i < countImpar; i++) 
            Console.WriteLine($"impar[{i}] = {impar[i]}");

        for (int i = 0; i < countPar; i++)
            Console.WriteLine($"par[{i}] = {par[i]}");
    }
}