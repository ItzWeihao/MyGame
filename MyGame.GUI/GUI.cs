public class GUI
{
    public GUI() {}

    private String name, age;

    public void main_menu()
    {
        /*
        Console.WriteLine("Hello, World!");
        */
        
        Console.Write("Name: ");
        name = Console.ReadLine()!;
        
        Console.Write("Age: ");
        age = Console.ReadLine()!;
    }

    public void call_detail()
    {
        Console.Write("Name: " + name + "\nAge: " + age);
    }
}

