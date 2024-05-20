using System;


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
    }

    public void HealDamage(float heal)
    {
        if (heal < 0) heal = 0;
        Console.WriteLine($"{this.name} heals {heal} HP!");
    }
}
