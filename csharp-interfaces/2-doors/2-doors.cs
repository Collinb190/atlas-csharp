﻿using System;

abstract class Base
{
    public string name  { get; set; }
    public override string ToString()
    {
        return name + " is a " + this.GetType();
    }
}

interface IInteractive
{
    void Interact();
}

interface IBreakable
{
    int durability { get; set; }
    void Break();
}

interface ICollectable
{
    bool isCollected { get; set; }
    void Collect();
}

class Door : Base, IInteractive
{
    public Door(string n = "Door")
    {
        name = n;
    }
    public void Interact()
    {
        Console.WriteLine($"You try to open the {name}. It's locked.");
    }
}
