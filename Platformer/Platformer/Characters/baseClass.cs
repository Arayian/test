using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Platformer
{
    class baseClass
    {
        //Put shared class things in here
        //TODO: Have other classes inherit from this once I remember how to

        private string _name = "Player";

        public string Name
        {
            get { return _name; }
            set { _name = value; }
        }


    }
}
