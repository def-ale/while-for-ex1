internal class Program
{
    private static void Main(string[] args)
    {
        int matricula, i;
        double n, n1, maior, menor, media;

        Console.Write("Informe o número de matrícula de um aluno (negativo para sair): ");
        matricula = Convert.ToInt32(Console.ReadLine());

        if (matricula > 0)
        {
            while (matricula > 0)
            {
                Console.Write("Digite a 1a nota: ");
                n = Convert.ToDouble(Console.ReadLine());
                maior = menor = n1 = n;

                for (i = 2; i <= 3; i++)
                {
                    Console.Write($"Digite a {i}a nota: ");
                    n = Convert.ToDouble(Console.ReadLine());

                    if (n > maior)
                    {
                        n1 = maior;
                        maior = n;
                    }
                    else
                    {
                        if (n < menor)
                        {
                            n1 = menor;
                            menor = n;
                        }
                        else
                        {
                            n1 = n;
                        }
                    }

                }
                media = CalculaMedia(maior, menor, n1);

                // IMPRESSÃO --INÍCIO
                Console.WriteLine("-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-");

                Console.WriteLine($"Matrícula: {matricula}");
                Console.WriteLine($"=> Notas, da maior para a menor: {maior}, {n1}, {menor}");

                if (media >= 5)
                {
                    Console.WriteLine($"Media {media}: APROVADO!");
                }
                else
                    Console.WriteLine($"Media {media}: REPROVADO.");

                Console.WriteLine("-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-");
                // IMPRESSÃO --FIM

                Console.Write("Informe o número de matrícula de um aluno (negativo para sair): ");
                matricula = Convert.ToInt32(Console.ReadLine());
            }
        }
        else;

        Console.WriteLine("");
        Console.WriteLine("Obrigado por utilizar esse programa!");
        Console.Write("Pressione qualquer tecla para sair ");
        Console.ReadKey();
    }

    static double CalculaMedia(double maior, double menor, double n1)
    {
        double media;

        media = (maior * 4 + menor * 3 + n1 * 3) / (4 + 3 + 3);
        return media;
    }
}