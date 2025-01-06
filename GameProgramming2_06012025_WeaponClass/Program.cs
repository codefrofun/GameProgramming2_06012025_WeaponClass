using System;

namespace GameProgramming2_06012025_WeaponClass
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            Weapon myWeapon = new Weapon();
            myWeapon.WeaponAttack("Dragon");
        }
    }


    public class Weapon
    {
        private int durability = 50;
        private int damageSword = 15;//change numbers after testing
        private int enemyHealth = 50;

        public int Durability()
        {
            get { return durability; }
            set { durability = 50; }
        }

        public int DamageSword()
        {
            get { return damageSword; }
            set { damageSword = 15; }
        }

        public int EnemyHealth()
        {
            get { return enemyHealth; }
            set { enemyHealth = 50; }
        }

        public void WeaponAttack(string Dragon)
        {

            Console.WriteLine("Weapon durability is {Durability}. Enemy health is {EnemyHealth}.");

            Console.WriteLine("Attacking enemy...");

            EnemyHealthUpdate();

            Random rand = new Random();
            int durabilityLoss = rand.Next(5, 11);
            Durability -= durabilityLoss;

            Console.WriteLine($"Damage is {damageSword} enemy health is now {enemyHealthUpdate}");

            Console.WriteLine("Weapon durability is now 40");

            // attack enemy with damage
            // on screen, display enemies health minus the damage it has taken
        }

        private void EnemyHealthUpdate()
        {
            EnemyHealth -= DamageSword;
        }
    }
}
