public class Exercicio5
{
    public static void Executar()
    {
        Console.Write("Insira um número: ");
        int num = int.Parse(Console.ReadLine());

        string invertido = new string(num.ToString().Reverse().ToArray());

        Console.WriteLine($"Número invertido: {invertido}");
    }
}