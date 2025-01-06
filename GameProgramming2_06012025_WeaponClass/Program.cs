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

        }

        public int DamageSword()
        {

        }

        public int EnemyHealth()
        {

        }

        public void enemyHealthUpdate()
        {
            enemyHealth -= damageSword;
            return;
        }


        public void WeaponAttack(string Dragon)
        {

            Console.WriteLine("Weapon durablility is 50. \n Enemy health is 50.");

            Console.WriteLine("Attacking enemy...");

            enemyHealthUpdate();

            Console.WriteLine($"Damage is {damageSword} enemy health is now {enemyHealthUpdate}");

            Console.WriteLine("Weapon durability is now 40");

            // attack enemy with damage
            // on screen, display enemies health minus the damage it has taken
        }
    }
}
