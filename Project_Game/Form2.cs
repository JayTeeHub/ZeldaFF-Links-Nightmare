using System;
using System.Linq;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.Threading;
using System.IO;
using System.Reflection;

namespace Project_Game
{
    public partial class Form2 : Form
    {

        protected Dungeon game;
        protected List<HumanPlayer> hPlayer;
        protected List<ComputerPlayer> cPlayer;
        protected Form4 f4;
        private Boolean death = false;

        //private Int32 itemCount = 0;                                                   
        private Int32 lastLevel = 0;
        public Form2(Dungeon _game)
        {
            InitializeComponent();
            this.KeyDown += new KeyEventHandler(PlayerControl);
            panel4.Click += new EventHandler(InventoryClick);
            mapPanel.Paint += new PaintEventHandler(PaintMap);
            //mapPanel.MouseDown += new MouseEventHandler(TestClick);
            
            game = _game;
            game.F2 = this;
            
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            LaunchGame();
        }

        public List<ComputerPlayer> CPlayer
        {
            get { return cPlayer; }
        }

        private void LaunchGame()
        {
            //game = new Dungeon();
            LoadPlayerStats();
            this.Show();
            mapPanel.Invalidate();
            
        }

        public void AddUser(HumanPlayer p)
        {
            if (hPlayer == null)
                hPlayer = new List<HumanPlayer>();
            hPlayer.Add(p);
        }

        public void AddComputer(ComputerPlayer c)
        {
            if (cPlayer == null)
            {
                cPlayer = new List<ComputerPlayer>();
                cPlayer.Capacity = 18;
            }
            String test = c.Name;
            cPlayer.Add(c);
        }

        private void LoadPlayerStats()
        {
            hPlayer[0].TotalExp = 10;
            hPlayer[0].TotalHealth = 10;
            hPlayer[0].TotalMana = 5;
            hPlayer[0].UpdateStat(hPlayer[0].WeaponDamage, StatAction.Add, Stats.AttackPower, CombatType.None);
            hPlayer[0].UpdateInventory(hPlayer[0].Weapon, InventoryTyp.Sword, hPlayer[0].WeaponDamage);
            lblPlayerName.Text = hPlayer[0].Name;
            lblLevelValue.Text = hPlayer[0].Level.ToString();
            
            lblExpValue.Text = String.Format("{0} / {1}", hPlayer[0].Exp, hPlayer[0].TotalExp);
            lblManaValue.Text = String.Format("{0} / {1}", hPlayer[0].Mana, hPlayer[0].TotalMana);
            lblHealthValue.Text = String.Format("{0} / {1}", hPlayer[0].Health, hPlayer[0].TotalHealth);

            lastLevel = hPlayer[0].Level;
            

        }

        /*private void UpdateUI()
        {
            lblExpValue.Text = String.Format("{0} / {1}", hPlayer[0].Exp, hPlayer[0].TotalExp);
            lblManaValue.Text = String.Format("{0} / {1}", hPlayer[0].Mana, hPlayer[0].TotalMana);
            lblHealthValue.Text = String.Format("{0} / {1}", hPlayer[0].Health, hPlayer[0].TotalHealth);
            lblLevelValue.Text = hPlayer[0].Level.ToString();
        }*/

