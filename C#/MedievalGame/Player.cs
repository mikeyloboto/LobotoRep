using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace MedievalGame
{
    class Player
    {
        public int coordX;
        public int coordY;
        public int health;
        public Item[] inventory;
        public String name;
        public int coins;
        public int mana;
        public int hitModifier;
        public int hitModifierDuration;
        public int Exp;

        public void hitModifierDecrease()
        {
            if (hitModifierDuration > 0)
            {
                hitModifier -= 1;
            }
            if (hitModifierDuration == 0)
            {
                hitModifier = 0;
            }
        }
        public void addHitModifier(int par1)
        {
            hitModifier = par1;
            hitModifierDuration = par1 + 2;
        }
        public void throwAwayItem(int par1, Player par2)
        {
            par2.inventory[par1].initItem(0, "Empty Slot");
        }
        public void giveItem(Item par1)
        {
            for (int i = 1; i < 21; i++)
            {
                if (inventory[i].ItemId == 0)
                {
                    inventory[i] = par1;
                    break;
                }

            }
        }
    }
}
