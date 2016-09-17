using System;
using System.Linq;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.Threading;

namespace Project_Game
{
    public partial class Form4 : Form
    {
        protected HumanPlayer hPlayer;
        protected ComputerPlayer cPlayer;
        protected List<HumanPlayer> hLPlayer;
        private Int32 hTurnCount = 0;
        private Int32 cTurnCount = 0;
        private Boolean hTurn = false;
        private Boolean cTurn = false;

        private Int32 cdHBlock;//determines cooldown status of Block
        private Int32 cdHRanged;//determines cooldown status of Ranged
        
        private Boolean bHBlock;//determines if user has used Block
        private Boolean bHRanged;//determines if user has used Ranged


        private Int32 cdCBlock;//determines cooldown status of Block

        private Boolean bCBlock;//determines if user has used Block

        private Boolean bStatus = false;

        public Form4()
        {
            InitializeComponent();
        }
        public Form4(HumanPlayer _hPlayer, ComputerPlayer _cPlayer)
        {
            InitializeComponent();
            hLPlayer = new List<HumanPlayer>();
            hPlayer = _hPlayer;
            cPlayer = _cPlayer;
            hLPlayer.Add(hPlayer);
        }

        private void Form4_Load(object sender, EventArgs e)
        {
            //panelMove.Enabled = false;
            
            listSpecial.Visible = false;

            if (CoolDownModerator(CombatType.None, CombatType.None, 0))
            {
                LoadPlayerStats();
                
                LoadPlayerAttacks();
            }
            
            DetermineTurn();
            
        }

        private void LoadPlayerStats()
        {
            Monitor.Enter(this);
            
            lblHName.Text = hPlayer.Name;
            lblhHealthValue.Text = hPlayer.Health.ToString() + "/" + hPlayer.TotalHealth.ToString();
            lblhManaValue.Text = hPlayer.Mana.ToString() + "/" + hPlayer.TotalMana.ToString();
            lblhAPStat.Text = hPlayer.AttackPower.ToString();
            lblhArmorStat.Text = hPlayer.Armor.ToString();
            lblhLevelStat.Text = hPlayer.Level.ToString();

            lblCName.Text = cPlayer.Name;
            lblcHealthValue.Text = cPlayer.Health.ToString() + "/" + cPlayer.TotalHealth.ToString();
            lblcManaValue.Text = cPlayer.Mana.ToString() + "/" + cPlayer.TotalMana.ToString();
            lblcAPStat.Text = cPlayer.AttackPower.ToString();
            lblcArmorStat.Text = cPlayer.Armor.ToString();
            lblcLevelStat.Text = cPlayer.Level.ToString();

            Monitor.Exit(this);
        }

        private void LoadPlayerAttacks()
        {
            if (hPlayer.Level < 1)
                btnAttack.Enabled = false;
            if (hPlayer.Level < 2)
            {
                lblBlock.Text = "Unavailable";
                btnBlock.Enabled = false;
                btnBlock.Text = "Lvl. 2";
            }
            if (hPlayer.Ranged == "None")
            {
                lblRanged.Text = "Unavailable";
                btnRanged.Enabled = false;
            }
        }

