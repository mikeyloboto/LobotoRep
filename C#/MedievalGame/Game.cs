using System;
using System.Threading;
using System.Windows.Forms;


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
        public static int slot = 0;
        public static GameWindow gameWindow = new GameWindow();
        public static Thread guiThread;

        //static void Main(string[] args)
        //{
        //    init();

        //    while (result != "quit")
        //    {
        //        CurrentCommand = Console.ReadLine();
        //        result = handler.processString(CurrentCommand);
        //        secondProcessLine(result);
        //    }
        //}
        public static void ForceClose()
        {
            Environment.Exit(0);
        }
        public static void StringFromGui(String par1)
        {
            CurrentCommand = par1;
            result = handler.processString(CurrentCommand);
            secondProcessLine(result);
        }
        public static void init()
        {
            currentWorld.generateMap();
            Item.InitAllItems();
            initGameWindow();
            initPlayer();
            putPlayer();
            initLook();
            
        }
        public static void initGameWindow()
        {
            if (!(guiThread == null))
            {
                if (!guiThread.IsAlive)
                {
                    guiThread = new Thread(new ThreadStart(windowedGameThread));
                    guiThread.Start();
                }
                else
                {
                    Console.WriteLine("Map is already open");
                }
            }
            else
            {
                guiThread = new Thread(new ThreadStart(windowedGameThread));
                guiThread.Start();
            }
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
            //Console.WriteLine("What is your name, stranger?");
            //player.name = Console.ReadLine();
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
            GameWindow.OutLine("You wake up in the middle of the " + currentWorld.getCurrentTerrainName(0));
            lookAround();
        }
        public static void lookAround()
        {
            GameWindow.OutLine("You look around and");
            GameWindow.OutLine("you can see " + currentWorld.getTerrainNameFromSide("south") + " on the south");
            GameWindow.OutLine(currentWorld.getTerrainNameFromSide("north") + " on the north");
            GameWindow.OutLine(currentWorld.getTerrainNameFromSide("east") + " on the east");
            GameWindow.OutLine("and " + currentWorld.getTerrainNameFromSide("west") + " on the west.");

        }
        public static void emptyInventory(Player par1)
        {
            for (int i = 1; i < 21; i++)
            {
                par1.inventory[i] = new Item();
                par1.inventory[i] = Item.itemEmptySlot;
            }

        }
        public static void secondProcessLine(string input)
        {
            switch (input)
            {
                case "error":
                    GameWindow.OutLine("Unknown command");
                    break;
                case "move":
                    move();
                    if (actRes==1)
                        GameWindow.OutLine("You are going " + direction);
                    break;
                case "compass":
                    GameWindow.OutLine("Your current coordinates are: " + player.coordX + ", " + player.coordY);
                    break;
                case "map":
                    currentWorld.drawMapWindow();
                    break;
                case "time":
                    GameWindow.OutLine(currentWorld.getTimeAndDay());
                    break;
                case "inventory":
                    showInventory(player);
                    break;
                case "fish":
                    startFishing();
                    break;
                case "cook":
                    startCooking();
                    break;
                case "quit":
                    Environment.Exit(0);
                    break;

            }
        }
        private static void startCooking()
        {
            int invSl = slot;
            Items.ItemFish.cookFishWithProbability(invSl, 3);
        }
        private static void startFishing()
        {
            Fishing.startFishing();
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
                            GameWindow.OutLine(EnumString.ERR_WORLD_LIMIT);
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
                            GameWindow.OutLine(EnumString.ERR_WORLD_LIMIT);
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
                            GameWindow.OutLine(EnumString.ERR_WORLD_LIMIT);
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
                            GameWindow.OutLine(EnumString.ERR_WORLD_LIMIT);
                            actRes = 0;
                        }
                        break;
                    default:

                        break;
                }
            }
                else
                {
                    GameWindow.OutLine(EnumString.ERR_WATER);
                    actRes = 0;
                }
            if (actRes == 1)
            {
                currentWorld.addTime();
            }
            int var10 = rollDice(10);
            if (var10 == 10)
            {
                Events.CombatEvent.generateMonsterEvent();
            }
           // World.currentMap.TTP(player.coordX, player.coordY);
            
        }
        public static void showInventory(Player par1)
        {
            for (int i = 1; i < 21; i++)
                GameWindow.OutLine("Slot " + i + ": " + par1.inventory[i].getName());
        }
        public static void windowedGameThread()
        {
            Application.Run(gameWindow);
        }
    }

}

