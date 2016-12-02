using System;

public class MonsterEnemy
{
  public MonsterEnemy(int health, int damage, int groupnumber, int size, string name)
    {
        Health = health;
        Damage = damage;
        GroupNumber = groupnumber;
        Size = size;
        Name = name;


    }

    public int Health {get; set;}
    public int Speed {get; set;}
    public int Luck {get; set;}
    public int Damage {get; set;}
    public int GroupNumber {get; set;}
    public string Weapon {get; set;}
    public int Size {get; set;}
    public string Name {get; set;}
}