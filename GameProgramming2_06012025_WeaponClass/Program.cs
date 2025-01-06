using System;

namespace GameProgramming2_06012025_WeaponClass
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            Weapon myWeapon = new Weapon();
            myWeapon.WeaponAttack();
        }

    }


    public class Weapon
    {
        private int durablility = 50;
        private int damageSword = 15;//change numbers after testing
        private int enemyHealth = 50;

        public void enemyHealthUpdate()
        {
            enemyHealth -= damageSword;
            return;
        }


        public void WeaponAttack()
        {

            Console.WriteLine("Weapon durablility is 50. \n Enemy health is 50.");

            Console.WriteLine("Attacking enemy...");

            enemyHealthUpdate();

            Console.WriteLine($"Damage is" + damageSword, "enemy health is now" + enemyHealthUpdate);

            Console.WriteLine("Weapon durablility is now 40");

            // attack enemy with damage
            // on screen, display enemies health minus the damage it has taken
        }
    }
}
