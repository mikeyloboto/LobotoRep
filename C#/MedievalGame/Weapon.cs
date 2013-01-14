using System;

namespace MedievalGame
{

    class Weapon
    { 
        public static int weaponId;
        public static String weaponName;
        public static int weaponDamage;

        public void initWeapon(int par1, int par2, string par3)
        {
            weaponId = par1;
            weaponDamage = par2;
            weaponName = par3;
        }

        public int getWeaponId()
        {
            return weaponId;
        }

        public int getWeaponDamage()
        {
            return weaponDamage;
        }

        public int getWeponDamagePlusModifier(int par1)
        {
            Random rand = new Random();
            return weaponDamage + rand.Next(par1) + 1;
        }

        public String getWeaponName()
        {
            return weaponName;
        }
    }
}