        private void PlayerControl(Object sender, KeyEventArgs e)
        {
            string EnumType = "";
            int position = GetMouseClickPosition(playerBox.Location.X, playerBox.Location.Y);

            if (position == 71 && hPlayer[0].KeyCount == 3)
            {
                
                playerBox.Location = new Point(0, 70);

            }
           
            if (position == 71 && hPlayer[0].KeyCount == 3)
                EnumType = "Boss";
            else if (position == 71 && hPlayer[0].KeyCount != 3)
                EnumType = "None";
            else
                EnumType = game.CheckIfOccupied(position);
            if (EnumType == "ITEM")
            {
                int index = game.ItemPositions.IndexOf(position);
                InventoryTyp type = game.ItemTypes[index];
                string item = game.ItemNames[index];
                int quantity = 0;
                if (InventoryModerator(item, type))
                {
                    if (type == InventoryTyp.Health || type == InventoryTyp.Mana)
                    {
                        MessageBox.Show("You found:  " + item);

                        if (item == "Red Pot" || item == "Blue Pot")
                            quantity = 10;
                        else if (item == "Magic Jars")
                            quantity = 6;
                        else if (item == "Milk")
                            quantity = 3;
                        else if (item == "Fairy" || item == "Elixir Soup")
                            quantity = 2;
                        else if (item == "Heart" || item == "Chu Jelly" || item == "Green Pot")
                            quantity = 1;

                        for (int i = 0; i < quantity; i++)
                        {
                            hPlayer[0].UpdateInventory(item, game.ItemTypes[index], game.ItemValues[index]);
                        }

                        game.ItemNames.RemoveAt(index);
                        game.ItemTypes.RemoveAt(index);
                        game.ItemValues.RemoveAt(index);
                        game.ItemPositions.Remove(position);
                    }
                    else
                    {
                        MessageBox.Show("You found:  " + item);
                        hPlayer[0].UpdateInventory(item, game.ItemTypes[index], game.ItemValues[index]);

                        game.ItemNames.RemoveAt(index);
                        game.ItemTypes.RemoveAt(index);
                        game.ItemValues.RemoveAt(index);
                        game.ItemPositions.Remove(position);
                    }

                }
            }
            else if (EnumType == "MONSTER")
            {
                
                int index = game.MonsterPositions.IndexOf(position);
                DialogResult result = MessageBox.Show("You have encountered! " + cPlayer[index].Name, "COMBAT", MessageBoxButtons.OK, MessageBoxIcon.Exclamation, MessageBoxDefaultButton.Button1);
                if (result == DialogResult.OK)
                {
                    f4 = new Form4(hPlayer[0], cPlayer[index]);
                    f4.Show();

                }
                hPlayer[0].CurMonsterPos = position;


            }
            else if (EnumType == "Boss")
            {
                int index = game.MonsterPositions.IndexOf(position);
                DialogResult result = MessageBox.Show("You have encountered! " + cPlayer[17].Name, "COMBAT", MessageBoxButtons.OK, MessageBoxIcon.Exclamation, MessageBoxDefaultButton.Button1);
                if (result == DialogResult.OK)
                {
                    f4 = new Form4(hPlayer[0], cPlayer[17]);
                    f4.Show();

                }
                hPlayer[0].CurMonsterPos = position;
            }
                
            
            /*else if (EnumType == "EXP GAINED")
            {
                MessageBox.Show("2 exp points gained");
                game.TestPositions.Remove(position);
                hPlayer[0].UpdateStat(2,StatAction.Add,Stats.Level);
                //hPlayer[0].UpdateStat(5, StatAction.Sub, Stats.Health);
                uiTimer.Enabled = true;
            }*/

            switch (e.KeyCode)
            {
                case Keys.Up:
                    if (playerBox.Top >= mapPanel.Top - 50)
                    {
                        playerBox.Top = playerBox.Top - 2;
                        
                    }
                    else
                    {
                        playerBox.Top = playerBox.Top + 2;
                        
                    }
                    break;
                case Keys.Down:
                    if (playerBox.Bottom == 202)
                    {
                        playerBox.Top = playerBox.Top - 2;
                        
                    }
                    else
                    {
                        playerBox.Top = playerBox.Top + 2;
                        
                    }
                    break;
                case Keys.Left:
                    if (playerBox.Left >= mapPanel.Left - 10)
                        playerBox.Left = playerBox.Left - 2;
                    else
                        playerBox.Left = playerBox.Left + 2;
                    break;
                case Keys.Right:
                    if (playerBox.Right >= mapPanel.Right - 10)
                        playerBox.Left = playerBox.Left - 2;
                    else
                        playerBox.Left = playerBox.Left + 2;
                    break;
            }
        }

