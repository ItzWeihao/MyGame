using MyGame.GUI;

namespace MyGame.Core;
public class PlayerFunctions
{
    private readonly MyGameState? _state = new MyGameState();
    private readonly Gui Gui = new Gui();

    public void PlayerMainMenuChoice(string? answer)
    {
        switch (answer)
        {
            case "1":
                _state?.Running();
                if (_state.state == true) { Gui.main_menu(); }
                break;
            case "2":
                _state?.Exiting();
                break;
        }
    }
}