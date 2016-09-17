using System;
using System.Linq;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.IO;
//-------------------------------------------------------------
//-----------------Project Name: Link's Nightmare--------------
//|N|A|M|E|: Jordan James Turner
//|S|T|U|D|E|N|T N|U|M|B|E|R: 046518999
//|D|A|T|E: April, 7th, 2014
//C|O|U|R|S|E: PRG655 Seneca College
//--------------------------------------------------------------
//--IF YOU STARTED HERE THEN YOU MISSED THE "Program.cs" FILE---
namespace Project_Game
{
    public partial class Form1 : Form
    {
        private String fullPath;//Holds the full path which is obtained in the constructor for Form1, it is the passed value.
        private String healthPath;
        private String manaPath;
        private String swordsPath;
        private String sheildsPath;
        private String rangedPath;
        private String keysPath;
        private String enemyPath;
        private String bossPath;
        private String baHumanPath;
        private String saHumanPath;
        private String saComputerPath;

        private String saCName;
        private Int32 saCValue;
        private Int32 saCCost;

        protected Form2 f;
        protected Dungeon game;
        protected HumanPlayer userPlayer;
        protected ComputerPlayer compPlayer;

        public Form1()
        {
            InitializeComponent();
            
        }

        public Form1(String _fullPath)
        {
            InitializeComponent();
            fullPath = _fullPath;
            game = new Dungeon();//Create a Dungeon object. 
            SetFilePaths();//Hover over method.
            f = new Form2(game);//Create a Form2 object and pass the game object to that form.
            userPlayer = new HumanPlayer("Link", 10, 10, 5, 5,1, "Wood Sword", 2,"None",0,"None",0,0);//Create a HumanPlayer object, which is our new player. Hover over constructor.
            f.AddUser(userPlayer);
            GetItems();
            SetMonsters();
            game.SetMonsterPositions();
            game.SetItemPositions();
            
            
        }

        public String FullPath
        {
            get { return fullPath; }
        }

        public String HealthPath
        {
            get { return healthPath; }
        }

        public String ManaPath
        {
            get { return manaPath; }
        }

        public String SwordsPath
        {
            get { return swordsPath; }
        }

        public String SheildsPath
        {
            get { return sheildsPath; }
        }

        public String RangedPath
        {
            get { return rangedPath; }
        }

        public String KeysPath
        {
            get { return keysPath; }
        }

        public String EnemyPath
        {
            get { return enemyPath; }
        }

        public String BossPath
        {
            get { return bossPath; }
        }

        public String BAHumanPath
        {
            get { return baHumanPath; }
        }

        public String SAHumanPath
        {
            get { return saHumanPath; }
        }

        public String SAComputerPath
        {
            get { return saComputerPath; }
        }
        /// <summary>
        /// Assign's all game resource files to class properties. 
        /// </summary>
        private void SetFilePaths()
        {
            healthPath = FullPath + "\\HealthItems.txt";
            manaPath = FullPath + "\\ManaItems.txt";
            swordsPath = FullPath + "\\Swords.txt";
            sheildsPath = FullPath + "\\Sheilds.txt";
            rangedPath = FullPath + "\\Ranged.txt";
            keysPath = FullPath + "\\Keys.txt";
            enemyPath = FullPath + "\\Enemies.txt";
            bossPath = FullPath + "\\Boss.txt";
            baHumanPath = FullPath + "\\BasicAttacksHuman.txt";
            saHumanPath = FullPath + "\\SpecialAttacksHuman.txt";
            saComputerPath = FullPath + "\\SpecialAttacksComputer.txt";
        }
        
