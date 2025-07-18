using System;

public class Example
{
    public static void Main(string[] args)
    {
        Random random = new Random();

        //gerar um numero aleatório entre 1 e 10
        int numero2 = random.Next(5, 16);
        Console.WriteLine($"Número aleatório entre 5 e 15: {numero2}");

    
    }
}