using MyGame.Core;
using MyGame.GUI;

namespace MyGame.Run;
public static class Program
{
    // Calling GUI and Core for use
    private static readonly PlayerFunctions PlayerFunctions = new PlayerFunctions();
    private static readonly Gui Gui = new Gui();
    
    // Start of the Program
    public static void Main(string[] args)
    {
        Gui.main_menu();
        PlayerFunctions.player_choice(Gui.Answer);
    }
}