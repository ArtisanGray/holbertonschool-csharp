using System;

/// <summary>
/// player class
/// </summary>
public class Player
{
    private string name
    {
        get;
        set;
    }
    private float maxHp
    {
        get;
        set;
    }
    private float hp
    {
        get;
        set;
    }
    /// <summary>
    /// player constructor
    /// </summary>
    /// <param name="name">player name</param>
    /// <param name="maxHp">player max hp</param>
    public Player(string name = "Player", float maxHp = 100f)
    {
        this.name = name;
        if (maxHp <= 0)
        {
            this.maxHp = 100f;
            this.hp = 100f;
            Console.WriteLine("maxHp must be greater than 0. maxHp set to 100f by default.");
        }
        else
        {
            this.maxHp = maxHp;
            this.hp = maxHp;
        }
    }
    /// <summary>
    /// player print
    /// </summary>
    public void PrintHealth()
    {
        Console.WriteLine($"{name} has {hp} / {maxHp} health");
    }
}