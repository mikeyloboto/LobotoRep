using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace MedievalGame
{
    public partial class Map : Form
    {
        private Timer timer = new Timer();
        public static int prevX = 0;
        public static int prevY = 0;
        public static PictureBox[,] pic = new PictureBox[51, 51];
        public static PictureBox pl = new PictureBox();

        public Map()
        {
            InitializeComponent();
        }
        public void PTT(int par1, int par2)
        {
            playerToTerrain(par1, par2);
        }
        public void TTP(int par1, int par2)
        {
            terrainToPlayer(par1, par2);
        }

        private void Map_Load(object sender, EventArgs e)
        {
            pl.Image = MedievalGame.Properties.Resources.player;
            pl.Size = new System.Drawing.Size(10, 10);
            pl.Visible = true;
            pl.Parent = this;
            for (int i = 1; i < 51; i++)
                for (int j = 1; j < 51; j++)
                {
                    pic[i, j] = new PictureBox();

                    pic[i, j].Size = new System.Drawing.Size(10, 10);
                    pic[i, j].Location = new System.Drawing.Point((i * 10) - 10, (j * 10) - 10);
                    pic[i, j].Image = getItemBitmap(i, j);
                    pic[i, j].Visible = true;
                    pic[i, j].Update();
                    pic[i, j].Parent = this;
                }

            timer.Interval = (100);
            timer.Start();
        }
        public void timerTick(Object sender, EventArgs e)
        {
            updatePlayer();
            timer.Start();
        }
        public void updatePlayer()
        {
            pl.Location = new System.Drawing.Point((Game.player.coordX*10)-10, (Game.player.coordY*10)-10);
            pl.Update();
        }
        public Bitmap getItemBitmap(int par1, int par2)
        {           
                   // if (par1 == Program.player.coordX && par2 == Program.player.coordY)
                    //{
                    //    return MedievalGame.Properties.Resources.player;

                    //}
                    //else
                        switch (Game.currentWorld.getTerrainFromCoords(par1, par2))
                        {
                            case 0:
                                    return MedievalGame.Properties.Resources.water;
                            case 1:
                                    return MedievalGame.Properties.Resources.beach;
                            case 2:
                                    return MedievalGame.Properties.Resources.plain;
                            case 3:
                                    return MedievalGame.Properties.Resources.forest;
                            case 4:
                                    return MedievalGame.Properties.Resources.mountain;
                            case 5:
                                    return MedievalGame.Properties.Resources.city;
                            case 6:
                                    return MedievalGame.Properties.Resources.road;
                            case 7:
                                    return MedievalGame.Properties.Resources.temple;
                            case 9:
                                    return MedievalGame.Properties.Resources.village;
                        }
                    return null;
               
        }
        public void playerToTerrain(int par1, int par2)
        {
            pic[par1, par2].Image = getItemBitmap(par1, par2);
            //pic[par1, par2].Update();
        }
        public void terrainToPlayer(int par1, int par2)
        {
            pic[prevX, prevY].Image = MedievalGame.Properties.Resources.player;
            //pic[par1, par2].Update();
        }
    }
}
