using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArenaGame
{
    public class Bandit : Hero
    {
        private const int DoubleDamageChance = 10;
        private int attackCount;

        public Bandit(string name) : base(name)
        {

            attackCount = 0;
        }

        public override int Attack()
        {
            int attack = base.Attack();
            if (ThrowDice(DoubleDamageChance))
            {
                attack *= 2;
                Console.WriteLine($"{Name} performs a deadly strike for double damage!");
            }
            return attack;
        }

        public override void TakeDamage(int incomingDamage)
        {
            if (ThrowDice(25))
            {
                incomingDamage = 0;
                Console.WriteLine($"{Name} dodges the attack!");
            }
            base.TakeDamage(incomingDamage);
        }
    }
}