        private void PaintMap(object sender, PaintEventArgs e)
        {
            DrawGrid(e.Graphics);
        }

        private void DrawGrid(Graphics g)
        {
            //Space the grid rows
            Int32 pixelsPerRow = mapPanel.Width / game.Rows;
            Int32 pixelsPerColumn = mapPanel.Width / game.Columns;

            //Draw grid lines
            Pen p = new Pen(Color.Black);
            p.Width = 2;

            for (int i = 0; i < game.Rows - 1; i++)
            {
                g.DrawLine(p, pixelsPerColumn * (i + 1), 0, pixelsPerColumn * (i + 1), mapPanel.Height);
            }

            for (int j = 0; j < game.Columns - 1; j++)
            {
                g.DrawLine(p, 0, pixelsPerRow * (j + 1), mapPanel.Width, pixelsPerRow * (j + 1));
            }

            playerBox.BringToFront();
        }

        /*private void TestClick(Object sender, MouseEventArgs e)
        {
            Int32 position = GetMouseClickPosition(e.X, e.Y);
        }*/

        private Int32 GetMouseClickPosition(Int32 xPos, Int32 yPos)
        {
            Int32 pixelsPerColumn = mapPanel.Width / game.Columns;
            Int32 pixelsPerRow = mapPanel.Height / game.Rows;

            Int32 row = yPos / pixelsPerRow;
            Int32 col = xPos / pixelsPerColumn;

            Int32 position = row * game.Columns + col;

            return position;
        }

        private void uiTimer_Tick(object sender, EventArgs e)
        {
            uiTimer.Enabled = false;

            if (death == false)
            {
                lblExpValue.Text = String.Format("{0} / {1}", hPlayer[0].Exp, hPlayer[0].TotalExp);
                lblManaValue.Text = String.Format("{0} / {1}", hPlayer[0].Mana, hPlayer[0].TotalMana);
                lblHealthValue.Text = String.Format("{0} / {1}", hPlayer[0].Health, hPlayer[0].TotalHealth);
                lblLevelValue.Text = hPlayer[0].Level.ToString();
            }

            if (lastLevel < hPlayer[0].Level)
            {
                MessageBox.Show("LEVEL UP!");
                lastLevel = hPlayer[0].Level;
            }

            
            if (!hPlayer[0].WinStatus && hPlayer[0].Health == 0 && death == false)
            {
              
                death = true;
                deathTimer.Enabled = true;
                
            }
            else if (hPlayer[0].WinStatus)
            {
               
                RemoveMonster(hPlayer[0].CurMonsterPos);
                winTimer.Enabled = true;
            }
            
        }

        private void RemoveMonster(int pos)
        {

            game.MonsterPositions.Remove(pos);
        }

