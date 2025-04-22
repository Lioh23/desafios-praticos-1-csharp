using DesafiosPraticos1.PromptSelector;

namespace DesafiosPraticos1.Desafios;

public class CalculosMatematicosChallenge : IExecutableInterface
{
    public void Execute()
    {
        Console.WriteLine("Insira o primeiro valor a ser calculado:");
        string strValor1 = Console.ReadLine();
        if (!HandleValidateInsertNumber(strValor1))
        {
            Execute();
            return;
        }

        Console.WriteLine("Insira o segundo valor a ser calculado:");
        string strValor2 = Console.ReadLine();
        if (!HandleValidateInsertNumber(strValor2))
        {
            Execute();
            return;
        }

        double valor1 = double.Parse(strValor1);
        double valor2 = double.Parse(strValor2);

        Console.WriteLine("");

        ExibeSomaValores(valor1, valor2);
        ExibeSubtraiValores(valor1, valor2);
        ExibeMultiplicaValores(valor1, valor2);
        ExibeDivideValores(valor1, valor2);
        ExibeMediaValores(valor1, valor2);
    }

    static void ExibeSomaValores(double valor1, double valor2)
    {
        double resultado = valor1 + valor2;

        Console.WriteLine($"O resultado de {valor1} + {valor2} é {resultado}");
    }

    static void ExibeSubtraiValores(double valor1, double valor2)
    {
        double resultado = valor1 - valor2;

        Console.WriteLine($"O resultado de {valor1} - {valor2} é {resultado}");
    }

    static void ExibeMultiplicaValores(double valor1, double valor2)
    {
        double resultado = valor1 * valor2;

        Console.WriteLine($"O resultado de {valor1} * {valor2} é {resultado}");
    }

    static void ExibeDivideValores(double valor1, double valor2)
    {
        if (valor2 == 0)
        {
            Console.WriteLine("Não é possível dividir por zero!");
            return;
        }

        double resultado = valor1 / valor2;

        Console.WriteLine($"O resultado de {valor1} / {valor2} é {resultado}");
    }

    static void ExibeMediaValores(double valor1, double valor2)
    {
        double resultado = (valor1 + valor2) / 2;

        Console.WriteLine($"A média de {valor1} e {valor2} é {resultado}");
    }

    static bool HandleValidateInsertNumber(string insertNumber)
    {
        double number;

        if (!double.TryParse(insertNumber, out number))
        {
            Console.Clear();
            Console.WriteLine("O valor informado é inválido!");
            return false;
        }

        return true;
    }
}
