using System;
namespace Hel.AdvancedCSharp
{
    public class Monster
    {
        private string type;
        private int xpAmount; 
        
        public string Type
        {
            get {return type;}
            set { type = value;}
        }
        public int XpAmount
        {
            get {return xpAmount;}
            set {xpAmount = value;}
        }
    }
}
