﻿using System;
using System.Collections.Generic;

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

class Decoration : Base, IInteractive, IBreakable
{
    public bool isQuestItem;
    public int durability { get; set; }

    public Decoration(string name = "Decoration", int durability = 1, bool isQuestItem = false)
    {
        if (durability <= 0)
            throw new Exception("Durability must be greater than 0");
        this.name = name;
        this.durability = durability;
        this.isQuestItem = isQuestItem;
    }

    public void Interact()
    {
        if (durability <= 0)
            Console.WriteLine($"The {name} has been broken.");
        else if (isQuestItem)
            Console.WriteLine($"You look at the {name}. There's a key inside.");
        else if (isQuestItem == false)
            Console.WriteLine($"You look at the {name}. Not much to see here.");
    }

    public void Break()
    {
        durability--;

        if (durability > 0)
            Console.WriteLine($"You hit the {name}. It cracks.");
        else if (durability == 0)
            Console.WriteLine($"You smash the {name}. What a mess.");
        else if (durability < 0)
            Console.WriteLine($"The {name} is already broken.");
    }
}

class Key : Base, ICollectable
{
    public bool isCollected { get; set; }

    public Key(string name = "Key", bool isCollected = false)
    {
        this.name = name;
        this.isCollected = isCollected;
    }

    public void Collect()
    {
        if (isCollected == false)
        {
            isCollected = true;
            Console.WriteLine($"You pick up the {name}.");
        }
        else if (isCollected == true)
            Console.WriteLine($"You have already picked up the {name}.");
    }
}

class RoomObjects
{
    public static void IterateAction(List<Base> roomObjects, Type type)
    {
		foreach (Base item in roomObjects)
		{

			if (type == typeof(IInteractive) && item is IInteractive)
				((IInteractive)item).Interact();
			else if (type == typeof(IBreakable) && item is IBreakable)
				((IBreakable)item).Break();
			else if (type == typeof(ICollectable) && item is ICollectable)
				((ICollectable)item).Collect();
        } 
    }
}