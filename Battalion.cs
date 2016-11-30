using System;

public class Batallion
{

    public Batallion()
    {
        Health = 50;
        Speed = 40;
        Luck = 50;
        Damage = 10;
        GroupNumber = 10;
        Weapon = "kunai";
    }

    public Batallion(int health, int speed, int luck, int damage, int groupnumber, string weapon)
    {
        Health = health;
        Speed = speed;
        Luck = luck;
        Damage = damage;
        GroupNumber = groupnumber;
        Weapon = weapon;

    }

    public void MonsterEnemy(int health, int damage, int groupnumber)
    {

    }

    public int Health {get; set;}
    public int Speed {get; set;}
    public int Luck {get; set;}
    public int Damage {get; set;}
    public int GroupNumber {get; set;}
    static string Weapon {get; set;}


}


