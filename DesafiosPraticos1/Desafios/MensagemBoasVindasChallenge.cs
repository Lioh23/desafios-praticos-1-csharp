using DesafiosPraticos1.PromptSelector;

namespace DesafiosPraticos1.Desafios;

public class MensagemBoasVindasChallenge : IExecutableInterface
{
    public void Execute()
    {
        Console.WriteLine("Digite seu nome:");

        string nomeUsuario = Console.ReadLine();

        Console.WriteLine($"Olá, {nomeUsuario}! Seja muito bem-vindo!");
    }
}