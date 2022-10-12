using MyGame.Core;
using MyGame.GUI;

namespace MyGame.Run;
public static class Program
{
    // Calling GUI and Core for use
    private static readonly PlayerFunctions PlayerFunctions = new PlayerFunctions();
    private static readonly Gui Gui = new Gui();
    private static readonly MyGameState MyGameState = new MyGameState();
    
    // Start of the Program
    public static void Main(string[] args)
    {
        MyGameState.Running();
        while (MyGameState.state == true)
        {
            Gui.main_menu();
            PlayerFunctions.PlayerMainMenuChoice(Gui.Answer);
        }
    }
}