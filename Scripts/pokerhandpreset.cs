using Godot;
using System;


public partial class pokerhandpreset : Control
{
    [Export] public string hand_name;

    [Export] public double hand_score;

    [Export] public Sprite2D card1;
    [Export] public Sprite2D card2;
    [Export] public Sprite2D card3;
    [Export] public Sprite2D card4;
    [Export] public Sprite2D card5;
    

    public pokerhandpreset(string name, double score)
    {
        hand_name = name;
        this.hand_score = score;
        setCards(name);
    } 

    public void setCards(string hand)
    {
        switch(hand)
        {
            case "3oak":
                card1.RegionRect = new Rect2(new Vector2(0, 0), new Vector2(48, 64));
                card2.RegionRect = new Rect2(new Vector2(0, 0), new Vector2(48, 64));
                card3.RegionRect = new Rect2(new Vector2(0, 0), new Vector2(48, 64));
                //card1.Position = new Vector2(card1.Position.X, card1.Position.Y + 16);
                //card2.Position = new Vector2(card2.Position.X, card2.Position.Y + 16);
                //card3.Position = new Vector2(card3.Position.X, card3.Position.Y + 16);

                card4.RegionRect = new Rect2(new Vector2(0, 0), new Vector2(48, 256));
                card5.RegionRect = new Rect2(new Vector2(0, 0), new Vector2(48, 256));
                break;
            case "straight":
                card1.RegionRect = new Rect2(new Vector2(0, 128), new Vector2(48, 64));
                card2.RegionRect = new Rect2(new Vector2(48, 64), new Vector2(48, 64));
                card3.RegionRect = new Rect2(new Vector2(96, 192), new Vector2(48, 64));
                card4.RegionRect = new Rect2(new Vector2(144, 128), new Vector2(48, 64));
                card5.RegionRect = new Rect2(new Vector2(192, 0), new Vector2(48, 64));
                break;
            case "flush":
                card1.RegionRect = new Rect2(new Vector2(0, 128), new Vector2(48, 64));
                card2.RegionRect = new Rect2(new Vector2(288, 128), new Vector2(48, 64));
                card3.RegionRect = new Rect2(new Vector2(384, 128), new Vector2(48, 64));
                card4.RegionRect = new Rect2(new Vector2(144, 128), new Vector2(48, 64));
                card5.RegionRect = new Rect2(new Vector2(192, 128), new Vector2(48, 64));
                break;
            case "straightflush":
                card1.RegionRect = new Rect2(new Vector2(0, 128), new Vector2(48, 64));
                card2.RegionRect = new Rect2(new Vector2(48, 128), new Vector2(48, 64));
                card3.RegionRect = new Rect2(new Vector2(96, 128), new Vector2(48, 64));
                card4.RegionRect = new Rect2(new Vector2(144, 128), new Vector2(48, 64));
                card5.RegionRect = new Rect2(new Vector2(192, 128), new Vector2(48, 64));
                break;
            case "royalflush":
                card1.RegionRect = new Rect2(new Vector2(432, 128), new Vector2(48, 64));
                card2.RegionRect = new Rect2(new Vector2(480, 128), new Vector2(48, 64));
                card3.RegionRect = new Rect2(new Vector2(528, 128), new Vector2(48, 64));
                card4.RegionRect = new Rect2(new Vector2(576, 128), new Vector2(48, 64));
                card5.RegionRect = new Rect2(new Vector2(0, 128), new Vector2(48, 64));
                break;
            case "4oak":
                card1.RegionRect = new Rect2(new Vector2(432, 128), new Vector2(48, 64));
                card2.RegionRect = new Rect2(new Vector2(432, 128), new Vector2(48, 64));
                card3.RegionRect = new Rect2(new Vector2(432, 128), new Vector2(48, 64));
                card4.RegionRect = new Rect2(new Vector2(432, 128), new Vector2(48, 64));
                card5.RegionRect = new Rect2(new Vector2(0, 0), new Vector2(48, 256));
                break;
            case "5oak":
                card1.RegionRect = new Rect2(new Vector2(432, 128), new Vector2(48, 64));
                card2.RegionRect = new Rect2(new Vector2(432, 128), new Vector2(48, 64));
                card3.RegionRect = new Rect2(new Vector2(432, 128), new Vector2(48, 64));
                card4.RegionRect = new Rect2(new Vector2(432, 128), new Vector2(48, 64));
                card5.RegionRect = new Rect2(new Vector2(432, 128), new Vector2(48, 64));
                break;
            case "fullhouse":
                card1.RegionRect = new Rect2(new Vector2(432, 128), new Vector2(48, 64));
                card2.RegionRect = new Rect2(new Vector2(432, 128), new Vector2(48, 64));
                card3.RegionRect = new Rect2(new Vector2(432, 128), new Vector2(48, 64));
                card4.RegionRect = new Rect2(new Vector2(0, 0), new Vector2(48, 64));
                card5.RegionRect = new Rect2(new Vector2(0, 0), new Vector2(48, 64));
                break;
        }
    }
}