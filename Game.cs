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

namespace EpicGame
{

   
    public class Game
    {
        public Batallion battle = new Batallion();
        public MonsterEnemy oni = new MonsterEnemy(60, 10, 2, 5, "oni");
        public MonsterEnemy cursedNinja = new MonsterEnemy(50, 20, 3, 1, "cursed ninja");
        public MonsterEnemy bladePanda = new MonsterEnemy(50, 15, 2, 3, "bladePanda");
        public MonsterEnemy trickster = new MonsterEnemy(30, 17, 4, 2, "trickster");



   
   
    
        public string phrase1 = "The spirit sings when the clock ticks.";
        public string phrase2 = "Will the tree fall when the technique morning sun rises?";
        public string phrase3 = "Rum is the best drink when the cat is sleeping.";
        public string phrase4 = "The sword falls on the weeping stump.";
        public void Beginning()
        {
            RainbowCave.BeginMessage = "You enter the cave of wonders";
            RainbowCave.obstacles = new string[] {"Moving rock", "Totem", "Spike mine", "Sparkle dust"};
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
    break;

    case 2:
         Console.WriteLine("You encounter an" + oni.Name + "behind the " + RainbowCave.doors[randomDoor.Next(0,4)]);
        
    }
}
    public void Play()
    {
        Console.WriteLine("Choose doors 1 - 4");
        OpenDoor(int.Parse(Console.ReadLine()));
        RainbowCave.doors = new string[] {"Demon door", "Wood door", "Steel door", "Racoon door"};


    }

    public void Attack(int i, Batallion battle)
    {
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
        for(i = 0;  i < battle.GroupNumber ; i++ )
        {
           Console.WriteLine("You gained one man");
           battle.Damage += 5;

        }

    }

    public void EnemyEncounter()
    {

    }


    
    public static LevelTemplate RainbowCave = new LevelTemplate();
    }

}