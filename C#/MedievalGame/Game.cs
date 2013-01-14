using System;


namespace MedievalGame
{

    class Game
    {
        public static StringHandler handler = new StringHandler();
        public static int actRes = 0;
        public static Player player = new Player();
        public static World currentWorld = new World();
        public static Map currentMap = new Map();
        public static string direction = "";
        public static string result = null;
        public static string CurrentCommand;
        static void Main(string[] args)
        {
            init();

            while (result != "quit")
            {
                CurrentCommand = Console.ReadLine();
                result = handler.processString(CurrentCommand);
                secondProcessLine(result);
            }
        }
        public static void init()
        {
            currentWorld.generateMap();
            initPlayer();
            putPlayer();
            initLook();
        }
        public static void putPlayer()
        {
            Random rand = new Random();
            player.coordX = rand.Next(30) + 10;
            player.coordY = rand.Next(30) + 10;
            if (currentWorld.getCurrentTerrain() == 0)
                putPlayer();
        }
        public static void initPlayer()
        {
            player.health = 20;
            player.mana = 20;
            player.coins = 200 + rollDice(100);
            player.inventory = new Item[21];
            player.Exp = 0;
            emptyInventory(player);
            Console.WriteLine("What is your name, stranger?");
            player.name = Console.ReadLine();
        }
        public static int rollDice(int input)
        {
            int result = 0;
            Random rand = new Random();
            result = rand.Next(input) + 1;
            return result;

        }
        public static void initLook()
        {
            Console.WriteLine("You wake up in the middle of the " + currentWorld.getCurrentTerrainName(0));
            lookAround();
        }
        public static void lookAround()
        {
            Console.WriteLine("You look around and");
            Console.WriteLine("you can see " + currentWorld.getTerrainNameFromSide("south") + " on the south");
            Console.WriteLine(currentWorld.getTerrainNameFromSide("north") + " on the north");
            Console.WriteLine(currentWorld.getTerrainNameFromSide("east") + " on the east");
            Console.WriteLine("and " + currentWorld.getTerrainNameFromSide("west") + " on the west.");

        }
        public static void emptyInventory(Player par1)
        {
            for (int i = 1; i < 21; i++)
            {
                par1.inventory[i] = new Item();
                par1.inventory[i].initItem(0, "Empty Slot");
            }

        }
        public static void secondProcessLine(string input)
        {
            switch (input)
            {
                case "error":
                    Console.WriteLine("Unknown command");
                    break;
                case "move":
                    move();
                    if (actRes==1)
                    Console.WriteLine("You are going " + direction);
                    break;
                case "compass":
                    Console.WriteLine("Your current coordinates are: " + player.coordX + ", " + player.coordY);
                    break;
                case "map":
                    currentWorld.drawMapWindow();
                    break;
                case "time":
                    Console.WriteLine(currentWorld.getTimeAndDay());
                    break;
                case "inventory":
                    showInventory(player);
                    break;

            }
        }
        public static void move()
        {
            
            Boolean var1 = (player.coordX == 1);
            Boolean var2 = (player.coordX == 50);
            Boolean var3 = (player.coordY == 1);
            Boolean var4 = (player.coordY == 50);
            //World.currentMap.PTT(player.coordX, player.coordY);
            Boolean var5 = (currentWorld.getTerrainFromSide(direction) != 0);
            if (var5)
            {
                switch (direction)
                {
                    case "South":
                    case "south":
                        if (!var4)
                        {
                            player.coordY += 1;
                            actRes = 1;
                        }
                        else
                        {
                            Console.WriteLine(EnumString.ERR_WORLD_LIMIT);
                            actRes = 0;
                        }
                        break;
                    case "North":
                    case "north":
                        if (!var3)
                        {
                            player.coordY -= 1;
                            actRes = 1;
                        }
                        else
                        {
                            Console.WriteLine(EnumString.ERR_WORLD_LIMIT);
                            actRes = 0;
                        }
                        break;
                    case "East":
                    case "east":
                        if (!var2)
                        {
                            player.coordX += 1;
                            actRes = 1;
                        }
                        else
                        {
                            Console.WriteLine(EnumString.ERR_WORLD_LIMIT);
                            actRes = 0;
                        }
                        break;
                    case "West":
                    case "west":
                        if (!var1)
                        {
                            player.coordX -= 1;
                            actRes = 1;
                        }
                        else
                        {
                            Console.WriteLine(EnumString.ERR_WORLD_LIMIT);
                            actRes = 0;
                        }
                        break;
                    default:

                        break;
                }
            }
                else
                {
                    Console.WriteLine(EnumString.ERR_WATER);
                    actRes = 0;
                }
            if (actRes == 1)
            {
                currentWorld.addTime();
            }
           // World.currentMap.TTP(player.coordX, player.coordY);
            
        }
        public static void showInventory(Player par1)
        {
            for (int i = 1; i < 21; i++)
                Console.WriteLine("Slot " + i + ": " + par1.inventory[i].getName());
        }
    }

}

