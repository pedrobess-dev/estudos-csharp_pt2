public class Exercicio5
{
    public static void Executar()
    {
        int[] nums = new int[5];

        for (int i = 0; i < nums.Length; i++)
        {
            Console.Write($"Insira o {i + 1}º número: ");
            nums[i] = int.Parse(Console.ReadLine());
        }

        Array.Reverse(nums);

        Console.WriteLine(string.Join(" ", nums));
    }
}