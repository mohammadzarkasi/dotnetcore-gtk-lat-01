using System;
using Gtk;

namespace dotnetcore_01
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");

            Application.Init();

            var w = new Window("gtk 01");
            w.Show();

            w.DeleteEvent += W_DeleteEvent;

            Application.Run();
        }

        private static void W_DeleteEvent(object o, DeleteEventArgs args)
        {
            Application.Quit();
        }
    }
}
