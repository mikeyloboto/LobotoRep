using System.Windows.Forms;

namespace MedievalGame
{
    partial class GameWindow
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
       
                components.Dispose();
            }
            base.Dispose(disposing);
            Game.ForceClose();
        }

        #region Windows Form Designer generated code
        //all inits
        private MenuStrip menustrip = new MenuStrip();
        public static ListBox output = new ListBox();
        public TextBox input = new TextBox();
        public Button sendCommand = new Button();
        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.newGameToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.loadGameToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.saveGameToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tooldToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.questsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.inventoryToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.characterToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.spellsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.extraTooolsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.mapToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.databaseToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.helpToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.tooldToolStripMenuItem,
            this.extraTooolsToolStripMenuItem,
            this.helpToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(584, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.newGameToolStripMenuItem,
            this.loadGameToolStripMenuItem,
            this.saveGameToolStripMenuItem,
            this.exitToolStripMenuItem});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(37, 20);
            this.fileToolStripMenuItem.Text = "File";
            // 
            // newGameToolStripMenuItem
            // 
            this.newGameToolStripMenuItem.Name = "newGameToolStripMenuItem";
            this.newGameToolStripMenuItem.Size = new System.Drawing.Size(134, 22);
            this.newGameToolStripMenuItem.Text = "New Game";
            // 
            // loadGameToolStripMenuItem
            // 
            this.loadGameToolStripMenuItem.Name = "loadGameToolStripMenuItem";
            this.loadGameToolStripMenuItem.Size = new System.Drawing.Size(134, 22);
            this.loadGameToolStripMenuItem.Text = "Load Game";
            // 
            // saveGameToolStripMenuItem
            // 
            this.saveGameToolStripMenuItem.Name = "saveGameToolStripMenuItem";
            this.saveGameToolStripMenuItem.Size = new System.Drawing.Size(134, 22);
            this.saveGameToolStripMenuItem.Text = "Save Game";
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(134, 22);
            this.exitToolStripMenuItem.Text = "Exit";
            // 
            // tooldToolStripMenuItem
            // 
            this.tooldToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.questsToolStripMenuItem,
            this.inventoryToolStripMenuItem,
            this.characterToolStripMenuItem,
            this.spellsToolStripMenuItem});
            this.tooldToolStripMenuItem.Name = "tooldToolStripMenuItem";
            this.tooldToolStripMenuItem.Size = new System.Drawing.Size(48, 20);
            this.tooldToolStripMenuItem.Text = "Tools";
            // 
            // questsToolStripMenuItem
            // 
            this.questsToolStripMenuItem.Name = "questsToolStripMenuItem";
            this.questsToolStripMenuItem.Size = new System.Drawing.Size(125, 22);
            this.questsToolStripMenuItem.Text = "Quests";
            // 
            // inventoryToolStripMenuItem
            // 
            this.inventoryToolStripMenuItem.Name = "inventoryToolStripMenuItem";
            this.inventoryToolStripMenuItem.Size = new System.Drawing.Size(125, 22);
            this.inventoryToolStripMenuItem.Text = "Inventory";
            // 
            // characterToolStripMenuItem
            // 
            this.characterToolStripMenuItem.Name = "characterToolStripMenuItem";
            this.characterToolStripMenuItem.Size = new System.Drawing.Size(125, 22);
            this.characterToolStripMenuItem.Text = "Character";
            // 
            // spellsToolStripMenuItem
            // 
            this.spellsToolStripMenuItem.Name = "spellsToolStripMenuItem";
            this.spellsToolStripMenuItem.Size = new System.Drawing.Size(125, 22);
            this.spellsToolStripMenuItem.Text = "Spells";
            // 
            // extraTooolsToolStripMenuItem
            // 
            this.extraTooolsToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mapToolStripMenuItem,
            this.databaseToolStripMenuItem});
            this.extraTooolsToolStripMenuItem.Name = "extraTooolsToolStripMenuItem";
            this.extraTooolsToolStripMenuItem.Size = new System.Drawing.Size(76, 20);
            this.extraTooolsToolStripMenuItem.Text = "Extra Tools";
            // 
            // mapToolStripMenuItem
            // 
            this.mapToolStripMenuItem.Name = "mapToolStripMenuItem";
            this.mapToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.mapToolStripMenuItem.Text = "Map";
            // 
            // databaseToolStripMenuItem
            // 
            this.databaseToolStripMenuItem.Name = "databaseToolStripMenuItem";
            this.databaseToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.databaseToolStripMenuItem.Text = "Database";
            // 
            // helpToolStripMenuItem
            // 
            this.helpToolStripMenuItem.Name = "helpToolStripMenuItem";
            this.helpToolStripMenuItem.Size = new System.Drawing.Size(44, 20);
            this.helpToolStripMenuItem.Text = "Help";
            // 
            // GameWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(584, 462);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "GameWindow";
            this.Text = EnumString.APP_NAME_FINAL + " " + EnumString.APP_VERSION;
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();
            //Resize Handler
            this.Resize += new System.EventHandler(this.GameWindow_Resize);
            //Other handlers
            input.KeyDown += input_KeyDown;
            sendCommand.Click += sendCommand_Click;
            //init elements
            output.Size = this.Size - new System.Drawing.Size(25, 90);
            output.Parent = this;
            output.Location = new System.Drawing.Point(5, 25);
            output.Visible = true;
            output.Update();
            input.Size = new System.Drawing.Size(this.Size.Width-120, 15);
            input.Parent = this;
            input.Location = new System.Drawing.Point(5, this.Size.Height - 65);
            input.Visible = true;
            input.Update();
            sendCommand.Parent = this;
            sendCommand.Size = new System.Drawing.Size(89, 18);
            sendCommand.Text ="Enter";
            sendCommand.Location = new System.Drawing.Point(input.Size.Width + 10, input.Location.Y);
            sendCommand.Visible = true;
            sendCommand.Update();
            //menu handlers

            this.mapToolStripMenuItem.Click += ShowMap;

            
 
        }

        private void ShowMap(object sender, System.EventArgs e)
        {
            Game.currentWorld.drawMapWindow();
        }

        private void input_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                SendCommandHandler(input.Text);
                input.Text = "";
                input.Update();
            }
        }

        void sendCommand_Click(object sender, System.EventArgs e)
        {
            SendCommandHandler(input.Text);
            input.Text = "";
            input.Update();
        }

        void GameWindow_Resize(object sender, System.EventArgs e)
        {
            output.Size = this.Size - new System.Drawing.Size(25, 90);
            input.Size = new System.Drawing.Size(this.Size.Width - 120, 15);
            input.Location = new System.Drawing.Point(5, this.Size.Height - 65);
            sendCommand.Size = new System.Drawing.Size(100, 20);
            sendCommand.Location = new System.Drawing.Point(input.Size.Width + 30, input.Location.Y);
            output.Update();
            input.Update();
            sendCommand.Update();
        }

        #endregion

        private MenuStrip menuStrip1;
        private ToolStripMenuItem fileToolStripMenuItem;
        private ToolStripMenuItem newGameToolStripMenuItem;
        private ToolStripMenuItem loadGameToolStripMenuItem;
        private ToolStripMenuItem saveGameToolStripMenuItem;
        private ToolStripMenuItem exitToolStripMenuItem;
        private ToolStripMenuItem tooldToolStripMenuItem;
        private ToolStripMenuItem questsToolStripMenuItem;
        private ToolStripMenuItem inventoryToolStripMenuItem;
        private ToolStripMenuItem characterToolStripMenuItem;
        private ToolStripMenuItem spellsToolStripMenuItem;
        private ToolStripMenuItem extraTooolsToolStripMenuItem;
        private ToolStripMenuItem mapToolStripMenuItem;
        private ToolStripMenuItem databaseToolStripMenuItem;
        private ToolStripMenuItem helpToolStripMenuItem;
    }
}