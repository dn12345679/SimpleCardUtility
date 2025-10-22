using Godot;
using System;

public partial class Utility : Control
{
	[Export] ruleset rs;
	//TODO: Add turns, coin, animations for changing turns, flipping coins, assigning presetpokerhands to all child Players, adding/dropping players
	public void assignRuleset(ruleset rs)
    {
		this.rs = rs;
    }
}
