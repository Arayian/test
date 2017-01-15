using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Platformer
{
    class Player
    {
        private string _name;
        private string _class;

        public string Class
        {
            get { return _class; }
            set { _class = value; }
        }

        public string Name
        {
            get { return _name; }
            set { _name = value; }
        }

    }

}

