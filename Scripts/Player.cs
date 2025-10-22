using Godot;
using System;
using System.Collections.Generic;
using System.Linq;

public partial class Player : Control
{

	[Export] ruleset rs;
	[Export] double score = 0;

	[Export] bool has_coin = false;
	[Export] bool is_turn = false;
	Dictionary<pokerhandpreset, int> hands_played = new Dictionary<pokerhandpreset, int>();

	[Export] Control handList;

	public void setValidHands()
    {
        //TODO #  just assign some variable for pokerhandspreset so you know what the score is
    }

	public void initPokerHands()
	{
		//TODO # initialize pokerhandpreset dictionary hands_played so you can increment, scoring is handled in parent
	}


	public override void _Ready()
	{
		if (handList == null)
		{
			GD.PrintErr("handList not assigned");
			return;
		}

		foreach (Node child in handList.GetChildren())
		{
			if (child is Control parentControl)
			{
				// Get all Button children of this parent
				var buttons = parentControl.GetChildren()
										   .OfType<Button>()
										   .ToList();

				if (buttons.Count > 0)
				{
					var parent = parentControl;
					buttons[0].Pressed += () => Increment(parent);
				}

				if (buttons.Count > 1)
				{
					var parent = parentControl;
					buttons[1].Pressed += () => Decrement(parent);
				}
			}
		}
	}

    private void Decrement(Control parent)
    {
        GD.Print($"Decrement called from {parent.Name}");
        // Your decrement logic here
    }

    private void Increment(Control parent)
    {
        GD.Print($"Increment called from {parent.Name}");
        // Your increment logic here
    }

	
}
