using System;

public class Spells
{
        public int MoonStrike(int Damage)
        {
        int betterDamage = Damage + 30;
        }
        public int LightBeam(int Damage, int Health)
        {
        int betterDamage = Damage + 10;
        int betterLuck = Health + 10;
        }
        public void LeafStorm(int Damage, int Luck)
        {
        int betterDamage = Damage + 20;
        int betterLuck = Luck + 20;
        } 
    
}