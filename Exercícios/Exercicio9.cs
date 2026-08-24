public class Exercicio9
{

    private class Aluno
    {
        public string nome;
        public double[] nota = new double[3];
        public double media;
    }
    public static void Executar()
    {
        List<Aluno> alunos = new List<Aluno>();

        for (int i = 0; i < 5; i++)
        {
            Aluno aluno = new Aluno();

            Console.Write("\nNome: ");
            aluno.nome = Console.ReadLine();

            for (int j = 0; j < aluno.nota.Length; j++)
            {
                Console.Write($"Nota {j + 1}: ");
                aluno.nota[j] = double.Parse(Console.ReadLine());

                aluno.media += aluno.nota[j];
            }

            aluno.media /= 3;

            alunos.Add(aluno);
        }

        Console.WriteLine("\n---ALUNOS---");

        foreach (Aluno aluno in alunos)
        {
            Console.WriteLine($"\nNome: {aluno.nome}");
            for (int i = 0; i < aluno.nota.Length; i++)
            {
                Console.WriteLine($"Nota {i + 1}: {aluno.nota[i]}");
            }
            Console.WriteLine($"Média: {aluno.media}");
        }
    }
}