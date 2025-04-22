using DesafiosPraticos1.PromptSelector;

namespace DesafiosPraticos1.Desafios;

public class ContagemCaracteresFraseChallenge : IExecutableInterface
{
    public void Execute()
    {
        Console.WriteLine("Insira uma frase");

        int quantidadeCaracteres = Console.ReadLine().Replace(" ", "").Length;

        Console.WriteLine($"A quantidade de caracteres dessa frase, desconsiderando os espaços em branco, é {quantidadeCaracteres}");
    }
}
