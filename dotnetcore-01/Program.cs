using System;
using Gtk;

namespace dotnetcore_01
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("initializing gtk....");

            Application.Init();
            Console.WriteLine("done");

            Console.Write("\ncreating window...");
            var w = new Window("gtk 01");
            w.SetDefaultSize(900, 500);
            w.Show();
            Console.WriteLine("done");

            w.DeleteEvent += W_DeleteEvent;

            Console.Write("\nrun the app...");
            Application.Run();
            Console.WriteLine("done");
        }

        private static void W_DeleteEvent(object o, DeleteEventArgs args)
        {
            Application.Quit();
        }
    }
}
