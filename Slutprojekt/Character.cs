using System;

namespace Slutprojekt;

public abstract class Character
{
public string Name;
public int Health;
public int MaxHealth;

public Character(string name, int maxHealth)
    {
        Name = name;
        MaxHealth = maxHealth;
        Health = maxHealth;
    }
}
