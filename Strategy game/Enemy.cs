using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Strategy_game
{
    /// <summary>
    /// Represents the base elements of an enemy.
    /// </summary>
    public class Enemy
    {
        /// <summary>
        /// This represents the players health values.
        /// </summary>
        
        public int enemyHealth { get; set; }
        public int enemyDamage { get; set; }
        
        /// <summary>
        /// The default contructor.
        /// </summary>
        public Enemy()
        {
            enemyHealth = 100;
            enemyDamage = new Random().Next(10, 15);
        }
    }
}
