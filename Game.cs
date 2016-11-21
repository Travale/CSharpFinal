//Want battalions
//weapon variable, speed, health, damage, luckiness
//abilities for seperate battalions, Rasengan, Moon strike, leaf storm, light beam.
//2 levels maybe 1. Deep forest and Rainbow caves. 
//lose 5 hitpoints random battalion member dies.
//Power ups.  Berserk and go metallic
//Next monster gets bigger than last. 
//3 ninjas have a combo ability if one dies the power lessons.  If two ninjas have two different weapons they can attack with a combo.
//4 random rooms per level.
//Run in to bombs that kill you
//5 people per batallion, weapon or ability for each person
//3 abilities overall.  
using System;

namespace NinjaGame
{
    public class Game
    {

        public string phrase1 = "The bird sings when the clock ticks.";
        public string phrase2 = "Will the tree fall when the spell is ready?";
        public string phrase3 = "Rum is the best drink when the cat is sleeping.";
        public string phrase4 = "The sword falls on the weeping stump.";
        public void Beginning()
        {
            RainbowCave.BeginMessage = "You enter the cave of wonders";
            RainbowCave.obstacles = new string[] {"Moving rock", "Totem", "Spike mine", "Sparkle dust"};
        }
        public void Start()
        {

        }

    public static void GameTimer()
    {
        System.Threading.Thread.Sleep(3000);
    }

    public static LevelTemplate RainbowCave = new LevelTemplate();
    }

}