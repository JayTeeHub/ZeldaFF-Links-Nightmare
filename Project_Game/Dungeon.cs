using System;
using System.Linq;
using System.Collections.Generic;
using System.Text;

namespace Project_Game
{
    public class Dungeon
    {

        private List<String> healthItemNames;
        private List<Int32> healthItemValues;
        private List<String> manaItemNames;
        private List<Int32> manaItemValues;

        private List<String> swordNames;
        private List<Int32> swordValues;
        private List<String> sheildNames;
        private List<Int32> sheildValues;
        private List<String> rangedNames;
        private List<Int32> rangedValues;

        private List<String> keyNames;

        private List<String> enemyNames;
        private List<Int32> enemyHealth;
        private List<Int32> enemyAP;
        private List<Int32> enemyMana;
        private List<Int32> enemyArmor;
        private List<Int32> enemyLevel;
        private List<Int32> enemyExpAward;

        private List<String> bossNames;
        private List<Int32> bossHealth;
        private List<Int32> bossAP;
        private List<Int32> bossMana;
        private List<Int32> bossArmor;
        private List<Int32> bossLevel;
        private List<Int32> bossExpAward;

        private Int32 bossIndex;

        private List<Int32> occupiedPositions;
        private List<Int32> itemPositions;
        private List<String> itemNames;
        private List<InventoryTyp> itemTypes;
        private List<Int32> itemValues;
        private List<Int32> monsterPositions;
        private List<String> monsterNames;
        private Random randPosition;

        private List<Int32> testPositions;

        protected Form2 f2;
        protected Map map;
        public Map MapLayout
        {
            get { return map; }
        }

        public Dungeon()
        {
            map = new Map();
            occupiedPositions = new List<Int32>();
            occupiedPositions.Capacity = 48;
            itemPositions = new List<Int32>();
            itemPositions.Capacity = 30;
            itemNames = new List<String>();
            itemNames.Capacity = itemPositions.Capacity;
            itemTypes = new List<InventoryTyp>();
            itemTypes.Capacity = itemPositions.Capacity;
            itemValues = new List<Int32>();
            itemValues.Capacity = itemPositions.Capacity;
            monsterPositions = new List<Int32>();
            monsterPositions.Capacity = 18;
            monsterNames = new List<String>();
            monsterNames.Capacity = 18;
            testPositions = new List<Int32>();
            testPositions.Capacity = 6;
            SetGamePositions();
            
            healthItemNames = new List<String>();
            healthItemNames.Capacity = 5;
            healthItemValues = new List<Int32>();
            healthItemValues.Capacity = 5;
            manaItemNames = new List<String>();
            manaItemNames.Capacity = 4;
            manaItemValues = new List<Int32>();
            manaItemValues.Capacity = 4;
            swordNames = new List<String>();
            swordNames.Capacity = 9;
            swordValues = new List<Int32>();
            swordValues.Capacity = 9;
            sheildNames = new List<String>();
            sheildNames.Capacity = 7;
            sheildValues = new List<Int32>();
            sheildValues.Capacity = 7;
            rangedNames = new List<String>();
            rangedNames.Capacity = 5;
            rangedValues = new List<Int32>();
            rangedValues.Capacity = 5;
            keyNames = new List<String>();
            keyNames.Capacity = 3;
            enemyNames = new List<String>();
            enemyNames.Capacity = 7;
            enemyHealth = new List<Int32>();
            enemyHealth.Capacity = 7;
            enemyMana = new List<Int32>();
            enemyMana.Capacity = 7;
            enemyAP = new List<Int32>();
            enemyAP.Capacity = 7;
            enemyArmor = new List<Int32>();
            enemyArmor.Capacity = 7;
            enemyLevel = new List<Int32>();
            enemyLevel.Capacity = 7;
            enemyExpAward = new List<Int32>();
            enemyExpAward.Capacity = 7;
            bossNames = new List<String>();
            bossNames.Capacity = 5;
            bossHealth = new List<Int32>();
            bossHealth.Capacity = 5;
            bossMana = new List<Int32>();
            bossMana.Capacity = 5;
            bossAP = new List<Int32>();
            bossAP.Capacity = 5;
            bossArmor = new List<Int32>();
            bossArmor.Capacity = 5;
            bossLevel = new List<Int32>();
            bossLevel.Capacity = 5;
            bossExpAward = new List<Int32>();
            bossExpAward.Capacity = 5;

            //SetTestPositions();

            /*SetMonsterPositions();
            SetItemPositions();*/

        }

