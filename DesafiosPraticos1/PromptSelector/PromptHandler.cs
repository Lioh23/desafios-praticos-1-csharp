namespace DesafiosPraticos1.PromptSelector;

public class PromptHandler
{
    public static void Execute(string promptTitle, List<PromptOption> options, int cursorIndex = 0)
    {

        HandleDrawPrompt(promptTitle, options, cursorIndex);

        var optionsLength = options.Count - 1;
        var consoleKey = Console.ReadKey().Key;
        var selectedIndex = HandleSelectedKey(consoleKey, cursorIndex, optionsLength);

        if (consoleKey == ConsoleKey.Escape)
        {
            Console.WriteLine("Programa encerrado pelo usuário");
            return;
        }

        if (consoleKey == ConsoleKey.Enter)
        {
            Console.Clear();
            options[cursorIndex].ExecutableObject.Execute();
            return;
        }
        
        Execute(promptTitle, options, selectedIndex);
    }

    static void HandleDrawPrompt(string promptTitle, List<PromptOption> options, int cursorIndex)
    {
        Console.Clear();
        Console.WriteLine(promptTitle);
        Console.WriteLine("");

        for (int i = 0; i < options.Count; i++)
        {
            string consoleOutput = "";
            consoleOutput += cursorIndex == i ? "> " : "";
            consoleOutput += (i + 1) + ". " + options[i].Label;
            Console.WriteLine(consoleOutput);
        }


        Console.WriteLine("");
        Console.WriteLine("Para encerrar a execução do programa, pressione \"ESC\" a qualquer momento.");


    }

    static int HandleSelectedKey(ConsoleKey consoleKey, int cursorIndex, int optionsLength)
    {
        Console.WriteLine($"consoleKey {consoleKey}, optionsLength {optionsLength} cursorIndex: {cursorIndex}");
        if (consoleKey == ConsoleKey.UpArrow && cursorIndex > 0)
            return cursorIndex - 1;

        if (consoleKey == ConsoleKey.UpArrow && cursorIndex == 0)
            return optionsLength;

        if (consoleKey == ConsoleKey.DownArrow && cursorIndex < optionsLength)
            return cursorIndex + 1;
        

        if (consoleKey == ConsoleKey.DownArrow && cursorIndex == optionsLength)
            return 0;

        return cursorIndex;
    }
}