        private void DetermineTurn()
        {
            Random rTurn = new Random();
            int result = -1;
            if (hTurnCount == 0 && cTurnCount == 0)
                result = rTurn.Next(0,2);
            Monitor.Enter(this);

            if (hTurnCount == 0 && cTurnCount == 0)//Called before first combat to determine who goes first
            {
                if (result == 0)//Human player goes first, Cooldown checks don't need to be made here
                {
                    hTurn = true;
                    hTurnCount++;
                }
                else if (result == 1)//Computer player goes first, Cooldown checks don't need to be made here
                {
                    cTurn = true;
                    cTurnCount++;
                }
            }
            else if (hTurnCount == 0 && cTurnCount > 0)//Computer player went first, Humans turn.  Cooldown checks don't need to be made here
            {
                hTurn = true;
                hTurnCount++;
                cTurn = false;
            }
            else if (hTurnCount > 0 && cTurnCount == 0)//Human play went first, Computer's turn.  Cooldown checks don't need to be made here
            {
                cTurn = true;
                cTurnCount++;
                hTurn = false;
            }
            else if (hTurnCount > 0 && cTurnCount > 0)//Both players have gone at least once
            {
                if (hTurnCount > cTurnCount)//Human player just went, Computers turn. Cooldown check needs to be made.
                {
                    if (bCBlock == true)
                    {
                        if (CoolDownModerator(CombatType.Computer, CombatType.Defend, 0))
                        {
                            if (btnBlock.Enabled == false)
                                btnBlock.Enabled = true;
                        }
                        else
                        {
                            btnBlock.Enabled = false;

                            int turnsRemaining = hPlayer.BaseCD[1] - cdCBlock + 1;
                            if (bCBlock == false && cdCBlock == 0)
                                lblBlock.Text = "This move will be available on your next turn";
                            else
                                lblBlock.Text = turnsRemaining.ToString() + " Turn(s) remaining";


                        }
                    }
                    else
                    {
                        
                    }
                    cTurn = true;
                    cTurnCount++;
                    hTurn = false;
                }
                else if (cTurnCount > hTurnCount)//Computer player just went, Humans turn. Cooldown check needs to be made.
                {
                    if (bHBlock == true)
                    {
                        if (CoolDownModerator(CombatType.Human, CombatType.Defend, 0))
                        {
                            if (btnBlock.Enabled == false)
                                btnBlock.Enabled = true;
                        }
                        else
                        {
                            btnBlock.Enabled = false;

                            int turnsRemaining = hPlayer.BaseCD[1] - cdHBlock + 1;
                           
                        }
                    }
                    else
                    {
                        if (btnBlock.Enabled == false)
                            btnBlock.Enabled = true;
                    }

                    if (bHRanged == true)
                    {
                        if (CoolDownModerator(CombatType.Human, CombatType.Ranged, 0))
                        {
                            if (btnRanged.Enabled == false)
                                btnRanged.Enabled = true;
                        }
                        else
                        {
                            btnRanged.Enabled = false;

                            int turnsRemaining = 3 - cdHRanged + 1;
                            if (bHRanged == false && cdHRanged == 0)
                                lblBlock.Text = "This move will be available on your next turn";
                            else
                                lblBlock.Text = turnsRemaining.ToString() + " Turn(s) remaining";
                        }

                    }
                    else
                    {
                        if(hPlayer.Ranged != "None")
                            if (btnRanged.Enabled == false)
                                btnRanged.Enabled = true;
                    }
                    hTurn = true;
                    hTurnCount++;
                    cTurn = false;
                }
                else if (cTurnCount == hTurnCount)//Both players have gone the same number of times
                {
                    if (cTurn == true && hTurn == false)//Computer was the last player to go, Humans turn
                    {
                        hTurn = true;
                        hTurnCount++;
                        if (bHBlock == true)
                        {
                            if (CoolDownModerator(CombatType.Human, CombatType.Defend, 0))
                            {
                                if (btnBlock.Enabled == false)
                                {
                                    btnBlock.Enabled = true;
                                    lblBlock.Text = "Block is ready!";
                                }
                            }
                            else
                            {
                                btnBlock.Enabled = false;

                                int turnsRemaining = hPlayer.BaseCD[1] - cdHBlock + 1;
                                if (bHBlock == false && cdHBlock == hPlayer.BaseCD[1])
                                    lblBlock.Text = "This move will be available on your next turn";
                                else
                                    lblBlock.Text = turnsRemaining.ToString() + " Turn(s) remaining";
                            }
                        }
                        else
                        {
                            if (btnBlock.Enabled == false)
                                btnBlock.Enabled = true;
                        }
                        
                        if (bHRanged == true)
                        {
                            if (CoolDownModerator(CombatType.Human, CombatType.Ranged, 0))
                            {
                                if (btnRanged.Enabled == false)
                                {
                                    btnRanged.Enabled = true;
                                    lblRanged.Text = "Ranged is ready!";
                                }
                            }
                            else
                            {
                                btnRanged.Enabled = false;

                                int turnsRemaining = 3 - cdHRanged + 1;
                                if (bHRanged == false && cdHRanged == 3)
                                    lblBlock.Text = "This move will be available on your next turn";
                                else
                                    lblBlock.Text = turnsRemaining.ToString() + " Turn(s) remaining";
                            }

                        }
                        else
                        {
                            if(hPlayer.Ranged != "None")
                                if (btnRanged.Enabled == false)
                                    btnRanged.Enabled = true;
                        }
                        
                        cTurn = false;
                    }
                    else if (cTurn == false && hTurn == true)//Human was the last player to go, Computers turn
                    {
                        cTurn = true;
                        cTurnCount++;

                        if (bCBlock == true)
                        {
                            if (CoolDownModerator(CombatType.Computer, CombatType.Defend, 0))
                            {
                                if (btnBlock.Enabled == false)
                                    btnBlock.Enabled = true;
                            }
                            else
                            {
                                btnBlock.Enabled = false;

                                int turnsRemaining = hPlayer.BaseCD[1] - cdCBlock + 1;
                                if (bCBlock == false && cdCBlock == 0)
                                    lblBlock.Text = "This move will be available on your next turn";
                                else
                                    lblBlock.Text = turnsRemaining.ToString() + " Turn(s) remaining";


                            }
                        }
                        else
                        {

                        }

                        hTurn = false;
                    }
                }
            }
           
            Monitor.Exit(this);

            GiveTurn(hTurn, cTurn);
        }

