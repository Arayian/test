using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LevelUpTest
{
    class Character
    {
        #region [ Fields ]

        private string _name;
        private int _level;
        private int _stamina;
        private int _intelligence;
        private int _dexterity;
        private int _strength;
        private int _currXP;
        private int _maxXP;

        #endregion

        #region [ Other Thingies ]

        public string Name
        {
            get { return _name; }
            set { _name = value; }
        }

        public int Level
        {
            get { return _level; }
            set { _level = value; }
        }

        public int Stamina
        {
            get { return _stamina; }
            set { _stamina = value; }
        }

        public int Intelligence
        {
            get { return _intelligence; }
            set { _intelligence = value; }
        }

        public int Dexterity
        {
            get { return _dexterity; }
            set { _dexterity = value; }
        }

        public int Strength
        {
            get { return _strength; }
            set { _strength = value; }
        }

        public int CurrentXP
        {
            get { return _currXP; }
            set { _currXP = value; }
        }

        public int MaxXP
        {
            get { return _maxXP; }
            set { _maxXP = value; }
        }

        #endregion

        #region [ Methods ]

        public void LevelUp()
        {
            Random rand = new Random();
            int numOfStats;

            //Increase Character's Level
            _level = _level + 1; 

            //Account for overflow experience
            //ie. Char needs 100xp for level, gains 120
            _currXP = _currXP - _maxXP;

            //Determine number of stats to raise
            numOfStats = rand.Next(1, 4);
            StatUp(numOfStats);
        }

        public void StatUp(int number)
        {
            //TODO: Write StatUp method
        }

        #endregion
    }
}
