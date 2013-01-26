using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace MedievalGame
{
    class StringHandler
    {
        public String ProcessedString;
        public String processString(string input)
        {
            switch (input)
            {
                case "quit":
                case "Quit":
                case "close":
                case "Close":
                case "exit":
                case "Exit":
                    return "quit";
                default:
                    return disassemleString(input);
            }

        }
        public String disassemleString(string input)
        {
            string inpLower = input.ToLower();
            Boolean var1 = false;
            Boolean var2 = false;
            Boolean var3 = false;
            Boolean var4 = false;
            Boolean var5 = false;
            Boolean var6 = false;
            Boolean var7 = false;
            Boolean var8 = false;
            Boolean var9 = false;

            if (input.Length > 1)
            {
                var1 = (inpLower.Substring(0, 2) == "go");
            }
            var2 = (inpLower == "map") || (inpLower == "show map") || (inpLower == "open map");
            if (input.Length > 3)
            {
                var3 = (inpLower.Substring(0, 4) == "move");
            }
            if (inpLower.Length > 4)
            {
                var8 = (inpLower.Substring(0, 4) == "cook");
            }
            var4 = (inpLower == "inventory") || (inpLower == "open inventory") || (inpLower == "show inventory");
            var5 = (inpLower == "look around");
            var6 = (inpLower == "time") || (inpLower == "calendar");
            var7 = (inpLower == "compass") || (inpLower == "use compass");
            var9 = (inpLower == "fishing") || (inpLower == "start fishing") || (inpLower == "catch fish") || (inpLower == "fish");
            if (var1)
            {
                Game.direction = input.Substring(3, input.Length - 3);
                return "move";
            }
            if (var2)
            {
                return "map";
            }
            if (var3)
            {
                Game.direction = input.Substring(5, input.Length - 5);
                return "move";
            }
            if (var4)
            {
                return "inventory";
            }
            if (var5)
            {
                Game.lookAround();
                return "";
            }
            if (var6)
            {
                return "time";
            }
            if (var7)
            {
                return "compass";
            }
            if (var8)
            {
                Game.slot = Convert.ToInt32(cutBeginning(inpLower, 4));
                return "cook";
            }
            if (var9)
            {
                return "fish";
            }
            return "error";

        }
        public String cutBeginning(String par1, int par2)
        {
            int len = par1.Length;
            return par1.Substring(par2 + 1, len - (par2 + 1));

        }
    }
}
