//Want battalions
//weapon variable, speed, health, damage, luckiness
//abilities for seperate battalions, Rasengan, Moon strike, leaf storm, light beam.
//2 levels maybe 1. Deep forest and Rainbow caves. 
//lose 5 hitpoints random battalion member dies.
//Power ups.  Berserk and go metallic
//Next monster gets bigger than last. 
//3 ninjas have a combo ability if one dies the power lessens.  If two ninjas have two different weapons they can attack with a combo.
//4 random rooms per level.
//Run in to bombs that kill you
//5 people per batallion, weapon or ability for each person
//3 abilities overall.  
//attack object with ranged and melee weapons if else distance effect
using System;
using System.Collections.Generic;

namespace EpicGame
{

   
    public class Game
    {
        public Batallion battle = new Batallion();
        public MonsterEnemy oni = new MonsterEnemy(60, 10, 2, 5, "oni");
        public MonsterEnemy cursedNinja = new MonsterEnemy(50, 20, 3, 1, "cursed ninja");
        public MonsterEnemy bladePanda = new MonsterEnemy(50, 15, 2, 3, "bladePanda");
        public MonsterEnemy trickster = new MonsterEnemy(30, 17, 4, 2, "trickster");

        public static MonsterEnemy monstergroup = new MonsterEnemy();

        



   
   
    
        public string phrase1 = "The spirit sings when the clock ticks.";
        public string phrase2 = "Will the tree fall when the technique morning sun rises?";
        public string phrase3 = "Rum is the best drink when the cat is sleeping.";
        public string phrase4 = "The sword falls on the weeping stump.";
        public void Beginning()
        {
            Random randomStuff = new Random();
            RainbowCave.BeginMessage = "You enter the cave of wonders";
            RainbowCave.obstacles = new string[] {"Moving rock", "Totem", "Spike mine", "Sparkle dust"};
            RainbowCave.description = new string[] {"Shiny", "glowing", "grassy", "Rocky"};
            Console.WriteLine("You start walking and run in to " + RainbowCave.obstacles[randomStuff.Next(0,4)]);
            Console.WriteLine("You look around and see that the cave is " + RainbowCave.description[randomStuff.Next(0,4)]);
            Play();
        }
     

    public static void GameTimer()
    {
        System.Threading.Thread.Sleep(3000);
    }

public void OpenDoor(int i)
{
    
    Random randomDoor = new Random();
    switch(i)
    {
    case 1:
        Console.WriteLine("You encounter an" + oni.Name + "behind the " + RainbowCave.doors[randomDoor.Next(0,4)]);
        Attack(oni, battle);
        UseSpell();
    break;

    case 2:
         Console.WriteLine("You encounter an" + cursedNinja.Name + "behind the " + RainbowCave.doors[randomDoor.Next(0,4)]);
         Attack(cursedNinja, battle);
         UseSpell();
    break;

    case 3:
        Console.WriteLine("You encounter a" + bladePanda.Name + "behind the" + RainbowCave.doors[randomDoor.Next(0,4)] );
        Attack(bladePanda, battle);
        UseSpell();
    break;

    case 4: 
        Console.WriteLine("You encounter a" + trickster.Name + "behind the" + RainbowCave.doors[randomDoor.Next(0,4)]);
        Attack(trickster, battle);
        UseSpell();
    break; 


    }
}
    
    public void Play()
    {
        
        Console.WriteLine("Choose doors 1 - 4");
        OpenDoor(int.Parse(Console.ReadLine()));
        RainbowCave.doors = new string[] {"Demon door", "Wood door", "Steel door", "Racoon door"};


    }

    public void Attack(MonsterEnemy monstergroup, Batallion battle)
    {
        monstergroup.monster = new string[] {"oni","cursed ninja","blade panda", "trickster"};
        Console.WriteLine("Which weapon do you have?");
        string input = Console.ReadLine();
        if(battle.Weapon == "Sword")
        {
            Console.WriteLine("You rush up to one range of your enemy");
        }
        else if(battle.Weapon == "Bow")
        {
            Console.WriteLine("You move in to five range of your enemy");
        }
        else
            Console.WriteLine("You have nowhere to move");
        for(int i = 0;  i < battle.GroupNumber ; i++ )
        {
           Console.WriteLine("You gained one man");
           battle.Damage += 5;

        }
        switch(monstergroup.Name)
        {
            case "oni":
                battle.Health -= 5;
                Console.WriteLine("The oni lowers your health by 5");
            break;
            case "cursed ninja":
                battle.Luck -= 5;
                Console.WriteLine("The cursed ninja lowers your luck");
            break;
            case "blade panda":
                battle.Damage -= 5;
                Console.WriteLine("The blade panda lowers your damage");
            break;
            case "trickster":
                battle.Speed -= 5;
                Console.WriteLine("The trickster lowers your speed");
            break;
            default:
                battle.Health -= 10;
                Console.WriteLine("What just happened?");
            break;
        }

    }

    public int HealthByTen(Batallion battle)
    {
        return battle.Health * 10;
    }

    public int LuckByTen(Batallion battle)
    {
        return battle.Luck * 10;
    }

    public int GroupByFive(Batallion battle)
    {
        return battle.GroupNumber * 5;
    }
    public void UseSpell()
    {
        Console.WriteLine("You see three items on the ground, choose one.  Choose whirlwind star, eclipsed medallion, or shining sun bar.");
        string spellItem = Console.ReadLine();
        switch(spellItem)
        {
            case "whirlwind star":
                Console.WriteLine("You equip the ability Leaf Storm");
            break;
            case "eclipsed medallion":
                Console.WriteLine("You equip the ability Moon Strike");
            break;
            case "shining sun bar":
                Console.WriteLine("You equip the ability light beam");
            break;
            default: 
                Console.WriteLine("You don't have any abilities");
            break;
        }

        while(cursedNinja.Health > 10)
        {
            Console.WriteLine("You use light beam on your enemy the cursed ninja");
            Console.WriteLine(phrase1);
            cursedNinja.Health -= 20;
        }

        while(oni.Health > 10)
        {
            Console.WriteLine("You use Leaf Storm on your enemy the oni");
            Console.WriteLine(phrase2);
            oni.Health -= 20;
        }

        for(int i = 0; oni.Health > i; i++)
        {
           Console.WriteLine("The oni is regenerating");
           Console.WriteLine(phrase3);
           oni.Damage ++; 
        }
        
        

        Console.WriteLine("Your health is increased by " + HealthByTen(battle));
        Console.WriteLine("Your Luck is increased by " + LuckByTen(battle));
        Console.WriteLine("Your battle group is increased by " + GroupByFive(battle));

    }
    public void MoreTroops()
    {
        List<Batallion> group = new List<Batallion>();

        group.Add( new Batallion(60, 30, 60, 15, 12, "ronin sword"));
        group.Add( new Batallion(40, 40, 40, 15, 15, "kunai and chain"));
        group.Add( new Batallion(70, 20, 20, 10, 15, "Poison blossom"));
        group.Add( new Batallion(50, 20, 30, 12, 12, "spike guantlets"));
      

    }
    public void EnemyEncounter()
    {

    }


    
    public static LevelTemplate RainbowCave = new LevelTemplate();
    }

}