using Godot;
using System;

public partial class MainScreen : Control
{
	[Export]
	public MainHandler MainHandler { get; set; } = null;

	public void nextSectionSetup()
    {
        
    }

	private void _on_onedeck_button_pressed()
	{
		
	}
    private void _on_twodeck_button_pressed()
    {
        GD.Print("Button2 was pressed!");
    }
}
