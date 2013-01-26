using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace MedievalGame.Events
{
    class CombatEvent : Event
    {
        public static Monster monsterChoice;
        public static Combat combat = new Combat();
        public static void generateMonsterEvent()
        {
            int rand = Game.rollDice(3);
            switch (rand)
            {
                case 1:
                    monsterChoice = Monster.MonsterWolf;
                    break;
                case 2:
                    monsterChoice = Monster.MonsterOrc;
                    break;
                case 3:
                    monsterChoice = Monster.MonsterWizard;
                    break;
            }
            combat.startCombat(monsterChoice, Game.player);
        }
    }
}
