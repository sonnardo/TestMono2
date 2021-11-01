using System;
using Gtk;

public partial class MainWindow : Gtk.Window
{
    public MainWindow() : base(Gtk.WindowType.Toplevel)
    {
        Build();
    }

    protected void OnDeleteEvent(object sender, DeleteEventArgs a)
    {
        Application.Quit();
        a.RetVal = true;
    }

    protected void onClick(object sender, EventArgs e)
    {
        string hexColor;
        hexColor = colorbutton1.Color.GetHashCode().ToString();
        label1.Text = hexColor;
    }
}
