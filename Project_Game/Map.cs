using System;
using System.Linq;
using System.Collections.Generic;
using System.Text;

namespace Project_Game
{
    public class Map : ICloneable
    {
        private const Int32 COLUMNS = 12;
        private const Int32 ROWS = 12;
        protected int[,] map;
        private Int32[] mapPositions;

        public Map(int[,] gameState)
            : this()
        {

        }

        public Map()
        {
            map = new int[ROWS, COLUMNS];
            mapPositions = new Int32[143];
            for (int i = 0; i < mapPositions.Length; i++)
            {
                mapPositions[i] = (i);
            }
        }

        public Int32[] MapPositions
        {
            get { return mapPositions; }
        }

        public int Rows
        {
            get { return ROWS; }
        }

        public int Columns
        {
            get { return COLUMNS; }
        }

        #region ICloneable Members

        public object Clone()
        {
            Map b = new Map(this.map);
            return b;

        }

        #endregion
    }
}
