using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace MedievalGame
{
    class Monster
    {
        public static Monster MonsterOrc = new Monsters.MonsterOrc();
        public static Monster MonsterWizard = new Monsters.MonsterWizard();
        public static Monster MonsterWolf = new Monsters.MonsterWolf();
        public String MonsterName;
        public int MonsterLvl;
        public int MonsterDefaultDamage;
        public int LootLevel;
        public int MonsterHp;
        public void initAll()
        {
            MonsterWolf.initMonster("Wolf", 1, 1);
            MonsterOrc.initMonster("Orc", 2, 2);
            MonsterWizard.initMonster("Wizard", 3, 3);
        }
        public void initMonster(string par1, int par2, int par3)
        {
            MonsterLvl = par3;
            LootLevel = par2;
            MonsterName = par1;
            MonsterHp = par3 * 10;

        }

    }
}
