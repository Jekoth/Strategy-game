using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Strategy_game
{
    class PlayerMove
    {
        public string Type { get; set; }
        public int Damage { get; set; }
        public int Health { get; set; }

        public PlayerMove(string type, int damage, int health)
        {
            this.Type = type;
            this.Damage = damage;
            this.Health = health;
        }
    }


}