        /// <summary>
        /// This function uses FILE I/O to load the game resources into class lists that are used by the rest of the project to populate the map.
        /// </summary>
        private void GetItems()
        {
            if (File.Exists(healthPath) == true)
            {
                using (StreamReader reader = new StreamReader(healthPath))
                {
                    string line;
                    while ((line = reader.ReadLine()) != null)
                    {
                        if(line.IndexOf("Name") != -1)
                        {
                            int index = line.IndexOf(':');
                            string result = line.Remove(0,index +1);
                            game.HealthItemNames.Add(result);
                        }
                        if (line.IndexOf("Value") != -1)
                        {
                            int index = line.IndexOf(':');
                            string result = line.Remove(0, index + 1);
                            game.HealthItemValues.Add(Convert.ToInt32(result));
                        }
                    }
                }
            }

            if (File.Exists(manaPath) == true)
            {
                using (StreamReader reader = new StreamReader(manaPath))
                {
                    string line;
                    while ((line = reader.ReadLine()) != null)
                    {
                        if (line.IndexOf("Name") != -1)
                        {
                            int index = line.IndexOf(':');
                            string result = line.Remove(0, index + 1);
                            game.ManaItemNames.Add(result);
                        }
                        if (line.IndexOf("Value") != -1)
                        {
                            int index = line.IndexOf(':');
                            string result = line.Remove(0, index + 1);
                            game.ManaItemValues.Add(Convert.ToInt32(result));
                        }
                    }
                }
            }
            
            if(File.Exists(swordsPath))
            {
                using (StreamReader reader = new StreamReader(swordsPath))
                {
                    string line;
                    while ((line = reader.ReadLine()) != null)
                    {
                        if (line.IndexOf("Name") != -1)
                        {
                            int index = line.IndexOf(':');
                            string result = line.Remove(0, index + 1);
                            game.SwordNames.Add(result);
                        }
                        if (line.IndexOf("Value") != -1)
                        {
                            int index = line.IndexOf(':');
                            string result = line.Remove(0, index + 1);
                            game.SwordValues.Add(Convert.ToInt32(result));
                        }
                    }
                }
            }

            if (File.Exists(sheildsPath))
            {
                using (StreamReader reader = new StreamReader(sheildsPath))
                {
                    string line;
                    while ((line = reader.ReadLine()) != null)
                    {
                        if (line.IndexOf("Name") != -1)
                        {
                            int index = line.IndexOf(':');
                            string result = line.Remove(0, index + 1);
                            game.SheildNames.Add(result);
                        }
                        if (line.IndexOf("Value") != -1)
                        {
                            int index = line.IndexOf(':');
                            string result = line.Remove(0, index + 1);
                            game.SheildValues.Add(Convert.ToInt32(result));
                        }
                    }
                }
            }

            if (File.Exists(rangedPath))
            {
                using (StreamReader reader = new StreamReader(rangedPath))
                {
                    string line;
                    while ((line = reader.ReadLine()) != null)
                    {
                        if (line.IndexOf("Name") != -1)
                        {
                            int index = line.IndexOf(':');
                            string result = line.Remove(0, index + 1);
                            game.RangedNames.Add(result);
                        }
                        if (line.IndexOf("Value") != -1)
                        {
                            int index = line.IndexOf(':');
                            string result = line.Remove(0, index + 1);
                            game.RangedValues.Add(Convert.ToInt32(result));
                        }
                    }
                }
            }

            if (File.Exists(keysPath))
            {
                using (StreamReader reader = new StreamReader(keysPath))
                {
                    string line;
                    while ((line = reader.ReadLine()) != null)
                    {
                        if (line.IndexOf("Name") != -1)
                        {
                            int index = line.IndexOf(':');
                            string result = line.Remove(0, index + 1);
                            game.KeyNames.Add(result);
                        }
                    }
                }
            }

            if (File.Exists(enemyPath))
            {
                using (StreamReader reader = new StreamReader(enemyPath))
                {
                    string line;
                    while ((line = reader.ReadLine()) != null)
                    {
                        if (line.IndexOf("Name") != -1)
                        {
                            int index = line.IndexOf(':');
                            string result = line.Remove(0, index + 1);
                            game.EnemyNames.Add(result);
                        }
                        if (line.IndexOf("Health") != -1)
                        {
                            int index = line.IndexOf(':');
                            string result = line.Remove(0, index + 1);
                            game.EnemyHealth.Add(Convert.ToInt32(result));
                        }
                        if (line.IndexOf("AP") != -1)
                        {
                            int index = line.IndexOf(':');
                            string result = line.Remove(0, index + 1);
                            game.EnemyAP.Add(Convert.ToInt32(result));
                        }
                        if (line.IndexOf("Mana") != -1)
                        {
                            int index = line.IndexOf(':');
                            string result = line.Remove(0, index + 1);
                            game.EnemyMana.Add(Convert.ToInt32(result));
                        }
                        if (line.IndexOf("Armor") != -1)
                        {
                            int index = line.IndexOf(':');
                            string result = line.Remove(0, index + 1);
                            game.EnemyArmor.Add(Convert.ToInt32(result));
                        }
                        if (line.IndexOf("Level") != -1)
                        {
                            int index = line.IndexOf(':');
                            string result = line.Remove(0, index + 1);
                            game.EnemyLevel.Add(Convert.ToInt32(result));
                        }
                        if (line.IndexOf("Exp") != -1)
                        {
                            int index = line.IndexOf(':');
                            string result = line.Remove(0, index + 1);
                            game.EnemyExpAward.Add(Convert.ToInt32(result));
                        }
                    }
                }
            }
            if (File.Exists(bossPath))
            {
                using (StreamReader reader = new StreamReader(bossPath))
                {
                    string line;
                    while ((line = reader.ReadLine()) != null)
                    {
                        if (line.IndexOf("Name") != -1)
                        {
                            int index = line.IndexOf(':');
                            string result = line.Remove(0, index + 1);
                            game.BossNames.Add(result);
                        }
                        if (line.IndexOf("Health") != -1)
                        {
                            int index = line.IndexOf(':');
                            string result = line.Remove(0, index + 1);
                            game.BossHealth.Add(Convert.ToInt32(result));
                        }
                        if (line.IndexOf("AP") != -1)
                        {
                            int index = line.IndexOf(':');
                            string result = line.Remove(0, index + 1);
                            game.BossAP.Add(Convert.ToInt32(result));
                        }
                        if (line.IndexOf("Mana") != -1)
                        {
                            int index = line.IndexOf(':');
                            string result = line.Remove(0, index + 1);
                            game.BossMana.Add(Convert.ToInt32(result));
                        }
                        if (line.IndexOf("Armor") != -1)
                        {
                            int index = line.IndexOf(':');
                            string result = line.Remove(0, index + 1);
                            game.BossArmor.Add(Convert.ToInt32(result));
                        }
                        if (line.IndexOf("Level") != -1)
                        {
                            int index = line.IndexOf(':');
                            string result = line.Remove(0, index + 1);
                            game.BossLevel.Add(Convert.ToInt32(result));
                        }
                        if (line.IndexOf("Exp") != -1)
                        {
                            int index = line.IndexOf(':');
                            string result = line.Remove(0, index + 1);
                            game.BossExpAward.Add(Convert.ToInt32(result));
                        }
                    }
                }
            }
            if (File.Exists(baHumanPath))
            {
                string name="";
                int value=-1, level=-1, cd=-1;
                using (StreamReader reader = new StreamReader(baHumanPath))
                {
                    string line;
                    while ((line = reader.ReadLine()) != null)
                    {
                        if (line.IndexOf("Name") != -1)
                        {
                            int index = line.IndexOf(':');
                            string result = line.Remove(0, index + 1);
                            name = result;
                        }
                        if (line.IndexOf("Value") != -1)
                        {
                            int index = line.IndexOf(':');
                            string result = line.Remove(0, index + 1);
                            value = Convert.ToInt32(result);
                        }
                        if (line.IndexOf("Level") != -1)
                        {
                            int index = line.IndexOf(':');
                            string result = line.Remove(0, index + 1);
                            level = Convert.ToInt32(result);
                        }
                        if (line.IndexOf("Cooldown") != -1)
                        {
                            int index = line.IndexOf(':');
                            string result = line.Remove(0, index + 1);
                            cd = Convert.ToInt32(result);
                        }
                        if (name != "" && value != -1 && level != -1 && cd != -1)
                        {
                            userPlayer.UpdateBasicAttacks(name, value, level, cd);
                            name = "";
                            value = -1; 
                            level = -1;
                            cd = -1;
                        }
                    }
                }
            }
            if (File.Exists(saHumanPath))
            {
                string name = "";
                int value = -1, level = -1, cost = -1;
                using (StreamReader reader = new StreamReader(saHumanPath))
                {
                    string line;
                    while ((line = reader.ReadLine()) != null)
                    {
                        if (line.IndexOf("Name") != -1)
                        {
                            int index = line.IndexOf(':');
                            string result = line.Remove(0, index + 1);
                            name = result;
                        }
                        if (line.IndexOf("Value") != -1)
                        {
                            int index = line.IndexOf(':');
                            string result = line.Remove(0, index + 1);
                            value = Convert.ToInt32(result);
                        }
                        if (line.IndexOf("Cost") != -1)
                        {
                            int index = line.IndexOf(':');
                            string result = line.Remove(0, index + 1);
                            cost = Convert.ToInt32(result);
                        }
                        if (line.IndexOf("Level") != -1)
                        {
                            int index = line.IndexOf(':');
                            string result = line.Remove(0, index + 1);
                            level = Convert.ToInt32(result);
                        }
                        
                        if (name != "" && value != -1 && level != -1 && cost != -1)
                        {
                            userPlayer.UpdateSpecialAttacks(name, value, level,cost);
                            name = "";
                            value = -1;
                            level = -1;
                            cost = -1;
                        }
                    }
                }
            }
            if (File.Exists(saComputerPath))
            {
                using (StreamReader reader = new StreamReader(saHumanPath))
                {
                    string line;
                    while ((line = reader.ReadLine()) != null)
                    {
                        if (line.IndexOf("Name") != -1)
                        {
                            int index = line.IndexOf(':');
                            string result = line.Remove(0, index + 1);
                            saCName = result;
                        }
                        if (line.IndexOf("Value") != -1)
                        {
                            int index = line.IndexOf(':');
                            string result = line.Remove(0, index + 1);
                            saCValue = Convert.ToInt32(result);
                        }
                        if (line.IndexOf("Cost") != -1)
                        {
                            int index = line.IndexOf(':');
                            string result = line.Remove(0, index + 1);
                            saCCost = Convert.ToInt32(result);
                        }
                    }
                }
            }
        }

