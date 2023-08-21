using Gtk;

class Main
{
    public void Mulai()
    {
        Console.WriteLine("fungsi mulai");

        Application.Init();

        var w = new Window("csharp gtk 01");
        w.SetDefaultSize(900,500);
        w.Show();

        w.DeleteEvent += _WindowDeleteEvent;


        Application.Run();
    }

    private static void _WindowDeleteEvent(object o, DeleteEventArgs args)
    {
        Application.Quit();
    }
}