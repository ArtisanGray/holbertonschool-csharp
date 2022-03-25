using System;

/// <summary>
/// player class
/// </summary>
public class Player
{
    string name
    {
        get;
        set;
    }
    float maxHp
    {
        get;
        set;
    }
    float hp
    {
        get;
        set;
    }
    /// <summary>
    /// player constructor.
    /// </summary>
    /// <param name="name">player's name</param>
    /// <param name="maxHp">player's max hp allowed.</param>
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
    /// prints current health values.
    /// </summary>
    public void PrintHealth()
    {
        Console.WriteLine($"{name} has {hp} / {maxHp} health");
    }
    /// <summary>
    /// 
    /// </summary>
    /// <param name="x">health amount passed as param.</param>
    /// <returns></returns>
    public delegate void CalculateHealth(float x);
    /// <summary>
    /// deduct from current health pool.
    /// </summary>
    /// <param name="damage">amount of health to deduct.</param>
    public void TakeDamage(float damage)
    {
        if (damage < 0)
            Console.WriteLine($"{name} takes 0 damage!");
        else
            Console.WriteLine($"{name} takes {damage} damage!");
    }
    /// <summary>
    /// heals the player, prints status.
    /// </summary>
    /// <param name="heal">amount to heal passed as parameter.</param>
    public void HealDamage(float heal)
    {
        if (heal < 0)
            Console.WriteLine($"{name} heals 0 HP!");
        else
            Console.WriteLine($"{name} heals {heal} HP!");
    }
}
