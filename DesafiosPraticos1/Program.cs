using DesafiosPraticos1.Desafios;
using DesafiosPraticos1.PromptSelector;

namespace DesafiosPraticos1;

class Program
{
    static void Main()
    {
        var promptOptions = new List<PromptOption>
        {
            new PromptOption(new MensagemBoasVindasChallenge(), "Programa em que o usuário precisa digitar um nome e uma mensagem de boas vindas"),
            new PromptOption(new NomeESobrenomeChallenge(), "Programa que concatene um nome e um sobrenome inseridos pelo usuário final"),
            new PromptOption(new CalculosMatematicosChallenge(), "Programa que receba 2 valores do tipo double e realiza cálculos matemáticos"),
            new PromptOption(new ContagemCaracteresFraseChallenge(), "Programa que conta a quanitdade de caracteres da frase inserida"),
            new PromptOption(new ValidacaoPlacaVeiculoChallenge(), "Programa que valida a placa de um veículo inserida"),
            new PromptOption(new DataAtualDiferentesFormatosChallenge(), "Programa que solicita ao usuário a exibição da data atual em diferentes formatos")
        };
        
        PromptHandler.Execute("Selecione o desafio que deseja testar pressionando \"ENTER\"", promptOptions);
    }
}