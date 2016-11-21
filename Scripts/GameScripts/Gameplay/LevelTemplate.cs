using System;

public class LevelTemplate
{
    private void Begin()
    {
        Console.WriteLine("How are you?");
    }

    public string BeginMessage;

    public bool doorUnlocked = true;
    public string[] levelType;  
    public string[] obstacles;

    public string[] rooms;

    public string[] doors;



    public void GoIn (){
        Console.WriteLine(BeginMessage);
    }

     public void Meeting (int i){
            switch (i)
            {
                case 0:
                    Console.WriteLine("You run into a " + obstacles[i]);
                break;

                case 1:
                    Console.WriteLine("You run into a " + obstacles[i]);
                break;
    
                case 2:
                    Console.WriteLine("You run into a " + obstacles[i]);

                    Random randomNum = new Random();
                    Beginning.RainbowCave.Meeting(randomNum.Next(0, Beginning.RainbowCave.obstacles.Length));
                break;
            }
}
}