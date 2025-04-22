using DesafiosPraticos1.PromptSelector;

namespace DesafiosPraticos1.Desafios;

public class NomeESobrenomeChallenge : IExecutableInterface
{
    public void Execute()
    {
        Console.WriteLine("Digite seu nome:");
        string nome = Console.ReadLine();

        Console.WriteLine("Digite seu sobrenome:");
        string sobrenome = Console.ReadLine();

        Console.WriteLine($"Nome completo: {nome} {sobrenome}");
    }
}
