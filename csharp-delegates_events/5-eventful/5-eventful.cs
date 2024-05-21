using System;

public enum Modifier
{
    Weak,
    Base,
    Strong
};

public delegate float CalculateModifier(float baseValue, Modifier modifier);

class Player
{
    private string name;
    private float maxHp;
    private float hp;
    private string status;

    /// <summary>
    /// Player constructor
    /// </summary>
    /// <param name="name">Players name</param>
    /// <param name="maxHp">total health</param>
    public Player(string name = "Player", float maxHp = 100f)
    {
        this.name = name;
        if (maxHp > 0) this.maxHp = maxHp;
        else
        {
            Console.WriteLine("maxHp must be greater than 0. maxHp set to 100f by default.");
            this.maxHp = 100f;
        }
        this.hp = this.maxHp;
        this.status = $"{this.name} is ready to go!";
        HPCheck += CheckStatus;
    }

    /// <summary>
    /// Prints the health of Player
    /// </summary>
    public void PrintHealth()
    {
        Console.WriteLine($"{this.name} has {this.hp} / {this.maxHp} health");
    }

    public delegate void CalculateHealth(float damage);

    public void TakeDamage(float damage)
    {
        if (damage < 0) damage = 0;
        Console.WriteLine($"{this.name} takes {damage} damage!");
        this.hp -= damage;
        ValidateHP(this.hp);
    }

    public void HealDamage(float heal)
    {
        if (heal < 0) heal = 0;
        Console.WriteLine($"{this.name} heals {heal} HP!");
        this.hp += heal;
        ValidateHP(this.hp);
    }

    public void ValidateHP(float newHP)
    {
        if (newHP < 0f) this.hp = 0f;
        else if (newHP > this.maxHp) this.hp = this.maxHp;
        else this.hp = newHP;
        OnCheckStatus(new CurrentHPArgs(this.hp));
    }

    public float ApplyModifier(float baseValue, Modifier modifier)
    {
        if (modifier == Modifier.Weak) return baseValue * 0.5f;
        else if (modifier == Modifier.Strong) return baseValue * 1.5f;
        else return baseValue;
    }

    public event EventHandler<CurrentHPArgs> HPCheck;

    private void CheckStatus(object sender, CurrentHPArgs e)
    {
        if (e.currentHP == this.maxHp) this.status = $"{this.name} is in perfect health!";
        else if (e.currentHP >= (this.maxHp * 0.5f) && e.currentHP < this.maxHp) this.status = $"{this.name} is doing well!";
        else if (e.currentHP >= (this.maxHp * .25f) && e.currentHP < (this.maxHp * 0.5f)) this.status = $"{this.name} isn't doing too great...";
        else if (e.currentHP > 0f && e.currentHP < (this.maxHp * 0.5f)) this.status = $"{this.name} needs help!";
        else this.status = $"{this.name} is knocked out!";
        Console.WriteLine(this.status);
    }

    private void HPValueWarning(object sender, CurrentHPArgs e)
    {
        if (e.currentHP == 0) Console.WriteLine("Health has reached zero!");
        else Console.WriteLine("Health is low!");
    }

    public void OnCheckStatus(CurrentHPArgs e)
    {
        if (e.currentHP < (this.maxHp * 0.25f)) HPCheck += HPValueWarning;
        HPCheck(this, e);
    }
}

class CurrentHPArgs : EventArgs
{
    public readonly float currentHP;

    public CurrentHPArgs(float newHP)
    {
        this.currentHP = newHP;
    }
}