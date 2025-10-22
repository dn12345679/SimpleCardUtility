using Godot;
using System;
using System.Drawing;
using System.Runtime.CompilerServices;

public partial class RulesetHandler : Control
{
    [Export] Utility util;


    ruleset Rset;

    [Export] TextEdit StartstackSize;
    [Export] TextEdit MaxstackSize;
    [Export] TextEdit HandSize;
    [Export] TextEdit StackNum;
    [Export] CheckBox inGameCoin;
    [Export] CheckBox randomCaller;
    [Export] ItemList handList;
    [Export] HSlider coinProb;
    [Export] Label coinProbLabel; // text only


    // Scoring

    [Export] TextEdit score3oak;
    [Export] TextEdit scorefh;
    [Export] TextEdit scorestraight;
    [Export] TextEdit scoreflush;
    [Export] TextEdit scorestraightflush;
    [Export] TextEdit score4oak;
    [Export] TextEdit scoreroyalflush;
    [Export] TextEdit score5oak;

    public void setOneDeckDefault()
    {
        int hand_size = 8;
        int stack_count = 4;
        int base_stack_size = 2;
        int max_stack_size = 12;
        double head_probability = 50.0;
        bool random_caller = false;
        bool using_real_coin = true;

        pokerhandpreset[] hands = new pokerhandpreset[8]
        {
            new pokerhandpreset("3oak", 5.0),
            new pokerhandpreset("straight", 10.0),
            new pokerhandpreset("flush", 11.0),
            new pokerhandpreset("fullhouse", 15.0),
            new pokerhandpreset("straightflush", 45.0),
            new pokerhandpreset("royalflush", 120.0),
            new pokerhandpreset("4oak", 0.0),
            new pokerhandpreset("5oak", 0.0),
        };

        Rset = new ruleset(hand_size, stack_count, base_stack_size, max_stack_size, head_probability, random_caller, using_real_coin, hands);
        setValues(Rset);
    }
    
        // EXPORT to Game
    private void _on_button_pressed()
    {
        Hide();

        pokerhandpreset[] hands = new pokerhandpreset[8]
        {
            new pokerhandpreset("3oak", Convert.ToDouble(score3oak.Text)),
            new pokerhandpreset("straight", Convert.ToDouble(scorestraight.Text)),
            new pokerhandpreset("flush", Convert.ToDouble(scoreflush.Text)),
            new pokerhandpreset("fullhouse", Convert.ToDouble(scorefh.Text)),
            new pokerhandpreset("straightflush", Convert.ToDouble(scorestraightflush.Text)),
            new pokerhandpreset("royalflush", Convert.ToDouble(scoreroyalflush.Text)),
            new pokerhandpreset("4oak", Convert.ToDouble(score4oak.Text)),
            new pokerhandpreset("5oak", Convert.ToDouble(score5oak.Text)),
        };

        Rset = new ruleset(Convert.ToInt32(HandSize.Text), Convert.ToInt32(StackNum.Text), Convert.ToInt32(StartstackSize.Text),
                             Convert.ToInt32(MaxstackSize.Text), Convert.ToDouble(coinProb.Value), randomCaller.ButtonPressed, inGameCoin.ButtonPressed, hands);
        setValues(Rset);
    }

    public void setTwoDeckDefault()
    {
        int hand_size = 8;
        int stack_count = 4;
        int base_stack_size = 2;
        int max_stack_size = 12;
        double head_probability = 50.0;
        bool random_caller = false;
        bool using_real_coin = true;

        pokerhandpreset[] hands = new pokerhandpreset[8]
        {
            new pokerhandpreset("3oak", 0.0),
            new pokerhandpreset("straight", 4.0),
            new pokerhandpreset("flush", 5.0),
            new pokerhandpreset("fullhouse", 7.0),
            new pokerhandpreset("straightflush", 20.0),
            new pokerhandpreset("royalflush", 70.0),
            new pokerhandpreset("4oak", 12.0), 
            new pokerhandpreset("5oak", 30.0), 
        };

        Rset = new ruleset(hand_size, stack_count, base_stack_size, max_stack_size, head_probability, random_caller, using_real_coin, hands);
        setValues(Rset);
    }

    public void setValues(ruleset r)
    {
        StartstackSize.Text = r.base_stack_size.ToString();
        MaxstackSize.Text = r.max_stack_size.ToString();
        HandSize.Text = r.hand_size.ToString();
        StackNum.Text = r.stack_count.ToString();
        inGameCoin.ButtonPressed = r.using_real_coin;
        randomCaller.ButtonPressed = r.random_caller;
        coinProb.Value = r.head_probability;


        // scores
        score3oak.Text = r.valid_hands_preset[0].hand_score.ToString();
        scorefh.Text = r.valid_hands_preset[3].hand_score.ToString();
        scorestraight.Text = r.valid_hands_preset[1].hand_score.ToString();
        scoreflush.Text = r.valid_hands_preset[2].hand_score.ToString();
        scorestraightflush.Text = r.valid_hands_preset[4].hand_score.ToString();
        score4oak.Text = r.valid_hands_preset[6].hand_score.ToString();
        score5oak.Text = r.valid_hands_preset[7].hand_score.ToString();
        scoreroyalflush.Text = r.valid_hands_preset[5].hand_score.ToString();
    }





    // ORIGINAL INTENT: DISABLE/ENABLE HANDS, but im too lazy rn so just leave htem all on
    private void _on_hand_list_item_selected(int index)
    {
        //handList.SetItemDisabled(index, !handList.);
    }

    
    private void _on_prob_slider_value_changed(float value)
    {
        coinProbLabel.Text = value.ToString() + "%";
    }



    
}
