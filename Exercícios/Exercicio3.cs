public class Exercicio3
{
    public static void Executar()
    {
        int[] nums = new int[10];
        int soma = 0;

        for (int i = 0; i < nums.Length; i++)
        {
            Console.Write($"Insira o {i + 1}º número: ");
            nums[i] = int.Parse(Console.ReadLine());

            soma += nums[i];
        }

        int maior = nums[0];
        int menor = nums[0];

        for (int i = 1; i < nums.Length; i++)
        {
            if (nums[i] > maior)
            {
                maior = nums[i];
            }

            if (nums[i] < menor)
            {
                menor = nums[i];
            }
        }

        double media = (double)soma / nums.Length;

        Console.WriteLine($"\nMaior: {maior} / Menor: {menor} / Média: {media}");
    }
}