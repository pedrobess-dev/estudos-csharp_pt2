public class Exercicio8
{
    public static void Executar()
    {
        int[] lista = new int[10];

        for (int i = 0; i < lista.Length; i++)
        {
            Console.Write($"Insira o {i + 1}º número: ");
            lista[i] = int.Parse(Console.ReadLine());
        }

        for (int i = 0; i < lista.Length - 1; i++)
        {
            for (int j = i + 1; j < lista.Length; j++)
            {
                if (lista[i] > lista[j])
                {
                    int temp = lista[i];
                    lista[i] = lista[j];
                    lista[j] = temp;
                }
            }
        }

        for (int i = 0; i < lista.Length; i++)
        {
            Console.Write($"{lista[i]} ");
        }
    }
}