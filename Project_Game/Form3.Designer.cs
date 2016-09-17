namespace Project_Game
{
    partial class Form3
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;
        private System.Windows.Forms.MainMenu mainMenu1;

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
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.mainMenu1 = new System.Windows.Forms.MainMenu();
            this.label1 = new System.Windows.Forms.Label();
            this.btnClose = new System.Windows.Forms.Button();
            this.treeInventory = new System.Windows.Forms.TreeView();
            this.panelPlayerStats = new System.Windows.Forms.Panel();
            this.lblArm = new System.Windows.Forms.Label();
            this.lblAtt = new System.Windows.Forms.Label();
            this.lblArmor = new System.Windows.Forms.Label();
            this.lblAP = new System.Windows.Forms.Label();
            this.lblStats = new System.Windows.Forms.Label();
            this.lblEquips = new System.Windows.Forms.Label();
            this.panelPlayerEquips = new System.Windows.Forms.Panel();
            this.lblRangedName = new System.Windows.Forms.Label();
            this.lblSwordName = new System.Windows.Forms.Label();
            this.lblShieldName = new System.Windows.Forms.Label();
            this.lblRanged = new System.Windows.Forms.Label();
            this.lblShield = new System.Windows.Forms.Label();
            this.lblSword = new System.Windows.Forms.Label();
            this.panelItemStats = new System.Windows.Forms.Panel();
            this.lblQtyValue = new System.Windows.Forms.Label();
            this.lblQty = new System.Windows.Forms.Label();
            this.btnEquip = new System.Windows.Forms.Button();
            this.lblStatValue = new System.Windows.Forms.Label();
            this.lblValue = new System.Windows.Forms.Label();
            this.lblName = new System.Windows.Forms.Label();
            this.lblItemStats = new System.Windows.Forms.Label();
            this.panelPlayerStats.SuspendLayout();
            this.panelPlayerEquips.SuspendLayout();
            this.panelItemStats.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular);
            this.label1.Location = new System.Drawing.Point(48, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(100, 20);
            this.label1.Text = "Inventory";
            this.label1.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // btnClose
            // 
            this.btnClose.BackColor = System.Drawing.Color.LemonChiffon;
            this.btnClose.Location = new System.Drawing.Point(194, 245);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(43, 20);
            this.btnClose.TabIndex = 2;
            this.btnClose.Text = "Close";
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // treeInventory
            // 
            this.treeInventory.Font = new System.Drawing.Font("Tahoma", 8F, System.Drawing.FontStyle.Regular);
            this.treeInventory.Location = new System.Drawing.Point(0, 23);
            this.treeInventory.Name = "treeInventory";
            this.treeInventory.Size = new System.Drawing.Size(134, 186);
            this.treeInventory.TabIndex = 3;
            this.treeInventory.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.treeInventory_KeyPress);
            // 
            // panelPlayerStats
            // 
            this.panelPlayerStats.BackColor = System.Drawing.Color.LemonChiffon;
            this.panelPlayerStats.Controls.Add(this.lblArm);
            this.panelPlayerStats.Controls.Add(this.lblAtt);
            this.panelPlayerStats.Controls.Add(this.lblArmor);
            this.panelPlayerStats.Controls.Add(this.lblAP);
            this.panelPlayerStats.Controls.Add(this.lblStats);
            this.panelPlayerStats.Location = new System.Drawing.Point(140, 3);
            this.panelPlayerStats.Name = "panelPlayerStats";
            this.panelPlayerStats.Size = new System.Drawing.Size(100, 87);
            // 
            // lblArm
            // 
            this.lblArm.Font = new System.Drawing.Font("Tahoma", 8F, System.Drawing.FontStyle.Regular);
            this.lblArm.Location = new System.Drawing.Point(67, 54);
            this.lblArm.Name = "lblArm";
            this.lblArm.Size = new System.Drawing.Size(20, 20);
            this.lblArm.Text = "10";
            // 
            // lblAtt
            // 
            this.lblAtt.Font = new System.Drawing.Font("Tahoma", 8F, System.Drawing.FontStyle.Regular);
            this.lblAtt.Location = new System.Drawing.Point(67, 20);
            this.lblAtt.Name = "lblAtt";
            this.lblAtt.Size = new System.Drawing.Size(20, 20);
            this.lblAtt.Text = "10";
            // 
            // lblArmor
            // 
            this.lblArmor.Font = new System.Drawing.Font("Tahoma", 8F, System.Drawing.FontStyle.Regular);
            this.lblArmor.Location = new System.Drawing.Point(3, 54);
            this.lblArmor.Name = "lblArmor";
            this.lblArmor.Size = new System.Drawing.Size(45, 20);
            this.lblArmor.Text = "Armor :";
            // 
            // lblAP
            // 
            this.lblAP.Font = new System.Drawing.Font("Tahoma", 8F, System.Drawing.FontStyle.Regular);
            this.lblAP.Location = new System.Drawing.Point(3, 20);
            this.lblAP.Name = "lblAP";
            this.lblAP.Size = new System.Drawing.Size(70, 20);
            this.lblAP.Text = "Att Power :";
            // 
            // lblStats
            // 
            this.lblStats.Dock = System.Windows.Forms.DockStyle.Top;
            this.lblStats.Location = new System.Drawing.Point(0, 0);
            this.lblStats.Name = "lblStats";
            this.lblStats.Size = new System.Drawing.Size(100, 17);
            this.lblStats.Text = "Player Stats";
            this.lblStats.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // lblEquips
            // 
            this.lblEquips.Dock = System.Windows.Forms.DockStyle.Top;
            this.lblEquips.Location = new System.Drawing.Point(0, 0);
            this.lblEquips.Name = "lblEquips";
            this.lblEquips.Size = new System.Drawing.Size(100, 15);
            this.lblEquips.Text = "Player Equips";
            this.lblEquips.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // panelPlayerEquips
            // 
            this.panelPlayerEquips.BackColor = System.Drawing.Color.LemonChiffon;
            this.panelPlayerEquips.Controls.Add(this.lblRangedName);
            this.panelPlayerEquips.Controls.Add(this.lblSwordName);
            this.panelPlayerEquips.Controls.Add(this.lblShieldName);
            this.panelPlayerEquips.Controls.Add(this.lblRanged);
            this.panelPlayerEquips.Controls.Add(this.lblShield);
            this.panelPlayerEquips.Controls.Add(this.lblSword);
            this.panelPlayerEquips.Controls.Add(this.lblEquips);
            this.panelPlayerEquips.Location = new System.Drawing.Point(140, 96);
            this.panelPlayerEquips.Name = "panelPlayerEquips";
            this.panelPlayerEquips.Size = new System.Drawing.Size(100, 104);
            // 
            // lblRangedName
            // 
            this.lblRangedName.Font = new System.Drawing.Font("Tahoma", 8F, System.Drawing.FontStyle.Regular);
            this.lblRangedName.Location = new System.Drawing.Point(47, 71);
            this.lblRangedName.Name = "lblRangedName";
            this.lblRangedName.Size = new System.Drawing.Size(48, 30);
            this.lblRangedName.Text = "None";
            this.lblRangedName.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // lblSwordName
            // 
            this.lblSwordName.Font = new System.Drawing.Font("Tahoma", 8F, System.Drawing.FontStyle.Regular);
            this.lblSwordName.Location = new System.Drawing.Point(47, 18);
            this.lblSwordName.Name = "lblSwordName";
            this.lblSwordName.Size = new System.Drawing.Size(50, 26);
            this.lblSwordName.Text = "Master Sword";
            this.lblSwordName.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // lblShieldName
            // 
            this.lblShieldName.Font = new System.Drawing.Font("Tahoma", 8F, System.Drawing.FontStyle.Regular);
            this.lblShieldName.Location = new System.Drawing.Point(50, 44);
            this.lblShieldName.Name = "lblShieldName";
            this.lblShieldName.Size = new System.Drawing.Size(45, 27);
            this.lblShieldName.Text = "None";
            this.lblShieldName.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // lblRanged
            // 
            this.lblRanged.Font = new System.Drawing.Font("Tahoma", 7F, System.Drawing.FontStyle.Regular);
            this.lblRanged.Location = new System.Drawing.Point(0, 71);
            this.lblRanged.Name = "lblRanged";
            this.lblRanged.Size = new System.Drawing.Size(44, 13);
            this.lblRanged.Text = "Ranged :";
            // 
            // lblShield
            // 
            this.lblShield.Font = new System.Drawing.Font("Tahoma", 8F, System.Drawing.FontStyle.Regular);
            this.lblShield.Location = new System.Drawing.Point(3, 44);
            this.lblShield.Name = "lblShield";
            this.lblShield.Size = new System.Drawing.Size(45, 20);
            this.lblShield.Text = "Shield :";
            // 
            // lblSword
            // 
            this.lblSword.Font = new System.Drawing.Font("Tahoma", 8F, System.Drawing.FontStyle.Regular);
            this.lblSword.Location = new System.Drawing.Point(3, 20);
            this.lblSword.Name = "lblSword";
            this.lblSword.Size = new System.Drawing.Size(45, 14);
            this.lblSword.Text = "Sword :";
            // 
            // panelItemStats
            // 
            this.panelItemStats.BackColor = System.Drawing.Color.LemonChiffon;
            this.panelItemStats.Controls.Add(this.lblQtyValue);
            this.panelItemStats.Controls.Add(this.lblQty);
            this.panelItemStats.Controls.Add(this.btnEquip);
            this.panelItemStats.Controls.Add(this.lblStatValue);
            this.panelItemStats.Controls.Add(this.lblValue);
            this.panelItemStats.Controls.Add(this.lblName);
            this.panelItemStats.Controls.Add(this.lblItemStats);
            this.panelItemStats.Location = new System.Drawing.Point(3, 215);
            this.panelItemStats.Name = "panelItemStats";
            this.panelItemStats.Size = new System.Drawing.Size(185, 50);
            this.panelItemStats.Visible = false;
            // 
            // lblQtyValue
            // 
            this.lblQtyValue.Font = new System.Drawing.Font("Tahoma", 8F, System.Drawing.FontStyle.Regular);
            this.lblQtyValue.Location = new System.Drawing.Point(161, 30);
            this.lblQtyValue.Name = "lblQtyValue";
            this.lblQtyValue.Size = new System.Drawing.Size(20, 20);
            this.lblQtyValue.Text = "10";
            // 
            // lblQty
            // 
            this.lblQty.Font = new System.Drawing.Font("Tahoma", 8F, System.Drawing.FontStyle.Regular);
            this.lblQty.Location = new System.Drawing.Point(124, 29);
            this.lblQty.Name = "lblQty";
            this.lblQty.Size = new System.Drawing.Size(28, 20);
            this.lblQty.Text = "Qty :";
            // 
            // btnEquip
            // 
            this.btnEquip.BackColor = System.Drawing.Color.LemonChiffon;
            this.btnEquip.Location = new System.Drawing.Point(140, 0);
            this.btnEquip.Name = "btnEquip";
            this.btnEquip.Size = new System.Drawing.Size(45, 20);
            this.btnEquip.TabIndex = 4;
            this.btnEquip.Text = "Equip";
            this.btnEquip.Click += new System.EventHandler(this.btnEquip_Click);
            // 
            // lblStatValue
            // 
            this.lblStatValue.Font = new System.Drawing.Font("Tahoma", 8F, System.Drawing.FontStyle.Regular);
            this.lblStatValue.Location = new System.Drawing.Point(54, 30);
            this.lblStatValue.Name = "lblStatValue";
            this.lblStatValue.Size = new System.Drawing.Size(66, 20);
            this.lblStatValue.Text = "+15 Health";
            // 
            // lblValue
            // 
            this.lblValue.Font = new System.Drawing.Font("Tahoma", 8F, System.Drawing.FontStyle.Regular);
            this.lblValue.Location = new System.Drawing.Point(3, 30);
            this.lblValue.Name = "lblValue";
            this.lblValue.Size = new System.Drawing.Size(45, 20);
            this.lblValue.Text = "Value :";
            // 
            // lblName
            // 
            this.lblName.Font = new System.Drawing.Font("Tahoma", 8F, System.Drawing.FontStyle.Regular);
            this.lblName.Location = new System.Drawing.Point(45, 14);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(100, 16);
            this.lblName.Text = "Name";
            this.lblName.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // lblItemStats
            // 
            this.lblItemStats.Dock = System.Windows.Forms.DockStyle.Top;
            this.lblItemStats.Font = new System.Drawing.Font("Tahoma", 8F, System.Drawing.FontStyle.Bold);
            this.lblItemStats.Location = new System.Drawing.Point(0, 0);
            this.lblItemStats.Name = "lblItemStats";
            this.lblItemStats.Size = new System.Drawing.Size(185, 14);
            this.lblItemStats.Text = "Item Stats";
            this.lblItemStats.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // Form3
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(96F, 96F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.AutoScroll = true;
            this.BackColor = System.Drawing.Color.LemonChiffon;
            this.ClientSize = new System.Drawing.Size(240, 268);
            this.Controls.Add(this.panelItemStats);
            this.Controls.Add(this.panelPlayerEquips);
            this.Controls.Add(this.panelPlayerStats);
            this.Controls.Add(this.treeInventory);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.label1);
            this.Menu = this.mainMenu1;
            this.Name = "Form3";
            this.Text = "Form3";
            this.panelPlayerStats.ResumeLayout(false);
            this.panelPlayerEquips.ResumeLayout(false);
            this.panelItemStats.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.TreeView treeInventory;
        private System.Windows.Forms.Panel panelPlayerStats;
        private System.Windows.Forms.Label lblStats;
        private System.Windows.Forms.Label lblEquips;
        private System.Windows.Forms.Panel panelPlayerEquips;
        private System.Windows.Forms.Panel panelItemStats;
        private System.Windows.Forms.Label lblItemStats;
        private System.Windows.Forms.Button btnEquip;
        private System.Windows.Forms.Label lblStatValue;
        private System.Windows.Forms.Label lblValue;
        private System.Windows.Forms.Label lblName;
        private System.Windows.Forms.Label lblQtyValue;
        private System.Windows.Forms.Label lblQty;
        private System.Windows.Forms.Label lblArm;
        private System.Windows.Forms.Label lblAtt;
        private System.Windows.Forms.Label lblArmor;
        private System.Windows.Forms.Label lblAP;
        private System.Windows.Forms.Label lblRanged;
        private System.Windows.Forms.Label lblShield;
        private System.Windows.Forms.Label lblSword;
        private System.Windows.Forms.Label lblRangedName;
        private System.Windows.Forms.Label lblSwordName;
        private System.Windows.Forms.Label lblShieldName;
    }
}