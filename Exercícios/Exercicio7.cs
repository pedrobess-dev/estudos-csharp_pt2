public class Exercicio7
{
    public static void Executar()
    {
        int[] nums = new int[10];

        for (int i = 0; i < nums.Length; i++)
        {
            Console.Write($"Insira o {i + 1}º número: ");
            nums[i] = int.Parse(Console.ReadLine());
        }

        for (int i = 0; i < nums.Length; i++)
        {
            int count = 0;
            for (int j = 0; j < nums.Length; j++)
            {
                if (nums[j] == nums[i])
                {
                    count++;
                }
            }

            if (count < 2)
            {
                Console.Write($"{nums[i]} ");
            }
        }
    }
}