using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Programming_Project_V5
{
    public class Game
    {
        public int id { get; set; }
        public string name { get; set; }
        public int Stock { get; set; }
        public decimal rentalPrice { get; set; }

        public Game(int id, string name, decimal rentalPrice, int stock)
        {
            this.id = id;
            this.name = name;
            this.rentalPrice = rentalPrice;
            this.Stock= stock;
        }

        public override string ToString()
        {
            return name;
        }


    }
}
