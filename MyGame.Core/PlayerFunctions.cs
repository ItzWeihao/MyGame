namespace MyGame.Core;
public class PlayerFunctions
{
    public void player_choice(string? answer)
    {
        switch (answer)
        {
            case "1":
                Console.WriteLine("hey1");
                break;
            case "2":
                Console.WriteLine("hey2");
                break;
            case "3":
                Console.WriteLine("hey3");
                break;
            case "4":
                Console.WriteLine("hey4");
                break;
        }
    }
}