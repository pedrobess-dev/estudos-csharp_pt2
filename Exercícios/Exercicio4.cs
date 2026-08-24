public class Exercicio4
{
    public static void Executar()
    {
        int count = 0;
        int par = 0;
        int impar = 0;
        int soma = 0;
        while (true)
        {
            Console.Write("Insira um número: ");
            int num = int.Parse(Console.ReadLine());

            count++;
            soma += num;

            if (num == 0)
            {
                break;
            }

            if (num % 2 == 0)
            {
                par++;
            }
            else
            {
                impar++;
            }
        }

        Console.WriteLine($"\nQtd. Números: {count} / Qtd. Pares: {par} / Qtd. Ímpares {impar} / Soma: {soma}");
    }
}