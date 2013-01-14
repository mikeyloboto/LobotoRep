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
            Boolean var1 = false;
            Boolean var2 = false;
            Boolean var3 = false;
            Boolean var4 = false;
            Boolean var5 = false;
            Boolean var6 = false;
            Boolean var7 = false;
            Boolean var8 = false;

            if (input.Length > 1)
            {
                var1 = (input.Substring(0, 2) == "go") || (input.Substring(0, 2) == "Go");
            }
            var2 = (input == "map") || (input == "Map") || (input == "show map") || (input == "Show map") || (input == "open map") || (input == "Open map");
            if (input.Length > 3)
            {
                var3 = (input.Substring(0, 4) == "move") || (input.Substring(0, 4) == "Move");
            }
            var4 = ((input == "Inventory") || (input == "inventory") || (input == "Open inventory") || (input == "open inventory") || (input == "Show inventory") || (input == "show inventory"));
            var5 = (input == "look around") || (input == "Look around");
            var6 = (input == "time") || (input == "Time") || (input == "Calendar") || (input == "calendar");
            var7 = (input == "compass") || (input == "Compass");
            var8 = (input == "Use compass") || (input == "use compass");
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
            if (var7 || var8)
            {
                return "compass";
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
