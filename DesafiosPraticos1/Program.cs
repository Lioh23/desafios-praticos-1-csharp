using DesafiosPraticos1.Desafios;
using DesafiosPraticos1.PromptSelector;

namespace DesafiosPraticos1;

class Program
{
    static void Main()
    {
        var promptOptions = new List<PromptOption>
        {
            new PromptOption(
                label: "Programa em que o usuário precisa digitar um nome e uma mensagem de boas vindas",
                executableObject: new MensagemBoasVindasChallenge()
            ),
            new PromptOption(
                label: "Programa que concatene um nome e um sobrenome inseridos pelo usuário final",
                executableObject: new NomeESobrenomeChallenge()
            ),
            new PromptOption(
                label: "Programa que receba 2 valores do tipo double e realiza cálculos matemáticos",
                executableObject: new CalculosMatematicosChallenge()
            ),
            new PromptOption(
                label: "Programa que conta a quanitdade de caracteres da frase inserida",
                executableObject: new ContagemCaracteresFraseChallenge()
            ),
            new PromptOption(
                label: "Programa que valida a placa de um veículo inserida",
                executableObject: new ValidacaoPlacaVeiculoChallenge()
            ),
            new PromptOption(
                label: "Programa que solicita ao usuário a exibição da data atual em diferentes formatos",
                executableObject: new DataAtualDiferentesFormatosChallenge()
            )
        };

        PromptHandler.Execute("Selecione o desafio que deseja testar pressionando \"ENTER\"", promptOptions);
    }
}