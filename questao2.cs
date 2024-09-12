using System;

class FibonacciProgram
{
    static void Main()
    {
        Console.Write("Digite um número: ");
        int numero = int.Parse(Console.ReadLine());

        bool fibonacci = SeqFibonacci(numero);

        if (fibonacci)
        {
            Console.WriteLine($"{numero} está na sequência de Fibonacci.");
        }
        else
        {
            Console.WriteLine($"{numero} não é um número da sequência de Fibonacci.");
        }
    }

    static bool SeqFibonacci(int numero)
    {
        if (numero == 0)
        {
            return true;
        }

        int a = 0;
        int b = 1;

        while (b < numero)
        {
            int temp = a;
            a = b;
            b = temp + b;
        }

        return b == numero;
    }
}