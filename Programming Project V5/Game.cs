using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Programming_Project_V5
{
    public class Game
    {
        public int id;
        public string name;

        public Game(int id, string name)
        {
            this.id = id;
            this.name = name;
        }

        public int GetID()
        {
            return id;
        }

        public string Name()
        {
            return name;
        }

    }
}
