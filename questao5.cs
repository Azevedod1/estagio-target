using System;

class Program
{
    static void Main()
    {
        Console.Write("Digite a string que deseja inverter: ");
        string stringOriginal = Console.ReadLine();
        
        string stringInvertida = InverterString(stringOriginal);
        Console.WriteLine("String invertida: " + stringInvertida);
    }

    static string InverterString(string str)
    {
        string stringInvertida = "";
        foreach (char caractere in str)
        {
            stringInvertida = caractere + stringInvertida;
        }
        return stringInvertida;
    }
}
