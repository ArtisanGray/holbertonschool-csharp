using System;
using System.Collections;
using System.Collections.Generic;

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
    public void PrintHealth()
    {
        Console.WriteLine($"{name} has {hp} / {maxHp} health");
    }
}