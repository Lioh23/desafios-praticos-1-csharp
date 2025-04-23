using DesafiosPraticos1.Desafios.FormatoDataAtual;
using DesafiosPraticos1.PromptSelector;

namespace DesafiosPraticos1.Desafios;

public class DataAtualDiferentesFormatosChallenge : IExecutableInterface
{
    public void Execute()
    {
        var promptOptions = new List<PromptOption>
        {
            new PromptOption(
                label: "Formato completo (dia da semana, dia do mês, mês, ano, hora, minutos, segundos)",
                executableObject: new DiaMesAnoHoraMinutoSegundos()
            ),
            new PromptOption(
                label: "Apenas a data no formato dd/mm/yyyy",
                executableObject: new DataPadraoBrasil()
            ),
            new PromptOption(
                label: "Apenas a hora no formato 24 horas",
                executableObject: new HoraFormato24()
            ),
            new PromptOption(
                label: "A data com o mes por extenso",
                executableObject: new DataComMesPorExtenso()
            )
        };

        PromptHandler.Execute("Navegue utilizando as setas até o formato da data de hoje que deseja visualizar e pressione \"ENTER\" para selecionar", promptOptions);
    }
}