        private void GiveTurn(Boolean hTurn, Boolean cTurn)
        {
            Monitor.Enter(this);
            if (hTurn == true && cTurn == true)
            {
                DetermineTurn();
            }
            else if (hTurn == false && cTurn == true)
            {
                timerCombatStatus.Enabled = true;
                if(cPlayer.Health != 0)
                    ComputerTurn(hPlayer.Health, hPlayer.Mana, hPlayer.AttackPower, hPlayer.Armor);
            }
            else if (hTurn == true && cTurn == false)
            {
                timerCombatStatus.Enabled = true;
                if(hPlayer.Health != 0)
                    panelMove.Enabled = true;
                
            }
            else
                DetermineTurn();
            Monitor.Exit(this);
        }

        private void DetermineVictor(Boolean _hTurn, Boolean _cTurn)
        {
            Monitor.Enter(this);
            if (_hTurn == true && _cTurn == true)//Error made, Correction will be attempted
            {
                LoadPlayerStats();
            }
            else if (_hTurn == false && _cTurn == true)//Computer player just made move, check life of Human player
            {
                if (hPlayer.Health == 0)
                {
                    hPlayer.WinStatus = false;
                    bStatus = true;
                }
                else
                    LoadPlayerStats();
            }
            else if (_hTurn == true && _cTurn == false)//Human player just made move, check life of Computer player
            {
                if (cPlayer.Health == 0)
                {
                    if (cPlayer.Name == "Gohma")
                        hPlayer.BoosWin = true;
                    hPlayer.UpdateStat(cPlayer.Exp, StatAction.Add, Stats.Level, CombatType.None);
                    hPlayer.WinStatus = true;
                    hPlayer.KeyCount = hPlayer.KeyCount + cPlayer.NumKeys;
                    if (hPlayer.KeyCount > 3)
                        hPlayer.KeyCount = 3;
                    bStatus = true;
                }
                else
                    LoadPlayerStats();
            }
            else
                LoadPlayerStats();

            Monitor.Exit(this);
        }