        private void SetMonsters()
        {
            Random rKey = new Random();
            int mKey = rKey.Next(0, 4);
            int totalCount = 0;
            int kIndex = GenerateKey();
            int mCount = 0;
            for(int i =0; i<game.EnemyNames.Count;i++)
            {
                if (game.EnemyNames[i] == "Lizalfos" || game.EnemyNames[i] == "Flare Dancer" || game.EnemyNames[i] == "Stalfos" || game.EnemyNames[i] == "Meg")
                    mCount = 3;
                else if (game.EnemyNames[i] == "Gerudo Thief")
                    mCount = 2;
                else if (game.EnemyNames[i] == "Dark Link" || game.EnemyNames[i] == "Gohma")
                    mCount = 1;
                for (int j = 0; j < mCount; j++)
                {
                    if (i == mKey)
                    {
                        compPlayer = new ComputerPlayer(game.EnemyNames[i], game.EnemyHealth[i], game.EnemyAP[i], game.EnemyMana[i], game.EnemyArmor[i], game.EnemyLevel[i], game.EnemyExpAward[i], game.KeyNames[kIndex], 1, MonsterType.Minion);
                        compPlayer.UpdateSpecialAttacks(saCName, saCValue, 0, saCCost);
                    }
                    else if (game.EnemyNames[i] == "Gohma")
                    {
                        game.BossIndex = i;
                        compPlayer = new ComputerPlayer(game.EnemyNames[i], game.EnemyHealth[i], game.EnemyAP[i], game.EnemyMana[i], game.EnemyArmor[i], game.EnemyLevel[i], game.EnemyExpAward[i], game.KeyNames[kIndex], 1, MonsterType.Minion);
                        compPlayer.UpdateSpecialAttacks(saCName, saCValue, 0, saCCost);
                        totalCount = 0;
                    }
                    else if (game.EnemyNames[i] == "Dark Link")
                    {
                        compPlayer = new ComputerPlayer(game.EnemyNames[i], game.EnemyHealth[i], game.EnemyAP[i], game.EnemyMana[i], game.EnemyArmor[i], game.EnemyLevel[i], game.EnemyExpAward[i], game.KeyNames[kIndex], 3, MonsterType.DarkLink);
                        compPlayer.UpdateSpecialAttacks(saCName, saCValue, 0, saCCost);
                    }
                    else
                    {
                        compPlayer = new ComputerPlayer(game.EnemyNames[i], game.EnemyHealth[i], game.EnemyAP[i], game.EnemyMana[i], game.EnemyArmor[i], game.EnemyLevel[i], game.EnemyExpAward[i], game.KeyNames[kIndex], 1, MonsterType.Minion);
                        compPlayer.UpdateSpecialAttacks(saCName, saCValue, 0, saCCost);
                    }
                    
                    f.AddComputer(compPlayer);
                    totalCount++;
                }
            }
        }

        private Int32 GenerateKey()
        {
            Random rKeyName = new Random();
            int kIndex = rKeyName.Next(0, 3);
            return kIndex;
        }

        private void btnPlay_Click(object sender, EventArgs e)
        {
            if (f != null)
                f.Show();
            else
                MessageBox.Show("Player not loaded");
        }
    }
}