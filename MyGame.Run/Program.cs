using MyGame.Core;

namespace MyGame.Run;

public class Program
{
    public static void Main(string[] args)
    {
        var app = new Program();
        var s = new Class1();
        var g = new GUI();
        g.main_menu();
        g.call_detail();
    }
}