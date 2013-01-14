using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace MedievalGame
{
    class Item
    {
        public int ItemId, ItemMeta;
        public String ItemName;
        public void initItem(int par1, int par2)
        {
            ItemId = par1;
            ItemMeta = par2;
        }
        public void initItem(int par1)
        {
            ItemId = par1;
            ItemMeta = 0;
        }
        public void initItem(int par1, String par2)
        {
            ItemId = par1;
            ItemName = par2;
        }
        public void initItem(int par1, int par2, String par3)
        {
            ItemId = par1;
            ItemMeta = par2;
            ItemName = par3;
        }
        public int getItemId()
        {
            return ItemId;
        }
        public String getName()
        {
            return ItemName;
        }
    }
}
