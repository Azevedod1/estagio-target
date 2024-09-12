using System;

class Program
{
    static void Main()
    {
        // Valores de faturamento por estado
        double sp = 67836.43;
        double rj = 36678.66;
        double mg = 29229.88;
        double es = 27165.48;
        double outros = 19849.53;

        // Cálculo do faturamento total
        double total = sp + rj + mg + es + outros;

        // Cálculo dos percentuais de representação
        double percSP = (sp / total) * 100;
        double percRJ = (rj / total) * 100;
        double percMG = (mg / total) * 100;
        double percES = (es / total) * 100;
        double percOutros = (outros / total) * 100;

        // Exibição dos resultados
        Console.WriteLine("Percentual de representação por estado:");
        Console.WriteLine($"SP: {percSP:F2}%");
        Console.WriteLine($"RJ: {percRJ:F2}%");
        Console.WriteLine($"MG: {percMG:F2}%");
        Console.WriteLine($"ES: {percES:F2}%");
        Console.WriteLine($"Outros: {percOutros:F2}%");
    }
}