        private void ComputerTurn(Int32 health, Int32 mana, Int32 ap, Int32 armor)
        {
            if (health < hPlayer.TotalHealth)
            {
                if (ap > cPlayer.AttackPower)
                {
                    if (armor > cPlayer.Armor)
                    {
                        if (mana < hPlayer.TotalMana)
                        {
                            PerformMove(CombatType.Computer, CombatType.SpecialAttack, cPlayer.SpecAttack[0]);
                        }
                        else if (mana == hPlayer.TotalMana)
                        {
                            PerformMove(CombatType.Computer, CombatType.SpecialAttack, cPlayer.SpecAttack[0]);
                        }
                    }
                    else if (armor < cPlayer.Armor)
                    {
                        if (mana < hPlayer.TotalMana)
                        {
                            PerformMove(CombatType.Computer, CombatType.BasicAttack, "Attack");
                        }
                        else if (mana == hPlayer.TotalMana)
                        {
                            PerformMove(CombatType.Computer, CombatType.Defend, "TEST");
                        }
                    }
                    else if (armor == cPlayer.Armor)
                    {
                        if (mana < hPlayer.TotalMana)
                        {
                            PerformMove(CombatType.Computer, CombatType.SpecialAttack, cPlayer.SpecAttack[0]);
                        }
                        else if (mana == hPlayer.TotalMana)
                        {
                            
                            PerformMove(CombatType.Computer, CombatType.Defend, "TEST");
                        }
                    }
                }
                else if (ap < cPlayer.AttackPower)
                {
                    if (armor > cPlayer.Armor)
                    {
                        if (mana < hPlayer.TotalMana)
                        {
                            PerformMove(CombatType.Computer, CombatType.Stun, "TEST");
                        }
                        else if (mana == hPlayer.TotalMana)
                        {
                            PerformMove(CombatType.Computer, CombatType.BasicAttack, "Attack");
                        }
                    }
                    else if (armor < cPlayer.Armor)
                    {
                        if (mana < hPlayer.TotalMana)
                        {
                            PerformMove(CombatType.Computer, CombatType.SpecialAttack, cPlayer.SpecAttack[0]);
                        }
                        else if (mana == hPlayer.TotalMana)
                        {
                            PerformMove(CombatType.Computer, CombatType.SpecialAttack, cPlayer.SpecAttack[0]);
                        }
                    }
                    else if (armor == cPlayer.Armor)
                    {
                        if (mana < hPlayer.TotalMana)
                        {
                            PerformMove(CombatType.Computer, CombatType.BasicAttack, "Attack");
                        }
                        else if (mana == hPlayer.TotalMana)
                        {
                            PerformMove(CombatType.Computer, CombatType.BasicAttack, "Attack");
                        }
                    }
                }
                else if (ap == cPlayer.AttackPower)
                {
                    if (armor > cPlayer.Armor)
                    {
                        if (mana < hPlayer.TotalMana)
                        {
                            PerformMove(CombatType.Computer, CombatType.BasicAttack, "Attack");
                        }
                        else if (mana == hPlayer.TotalMana)
                        {
                            PerformMove(CombatType.Computer, CombatType.BasicAttack, "Attack");
                        }
                    }
                    else if (armor < cPlayer.Armor)
                    {
                        if (mana < hPlayer.TotalMana)
                        {
                            PerformMove(CombatType.Computer, CombatType.SpecialAttack, cPlayer.SpecAttack[0]);
                        }
                        else if (mana == hPlayer.TotalMana)
                        {
                            PerformMove(CombatType.Computer, CombatType.SpecialAttack, cPlayer.SpecAttack[0]);
                        }
                    }
                    else if (armor == cPlayer.Armor)
                    {
                        if (mana < hPlayer.TotalMana)
                        {
                            PerformMove(CombatType.Computer, CombatType.BasicAttack, "Attack");
                        }
                        else if (mana == hPlayer.TotalMana)
                        {
                            PerformMove(CombatType.Computer, CombatType.BasicAttack, "Attack");
                        }
                    }
                }
            }
            else if (health == hPlayer.TotalHealth)
            {
                if (ap > cPlayer.AttackPower)
                {
                    if (armor > cPlayer.Armor)
                    {
                        if (mana < hPlayer.TotalMana)
                        {
                            PerformMove(CombatType.Computer, CombatType.BasicAttack, "Attack");
                        }
                        else if (mana == hPlayer.TotalMana)
                        {
                            PerformMove(CombatType.Computer, CombatType.BasicAttack, "Attack");
                        }
                    }
                    else if (armor < cPlayer.Armor)
                    {
                        if (mana < hPlayer.TotalMana)
                        {
                            PerformMove(CombatType.Computer, CombatType.BasicAttack, "Attack");
                        }
                        else if (mana == hPlayer.TotalMana)
                        {
                            PerformMove(CombatType.Computer, CombatType.SpecialAttack, cPlayer.SpecAttack[0]);
                        }
                    }
                    else if (armor == cPlayer.Armor)
                    {
                        if (mana < hPlayer.TotalMana)
                        {
                            PerformMove(CombatType.Computer, CombatType.BasicAttack, "Attack");
                        }
                        else if (mana == hPlayer.TotalMana)
                        {
                            PerformMove(CombatType.Computer, CombatType.BasicAttack, "Attack");
                        }
                    }
                }
                else if (ap < cPlayer.AttackPower)
                {
                    if (armor > cPlayer.Armor)
                    {
                        if (mana < hPlayer.TotalMana)
                        {
                            PerformMove(CombatType.Computer, CombatType.SpecialAttack, cPlayer.SpecAttack[0]);
                        }
                        else if (mana == hPlayer.TotalMana)
                        {
                            PerformMove(CombatType.Computer, CombatType.BasicAttack, "Attack");
                        }
                    }
                    else if (armor < cPlayer.Armor)
                    {
                        if (mana < hPlayer.TotalMana)
                        {
                            PerformMove(CombatType.Computer, CombatType.BasicAttack, "Attack");
                        }
                        else if (mana == hPlayer.TotalMana)
                        {
                            PerformMove(CombatType.Computer, CombatType.BasicAttack, "Attack");
                        }
                    }
                    else if (armor == cPlayer.Armor)
                    {
                        if (mana < hPlayer.TotalMana)
                        {
                            PerformMove(CombatType.Computer, CombatType.BasicAttack, "Attack");
                        }
                        else if (mana == hPlayer.TotalMana)
                        {
                            PerformMove(CombatType.Computer, CombatType.BasicAttack, "Attack");
                        }
                    }
                }
                else if (ap == cPlayer.AttackPower)
                {
                    if (armor > cPlayer.Armor)
                    {
                        if (mana < hPlayer.TotalMana)
                        {
                            PerformMove(CombatType.Computer, CombatType.BasicAttack, "Attack");
                        }
                        else if (mana == hPlayer.TotalMana)
                        {
                            PerformMove(CombatType.Computer, CombatType.BasicAttack, "Attack");
                        }
                    }
                    else if (armor < cPlayer.Armor)
                    {
                        if (mana < hPlayer.TotalMana)
                        {
                            PerformMove(CombatType.Computer, CombatType.BasicAttack, "Attack");
                        }
                        else if (mana == hPlayer.TotalMana)
                        {
                            PerformMove(CombatType.Computer, CombatType.BasicAttack, "Attack");
                        }
                    }
                    else if (armor == cPlayer.Armor)
                    {
                        if (mana < hPlayer.TotalMana)
                        {
                            PerformMove(CombatType.Computer, CombatType.BasicAttack, "Attack");
                        }
                        else if (mana == hPlayer.TotalMana)
                        {
                            PerformMove(CombatType.Computer, CombatType.BasicAttack, "Attack");
                        }
                    }
                }
            }
        }

