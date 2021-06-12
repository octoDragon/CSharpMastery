using System;

public class Achievement_System : Observer
{
    Physics physics;
    public void OnNotify(Entity entity, Enum e)
    {
        int x = physics.IN_WATER;

        //switch(eventA)
        switch(e)
        {
            case IN_WATER: //how to enums from different classes? 
                UnlockAchievement(IN_WATER);
            default:
                break;
        }
    }

    public void UnlockAchivement(Enum e)
    {
        Console.Write("You have unlcoked the: ");
        switch (e)
        {

        }
    }
}