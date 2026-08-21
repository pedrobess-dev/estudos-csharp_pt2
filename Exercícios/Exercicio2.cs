public class Exercicio2
{
    public static void Executar()
    {
        Console.Write("Insira um número: ");
        int quantidade = int.Parse(Console.ReadLine());

        int a = 0;
        int b = 1;

        for (int i = 0; i < quantidade; i++)
        {
            Console.Write(a + " ");

            int proximo = a + b;
            b = a;
            a = proximo;
        }
    }
}