        private void LoadSpecAttacks()
        {
            Monitor.Enter(this);
            int ii = 0;
            var items = listSpecial.Items;
            foreach (var value in hPlayer.SpecAttack)
            {
                string attack = value + " Cost: " + hPlayer.SpecCost[ii] + " MP";
                var viewItem = new ListViewItem(attack);
                if (hPlayer.Level >= hPlayer.SpecLevel[ii])
                {   
                        if (hPlayer.Mana >= hPlayer.SpecCost[ii])
                        {
                            viewItem.Tag = hPlayer.SpecAttack[ii];
                            listSpecial.Items.Add(viewItem);
                        }
                }
                ii++;
            }
            Monitor.Exit(this);
        }

        private void PerformMove(CombatType player, CombatType cType, String move)
        {
            int Damage = 0;
            switch (player)
            {
                case CombatType.Human:

                    switch (cType)
                    {
                        case CombatType.BasicAttack:
                            Damage = hPlayer.AttackPower - cPlayer.Armor;
                            if (Damage < 0)
                                Damage = 1;
                            cPlayer.UpdateStat(Damage, StatAction.Sub, Stats.Health, CombatType.None);
                            LoadPlayerStats();
                            
                            DetermineVictor(hTurn, cTurn);
                            break;
                        case CombatType.Defend:
                            hPlayer.UpdateStat(hPlayer.BaDamage[1], StatAction.Add, Stats.Armor, CombatType.None);
                            
                            LoadPlayerStats();
                            break;
                        case CombatType.Heal:
                            break;
                        case CombatType.Mana:
                            break;
                        case CombatType.Ranged:
                            Damage = hPlayer.AttackPower + hPlayer.RangedDamage;
                            cPlayer.UpdateStat(Damage, StatAction.Sub, Stats.Health, CombatType.None);
                            LoadPlayerStats();
                            break;
                        case CombatType.SpecialAttack:
                            int index = hPlayer.SpecAttack.IndexOf(move);
                            hPlayer.UpdateStat(hPlayer.SpecCost[index], StatAction.Sub, Stats.Mana, CombatType.None);
                            hPlayer.UpdateStat(hPlayer.SaDamage[index], StatAction.Add, Stats.AttackPower, CombatType.SpecialAttack);
                            Damage = hPlayer.AttackPower - cPlayer.Armor;
                            if (Damage < 0)
                                Damage = 5;
                            cPlayer.UpdateStat(Damage, StatAction.Sub, Stats.Health, CombatType.None);
                            hPlayer.UpdateStat(hPlayer.SaDamage[index], StatAction.Sub, Stats.AttackPower, CombatType.None);
                            LoadPlayerStats();

                            DetermineVictor(hTurn, cTurn);
                            break;
                        case CombatType.Stun:
                            break;
                    }

                    break;
                case CombatType.Computer:

                    switch (cType)
                    {
                        case CombatType.BasicAttack:
                            Damage = cPlayer.AttackPower - hPlayer.Armor;
                            if (Damage < 0)
                                Damage = 1;
                            hPlayer.UpdateStat(Damage, StatAction.Sub, Stats.Health, CombatType.None);
                            LoadPlayerStats();

                            DetermineVictor(hTurn, cTurn);
                            break;
                        case CombatType.Defend:
                            cPlayer.UpdateStat(hPlayer.BaDamage[1], StatAction.Add, Stats.Armor, CombatType.None);

                            LoadPlayerStats();
                            break;
                        case CombatType.Heal:
                            break;
                        case CombatType.Mana:
                            break;
                        case CombatType.SpecialAttack:
                            int index = cPlayer.SpecAttack.IndexOf(move);
                            cPlayer.UpdateStat(cPlayer.SpecCost[index], StatAction.Sub, Stats.Mana, CombatType.None);
                            cPlayer.UpdateStat(cPlayer.SaDamage[index], StatAction.Add, Stats.AttackPower, CombatType.SpecialAttack);
                            Damage = cPlayer.AttackPower - hPlayer.Armor;
                            if (Damage < 0)
                                Damage = 5;
                            hPlayer.UpdateStat(Damage, StatAction.Sub, Stats.Health, CombatType.None);
                            cPlayer.UpdateStat(cPlayer.SaDamage[index], StatAction.Sub, Stats.AttackPower, CombatType.None);
                            LoadPlayerStats();

                            DetermineVictor(hTurn, cTurn);
                            break;
                        case CombatType.Stun:
                            break;
                    }

                    break;
            }
            DetermineTurn();
        }