        public String CheckIfOccupied(Int32 position) //Will change to Enum
        {
            if (OccupiedPositions.Contains(position))
            {
                if (ItemPositions.Contains(position))
                    return "ITEM";
                if (MonsterPositions.Contains(position))
                    return "MONSTER";
                if (testPositions.Contains(position))
                    return "EXP GAINED";
            }
            else if (position == 71)
            {
                return "MONSTER";
            }
            return "NOT OCCUPIED";
        }

        private void SetGamePositions()
        {
            randPosition = new Random();
            int index;
            int n = 0;
            while (n != occupiedPositions.Capacity)
            {

                index = randPosition.Next(map.MapPositions.Length);
                if (!occupiedPositions.Contains(map.MapPositions[index]))
                {
                    occupiedPositions.Add(map.MapPositions[index]);
                    n++;
                }
            }
        }

        public void SetMonsterPositions()
        {
            randPosition = new Random();            
            int n = 0;
            int index;
            while (n != monsterPositions.Capacity)
            {
                
                index = randPosition.Next(occupiedPositions.ToArray().Length);
                if (!monsterPositions.Contains(occupiedPositions[index]))
                {
                    if (monsterPositions.Count == 17)
                        if (monsterPositions.Contains(71))
                        {
                            MonsterPositions.Remove(71);
                            monsterPositions.Add(71);
                        }
                        else
                            monsterPositions.Add(71);
                   else
                       monsterPositions.Add(occupiedPositions[index]);
                    if (monsterPositions.Count == 17)
                        monsterNames.Add(f2.CPlayer[17].Name);
                    else
                        monsterNames.Add(f2.CPlayer[n].Name);
                    n++;
                }
            }
        }

        public void SetItemPositions()
        {
            Boolean found = false;
            Boolean healthFilled = false, manaFilled = false, swordFilled = false, sheildFilled = false, rangedFilled = false;
            randPosition = new Random();
            int n = 0;
            int k = 0;
            while (n != itemPositions.Capacity)
            {
                int index = randPosition.Next(occupiedPositions.ToArray().Length);
                if (monsterPositions.Contains(occupiedPositions[index]))
                    found = true;
                if (!itemPositions.Contains(occupiedPositions[index]) && found != true)
                {
                    itemPositions.Add((occupiedPositions[index]));
                    if (k != HealthItemNames.Capacity && healthFilled == false)
                    {
                        itemNames.Add(HealthItemNames[k]);
                        itemTypes.Add(InventoryTyp.Health);
                        itemValues.Add(HealthItemValues[k]);
                        k++;
                    }
                    else
                    {
                        if(!healthFilled)
                            k = 0;
                        healthFilled = true;
                        if (k != ManaItemNames.Capacity && manaFilled == false)
                        {
                            itemNames.Add(ManaItemNames[k]);
                            itemTypes.Add(InventoryTyp.Mana);
                            itemValues.Add(ManaItemValues[k]);
                            k++;
                        }
                        else if(manaFilled == false)
                        {
                            manaFilled = true;
                            k = 0;
                        }
                    }
                    if (manaFilled == true)
                    {
                        if (k != SwordNames.Capacity && swordFilled == false)
                        {
                            //Random rr = new Random();
                            //int num = rr.Next(0, 101);
                            //if (SwordNames[k] == "Master Sword" && num == 4)
                                //itemNames.Add(SwordNames[k]);
                            //else if (SwordNames[k] == "Biggoron Sword" && num == 15)
                                //itemNames.Add(SwordNames[k]);
                            //else
                            
                            itemNames.Add(SwordNames[k]);
                            itemTypes.Add(InventoryTyp.Sword);
                            itemValues.Add(SwordValues[k]);
                            k++;
                        }
                        else if(swordFilled == false)
                        {
                            swordFilled = true;
                            k = 0;
                        }
                    }
                    if (swordFilled == true)
                    {
                        if (k != SheildNames.Capacity && sheildFilled == false)
                        {
                            itemNames.Add(SheildNames[k]);
                            itemTypes.Add(InventoryTyp.Shield);
                            itemValues.Add(SheildValues[k]);
                            k++;
                        }
                        else if(sheildFilled == false)
                        {
                            sheildFilled = true;
                            k = 0;
                        }
                    }
                    if (sheildFilled == true)
                    {
                        if (k != RangedNames.Capacity && rangedFilled == false)
                        {
                            itemNames.Add(RangedNames[k]);
                            itemTypes.Add(InventoryTyp.Ranged);
                            itemValues.Add(RangedValues[k]);
                            k++;
                        }
                        else if(rangedFilled == false)
                        {
                            rangedFilled = true;
                            k = 0;
                        }
                    }
                    n++;
                }
                found = false;
            }
        }

