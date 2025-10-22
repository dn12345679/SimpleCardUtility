using Godot;
using System;

public partial class MainScreen : Control
{
	[Export]
	public MainHandler MainHandler { get; set; } = null;

	private void _on_onedeck_button_pressed()
    {
        Hide();
        this.MainHandler.rhandle.setOneDeckDefault();
        this.MainHandler.rhandle.Show();
	}
    private void _on_twodeck_button_pressed()
    {
        Hide();
        this.MainHandler.rhandle.setTwoDeckDefault();
        this.MainHandler.rhandle.Show();
    }
}