        private Boolean CoolDownModerator(CombatType playerType, CombatType moveType, Int32 playerCount)
        {
            Monitor.Enter(this);
            switch (playerType)
            {
                case CombatType.None:
                    switch (moveType)
                    {
                        case CombatType.None:
                            if (playerCount == 0)
                            {
                                cdHBlock = 0;
                                cdHRanged = 0;

                                bHBlock = false;
                                bHRanged = false;

                                cdCBlock = 0;
                                bCBlock = false;

                                return true;
                            }
                            break;
                        case CombatType.Ranged:
                            break;
                        case CombatType.Defend:
                            break;
                        case CombatType.Stun:
                            break;
                    }
                    break;
                case CombatType.Human:
                    switch (moveType)
                    {
                        case CombatType.Defend:
                            if (cdHBlock == 0 && bHBlock == false)//Move hasn't been used
                            {
                                return true;
                            }
                            else if (cdHBlock == 0 && bHBlock == true)
                            {
                                cdHBlock++;
                                return false;
                            }
                            else if (cdHBlock < hPlayer.BaseCD[1])//Move has already been made, player must wait.
                            {
                                cdHBlock++;
                                hPlayer.UpdateStat(hPlayer.BaDamage[1], StatAction.Sub, Stats.Armor, CombatType.None);
                                LoadPlayerStats();
                                return false;

                            }
                            else if (cdHBlock == hPlayer.BaseCD[1])//Final turn has been made, on the next turn player will be able to use this move
                            {
                                cdHBlock = 0;
                                bHBlock = false;
                                return true;
                            }
                            break;
                        case CombatType.Ranged:
                            if (cdHRanged == 0 && bHRanged == false)//Move hasn't been used
                            {
                                return true;
                            }
                            else if (cdHRanged == 0 && bHRanged == true)
                            {
                                cdHRanged++;
                                return false;
                            }
                            else if (cdHRanged < 3)//Move has already been made, player must wait.
                            {
                                cdHRanged++;
                                return false;

                            }
                            else if (cdHRanged == 3)//Final turn has been made, on the next turn player will be able to use this move
                            {
                                cdHRanged = 0;
                                bHRanged = false;
                                return true;
                            }
                            break;
                    }
                    break;
                case CombatType.Computer:
                    switch (moveType)
                    {
                        case CombatType.Defend:
                            if (cdCBlock == 0 && bCBlock == false)//Move hasn't been used
                            {
                                return true;
                            }
                            else if (cdCBlock == 0 && bCBlock == true)
                            {
                                cdCBlock++;
                                return false;
                            }
                            else if (cdHBlock < hPlayer.BaseCD[1])//Move has already been made, player must wait.
                            {
                                cdCBlock++;
                                cPlayer.UpdateStat(hPlayer.BaDamage[1], StatAction.Sub, Stats.Armor, CombatType.None);
                                LoadPlayerStats();
                                return false;

                            }
                            else if (cdCBlock == hPlayer.BaseCD[1])//Final turn has been made, on the next turn player will be able to use this move
                            {
                                cdCBlock = 0;
                                bCBlock = false;
                                return true;
                            }
                            break;
                    }
                    break;

            }
            Monitor.Exit(this);
            return false;
            

        }

        
        private void btnHeal_Click(object sender, EventArgs e)
        {
            Form3 f3 = new Form3(hLPlayer);
            f3.Show();

            LoadPlayerStats();
            
        }

