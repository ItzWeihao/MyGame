namespace MyGame.GUI;

public class Gui
{
    public string? Answer;
    public void main_menu()
    {
        var mainMenuFilePath = Environment.CurrentDirectory + (@"\assets\gui\main_menu.txt");

        var mainMenuFileElement = new List<string>(File.ReadLines(mainMenuFilePath));

        foreach (var element in mainMenuFileElement) { Console.WriteLine(element); }

        Console.Write("Choose your action: ");
        Answer = Console.ReadLine()!;
    }

    public void call_detail()
    {
        var playerFilePath = Environment.CurrentDirectory + (@"\assets\stats\player_stats.txt");

        var playerFileElement = new List<string?>(File.ReadLines(playerFilePath));
        
        playerFileElement.Add(Answer);
        File.WriteAllText(playerFilePath, Answer);
        
        foreach (var element in playerFileElement){ Console.WriteLine(element); }
    }
}