        private void SetTestPositions()
        {
            Boolean found = false;
            randPosition = new Random();
            int n = 0;
            while (n != testPositions.Capacity)
            {
                int index = randPosition.Next(occupiedPositions.ToArray().Length);
                if (monsterPositions.Contains(occupiedPositions[index])||itemPositions.Contains(occupiedPositions[index]))
                    found = true;
                if (!testPositions.Contains(occupiedPositions[index]) && found != true)
                {
                    testPositions.Add((occupiedPositions[index]));
                    n++;
                }
                found = false;
            }
        }

        public int Columns
        {
            get { return map.Columns; }
        }

        public int Rows
        {
            get { return map.Rows; }
        }

        public Form2 F2
        {
            get { return f2; }
            set { f2 = value; }
        }

        public List<Int32> OccupiedPositions
        {
            get { return occupiedPositions; }
        }

        public List<Int32> ItemPositions
        {
            get { return itemPositions; }
        }

        public List<String> ItemNames
        {
            get { return itemNames; }
        }

        public List<InventoryTyp> ItemTypes
        {
            get { return itemTypes; }
        }

        public List<Int32> ItemValues
        {
            get { return itemValues; }
        }

        public List<Int32> MonsterPositions
        {
            get { return monsterPositions; }
        }

        public List<Int32> TestPositions
        {
            get { return testPositions; }
        }

        public List<String> HealthItemNames
        {
            get { return healthItemNames; }
        }

        public List<Int32> HealthItemValues
        {
            get { return healthItemValues; }
        }

        public List<String> ManaItemNames
        {
            get { return manaItemNames; }
        }
        
        public List<Int32> ManaItemValues
        {
            get { return manaItemValues; }
        }

        public List<String> SwordNames
        {
            get { return swordNames; }
        }

        public List<Int32> SwordValues
        {
            get { return swordValues; }
        }

        public List<String> SheildNames
        {
            get { return sheildNames; }
        }

        public List<Int32> SheildValues
        {
            get { return sheildValues; }
        }

        public List<String> RangedNames
        {
            get { return rangedNames; }
        }

        public List<Int32> RangedValues
        {
            get { return rangedValues; }
        }

        public List<String> KeyNames
        {
            get { return keyNames; }
        }

        public List<String> EnemyNames
        {
            get { return enemyNames; }
        }

        public List<Int32> EnemyHealth
        {
            get { return enemyHealth; }
        }

        public List<Int32> EnemyAP
        {
            get { return enemyAP; }
        }

        public List<Int32> EnemyMana
        {
            get { return enemyMana; }
        }

        public List<Int32> EnemyArmor
        {
            get { return enemyArmor; }
        }

        public List<Int32> EnemyLevel
        {
            get { return enemyLevel; }
        }

        public List<Int32> EnemyExpAward
        {
            get { return enemyExpAward; }
        }

        public List<String> BossNames
        {
            get { return bossNames; }
        }

        public List<Int32> BossHealth
        {
            get { return bossHealth; }
        }

        public List<Int32> BossAP
        {
            get { return bossAP; }
        }

        public List<Int32> BossMana
        {
            get { return bossMana; }
        }

        public List<Int32> BossArmor
        {
            get { return bossArmor; }
        }

        public List<Int32> BossLevel
        {
            get { return bossLevel; }
        }

        public List<Int32> BossExpAward
        {
            get { return bossExpAward; }
        }
        public Int32 BossIndex
        {
            get { return bossIndex; }
            set { bossIndex = value; }
        }
    }

   
}
