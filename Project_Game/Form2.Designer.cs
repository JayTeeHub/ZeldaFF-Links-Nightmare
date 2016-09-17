namespace Project_Game
{
    partial class Form2
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form2));
            this.mainMenu1 = new System.Windows.Forms.MainMenu();
            this.panel1 = new System.Windows.Forms.Panel();
            this.lblHealthValue = new System.Windows.Forms.Label();
            this.lblHealth = new System.Windows.Forms.Label();
            this.lblName = new System.Windows.Forms.Label();
            this.lblMana = new System.Windows.Forms.Label();
            this.lblExp = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.lblManaValue = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.lblExpValue = new System.Windows.Forms.Label();
            this.lblPlayerName = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.lblLevelValue = new System.Windows.Forms.Label();
            this.uiTimer = new System.Windows.Forms.Timer();
            this.lblKey = new System.Windows.Forms.Label();
            this.lblKeyValue = new System.Windows.Forms.Label();
            this.panel4 = new System.Windows.Forms.Panel();
            this.lblInventory = new System.Windows.Forms.Label();
            this.deathTimer = new System.Windows.Forms.Timer();
            this.winTimer = new System.Windows.Forms.Timer();
            this.playerBox = new System.Windows.Forms.PictureBox();
            this.mapPanel = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            this.panel4.SuspendLayout();
            this.mapPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Red;
            this.panel1.Controls.Add(this.lblHealthValue);
            this.panel1.Location = new System.Drawing.Point(46, 16);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(56, 10);
            // 
            // lblHealthValue
            // 
            this.lblHealthValue.BackColor = System.Drawing.Color.Red;
            this.lblHealthValue.Font = new System.Drawing.Font("Tahoma", 6F, System.Drawing.FontStyle.Regular);
            this.lblHealthValue.Location = new System.Drawing.Point(23, -1);
            this.lblHealthValue.Name = "lblHealthValue";
            this.lblHealthValue.Size = new System.Drawing.Size(33, 11);
            this.lblHealthValue.Text = "10/10";
            // 
            // lblHealth
            // 
            this.lblHealth.Font = new System.Drawing.Font("Tahoma", 7F, System.Drawing.FontStyle.Regular);
            this.lblHealth.Location = new System.Drawing.Point(13, 15);
            this.lblHealth.Name = "lblHealth";
            this.lblHealth.Size = new System.Drawing.Size(32, 11);
            this.lblHealth.Text = "Health";
            // 
            // lblName
            // 
            this.lblName.Font = new System.Drawing.Font("Tahoma", 7F, System.Drawing.FontStyle.Regular);
            this.lblName.Location = new System.Drawing.Point(13, 4);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(32, 11);
            this.lblName.Text = "Name";
            // 
            // lblMana
            // 
            this.lblMana.Font = new System.Drawing.Font("Tahoma", 7F, System.Drawing.FontStyle.Regular);
            this.lblMana.Location = new System.Drawing.Point(13, 26);
            this.lblMana.Name = "lblMana";
            this.lblMana.Size = new System.Drawing.Size(32, 11);
            this.lblMana.Text = "Mana";
            // 
            // lblExp
            // 
            this.lblExp.Font = new System.Drawing.Font("Tahoma", 7F, System.Drawing.FontStyle.Regular);
            this.lblExp.Location = new System.Drawing.Point(108, 16);
            this.lblExp.Name = "lblExp";
            this.lblExp.Size = new System.Drawing.Size(32, 11);
            this.lblExp.Text = "Exp.";
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.DeepSkyBlue;
            this.panel2.Controls.Add(this.lblManaValue);
            this.panel2.Location = new System.Drawing.Point(46, 29);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(56, 10);
            // 
            // lblManaValue
            // 
            this.lblManaValue.Font = new System.Drawing.Font("Tahoma", 6F, System.Drawing.FontStyle.Regular);
            this.lblManaValue.Location = new System.Drawing.Point(23, -1);
            this.lblManaValue.Name = "lblManaValue";
            this.lblManaValue.Size = new System.Drawing.Size(30, 11);
            this.lblManaValue.Text = "5/5";
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.Gold;
            this.panel3.Controls.Add(this.lblExpValue);
            this.panel3.Location = new System.Drawing.Point(133, 18);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(52, 10);
            // 
            // lblExpValue
            // 
            this.lblExpValue.Font = new System.Drawing.Font("Tahoma", 6F, System.Drawing.FontStyle.Regular);
            this.lblExpValue.Location = new System.Drawing.Point(23, -1);
            this.lblExpValue.Name = "lblExpValue";
            this.lblExpValue.Size = new System.Drawing.Size(30, 11);
            this.lblExpValue.Text = "0/10";
            // 
            // lblPlayerName
            // 
            this.lblPlayerName.Font = new System.Drawing.Font("Tahoma", 7F, System.Drawing.FontStyle.Regular);
            this.lblPlayerName.Location = new System.Drawing.Point(46, 2);
            this.lblPlayerName.Name = "lblPlayerName";
            this.lblPlayerName.Size = new System.Drawing.Size(56, 11);
            this.lblPlayerName.Text = "Link";
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Tahoma", 7F, System.Drawing.FontStyle.Regular);
            this.label1.Location = new System.Drawing.Point(108, 4);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(32, 11);
            this.label1.Text = "Level";
            // 
            // lblLevelValue
            // 
            this.lblLevelValue.Font = new System.Drawing.Font("Tahoma", 6F, System.Drawing.FontStyle.Regular);
            this.lblLevelValue.Location = new System.Drawing.Point(133, 5);
            this.lblLevelValue.Name = "lblLevelValue";
            this.lblLevelValue.Size = new System.Drawing.Size(54, 10);
            this.lblLevelValue.Text = "1";
            this.lblLevelValue.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // uiTimer
            // 
            this.uiTimer.Tick += new System.EventHandler(this.uiTimer_Tick);
            // 
            // lblKey
            // 
            this.lblKey.Font = new System.Drawing.Font("Tahoma", 7F, System.Drawing.FontStyle.Regular);
            this.lblKey.Location = new System.Drawing.Point(108, 31);
            this.lblKey.Name = "lblKey";
            this.lblKey.Size = new System.Drawing.Size(32, 11);
            this.lblKey.Text = "Keys";
            // 
            // lblKeyValue
            // 
            this.lblKeyValue.Font = new System.Drawing.Font("Tahoma", 6F, System.Drawing.FontStyle.Regular);
            this.lblKeyValue.Location = new System.Drawing.Point(135, 32);
            this.lblKeyValue.Name = "lblKeyValue";
            this.lblKeyValue.Size = new System.Drawing.Size(54, 10);
            this.lblKeyValue.Text = "0/3";
            this.lblKeyValue.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.SystemColors.Desktop;
            this.panel4.Controls.Add(this.lblInventory);
            this.panel4.Location = new System.Drawing.Point(185, 3);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(52, 12);
            // 
            // lblInventory
            // 
            this.lblInventory.BackColor = System.Drawing.SystemColors.Desktop;
            this.lblInventory.Font = new System.Drawing.Font("Tahoma", 7F, System.Drawing.FontStyle.Bold);
            this.lblInventory.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.lblInventory.Location = new System.Drawing.Point(0, 2);
            this.lblInventory.Name = "lblInventory";
            this.lblInventory.Size = new System.Drawing.Size(52, 12);
            this.lblInventory.Text = "Inventory";
            // 
            // deathTimer
            // 
            this.deathTimer.Tick += new System.EventHandler(this.deathTimer_Tick);
            // 
            // winTimer
            // 
            this.winTimer.Tick += new System.EventHandler(this.winTimer_Tick);
            // 
            // playerBox
            // 
            this.playerBox.Image = ((System.Drawing.Image)(resources.GetObject("playerBox.Image")));
            this.playerBox.Location = new System.Drawing.Point(0, 88);
            this.playerBox.Name = "playerBox";
            this.playerBox.Size = new System.Drawing.Size(17, 16);
            this.playerBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            // 
            // mapPanel
            // 
            this.mapPanel.BackColor = System.Drawing.SystemColors.Info;
            this.mapPanel.Controls.Add(this.pictureBox1);
            this.mapPanel.Controls.Add(this.playerBox);
            this.mapPanel.Location = new System.Drawing.Point(13, 51);
            this.mapPanel.Name = "mapPanel";
            this.mapPanel.Size = new System.Drawing.Size(224, 202);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(204, 88);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(17, 16);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.Visible = false;
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(96F, 96F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.AutoScroll = true;
            this.ClientSize = new System.Drawing.Size(240, 268);
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.lblKeyValue);
            this.Controls.Add(this.lblKey);
            this.Controls.Add(this.lblLevelValue);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lblPlayerName);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.lblExp);
            this.Controls.Add(this.lblMana);
            this.Controls.Add(this.lblName);
            this.Controls.Add(this.lblHealth);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.mapPanel);
            this.Menu = this.mainMenu1;
            this.Name = "Form2";
            this.Text = "Form2";
            this.Load += new System.EventHandler(this.Form2_Load);
            this.GotFocus += new System.EventHandler(this.Form2_GotFocus);
            this.panel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.panel4.ResumeLayout(false);
            this.mapPanel.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label lblHealthValue;
        private System.Windows.Forms.Label lblHealth;
        private System.Windows.Forms.Label lblName;
        private System.Windows.Forms.Label lblMana;
        private System.Windows.Forms.Label lblExp;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label lblManaValue;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Label lblExpValue;
        private System.Windows.Forms.Label lblPlayerName;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblLevelValue;
        private System.Windows.Forms.Timer uiTimer;
        private System.Windows.Forms.Label lblKey;
        private System.Windows.Forms.Label lblKeyValue;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Label lblInventory;
        private System.Windows.Forms.Timer deathTimer;
        private System.Windows.Forms.Timer winTimer;
        private System.Windows.Forms.PictureBox playerBox;
        private System.Windows.Forms.Panel mapPanel;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}