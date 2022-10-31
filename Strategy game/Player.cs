using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Strategy_game
{   
    /// <summary>
    /// This class represents playable character.
    /// </summary>
    public class Player
    {
        /// <summary>
        /// This represents the players health values.
        /// </summary>
        
        public int playerHealth { get; set; }
        public int playerDamage { get; set; }

        /// <summary>
        /// The default contructor.
        /// </summary>
        public Player()
        {
            playerHealth = 100;
            playerDamage = new Random().Next(15, 20);
        }
    }
}
