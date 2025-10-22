using Godot;
using System;
using System.Linq;

public partial class pokerhand : Resource
{


    [Export] public string name = "NoHand";
    [Export] public int num_pairs = 0;

    [Export] public int unique_ranks = 0;
    [Export] public int unique_suits = 0;

    [Export] public bool straight = false;
    [Export] public int[] ranks = new int[5] { 0, 0, 0, 0, 0};
    [Export] public double score = 0;

    [Export] public int num_cards = 5;

    public pokerhand(string name, int npair, int urank, int usuit, bool straight, int[] ranks, double score, int num_cards)
    {
        this.name = name;
        num_pairs = npair;
        unique_ranks = urank;
        unique_suits = usuit;
        this.straight = straight;
        this.ranks = ranks;
        this.score = score;
        this.num_cards = num_cards;
    }

    public bool isThreeKind()
    {
        return (num_pairs == 1 && unique_ranks == 3);
    }
    public bool isFlush()
    {
        return (unique_suits == 1 && unique_ranks > 2 && !isStraight());
    }
    public bool isStraightFlush()
    {
        return (unique_suits == 1 && unique_ranks == 5 && isStraight());
    }
    public bool isRoyalFlush()
    {
        // assume that array is sorted since isStraightFlush calls isStraight which sorts the array
        return (isStraightFlush() && ranks[ranks.Length - 1] == 14);
    }

    public bool isStraight()
    {
        return straight; //  was doing the wrong thing
        //quickSort(ranks, 0, ranks.Length - 1);
        //return ranks.Zip(ranks.Skip(1), (a, b) => b - a).All(diff => diff == 1);
    }
    public bool isFullHouse()
    {
        return (unique_ranks == 2 && num_pairs == 2);
    }

    private int partition(int[] arr, int low, int high)
    {
        int pivot = arr[high];
        int i = low - 1;

        for (int j = low; j <= high - 1; j++)
        {
            if (arr[j] < pivot)
            {
                i++;
                swap(arr, i, j);
            }
        }
        swap(arr, i + 1, high);
        return i + 1;
    }
    private void swap(int[] arr, int i, int j)
    {
        int temp = arr[i];
        arr[i] = arr[j];
        arr[j] = temp;
    }
    
    private void quickSort(int[] arr, int low, int high)
    {
        if (low < high)
        {
            int pi = partition(arr, low, high);
            quickSort(arr, low, pi - 1);
            quickSort(arr, pi + 1, high);
        }
    }

}