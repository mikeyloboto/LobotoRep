using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Windows.Forms;

namespace MedievalGame
{
    class World
    {
        public static int[,] location = new int[52, 52];
        public int time = 0;
        public int day = 0;
        public static Map currentMap;
        Thread mapThread;
        public void generateMap()
        {
            /* 0 - water
             * 1 - beach
             * 2 - plain
             * 3 - forest
             * 4 - mountain
             * 5 - city
             * 6 - road
             * 7 - sacred temple (one on the map)
             * 8 - void
             * 9 - village
             */
            //init fill map with plains
            {
                for (int i = 1; i < 51; i++)
                    for (int j = 1; j < 51; j++)
                        location[i, j] = 2;
            }
            //add forest
            {
                for (int i = 0; i <= 21; i++)
                    for (int j = 19; j <= 31; j++)
                        location[i, j] = 3;
                for (int i = 4; i <= 7; i++)
                    for (int j = 16; j <= 18; j++)
                        location[i, j] = 3;
                for (int i = 0; i <= 16; i++)
                    for (int j = 32; j <= 35; j++)
                        location[i, j] = 3;
                for (int i = 8; i <= 23; i++)
                    for (int j = 17; j <= 22; j++)
                        location[i, j] = 3;
                for (int i = 0; i <= 12; i++)
                    for (int j = 35; j <= 39; j++)
                        location[i, j] = 3;
                for (int i = 6; i <= 12; i++)
                    for (int j = 40; j <= 42; j++)
                        location[i, j] = 3;
                for (int i = 12; i <= 23; i++)
                    location[i, 16] = 3;
                for (int i = 17; i <= 22; i++)
                    location[i, 15] = 3;
                for (int i = 17; i <= 20; i++)
                    location[i, 14] = 3;
                for (int i = 17; i <= 19; i++)
                    location[i, 13] = 3;
                for (int i = 5; i <= 7; i++)
                    location[i, 15] = 3;
                for (int i = 26; i <= 28; i++)
                    location[22, i] = 3;
                for (int i = 19; i <= 20; i++)
                    location[i, 32] = 3;
                for (int i = 13; i <= 15; i++)
                    location[i, 36] = 3;
                for (int i = 13; i <= 14; i++)
                    location[i, 37] = 3;
                location[13, 38] = 3;
                for (int i = 6; i <= 8; i++)
                    location[i, 43] = 3;
                for (int i = 1; i <= 3; i++)
                    location[i, 40] = 3;
                for (int i = 1; i <= 2; i++)
                    location[i, 41] = 3;
                location[1, 42] = 3;

            }



            //add ocean (water)
            {
                for (int i = 26; i < 51; i++)
                    for (int j = 50 - (i - 26); j < 51; j++)
                        location[i, j] = 0;
                for (int i = 23; i < 26; i++)
                    location[i, 50] = 0;
                for (int i = 25; i < 27; i++)
                    location[i, 49] = 0;
                location[26, 48] = 0;
                location[27, 48] = 0;
                location[28, 47] = 0;
                location[29, 46] = 0;
                for (int i = 29; i < 39; i++)
                {
                    location[i, 29 + 47 - i] = 0;
                }
                for (int i = 44; i < 48; i++)
                {
                    location[i, 43 + 32 - i] = 0;
                }

            }
            //add void
            {
                for (int i = 0; i < 52; i++)
                {
                    location[i, 0] = 8;
                    location[i, 51] = 8;
                }
                for (int j = 0; j < 52; j++)
                {
                    location[0, j] = 8;
                    location[51, j] = 8;
                }
            }
            //add beach
            {
                for (int i = 21; i < 23; i++)
                    location[i, 50] = 1;
                for (int i = 22; i < 25; i++)
                    location[i, 49] = 1;
                for (int i = 24; i < 26; i++)
                    location[i, 48] = 1;
                location[26, 47] = 1;
                location[27, 46] = 1;
                location[28, 45] = 1;
                for (int i = 26; i < 38; i++)
                    location[i, 26 - i + 48] = 1;
                for (int i = 30; i < 51; i++)
                    location[i, 30 - i + 45] = 1;
                for (int i = 39; i < 44; i++)
                    location[i, 39 - i + 37] = 1;
                location[43, 31] = 1;
                location[44, 30] = 1;
                location[48, 26] = 1;
                location[49, 27] = 1;
                location[50, 26] = 1;

            }
            //add mountains
            {
                for (int i = 1; i < 5; i++)
                    for (int j = 1; j < 13; j++)
                        location[i, j] = 4;
                for (int i = 1; i < 11; i++)
                    for (int j = 1; j < 12; j++)
                        location[i, j] = 4;
                for (int i = 1; i < 13; i++)
                    for (int j = 1; j < 11; j++)
                        location[i, j] = 4;
                for (int i = 1; i < 15; i++)
                    for (int j = 1; j < 9; j++)
                        location[i, j] = 4;
                for (int i = 1; i < 16; i++)
                    for (int j = 1; j < 7; j++)
                        location[i, j] = 4;
                for (int i = 1; i < 17; i++)
                    for (int j = 1; j < 5; j++)
                        location[i, j] = 4;
                for (int i = 1; i < 18; i++)
                    for (int j = 1; j < 3; j++)
                        location[i, j] = 4;
            }
            //add roads
            {
                for (int i = 6; i < 10; i++)
                    location[5, i] = 6;
                for (int i = 9; i < 11; i++)
                    location[4, i] = 6;
                for (int i = 10; i < 24; i++)
                    location[3, i] = 6;
                for (int i = 24; i < 27; i++)
                    location[4, i] = 6;
                for (int i = 26; i < 29; i++)
                    location[5, i] = 6;
                for (int i = 28; i < 30; i++)
                    location[6, i] = 6;
                for (int i = 29; i < 35; i++)
                    location[7, i] = 6;
                for (int i = 18; i < 20; i++)
                    location[5, i] = 6;
                for (int i = 19; i < 21; i++)
                    location[6, i] = 6;
                for (int i = 20; i < 22; i++)
                    location[7, i] = 6;
                location[4, 18] = 6;
                for (int i = 8; i < 11; i++)
                    location[i, 21] = 6;
                for (int i = 10; i < 13; i++)
                    location[i, 20] = 6;
                location[12, 21] = 6;
                for (int i = 12; i < 20; i++)
                    location[i, 22] = 6;
                for (int i = 23; i < 28; i++)
                    location[16, i] = 6;
                for (int i = 27; i < 29; i++)
                    location[17, i] = 6;
                for (int i = 28; i < 33; i++)
                    location[18, i] = 6;
                for (int i = 32; i < 36; i++)
                    location[17, i] = 6;
                location[9, 35] = 6;
                location[11, 35] = 6;
                location[13, 35] = 6;
                location[15, 35] = 6;
                for (int i = 6; i < 12; i++)
                    location[i, 5] = 6;
                for (int i = 11; i < 14; i++)
                    location[i, 6] = 6;
                for (int i = 12; i < 25; i++)
                    location[i, 7] = 6;
                for (int i = 24; i < 27; i++)
                    location[i, 6] = 6;
                for (int i = 26; i < 44; i++)
                    location[i, 7] = 6;
                for (int i = 18; i < 20; i++)
                    location[i, 34] = 6;
                for (int i = 19; i < 23; i++)
                    location[i, 35] = 6;
                location[22, 36] = 6;
                for (int i = 36; i < 40; i++)
                    location[23, i] = 6;
                location[24, 39] = 6;
                location[25, 39] = 6;
                for (int i = 33; i < 40; i++)
                    location[27, i] = 6;
                for (int i = 28; i < 32; i++)
                    location[i, 33] = 6;
                for (int i = 31; i < 39; i++)
                    location[i, 32] = 6;
                for (int i = 27; i < 34; i++)
                    location[38, i] = 6;
                for (int i = 37; i < 46; i++)
                    location[i, 28] = 6;
                for (int i = 20; i < 22; i++)
                    location[i, 23] = 6;
                for (int i = 21; i < 26; i++)
                    location[i, 24] = 6;
                for (int i = 25; i < 28; i++)
                    location[i, 25] = 6;
                for (int i = 27; i < 33; i++)
                    location[i, 26] = 6;
                for (int i = 32; i < 38; i++)
                    location[i, 27] = 6;
                location[36, 26] = 6;
                for (int i = 9; i < 28; i++)
                    location[43, i] = 6;
                for (int i = 8; i < 10; i++)
                    location[29, i] = 6;
                for (int i = 9; i < 11; i++)
                    location[31, i] = 6;
                for (int i = 10; i < 14; i++)
                    location[32, i] = 6;
                for (int i = 13; i < 15; i++)
                    location[33, i] = 6;
                for (int i = 14; i < 16; i++)
                    location[34, i] = 6;
                for (int i = 15; i < 19; i++)
                    location[35, i] = 6;
                for (int i = 19; i < 21; i++)
                    location[34, i] = 6;
                for (int i = 20; i < 26; i++)
                    location[35, i] = 6;
                location[30, 9] = 6;
            }
            //add cities
            {
                location[5, 5] = 5;
                location[16, 22] = 5;
                location[7, 35] = 5;
                location[26, 39] = 5;
                location[29, 7] = 5;
                location[35, 26] = 5;
                location[45, 29] = 5;
            }
            //add sacred temple
            {
                location[43, 8] = 7;
            }
            //add villages
            {
                location[7, 28] = 9;
                location[20, 22] = 9;
                location[23, 35] = 9;
                location[34, 18] = 9;
            }
        }
        public int getCurrentTerrain()
        {
            return location[Game.player.coordX, Game.player.coordY];
        }
        public String getCurrentTerrainName(int par1)
        {
            switch (par1)
            {
            case 0:
                switch (location[Game.player.coordX, Game.player.coordY])
                {
                     case 0:
                        return "ocean";
                     case 1:
                        return "beach";
                     case 2:
                        return "plains";
                     case 3:
                        return "forest";
                     case 4:
                        return "mountain";
                     case 5:
                        return "city";
                     case 6:
                        return "road";
                     case 7:
                        return "temple";
                    case 8:
                        return "void";
                    case 9:
                        return "village";
                }
                break;
            case 1:
                switch (location[Game.player.coordX, Game.player.coordY])
                {
                    case 0:
                        return "Ocean";
                    case 1:
                        return "Beach";
                    case 2:
                        return "Plains";
                    case 3:
                        return "Forest";
                    case 4:
                        return "Mountain";
                    case 5:
                        return "City";
                    case 6:
                        return "Road";
                    case 7:
                        return "Temple";
                    case 8:
                        return "Void";
                    case 9:
                        return "Village";
                }
                break;
            }
            return "err";
        }
        public int getTerrainFromSide(String par1)
        {
            switch (par1)
            {
                case "North": case "north":
                    return location[Game.player.coordX, Game.player.coordY - 1];
                case "East": case "east":
                    return location[Game.player.coordX + 1, Game.player.coordY];
                case "South": case "south":
                    return location[Game.player.coordX, Game.player.coordY + 1];
                case "West": case "west":
                    return location[Game.player.coordX - 1, Game.player.coordY];
            }
            return 0;
        }
        public String getTerrainNameFromSide(String par1)
        {
            switch (getTerrainFromSide(par1))
            {
                     case 0:
                        return "ocean";
                     case 1:
                        return "beach";
                     case 2:
                        return "plains";
                     case 3:
                        return "forest";
                     case 4:
                        return "mountain";
                     case 5:
                        return "city";
                     case 6:
                        return "road";
                case 7:
                        return "temple";
                case 8:
                        return "void";
                case 9:
                        return "village";
                default:
                        return "nothing";
            }
        }
        public void drawMap()
        {
            for (int i = 1; i < 51; i++)
            {
                for (int j = 1; j < 51; j++)
                {
                    if (Game.player.coordX == i && Game.player.coordY == j)
                    {
                        Console.Write("X");
                    }
                    else
                    Console.Write(location[j, i]);
                }
                Console.WriteLine();
            }
        }
        public void drawMapColored()
        {
            for (int j = 1; j < 51; j++)
            {
                for (int i = 1; i < 51; i++)
                {
                    if (i == Game.player.coordX && j == Game.player.coordY)
                    {
                        Console.BackgroundColor = ConsoleColor.Black;
                        Console.ForegroundColor = ConsoleColor.Red;
                        Console.Write("X");
                        Console.ResetColor();

                    }
                    else
                        switch (location[i, j])
                        {
                            case 0:
                                {
                                    Console.BackgroundColor = ConsoleColor.DarkBlue;
                                    Console.ForegroundColor = ConsoleColor.Blue;
                                    Console.Write("~");
                                    Console.ResetColor();
                                }
                                break;
                            case 1:
                                {
                                    Console.BackgroundColor = ConsoleColor.DarkYellow;
                                    Console.ForegroundColor = ConsoleColor.Yellow;
                                    Console.Write("-");
                                    Console.ResetColor();
                                }
                                break;
                            case 2:
                                {
                                    Console.BackgroundColor = ConsoleColor.DarkGreen;
                                    Console.ForegroundColor = ConsoleColor.Black;
                                    Console.Write("-");
                                    Console.ResetColor();
                                }
                                break;
                            case 3:
                                {
                                    Console.BackgroundColor = ConsoleColor.Green;
                                    Console.ForegroundColor = ConsoleColor.DarkGreen;
                                    Console.Write("^");
                                    Console.ResetColor();
                                }
                                break;
                            case 4:
                                {
                                    Console.BackgroundColor = ConsoleColor.Gray;
                                    Console.ForegroundColor = ConsoleColor.Black;
                                    Console.Write("^");
                                    Console.ResetColor();
                                }
                                break;
                            case 5:
                                {
                                    Console.BackgroundColor = ConsoleColor.White;
                                    Console.ForegroundColor = ConsoleColor.Black;
                                    Console.Write("C");
                                    Console.ResetColor();
                                }
                                break;
                            case 6:
                                {
                                    Console.BackgroundColor = ConsoleColor.DarkGray;
                                    Console.ForegroundColor = ConsoleColor.Black;
                                    Console.Write("=");
                                    Console.ResetColor();
                                }
                                break;
                            case 7:
                                {
                                    Console.BackgroundColor = ConsoleColor.Green;
                                    Console.ForegroundColor = ConsoleColor.White;
                                    Console.Write("H");
                                    Console.ResetColor();
                                }
                                break;
                            case 9:
                                {
                                    Console.BackgroundColor = ConsoleColor.White;
                                    Console.ForegroundColor = ConsoleColor.Black;
                                    Console.Write("V");
                                    Console.ResetColor();
                                }
                                break;
                        }
                }
                Console.WriteLine();

            }
        }
        public void drawMapWindow()
        {
            if (!(mapThread == null))
            {
                if (!mapThread.IsAlive)
                {
                    mapThread = new Thread(new ThreadStart(windowedMapThread));
                    mapThread.Start();
                }
                else
                {
                    Console.WriteLine("Map is already open");
                }
            }
            else
            {
                mapThread = new Thread(new ThreadStart(windowedMapThread));
                mapThread.Start();
            }
            //currentMap.Show();
        }
        public int getTerrainFromCoords(int par1, int par2)
        {
            return location[par1, par2];
        }
        public static void windowedMapThread()
        {
            currentMap = new Map();
            Application.Run(currentMap);
        }
        public void addTime()
        {
            time += 1;
            Boolean var1 = (time == 12);
            if (var1)
            {
                day += 1;
                time = 0;
            }
        }
        public String getTimeAndDay()
        {
            String out1 = "Current time: " + time * 2 + ":00, Day " + day + ".";
            return out1;
        }
    }
}
