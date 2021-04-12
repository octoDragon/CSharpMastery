using System;
namespace Hel.AdvancedCSharp
{
    public class EventProgram
    {
        public static void Program()
        {
            //object
            Rat rat1 = new Rat();
            Rat rat2 = new Rat();
            Dragon drag1 = new Dragon();
            //broadcaster
            MonsterManager mm = new MonsterManager();
            //subscriber(s)
            var experienceManager = new ExpierenceManager();
            var statsManager = new StatsManager();

            //subscribing 
            mm.MonsterDied += experienceManager.OnMonsterDeath;
            mm.MonsterDied += statsManager.OnMonsterDeath;

            mm.Die(rat1);
            mm.Die(rat2);
            mm.Die(drag1);
        }
    }
}