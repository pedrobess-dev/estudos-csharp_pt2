public class Exercicio1
{
    public static void Executar()
    {
        bool primo = true;
        Console.Write("Informe um número: ");
        int num = int.Parse(Console.ReadLine());

        if (num < 2)
        {
            primo = false;
        }

        for (int i = 2; i < num + 1; i++)
        {
            if (num % i == 0)
            {
                primo = false;
                break;
            } 
        }

        if (primo)
        {
            Console.WriteLine("É primo");
        } 
        else
        {
            Console.WriteLine("Não é primo");
        }
    }
}