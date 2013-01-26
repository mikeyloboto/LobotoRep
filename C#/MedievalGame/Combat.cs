using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace MedievalGame
{
    class Combat
    {
        public static Monster monster;
        public void startCombat(Monster par1, Player par2)
        {
            monster = par1;
            GameWindow.OutLine("You have started a battle with " + monster.MonsterName);

        }
    }
}
