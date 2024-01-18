using System;
using System.Collections.Generic;
using System.Text;

namespace TurnBase
{
    class Unit
    {
        //Unit basic stats
        int currentHp;
        int maxHp;
        int attackPower;
        int healPower;
        string unitName;
        Random random;

        public int Hp
        {
            get { return currentHp; }
        }

        public string Name
        {
            get { return unitName; }
        }

        public bool isDead
        {
            get { return currentHp <= 0; }
        }

        public Unit(int maxHp, int attackPower, int healPower, string unitName)
        {
            this.maxHp = maxHp;
            this.currentHp = maxHp;
            this.attackPower = attackPower;
            this.healPower = healPower;
            this.unitName = unitName;
            this.random = new Random();
        }

        public void Attack(Unit unitToAttack)
        {
            //Randomize damage value
            double rng = random.NextDouble();
            rng = rng / 2 + 0.75f;
            int randomDamage = (int)(attackPower * rng);
            unitToAttack.TakeDamage(randomDamage);
            Console.WriteLine(unitName + " attacks " + unitToAttack.unitName + " and deals " + randomDamage + " damage");
            Console.WriteLine("");
        }

        public void TakeDamage(int damage)
        {
            currentHp -= damage;

            if (isDead)
                Console.WriteLine(unitName + " has been defeated");
        }

        public void Heal()
        {
            //Randomize heal value
            double rng = random.NextDouble();
            rng = rng / 2 + 0.75f;
            int heal = (int)(healPower * rng);
            currentHp = currentHp + heal > maxHp ? maxHp : currentHp + heal;
            Console.WriteLine(unitName + " heals " + heal);
            Console.WriteLine("");

        }
    }


}
