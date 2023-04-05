using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
public class Program
{
    public static void Main()
    {
        Console.WriteLine("Digite quantos números deseja:");
        int qtdNumeros = int.Parse(Console.ReadLine());

        int maior = 0;
        int somaPares = 0;
        int[] numeros = new int[qtdNumeros];
        int i = 0;

        while (i < qtdNumeros)
        {
            Console.WriteLine("Digite o número " + (i + 1) + ": ");
            int n = int.Parse(Console.ReadLine());

            if (numeros.Contains(n))
                continue;
            else
            {
                numeros[i] = n;
                i++;

                if (n > maior)
                    maior = n;

                if (n % 2 == 0)
                    somaPares = somaPares + n;
            }
        }

        Console.WriteLine("Maior: " + maior);
        Console.WriteLine("Soma Pares: " + somaPares);
        Console.Read();

    }
}