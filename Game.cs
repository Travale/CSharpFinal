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

        DeepForestLevel forest;
        Batallion battle;
        List<Battalion> Battlelist;
        List<Enemy> enemyList;
        Enemy enemy;
        Ability ability;
        public Game()
        {
            battle = new Battalion();
            Battlelist = new List<Battalion>();
            enemyList = new List<enemy>();
            enemy = new Enemy();
            forest = new DeepForestLevel();
            ability = new Ability();
        }
    
        public string phrase1 = "The bird sings when the clock ticks.";
        public string phrase2 = "Will the tree fall when the spell is ready?";
        public string phrase3 = "Rum is the best drink when the cat is sleeping.";
        public string phrase4 = "The sword falls on the weeping stump.";
        public void Beginning()
        {
            RainbowCave.BeginMessage = "You enter the cave of wonders";
            RainbowCave.obstacles = new string[] {"Moving rock", "Totem", "Spike mine", "Sparkle dust"};
        }
        public void Play()
        {
            InitializeMen();
            Console.WriteLine("What weapon do you choose?");
            Console.ReadLine();
        }

        public void InitializeMen()
        {
            for (int i = 0; i < battle.GroupNumber; i++)
            {
                //Creates a new battalion man
                Battlelist.Add(new Battalion());
                //Naming Battalion Man.
                Console.Write($"\nName of Battalion number {i + 1}? : ");
                Battlelist[i].Name = Console.ReadLine();

                //Asking if he has a weapon or ability
                Console.Write($"Does {Battlelist[i].Name} have a Weapon or Ability? : ");
                string input = Console.ReadLine();

                //Asking user for the name of the weapn
                if (input == "Weapon")
                {
                    Console.Write($"What Weapon does {Battlelist[i].Name} have? : ");
                    Battlelist[i].Weapon = Console.ReadLine();
                    Console.WriteLine($"{Battlelist[i].Name} is now equiped with a {Battlelist[i].Weapon}!!");
                }
                //Asking user which ability he wants to give the battalion man
                else
                {
                    battle.DisplayAbility();
                    Console.Write($"What ability does {Battlelist[i].Name} have? (enter in the number to select ability): ");
                    Battlelist[i].SelectAbility(int.Parse(Console.ReadLine()));
                    Console.WriteLine($"{Battlelist[i].Name} has been empowered with {Battlelist[i].Ability}!!");
                    Battlelist[i].Weapon = "";
                }
            }

            Console.ReadLine();
            //Displays list of battalion men
            Console.WriteLine("\nHere is you Battalion!\n");
            foreach (var item in Battlelist)
            {
                if(item.Weapon !="")
                    Console.WriteLine($"{item.Name} Equiped with: {item.Weapon}!");
                else
                    Console.WriteLine($"{item.Name} Empowered with: {item.Ability}!");
            }
            //The adventure starts 
            Console.WriteLine($"\nYour Battalion enters into the {forest.DeepForestName}\n");
            //Spawn monsters, the monster type is dependent on the dungeon name.
            forest.Create(enemyList);
            Console.ReadKey();
            //Runs combat for whatever monster you are fighting 
            Attack();
            //List what you have
            //if good then move to cave()
        }

           public void Attack()
        {
            do
            {
                //Combat side for Battalion men. Test to see if any monsters exsist 
                if (enemyList.Any())
                {
                    for (int i = 0; i < Battlelist.Count; i++)
                    {
                        if (Battlelist[i].Weapon != "" && enemyList.Any() && Battlelist.Any())
                        {
                            Console.WriteLine($"{Battlelist[i].Name} hits {enemyList[0].Name} with {Battlelist[i].Weapon}!\n");
                            enemyList[0].Health -= Battlelist[0].Damage;
                            enemy.CheckDeath(enemyList);
                            Console.ReadLine();
                        }
                        else if (enemyList.Any() && Battlelist.Any())
                        {
                            Console.WriteLine($"{Battlelist[i].Name} hits {enemyList[0].Name} with {Battlelist[i].Ability}!\n");
                            ability.UseAbility(Battlelist[i].Ability, enemyList);
                            //monsterList[0].Health -= spell.Damage;
                            enemy.CheckDeath(enemyList);
                            Console.ReadLine();
                        }
                        else
                            Console.WriteLine("You lose");
                        //Combat for Monster
                    }
                }

            for(int i = 0; i < enemyList.Count; i++)
                {
                    if (Battlelist.Any())
                    {
                        Random randomHit = new Random();
                        int j = randomHit.Next(0, Battlelist.Count);
                        Console.WriteLine($"{enemyList[i].Name} hits {Battlelist[j].Name} with a {enemyList[i].Weapon}!\n");
                        Console.ReadLine();
                        Battlelist[j].Health -= enemyList[i].Damage;
                        Console.WriteLine($"{Battlelist[j].Name} has {Battlelist[j].Health} hit points left !\n");
                        battle.CheckDeath(Battlelist);
                        Console.ReadKey();
                    }
                    else Console.WriteLine("You lose"); 
                }
                // Console.WriteLine($"{monsterList[0].Name} hits {Battlelist[0].Name} with a {monsterList[0].Weapon}!");
            } while (enemyList.Any() && Battlelist.Any());
            Console.WriteLine("Good job!");
        }

    public static void GameTimer()
    {
        System.Threading.Thread.Sleep(3000);
    }

    public void Attack(int i, Batallion.GroupNumber)
    {
        if(Batallion.Weapon = "Sword")
        {
            
        }
        for(i = 0, Batallion < 10, i++ )
        {

        }
    }


    
    public static LevelTemplate RainbowCave = new LevelTemplate();
    }

}