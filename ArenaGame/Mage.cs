using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArenaGame
{
    public class Mage : Hero
    {
        private const int DoubleDamageChance = 20; // 20% chance to deal double damage

        private const int ManaRestorationRound = 4; // Restores mana every 4 rounds

        private const int ManaCostForSpecialAttack = 30; // Mana cost for special attack

        private const int MaxMana = 100;

        private int mana;

        private int attackCount;

        public Mage(string name) : base(name)
        {
            attackCount = 0;
        }
        public override int Attack()
        {
            int attack = base.Attack();

            // Check if enough mana for special attack
            if (mana >= ManaCostForSpecialAttack)
            {
                if (ThrowDice(DoubleDamageChance))
                {
                    attack *= 2;
                    mana -= ManaCostForSpecialAttack;
                    Console.WriteLine($"{Name} uses a powerful magic attack!");
                }
            }

            attackCount++;
            if (attackCount % ManaRestorationRound == 0)
            {
                mana = Math.Min(mana + 25, MaxMana);
                Console.WriteLine($"{Name} restores 25 mana.");
            }

            return attack;
        }

        public override void TakeDamage(int incomingDamage)
        {
            if (ThrowDice(15)) // 15% chance to completely avoid damage
            {
                incomingDamage = 0;
                Console.WriteLine($"{Name} uses a magical shield to avoid damage!");
            }
            base.TakeDamage(incomingDamage);
        }
    }
}
