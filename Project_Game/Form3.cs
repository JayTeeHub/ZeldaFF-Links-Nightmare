using System;
using System.Linq;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace Project_Game
{
   

    public delegate void KeyHandler(object sender, KeyPressEventArgs e);

    public partial class Form3 : Form
    {
        protected List<HumanPlayer> hPlayer;
        protected event KeyHandler Key;
        private String uvItem = "";
        private Int32 uvValue = 0;
        private InventoryTyp uvType;

        public Form3()
        {
            InitializeComponent();
        }

        public Form3(List<HumanPlayer> currPlayer)
        {   
            InitializeComponent();
            hPlayer = currPlayer;
            
            Key += new KeyHandler(ShowItemStats);

            UpdatePlayerStats();
            UpdatePlayerEquips();

            TreeNode healthNode = new TreeNode("Health");
            treeInventory.Nodes.Add(healthNode);

            TreeNode manaNode = new TreeNode("Mana");
            treeInventory.Nodes.Add(manaNode);

            TreeNode shieldNode = new TreeNode("Shield");
            treeInventory.Nodes.Add(shieldNode);

            for (int i = 0; i < treeInventory.Nodes.Count; i++)
            {
                for (int j = 0; j < hPlayer[0].Inventory.Count; j++)
                {
                    if (treeInventory.Nodes[i].Text == hPlayer[0].InventoryType[j].ToString())
                    {
                        treeInventory.Nodes[i].Nodes.Add(new TreeNode(hPlayer[0].Inventory[j].ToString()));
                    }
                }
            }


            TreeNode swordNode = new TreeNode("Sword");
            TreeNode rangedNode = new TreeNode("Ranged");
            TreeNode[] weaponArr = new TreeNode[] { swordNode, rangedNode };
            TreeNode weaponNode = new TreeNode("Weapon");
            treeInventory.Nodes.Add(weaponNode);
            foreach (TreeNode weapon in weaponArr)
            {
                treeInventory.Nodes[3].Nodes.Add(new TreeNode(weapon.Text));
            }
            
            for (int i = 0; i < treeInventory.Nodes[3].Nodes.Count; i++)
            {
                for (int j = 0; j < hPlayer[0].Inventory.Count; j++)
                {
                    if (treeInventory.Nodes[3].Nodes[i].Text == hPlayer[0].InventoryType[j].ToString())
                    {
                        treeInventory.Nodes[3].Nodes[i].Nodes.Add(new TreeNode(hPlayer[0].Inventory[j].ToString()));
                    }
                }
            }

        }

        private void OnKey(InventoryViewEventArgs e)
        {
            if (Key != null)
            {
                Key(this, e);
            }
        }

        private void KeyClick(KeyPressEventArgs e)
        {
            OnKey(new InventoryViewEventArgs(e.KeyChar));
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void treeInventory_KeyPress(object sender, KeyPressEventArgs e)
        {
            KeyClick(e);
        }

        private void ShowItemStats(object sender, KeyPressEventArgs e)
        {
            TreeView tv_Inventory = treeInventory;
            int index = hPlayer[0].Inventory.IndexOf(tv_Inventory.SelectedNode.Text);
            int qty = 0;
            if (index != -1)
            {
                InventoryTyp iType = hPlayer[0].InventoryType[index];
                panelItemStats.Visible = true;

                switch (iType)
                { 
                    case InventoryTyp.Sword:

                        if (btnEquip.Text == "Use")
                            btnEquip.Text = "Equip";

                        lblName.Text = hPlayer[0].Inventory[index];
                        lblStatValue.Text =" +" + hPlayer[0].InventoryValue[index].ToString() + " Att";

                        uvItem = lblName.Text;
                        uvValue = hPlayer[0].InventoryValue[index];
                        uvType = iType;

                        for (int i=0; i < hPlayer[0].Inventory.Count; i++)
                        {
                            if (hPlayer[0].Inventory[i] == lblName.Text)
                                qty++;
                        }

                        lblQtyValue.Text = qty.ToString();

                        if (hPlayer[0].Inventory[index] == hPlayer[0].Weapon)
                        {
                            btnEquip.Enabled = false;
                        }
                        else
                        {
                            btnEquip.Enabled = true;
                        }
                        break;
                    case InventoryTyp.Ranged:

                        if (btnEquip.Text == "Use")
                            btnEquip.Text = "Equip";

                        lblName.Text = hPlayer[0].Inventory[index];
                        lblStatValue.Text = " +" + hPlayer[0].InventoryValue[index].ToString() + " Att";

                        uvItem = lblName.Text;
                        uvValue = hPlayer[0].InventoryValue[index];
                        uvType = iType;

                        for (int i = 0; i < hPlayer[0].Inventory.Count; i++)
                        {
                            if (hPlayer[0].Inventory[i] == lblName.Text)
                                qty++;
                        }

                        lblQtyValue.Text = qty.ToString();

                        if (hPlayer[0].Inventory[index] == hPlayer[0].Ranged)
                        {
                            btnEquip.Enabled = false;
                        }
                        else
                        {
                            btnEquip.Enabled = true;
                        }
                        break;
                    
                    case InventoryTyp.Shield:

                        if (btnEquip.Text == "Use")
                            btnEquip.Text = "Equip";

                        lblName.Text = hPlayer[0].Inventory[index];
                        lblStatValue.Text = " +" + hPlayer[0].InventoryValue[index].ToString() + " Armor";

                        uvItem = lblName.Text;
                        uvValue = hPlayer[0].InventoryValue[index];
                        uvType = iType;

                        for (int i = 0; i < hPlayer[0].Inventory.Count; i++)
                        {
                            if (hPlayer[0].Inventory[i] == lblName.Text)
                                qty++;
                        }

                        lblQtyValue.Text = qty.ToString();

                        if (hPlayer[0].Inventory[index] == hPlayer[0].Shield)
                        {
                            btnEquip.Enabled = false;
                        }
                        else
                        {
                            btnEquip.Enabled = true;
                        }
                        
                        break;
                    case InventoryTyp.Health:
                        
                        btnEquip.Text = "Use";

                        if(!btnEquip.Enabled)
                            btnEquip.Enabled = true;

                        lblName.Text = hPlayer[0].Inventory[index];
                        lblStatValue.Text = " +" + hPlayer[0].InventoryValue[index].ToString() + " Health";

                        uvItem = lblName.Text;
                        uvValue = hPlayer[0].InventoryValue[index];
                        uvType = iType;

                        for (int i = 0; i < hPlayer[0].Inventory.Count; i++)
                        {
                            if (hPlayer[0].Inventory[i] == lblName.Text)
                                qty++;
                        }

                        lblQtyValue.Text = qty.ToString();

                        break;

                    case InventoryTyp.Mana:

                        btnEquip.Text = "Use";

                        if (!btnEquip.Enabled)
                            btnEquip.Enabled = true;

                        lblName.Text = hPlayer[0].Inventory[index];
                        lblStatValue.Text = " +" + hPlayer[0].InventoryValue[index].ToString() + " Health";

                        uvItem = lblName.Text;
                        uvValue = hPlayer[0].InventoryValue[index];
                        uvType = iType;

                        for (int i = 0; i < hPlayer[0].Inventory.Count; i++)
                        {
                            if (hPlayer[0].Inventory[i] == lblName.Text)
                                qty++;
                        }

                        lblQtyValue.Text = qty.ToString();

                        break;
                }
            }
            else
            {
                panelItemStats.Visible = false;
            }
        }

        private void UpdatePlayerStats()
        {
            lblAtt.Text = hPlayer[0].AttackPower.ToString();
            lblArm.Text = hPlayer[0].Armor.ToString();
        }

        private void UpdatePlayerEquips()
        {
            lblSwordName.Text = hPlayer[0].Weapon;
            lblShieldName.Text = hPlayer[0].Shield;
            lblRangedName.Text = hPlayer[0].Ranged;
        }

        private void btnEquip_Click(object sender, EventArgs e)
        {
            if (btnEquip.Text != "Use")
                btnEquip.Enabled = false;

            switch (uvType)
            {
                case InventoryTyp.Sword:
                    hPlayer[0].UpdateStat(hPlayer[0].LastAttackAmount, StatAction.Sub, Stats.AttackPower, CombatType.None);
                    hPlayer[0].UpdateStat(uvValue, StatAction.Add, Stats.AttackPower, CombatType.None);
                    hPlayer[0].UpdateWeapon(uvItem, uvValue, uvType);
                    UpdatePlayerStats();
                    UpdatePlayerEquips();
                    break;
                case InventoryTyp.Shield:
                    hPlayer[0].UpdateStat(hPlayer[0].LastArmor, StatAction.Sub, Stats.Armor, CombatType.None);
                    hPlayer[0].UpdateStat(uvValue, StatAction.Add, Stats.Armor, CombatType.None);
                    hPlayer[0].UpdateWeapon(uvItem, uvValue, uvType);
                    UpdatePlayerStats();
                    UpdatePlayerEquips();
                    break;
                case InventoryTyp.Ranged:
                    hPlayer[0].UpdateWeapon(uvItem, uvValue, uvType);
                    UpdatePlayerStats();
                    UpdatePlayerEquips();
                    break;
                case InventoryTyp.Health:
                    hPlayer[0].UpdateStat(uvValue, StatAction.Add, Stats.Health, CombatType.None);
                    hPlayer[0].RemoveItem(uvItem, InventoryTyp.Health);
                    UpdatePlayerStats();
                    UpdatePlayerEquips();
                    break;
                case InventoryTyp.Mana:
                    hPlayer[0].UpdateStat(uvValue, StatAction.Add, Stats.Mana, CombatType.None);
                    hPlayer[0].RemoveItem(uvItem, InventoryTyp.Mana);
                    UpdatePlayerStats();
                    UpdatePlayerEquips();
                    break;

            }
        }
    }

    //Custom KeyPressEvent for the TreeView Control
    public class InventoryViewEventArgs : KeyPressEventArgs
    {
        public Char Name;
        public InventoryViewEventArgs(Char name): base(name)
        {
            Name = name;
        }
    }
}