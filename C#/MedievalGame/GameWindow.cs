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
    public partial class GameWindow : Form
    {
        public GameWindow()
        {
            InitializeComponent();
        }
        static void Main(string[] args)
        {
            Game.init();
        }
        void SendCommandHandler(String par1)
        {
            if (!(par1 == ""))
            {
                Game.StringFromGui(par1);
                output.Items.Add("User Input -> " + par1);
            }
        }
        public static void OutLine(String par1)
        {
            output.Items.Add(par1);
        }

    }
}
