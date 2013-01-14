using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
namespace MedievalGame.Items
{
    class ItemPotion : Item
    {
        public int PotionId;
        public int PotionType;
        public int PotionSize;
        public String PotionName;

        public void initItemPotion(int par1, int par2, int par3)
        {
            PotionId = par1;
            PotionType = par2;
            PotionSize = par3;
            buildName();
            this.ItemId = ((PotionId - 1) * 6) + (PotionSize - 1) + 100;
        }
        public void potionUse()
        {
            switch (PotionType)
            {
                case 1:
                    Game.player.health += (PotionSize * 3);
                    break;
                case 2:
                    Game.player.mana += (PotionSize * 3);
                    break;
                case 3:
                    Game.player.addHitModifier(PotionSize);
                    break;

            }
        }
        public void buildName()
        {
            string initName = " potion of ";
            switch (PotionSize)
            {
                case 1:
                    initName = "Very small" + initName;
                    break;
                case 2:
                    initName = "Small" + initName;
                    break;
                case 3:
                    initName = "Medium" + initName;
                    break;
                case 4:
                    initName = "Large" + initName;
                    break;
                case 5:
                    initName = "Very large" + initName;
                    break;
                case 6:
                    initName = "Huge" + initName;
                    break;

            }
            switch (PotionType)
            {
                case 1:
                    initName += "health";
                    break;
                case 2:
                    initName += "mana";
                    break;
                case 3:
                    initName += "strength";
                    break;
            }
            this.PotionName = initName;
        }
        public String getPotionName()
        {
            return PotionName;
        }
    }
}
