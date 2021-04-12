using System;
namespace Hel.AdvancedCSharp
{
    public class ExpierenceManager
    {
        int totalExpierence = 0;

        public void OnMonsterDeath(object source, MonsterEventArgs args)
        {
            totalExpierence += args.Monster.XpAmount;
            Console.WriteLine("Total Expierence = " + totalExpierence);
        }
    }
}