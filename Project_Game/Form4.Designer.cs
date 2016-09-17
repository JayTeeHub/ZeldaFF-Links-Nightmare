namespace Project_Game
{
    partial class Form4
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
            this.panelStats = new System.Windows.Forms.Panel();
            this.panelComputerStats = new System.Windows.Forms.Panel();
            this.lblcLevelStat = new System.Windows.Forms.Label();
            this.lblcArmorStat = new System.Windows.Forms.Label();
            this.lblcAPStat = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.lblcManaValue = new System.Windows.Forms.Label();
            this.panelcHealth = new System.Windows.Forms.Panel();
            this.lblcHealthValue = new System.Windows.Forms.Label();
            this.lblcLevel = new System.Windows.Forms.Label();
            this.lblcArmor = new System.Windows.Forms.Label();
            this.lblcAP = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.lblcHealth = new System.Windows.Forms.Label();
            this.lblCName = new System.Windows.Forms.Label();
            this.panelPlayerStats = new System.Windows.Forms.Panel();
            this.lblhLevelStat = new System.Windows.Forms.Label();
            this.lblhArmorStat = new System.Windows.Forms.Label();
            this.lblhAPStat = new System.Windows.Forms.Label();
            this.panelhMana = new System.Windows.Forms.Panel();
            this.lblhManaValue = new System.Windows.Forms.Label();
            this.panelhHealth = new System.Windows.Forms.Panel();
            this.lblhHealthValue = new System.Windows.Forms.Label();
            this.lblhLevel = new System.Windows.Forms.Label();
            this.lblhArmor = new System.Windows.Forms.Label();
            this.lblhAP = new System.Windows.Forms.Label();
            this.lblhMana = new System.Windows.Forms.Label();
            this.lblhHealth = new System.Windows.Forms.Label();
            this.lblHName = new System.Windows.Forms.Label();
            this.panelMove = new System.Windows.Forms.Panel();
            this.btnSPAtt = new System.Windows.Forms.Button();
            this.btnMana = new System.Windows.Forms.Button();
            this.btnHeal = new System.Windows.Forms.Button();
            this.btnAttack = new System.Windows.Forms.Button();
            this.btnRanged = new System.Windows.Forms.Button();
            this.btnBlock = new System.Windows.Forms.Button();
            this.panelAction = new System.Windows.Forms.Panel();
            this.lblRanged = new System.Windows.Forms.Label();
            this.lblBlock = new System.Windows.Forms.Label();
            this.listSpecial = new System.Windows.Forms.ListView();
            this.timerCombatStatus = new System.Windows.Forms.Timer();
            this.panelStats.SuspendLayout();
            this.panelComputerStats.SuspendLayout();
            this.panel1.SuspendLayout();
            this.panelcHealth.SuspendLayout();
            this.panelPlayerStats.SuspendLayout();
            this.panelhMana.SuspendLayout();
            this.panelhHealth.SuspendLayout();
            this.panelMove.SuspendLayout();
            this.panelAction.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelStats
            // 
            this.panelStats.Controls.Add(this.panelComputerStats);
            this.panelStats.Controls.Add(this.panelPlayerStats);
            this.panelStats.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelStats.Location = new System.Drawing.Point(0, 0);
            this.panelStats.Name = "panelStats";
            this.panelStats.Size = new System.Drawing.Size(240, 82);
            // 
            // panelComputerStats
            // 
            this.panelComputerStats.Controls.Add(this.lblcLevelStat);
            this.panelComputerStats.Controls.Add(this.lblcArmorStat);
            this.panelComputerStats.Controls.Add(this.lblcAPStat);
            this.panelComputerStats.Controls.Add(this.panel1);
            this.panelComputerStats.Controls.Add(this.panelcHealth);
            this.panelComputerStats.Controls.Add(this.lblcLevel);
            this.panelComputerStats.Controls.Add(this.lblcArmor);
            this.panelComputerStats.Controls.Add(this.lblcAP);
            this.panelComputerStats.Controls.Add(this.label9);
            this.panelComputerStats.Controls.Add(this.lblcHealth);
            this.panelComputerStats.Controls.Add(this.lblCName);
            this.panelComputerStats.Dock = System.Windows.Forms.DockStyle.Right;
            this.panelComputerStats.Location = new System.Drawing.Point(115, 0);
            this.panelComputerStats.Name = "panelComputerStats";
            this.panelComputerStats.Size = new System.Drawing.Size(125, 82);
            // 
            // lblcLevelStat
            // 
            this.lblcLevelStat.Font = new System.Drawing.Font("Tahoma", 7F, System.Drawing.FontStyle.Regular);
            this.lblcLevelStat.Location = new System.Drawing.Point(96, 64);
            this.lblcLevelStat.Name = "lblcLevelStat";
            this.lblcLevelStat.Size = new System.Drawing.Size(23, 14);
            this.lblcLevelStat.Text = "1";
            this.lblcLevelStat.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // lblcArmorStat
            // 
            this.lblcArmorStat.Font = new System.Drawing.Font("Tahoma", 7F, System.Drawing.FontStyle.Regular);
            this.lblcArmorStat.Location = new System.Drawing.Point(44, 64);
            this.lblcArmorStat.Name = "lblcArmorStat";
            this.lblcArmorStat.Size = new System.Drawing.Size(23, 14);
            this.lblcArmorStat.Text = "100";
            // 
            // lblcAPStat
            // 
            this.lblcAPStat.Font = new System.Drawing.Font("Tahoma", 7F, System.Drawing.FontStyle.Regular);
            this.lblcAPStat.Location = new System.Drawing.Point(44, 48);
            this.lblcAPStat.Name = "lblcAPStat";
            this.lblcAPStat.Size = new System.Drawing.Size(23, 14);
            this.lblcAPStat.Text = "150";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.DeepSkyBlue;
            this.panel1.Controls.Add(this.lblcManaValue);
            this.panel1.Location = new System.Drawing.Point(48, 36);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(56, 10);
            // 
            // lblcManaValue
            // 
            this.lblcManaValue.Font = new System.Drawing.Font("Tahoma", 6F, System.Drawing.FontStyle.Regular);
            this.lblcManaValue.Location = new System.Drawing.Point(23, -1);
            this.lblcManaValue.Name = "lblcManaValue";
            this.lblcManaValue.Size = new System.Drawing.Size(30, 11);
            this.lblcManaValue.Text = "5/5";
            // 
            // panelcHealth
            // 
            this.panelcHealth.BackColor = System.Drawing.Color.Red;
            this.panelcHealth.Controls.Add(this.lblcHealthValue);
            this.panelcHealth.Location = new System.Drawing.Point(48, 20);
            this.panelcHealth.Name = "panelcHealth";
            this.panelcHealth.Size = new System.Drawing.Size(56, 10);
            // 
            // lblcHealthValue
            // 
            this.lblcHealthValue.BackColor = System.Drawing.Color.Red;
            this.lblcHealthValue.Font = new System.Drawing.Font("Tahoma", 6F, System.Drawing.FontStyle.Regular);
            this.lblcHealthValue.Location = new System.Drawing.Point(23, -1);
            this.lblcHealthValue.Name = "lblcHealthValue";
            this.lblcHealthValue.Size = new System.Drawing.Size(33, 11);
            this.lblcHealthValue.Text = "10/10";
            // 
            // lblcLevel
            // 
            this.lblcLevel.Font = new System.Drawing.Font("Tahoma", 7F, System.Drawing.FontStyle.Bold);
            this.lblcLevel.Location = new System.Drawing.Point(68, 64);
            this.lblcLevel.Name = "lblcLevel";
            this.lblcLevel.Size = new System.Drawing.Size(30, 14);
            this.lblcLevel.Text = "Level";
            // 
            // lblcArmor
            // 
            this.lblcArmor.Font = new System.Drawing.Font("Tahoma", 7F, System.Drawing.FontStyle.Bold);
            this.lblcArmor.Location = new System.Drawing.Point(6, 64);
            this.lblcArmor.Name = "lblcArmor";
            this.lblcArmor.Size = new System.Drawing.Size(36, 14);
            this.lblcArmor.Text = "Armor";
            // 
            // lblcAP
            // 
            this.lblcAP.Font = new System.Drawing.Font("Tahoma", 7F, System.Drawing.FontStyle.Bold);
            this.lblcAP.Location = new System.Drawing.Point(6, 48);
            this.lblcAP.Name = "lblcAP";
            this.lblcAP.Size = new System.Drawing.Size(21, 14);
            this.lblcAP.Text = "AP";
            // 
            // label9
            // 
            this.label9.Font = new System.Drawing.Font("Tahoma", 7F, System.Drawing.FontStyle.Bold);
            this.label9.Location = new System.Drawing.Point(6, 34);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(36, 14);
            this.label9.Text = "Mana";
            // 
            // lblcHealth
            // 
            this.lblcHealth.Font = new System.Drawing.Font("Tahoma", 7F, System.Drawing.FontStyle.Bold);
            this.lblcHealth.Location = new System.Drawing.Point(6, 20);
            this.lblcHealth.Name = "lblcHealth";
            this.lblcHealth.Size = new System.Drawing.Size(36, 14);
            this.lblcHealth.Text = "Health";
            // 
            // lblCName
            // 
            this.lblCName.Dock = System.Windows.Forms.DockStyle.Top;
            this.lblCName.Font = new System.Drawing.Font("Tahoma", 8F, System.Drawing.FontStyle.Bold);
            this.lblCName.Location = new System.Drawing.Point(0, 0);
            this.lblCName.Name = "lblCName";
            this.lblCName.Size = new System.Drawing.Size(125, 20);
            this.lblCName.Text = "Name";
            this.lblCName.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // panelPlayerStats
            // 
            this.panelPlayerStats.Controls.Add(this.lblhLevelStat);
            this.panelPlayerStats.Controls.Add(this.lblhArmorStat);
            this.panelPlayerStats.Controls.Add(this.lblhAPStat);
            this.panelPlayerStats.Controls.Add(this.panelhMana);
            this.panelPlayerStats.Controls.Add(this.panelhHealth);
            this.panelPlayerStats.Controls.Add(this.lblhLevel);
            this.panelPlayerStats.Controls.Add(this.lblhArmor);
            this.panelPlayerStats.Controls.Add(this.lblhAP);
            this.panelPlayerStats.Controls.Add(this.lblhMana);
            this.panelPlayerStats.Controls.Add(this.lblhHealth);
            this.panelPlayerStats.Controls.Add(this.lblHName);
            this.panelPlayerStats.Dock = System.Windows.Forms.DockStyle.Left;
            this.panelPlayerStats.Location = new System.Drawing.Point(0, 0);
            this.panelPlayerStats.Name = "panelPlayerStats";
            this.panelPlayerStats.Size = new System.Drawing.Size(115, 82);
            // 
            // lblhLevelStat
            // 
            this.lblhLevelStat.Font = new System.Drawing.Font("Tahoma", 7F, System.Drawing.FontStyle.Regular);
            this.lblhLevelStat.Location = new System.Drawing.Point(90, 64);
            this.lblhLevelStat.Name = "lblhLevelStat";
            this.lblhLevelStat.Size = new System.Drawing.Size(23, 14);
            this.lblhLevelStat.Text = "1";
            this.lblhLevelStat.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // lblhArmorStat
            // 
            this.lblhArmorStat.Font = new System.Drawing.Font("Tahoma", 7F, System.Drawing.FontStyle.Regular);
            this.lblhArmorStat.Location = new System.Drawing.Point(38, 64);
            this.lblhArmorStat.Name = "lblhArmorStat";
            this.lblhArmorStat.Size = new System.Drawing.Size(23, 14);
            this.lblhArmorStat.Text = "100";
            // 
            // lblhAPStat
            // 
            this.lblhAPStat.Font = new System.Drawing.Font("Tahoma", 7F, System.Drawing.FontStyle.Regular);
            this.lblhAPStat.Location = new System.Drawing.Point(38, 48);
            this.lblhAPStat.Name = "lblhAPStat";
            this.lblhAPStat.Size = new System.Drawing.Size(23, 14);
            this.lblhAPStat.Text = "150";
            // 
            // panelhMana
            // 
            this.panelhMana.BackColor = System.Drawing.Color.DeepSkyBlue;
            this.panelhMana.Controls.Add(this.lblhManaValue);
            this.panelhMana.Location = new System.Drawing.Point(42, 36);
            this.panelhMana.Name = "panelhMana";
            this.panelhMana.Size = new System.Drawing.Size(56, 10);
            // 
            // lblhManaValue
            // 
            this.lblhManaValue.Font = new System.Drawing.Font("Tahoma", 6F, System.Drawing.FontStyle.Regular);
            this.lblhManaValue.Location = new System.Drawing.Point(23, -1);
            this.lblhManaValue.Name = "lblhManaValue";
            this.lblhManaValue.Size = new System.Drawing.Size(30, 11);
            this.lblhManaValue.Text = "5/5";
            // 
            // panelhHealth
            // 
            this.panelhHealth.BackColor = System.Drawing.Color.Red;
            this.panelhHealth.Controls.Add(this.lblhHealthValue);
            this.panelhHealth.Location = new System.Drawing.Point(42, 20);
            this.panelhHealth.Name = "panelhHealth";
            this.panelhHealth.Size = new System.Drawing.Size(56, 10);
            // 
            // lblhHealthValue
            // 
            this.lblhHealthValue.BackColor = System.Drawing.Color.Red;
            this.lblhHealthValue.Font = new System.Drawing.Font("Tahoma", 6F, System.Drawing.FontStyle.Regular);
            this.lblhHealthValue.Location = new System.Drawing.Point(23, -1);
            this.lblhHealthValue.Name = "lblhHealthValue";
            this.lblhHealthValue.Size = new System.Drawing.Size(33, 11);
            this.lblhHealthValue.Text = "10/10";
            // 
            // lblhLevel
            // 
            this.lblhLevel.Font = new System.Drawing.Font("Tahoma", 7F, System.Drawing.FontStyle.Bold);
            this.lblhLevel.Location = new System.Drawing.Point(62, 64);
            this.lblhLevel.Name = "lblhLevel";
            this.lblhLevel.Size = new System.Drawing.Size(30, 14);
            this.lblhLevel.Text = "Level";
            // 
            // lblhArmor
            // 
            this.lblhArmor.Font = new System.Drawing.Font("Tahoma", 7F, System.Drawing.FontStyle.Bold);
            this.lblhArmor.Location = new System.Drawing.Point(0, 64);
            this.lblhArmor.Name = "lblhArmor";
            this.lblhArmor.Size = new System.Drawing.Size(36, 14);
            this.lblhArmor.Text = "Armor";
            // 
            // lblhAP
            // 
            this.lblhAP.Font = new System.Drawing.Font("Tahoma", 7F, System.Drawing.FontStyle.Bold);
            this.lblhAP.Location = new System.Drawing.Point(0, 48);
            this.lblhAP.Name = "lblhAP";
            this.lblhAP.Size = new System.Drawing.Size(21, 14);
            this.lblhAP.Text = "AP";
            // 
            // lblhMana
            // 
            this.lblhMana.Font = new System.Drawing.Font("Tahoma", 7F, System.Drawing.FontStyle.Bold);
            this.lblhMana.Location = new System.Drawing.Point(0, 34);
            this.lblhMana.Name = "lblhMana";
            this.lblhMana.Size = new System.Drawing.Size(36, 14);
            this.lblhMana.Text = "Mana";
            // 
            // lblhHealth
            // 
            this.lblhHealth.Font = new System.Drawing.Font("Tahoma", 7F, System.Drawing.FontStyle.Bold);
            this.lblhHealth.Location = new System.Drawing.Point(0, 20);
            this.lblhHealth.Name = "lblhHealth";
            this.lblhHealth.Size = new System.Drawing.Size(36, 14);
            this.lblhHealth.Text = "Health";
            // 
            // lblHName
            // 
            this.lblHName.Dock = System.Windows.Forms.DockStyle.Top;
            this.lblHName.Font = new System.Drawing.Font("Tahoma", 8F, System.Drawing.FontStyle.Bold);
            this.lblHName.Location = new System.Drawing.Point(0, 0);
            this.lblHName.Name = "lblHName";
            this.lblHName.Size = new System.Drawing.Size(115, 20);
            this.lblHName.Text = "Name";
            this.lblHName.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // panelMove
            // 
            this.panelMove.Controls.Add(this.btnSPAtt);
            this.panelMove.Controls.Add(this.btnMana);
            this.panelMove.Controls.Add(this.btnHeal);
            this.panelMove.Controls.Add(this.btnAttack);
            this.panelMove.Controls.Add(this.btnRanged);
            this.panelMove.Controls.Add(this.btnBlock);
            this.panelMove.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panelMove.Location = new System.Drawing.Point(0, 195);
            this.panelMove.Name = "panelMove";
            this.panelMove.Size = new System.Drawing.Size(240, 73);
            // 
            // btnSPAtt
            // 
            this.btnSPAtt.BackColor = System.Drawing.Color.Green;
            this.btnSPAtt.Font = new System.Drawing.Font("Tahoma", 8F, System.Drawing.FontStyle.Bold);
            this.btnSPAtt.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.btnSPAtt.Location = new System.Drawing.Point(123, 41);
            this.btnSPAtt.Name = "btnSPAtt";
            this.btnSPAtt.Size = new System.Drawing.Size(114, 20);
            this.btnSPAtt.TabIndex = 4;
            this.btnSPAtt.Text = "Speical Attack";
            this.btnSPAtt.Click += new System.EventHandler(this.btnSPAtt_Click);
            // 
            // btnMana
            // 
            this.btnMana.BackColor = System.Drawing.Color.DeepSkyBlue;
            this.btnMana.Font = new System.Drawing.Font("Tahoma", 8F, System.Drawing.FontStyle.Bold);
            this.btnMana.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.btnMana.Location = new System.Drawing.Point(183, 6);
            this.btnMana.Name = "btnMana";
            this.btnMana.Size = new System.Drawing.Size(56, 20);
            this.btnMana.TabIndex = 6;
            this.btnMana.Text = "Mana";
            this.btnMana.Click += new System.EventHandler(this.btnMana_Click);
            // 
            // btnHeal
            // 
            this.btnHeal.BackColor = System.Drawing.Color.Red;
            this.btnHeal.Font = new System.Drawing.Font("Tahoma", 8F, System.Drawing.FontStyle.Bold);
            this.btnHeal.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.btnHeal.Location = new System.Drawing.Point(121, 6);
            this.btnHeal.Name = "btnHeal";
            this.btnHeal.Size = new System.Drawing.Size(56, 20);
            this.btnHeal.TabIndex = 5;
            this.btnHeal.Text = "Heal";
            this.btnHeal.Click += new System.EventHandler(this.btnHeal_Click);
            // 
            // btnAttack
            // 
            this.btnAttack.BackColor = System.Drawing.SystemColors.Desktop;
            this.btnAttack.Font = new System.Drawing.Font("Tahoma", 8F, System.Drawing.FontStyle.Bold);
            this.btnAttack.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.btnAttack.Location = new System.Drawing.Point(3, 41);
            this.btnAttack.Name = "btnAttack";
            this.btnAttack.Size = new System.Drawing.Size(114, 20);
            this.btnAttack.TabIndex = 2;
            this.btnAttack.Text = "Attack";
            this.btnAttack.Click += new System.EventHandler(this.btnAttack_Click);
            // 
            // btnRanged
            // 
            this.btnRanged.BackColor = System.Drawing.Color.SaddleBrown;
            this.btnRanged.Font = new System.Drawing.Font("Tahoma", 8F, System.Drawing.FontStyle.Bold);
            this.btnRanged.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.btnRanged.Location = new System.Drawing.Point(64, 6);
            this.btnRanged.Name = "btnRanged";
            this.btnRanged.Size = new System.Drawing.Size(53, 20);
            this.btnRanged.TabIndex = 1;
            this.btnRanged.Text = "Ranged";
            this.btnRanged.Click += new System.EventHandler(this.btnRanged_Click);
            // 
            // btnBlock
            // 
            this.btnBlock.BackColor = System.Drawing.SystemColors.Desktop;
            this.btnBlock.Font = new System.Drawing.Font("Tahoma", 8F, System.Drawing.FontStyle.Bold);
            this.btnBlock.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.btnBlock.Location = new System.Drawing.Point(3, 6);
            this.btnBlock.Name = "btnBlock";
            this.btnBlock.Size = new System.Drawing.Size(56, 20);
            this.btnBlock.TabIndex = 0;
            this.btnBlock.Text = "Block";
            this.btnBlock.Click += new System.EventHandler(this.btnBlock_Click);
            // 
            // panelAction
            // 
            this.panelAction.Controls.Add(this.lblRanged);
            this.panelAction.Controls.Add(this.lblBlock);
            this.panelAction.Controls.Add(this.listSpecial);
            this.panelAction.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelAction.Location = new System.Drawing.Point(0, 82);
            this.panelAction.Name = "panelAction";
            this.panelAction.Size = new System.Drawing.Size(240, 113);
            // 
            // lblRanged
            // 
            this.lblRanged.Location = new System.Drawing.Point(10, 84);
            this.lblRanged.Name = "lblRanged";
            this.lblRanged.Size = new System.Drawing.Size(172, 20);
            this.lblRanged.Text = "Ranged is ready!";
            // 
            // lblBlock
            // 
            this.lblBlock.Location = new System.Drawing.Point(10, 8);
            this.lblBlock.Name = "lblBlock";
            this.lblBlock.Size = new System.Drawing.Size(172, 20);
            this.lblBlock.Text = "Block is ready!";
            // 
            // listSpecial
            // 
            this.listSpecial.Location = new System.Drawing.Point(3, 3);
            this.listSpecial.Name = "listSpecial";
            this.listSpecial.Size = new System.Drawing.Size(231, 107);
            this.listSpecial.TabIndex = 1;
            this.listSpecial.View = System.Windows.Forms.View.List;
            this.listSpecial.SelectedIndexChanged += new System.EventHandler(this.listSpecial_SelectedIndexChanged);
            // 
            // timerCombatStatus
            // 
            this.timerCombatStatus.Tick += new System.EventHandler(this.timerCombatStatus_Tick);
            // 
            // Form4
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(96F, 96F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.AutoScroll = true;
            this.ClientSize = new System.Drawing.Size(240, 268);
            this.Controls.Add(this.panelAction);
            this.Controls.Add(this.panelMove);
            this.Controls.Add(this.panelStats);
            this.KeyPreview = true;
            this.Menu = this.mainMenu1;
            this.Name = "Form4";
            this.Text = "Form4";
            this.Load += new System.EventHandler(this.Form4_Load);
            this.panelStats.ResumeLayout(false);
            this.panelComputerStats.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panelcHealth.ResumeLayout(false);
            this.panelPlayerStats.ResumeLayout(false);
            this.panelhMana.ResumeLayout(false);
            this.panelhHealth.ResumeLayout(false);
            this.panelMove.ResumeLayout(false);
            this.panelAction.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelStats;
        private System.Windows.Forms.Panel panelMove;
        private System.Windows.Forms.Panel panelAction;
        private System.Windows.Forms.Panel panelComputerStats;
        private System.Windows.Forms.Panel panelPlayerStats;
        private System.Windows.Forms.Label lblHName;
        private System.Windows.Forms.Label lblCName;
        private System.Windows.Forms.Label lblhHealth;
        private System.Windows.Forms.Label lblhLevel;
        private System.Windows.Forms.Label lblhArmor;
        private System.Windows.Forms.Label lblhAP;
        private System.Windows.Forms.Label lblhMana;
        private System.Windows.Forms.Panel panelhHealth;
        private System.Windows.Forms.Label lblhHealthValue;
        private System.Windows.Forms.Panel panelhMana;
        private System.Windows.Forms.Label lblhManaValue;
        private System.Windows.Forms.Label lblhLevelStat;
        private System.Windows.Forms.Label lblhArmorStat;
        private System.Windows.Forms.Label lblhAPStat;
        private System.Windows.Forms.Label lblcLevelStat;
        private System.Windows.Forms.Label lblcArmorStat;
        private System.Windows.Forms.Label lblcAPStat;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label lblcManaValue;
        private System.Windows.Forms.Panel panelcHealth;
        private System.Windows.Forms.Label lblcHealthValue;
        private System.Windows.Forms.Label lblcLevel;
        private System.Windows.Forms.Label lblcArmor;
        private System.Windows.Forms.Label lblcAP;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label lblcHealth;
        private System.Windows.Forms.Button btnBlock;
        private System.Windows.Forms.Button btnMana;
        private System.Windows.Forms.Button btnHeal;
        private System.Windows.Forms.Button btnSPAtt;
        private System.Windows.Forms.Button btnAttack;
        private System.Windows.Forms.Button btnRanged;
        private System.Windows.Forms.ListView listSpecial;
        private System.Windows.Forms.Label lblRanged;
        private System.Windows.Forms.Label lblBlock;
        private System.Windows.Forms.Timer timerCombatStatus;
    }
}