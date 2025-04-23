using DesafiosPraticos1.PromptSelector;

namespace DesafiosPraticos1.Desafios;

public class ValidacaoPlacaVeiculoChallenge : IExecutableInterface
{
    public void Execute()
    {
        Console.WriteLine("Insira a placa do veículo aqui");
        string placa = Console.ReadLine();

        string output =  HandleValidatePlaca(placa) ? "Verdadeiro " : "Falso";

        Console.WriteLine(output);
    }

    static bool HandleValidatePlaca(string placa)
    {
        // valida quantidade de caracteres
        if (placa.Length != 7)
            return false;

        int typeInteger;

        // valida se os 3 primeiros caracteres são letras
        for (int i = 0; i <= 2; i++)
        {
            if (int.TryParse(placa[i].ToString(), out typeInteger))
                return false;
        }

        // valida se os 4 ultimos caracteres são números
        for (int i = 3; i < placa.Length; i++)
        {
            if (!int.TryParse(placa[i].ToString(), out typeInteger))
                return false;
        }

        return true;
    }
}
