using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArenaGame
{

    public abstract class Weapon
    {
        public abstract string Name { get; }
        public abstract int Damage { get; }
    }
    public class Sword : Weapon
    {
        public override string Name => "Sword";
        public override int Damage => 10; 
    }
  
    public class Bow : Weapon
    {
        public override string Name => "Bow";
        public override int Damage => 8; 
    }
    public class Axe : Weapon
    {
        public override string Name => "Axe";
        public override int Damage => 12; 
    }

}
