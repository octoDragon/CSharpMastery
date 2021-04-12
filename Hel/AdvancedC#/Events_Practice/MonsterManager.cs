using System;
namespace Hel.AdvancedCSharp
{
    public class MonsterManager
    {
        //delegate
        public delegate void DeathEventHandler(object source, MonsterEventArgs args);
        //event -> rat dying 
        public event DeathEventHandler MonsterDied;

        public void Die(Monster monster)
        {
            Console.WriteLine( monster.Type + " has been slain.");
            OnMonsterDeath(monster);
        }

        protected virtual void OnMonsterDeath(Monster monster)
        {
            if (MonsterDied != null)
                MonsterDied(this, new MonsterEventArgs() { Monster = monster});
        }
    }

    //monster args
    public class MonsterEventArgs : EventArgs
    {
        public Monster Monster {get; set;}
    }
}