using System;

namespace GameProgramming2_06012025_WeaponClass
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            Weapon myWeapon = new Weapon();
            //creating instance
            myWeapon.WeaponAttack("Dragon");
            //calling my class
            Console.ReadLine();
        }
    }


    public class Weapon
    {
        private int durability = 50;
        private int damageSword = 15;
        private int enemyHealth = 50;
        //setting private variables

        public int Durability
        {
            get { return durability; }
            set { durability = value; }
        }

        public int DamageSword
        {
            get { return damageSword; }
            set { damageSword = value; }
        }

        public int EnemyHealth
        {
            get { return enemyHealth; }
            set { enemyHealth = value; }
        }

        public void WeaponAttack(string Dragon)
        {

            Console.WriteLine("Weapon durability is {Durability}. Enemy health is {EnemyHealth}.");

            Console.WriteLine("Attacking enemy...");

            EnemyHealthUpdate();

            Random rand = new Random();
            int durabilityLoss = rand.Next(5, 11);
            Durability -= durabilityLoss;

            Console.WriteLine($"Damage {DamageSword} applied to enemy {Dragon}. Enemy health is now {EnemyHealth}.");

            Console.WriteLine($"Weapon durability is now {Durability}.");

            // attack enemy with damage
            // on screen, display enemies health after taking damage
        }

        private void EnemyHealthUpdate()
        {
            EnemyHealth -= DamageSword;
        }
    }
}