        private void btnMana_Click(object sender, EventArgs e)
        {
            Form3 f3 = new Form3(hLPlayer);
            f3.Show();

            LoadPlayerStats();
         
        }

        private void btnSPAtt_Click(object sender, EventArgs e)
        {
            listSpecial.BringToFront();
            if (listSpecial.Visible == false)
            {
                LoadSpecAttacks();
                listSpecial.Visible = true;
            }
            else
                listSpecial.Visible = false;
        }

        private void listSpecial_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (listSpecial.FocusedItem != null)
            {
                PerformMove(CombatType.Human, CombatType.SpecialAttack, listSpecial.FocusedItem.Tag.ToString());
            }
        }

        private void btnAttack_Click(object sender, EventArgs e)
        {
            PerformMove(CombatType.Human, CombatType.BasicAttack, "Attack");
        }

        private void btnBlock_Click(object sender, EventArgs e)
        {
            bHBlock = true;
            PerformMove(CombatType.Human, CombatType.Defend, hPlayer.BaseAttack[1]);
        }

        private void btnRanged_Click(object sender, EventArgs e)
        {
            bHRanged = true;
            PerformMove(CombatType.Human, CombatType.Ranged, "Ranged");
        }

        private void timerCombatStatus_Tick(object sender, EventArgs e)
        {
            timerCombatStatus.Enabled = false;
            if (bStatus == true)
            {
                Monitor.Enter(this);
                if (cPlayer.Health == 0)
                    MessageBox.Show("Kill");
                else if (hPlayer.Health == 0)
                    MessageBox.Show("You have died");
                this.Close();
                Monitor.Exit(this);
            }

        }

    }
}