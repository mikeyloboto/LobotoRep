using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace MedievalGame
{
    class Fishing
    {
        public static void startFishing()
        {
            Game.currentWorld.addTime();
            bool waterNearby = false;
            for (int i = Game.player.coordX - 1; i < Game.player.coordX + 2; i++)
                for (int j = Game.player.coordY - 1; j < Game.player.coordY + 2; j++)
                    if (Game.currentWorld.getTerrainFromCoords(i, j) == 0)
                        waterNearby = true;
            bool result;
            int res = Game.rollDice(10);
            if (waterNearby == true)
            {
                if (res == 10)
                {
                    result = true;
                }
                else
                {
                    result = false;
                }
                addFishWithNotify(result);
            }
            else GameWindow.OutLine("You cannot fish here. There is no water nearby.");
        }

        private static void addFishWithNotify(bool par1)
        {
            switch (par1)
            {
                case true:
                    {
                        Game.player.giveItem(Item.itemFish);
                        GameWindow.OutLine("Congratulations. You've caught the fish.");
                        break;
                    }
                case false:
                    {
                        GameWindow.OutLine("Unfortunately, you've caught nothing");
                        break;
                    }
            }
        }
    }
}
