namespace DesafiosPraticos1.PromptSelector;

public class PromptOption(IExecutableInterface executableObject, string label)
{
    public IExecutableInterface ExecutableObject { get; set; } = executableObject;
    public string Label { get; set; } = label;
}
