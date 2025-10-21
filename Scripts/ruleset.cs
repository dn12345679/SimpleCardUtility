using Godot;
using System;

public partial class ruleset : Resource
{
    [Export] public int hand_size { get; set; } = 8;
    [Export] public int stack_count { get; set; } = 4;
    [Export] public int base_stack_size { get; set; } = 2;
    [Export] public int max_stack_size { get; set; } = 12;
    [Export] public double head_probability { get; set; } = 0.5;
    [Export] public bool random_caller { get; set; } = false;
    [Export] public bool using_real_coin { get; set; } = true; 

    public void setOneDeckDefault()
    {
        hand_size = 8;
        stack_count = 4;
        base_stack_size = 2;
        max_stack_size = 12;
        head_probability = 0.5;
        random_caller = false;
        using_real_coin = true;
    }
}