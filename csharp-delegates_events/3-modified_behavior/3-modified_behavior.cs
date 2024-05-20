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
    }

    public float ApplyModifier(float baseValue, Modifier modifier)
    {
        if (modifier == Modifier.Weak) return baseValue * 0.5f;
        else if (modifier == Modifier.Strong) return baseValue * 1.5f;
        else return baseValue;
    }
}