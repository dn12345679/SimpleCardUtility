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

    [Export] public pokerhandpreset[] valid_hands_preset { get; set; }
    [Export] public pokerhand[] valid_hands { get; set; }


    public ruleset(int hsize, int scount, int bstack, int mstack, double hprob, bool rcall, bool rcoin, pokerhandpreset[] presethands = null, pokerhand[] validhands = null)
    {
        hand_size = hsize;
        stack_count = scount;
        base_stack_size = bstack;
        max_stack_size = mstack;
        head_probability = hprob;
        random_caller = rcall;
        using_real_coin = rcoin;
        valid_hands = validhands;
        valid_hands_preset = presethands;
    }
}