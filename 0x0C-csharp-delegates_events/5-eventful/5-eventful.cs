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
    string status;
    EventHandler<CurrentHPArgs> HPCheck;
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
        this.HPCheck += CheckStatus;
        this.status = name + " is ready to go!";
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
        {
            Console.WriteLine($"{name} takes {damage} damage!");
            ValidateHP(hp - damage);
        }

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
        {
            Console.WriteLine($"{name} heals {heal} HP!");
            ValidateHP(hp + heal);
        }
    }
    /// <summary>
    /// modifies the hp value of the player.
    /// </summary>
    /// <param name="newHp">new hp value to be compared with.</param>
    public void ValidateHP(float newHp)
    {
        if (newHp < 0)
            hp = 0;
        else if (newHp > maxHp)
            hp = maxHp;
        else
            hp = newHp;
        OnCheckStatus(this, new CurrentHPArgs(this.hp));
    }
    /// <summary>
    /// applies given modifier.
    /// </summary>
    /// <param name="baseValue"> base float value to modify.</param>
    /// <param name="modifier">modifier to apply</param>
    /// <returns></returns>
    public float ApplyModifier(float baseValue, Modifier modifier)
    {
        if (modifier == Modifier.Weak)
            return (baseValue / 2);
        else if (modifier == Modifier.Base)
            return baseValue;
        else
            return (baseValue * 2);
    }
    /// <summary>
    /// checks the status of the player
    /// </summary>
    /// <param name="sender">sender</param>
    /// <param name="e">event</param>
    private void CheckStatus(object sender, CurrentHPArgs e)
    {
        if (e.currentHp == maxHp)
            this.status = name + " is in perfect health!";
        else if (e.currentHp >= maxHp * 0.5f)
            this.status = name + " is doing well!";
        else if (e.currentHp >= maxHp * 0.25f)
            this.status = name + " isn't doing too great...";
        else if (e.currentHp > 0)
            this.status = name + " needs help!";
        else
            this.status = name + " is knocked out!";
        Console.WriteLine(status);
    }
    private void HPValueWarning(object sender, CurrentHPArgs e)
    {
        if (e.currentHp == 0)
        {
            Console.BackgroundColor = ConsoleColor.Red;
            Console.WriteLine("Health has reached zero!");
        }
        else
        {
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine("Health is low!");
        }
        Console.BackgroundColor = ConsoleColor.Black;
        Console.ForegroundColor = ConsoleColor.White;
    }
    /// <summary>
    /// 
    /// </summary>
    /// <param name="sender"></param>
    /// <param name="e"></param>
    void OnCheckStatus(object sender, CurrentHPArgs e)
    {
        if (e.currentHp < maxHp * 0.25)
        {
            HPCheck += HPValueWarning;
        }
        HPCheck(this, e);
    }
}
/// <summary>
/// modifier and stuff.
/// </summary>
public enum Modifier
{
    /// <summary>
    /// weak modifier
    /// </summary>
    Weak,
    /// <summary>
    /// base modifier. no changes.
    /// </summary>
    Base,
    /// <summary>
    /// strong modifier.
    /// </summary>
    Strong
}
/// <summary>
/// calculates an applied modifier to the given float.
/// </summary>
/// <param name="baseValue"> base value to pass</param>
/// <param name="modifier"> modifier to pass to base value</param>
/// <returns></returns>
public delegate float CalculateModifier(float baseValue, Modifier modifier);
/// <summary>
/// gets and sets hp
/// </summary>
public class CurrentHPArgs : EventArgs
{
    /// <summary>
    /// current hp
    /// </summary>
    public float currentHp
    {
        get;
    }
    /// <summary>
    /// hp constructor
    /// </summary>
    /// <param name="newHp">hp to set</param>
    public CurrentHPArgs(float newHp)
    {
        currentHp = newHp;
    }
}