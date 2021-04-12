using System;
namespace Hel.AdvancedCSharp
{
    public class StatsManager
    {
        int ratKills = 0;
        int dragonKills = 0;
        
        public void OnMonsterDeath(object source, MonsterEventArgs args)
        {
            switch (args.Monster.Type)
            {
                case "rat":
                    ratKills++;
                    break;
                case "dragon":
                    dragonKills++;
                    break;
                default:
                    break;
            }

            System.Console.WriteLine("Rat Kills: " + ratKills);
            System.Console.WriteLine("Dragon Kills " + dragonKills);
            System.Console.WriteLine('\n');
        }
   }
}