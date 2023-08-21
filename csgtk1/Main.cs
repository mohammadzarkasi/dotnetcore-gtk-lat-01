using Gtk;

class Main
{
    public void Mulai()
    {
        Console.WriteLine("fungsi mulai");

        Application.Init();

        var w = new Window("csharp gtk 01");
        w.SetDefaultSize(900,500);

        var drw1 = new DrawingArea();

        var btn1 = new Button("btn 1");

        var box = new HBox(true, 0);
        box.Add(drw1);
        box.Add(btn1);

        w.Add(box);

        // w.Show();
        w.ShowAll();

        w.DeleteEvent += _WindowDeleteEvent;

        Application.Run();
    }

    private static void _WindowDeleteEvent(object o, DeleteEventArgs args)
    {
        Console.WriteLine("window delete event");
        Application.Quit();
    }
}