        private Boolean InventoryModerator(String item, InventoryTyp type)
        {
            Random rr = new Random();
            int num = rr.Next(0, 201);

            switch (type)
            {
                case InventoryTyp.Sword:
                    switch (item)
                    {
                        case "Master Sword":
                            if (num == 4)
                                return true;
                            return false;
                        case "Biggoron Sword":
                            if (num == 19)
                                return true;
                            return false;
                        case "Noble Sword":
                            return true;
                        case "Heros Sword":
                            if (hPlayer[0].Inventory.Contains("Noble Sword"))
                                return true;
                            return false;
                        case "Razor Sword":
                            if (hPlayer[0].Inventory.Contains("Heros Sword"))
                                return true;
                            return false;
                        case "Magical Sword":
                            if (hPlayer[0].Level == 5)
                                return true;
                            return false;
                        case "Phantom Sword":
                            if (hPlayer[0].Level == 7)
                                return true;
                            return false;
                    }
                    break;
                case InventoryTyp.Shield:
                    switch (item)
                    {
                        case "Hylian Sheild":
                            if (num == 5)
                                return true;
                            return false;
                        case "Deku Sheild":
                            return true;
                        case "Hero Sheild":
                            if (hPlayer[0].Inventory.Contains("Deku Sheild"))
                                return true;
                            return false;
                        case "Fighter Sheild":
                            if (hPlayer[0].Inventory.Contains("Hero Sheild"))
                                return true;
                            return false;
                        case "Red Sheild":
                            if (hPlayer[0].Level == 8)
                                return true;
                            return false;
                        case "Sacred Sheild":
                            if (hPlayer[0].Level == 9)
                                return true;
                            return false;
                    }
                    break;
                case InventoryTyp.Ranged:
                    switch (item)
                    {
                        case "Bow of Light":
                            if (num == 94)
                                return true;
                            return false;
                        case "Boomerang":
                            return true;
                        case "Magic Boomerang":
                            if (hPlayer[0].Inventory.Contains("Boomerang"))
                                return true;
                            return false;
                        case "Bomb":
                            if (hPlayer[0].Level == 8)
                                return true;
                            return false;
                        case "Bow":
                            if (hPlayer[0].Level == 9)
                                return true;
                            return false;
                    }
                    break;
                case InventoryTyp.Health:
                    return true;
                case InventoryTyp.Mana:
                    return true;
            }
            return false;
        }

        /*private void btnInventory_Click(object sender, EventArgs e)
        {
            Form3 f3 = new Form3(hPlayer);
            f3.Show();
        }*/

        private void InventoryClick(object sender, EventArgs e)
        {
            Form3 f3 = new Form3(hPlayer);
            f3.Show();
        }

        private void Form2_GotFocus(object sender, EventArgs e)
        {
            if (hPlayer[0].WinStatus == false)
                uiTimer.Enabled = true;
            else if (hPlayer[0].WinStatus == true)
                uiTimer.Enabled = true;
            else
                uiTimer.Enabled = false;
        }

        private void deathTimer_Tick(object sender, EventArgs e)
        {
            deathTimer.Enabled = false;
            uiTimer.Enabled = false;
            DialogResult result = MessageBox.Show("Play Again?", "GAME OVER", MessageBoxButtons.YesNo, MessageBoxIcon.Hand, MessageBoxDefaultButton.Button1);
            if (result == DialogResult.Yes)
            {
                playerBox.Location = new Point(0, 88);
                hPlayer[0].UpdateStat(hPlayer[0].TotalHealth, StatAction.Add, Stats.Health, CombatType.None);
                lblHealthValue.Text = String.Format("{0} / {1}", hPlayer[0].Health, hPlayer[0].TotalHealth);
                death = false;
                 

            }
            else if (result == DialogResult.No)
            {
                Application.Exit();
            }
                
        }

        private void winTimer_Tick(object sender, EventArgs e)
        {
            winTimer.Enabled = false;
            uiTimer.Enabled = false;
            hPlayer[0].WinStatus = false;
            lblKeyValue.Text = hPlayer[0].KeyCount + "/ 3";
            MessageBox.Show("Victory!");
            if (hPlayer[0].BoosWin)
            {
                MessageBox.Show("Congratulations, You have slayed the monster and awaken from the nightmare");
                MessageBox.Show("Thank you for playing!");
                MessageBox.Show("Created by: Jordan Turner. April, 7th, 2014");
                MessageBox.Show("PRG655 Project");
                Application.Exit();
            }
            if (hPlayer[0].KeyCount == 3)
            {
                MessageBox.Show("You have found 3 keys, it's time to fight the boss, don't forget to gear up by searching the map!");
                pictureBox1.Visible = true;
                game.MonsterPositions.Clear();
            }
            else
            {
                int keysLeft = 3 - hPlayer[0].KeyCount;
                MessageBox.Show("Only " + keysLeft.ToString() + " left to get!");
            }
        } 
    }
}