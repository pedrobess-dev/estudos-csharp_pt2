public class Exercicio10
{
    public static void Executar()
    {
        Console.Write("Insira um valor: ");
        int valor = int.Parse(Console.ReadLine());

        int qtd100 = valor / 100;
        int resto = valor % 100;

        int qtd50 = resto / 50;
        resto %= 50;

        int qtd20 = resto / 20;
        resto %= 20;

        int qtd10 = resto / 10;
        resto %= 10;

        int qtd5 = resto / 5;
        resto %= 5;

        int qtd2 = resto / 2;
        resto %= 2;

        Console.WriteLine($"\n100: {qtd100}");
        Console.WriteLine($"50: {qtd50}");
        Console.WriteLine($"20: {qtd20}");
        Console.WriteLine($"10: {qtd10}");
        Console.WriteLine($"5: {qtd5}");
        Console.WriteLine($"2: {qtd2}");
        Console.WriteLine($"Sobra: {resto}");
    }
}