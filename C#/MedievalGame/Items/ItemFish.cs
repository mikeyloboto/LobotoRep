using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace MedievalGame.Items
{
    class ItemFish : Item
    {
        public static void cookFishWithProbability(int par1, int par2)
        {
            Game.currentWorld.addTime();
            Item cookedFish = new Items.ItemCookedFish();
            Boolean isFish = (Game.player.inventory[par1] == Item.itemFish);
            if (isFish)
            {
                int prob = Game.rollDice(par2);
                if (prob == par2)
                {
                    Game.player.inventory[par1] = Item.itemCookedFish;
                    Console.WriteLine("You've successfully cooked the fish.");
                }
                else
                {
                    Game.player.inventory[par1] = Item.itemEmptySlot;
                    Console.WriteLine("You've accidentally burned your fish");
                }
            }
            else
            {
                Console.WriteLine("Item in slot [" + par1 + "] is not a fish");
            }
        }
        public static void cookFish(int par1)
        {

        }

    }
}
