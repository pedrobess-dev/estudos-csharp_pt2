public class Exercicio6
{
    public static void Executar()
    {
        Console.Write("Insira uma palavra: ");
        string palavra = Console.ReadLine();

        char[] normal = palavra.ToArray();
        char[] invertido = palavra.Reverse().ToArray();

        if (normal.SequenceEqual(invertido))
        {
            Console.WriteLine("Palíndromo");
        }
        else
        {
            Console.WriteLine("Não é palíndromo");
        }
    }
}