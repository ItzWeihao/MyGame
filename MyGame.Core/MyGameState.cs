namespace MyGame.Core;

public class MyGameState
{
    public bool state;

    public void Running() { state = true; }
    public void Exiting() { state = false; Environment.Exit(0); }
}