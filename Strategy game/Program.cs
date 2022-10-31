using Strategy_game;

class Program
{
    static void Main(string[] args)
    {

        // Create player and enemy character
        Player player = new Player();
        Enemy enemy = new Enemy();

        // Heal amount
        int healAmount = new Random().Next(5, 10);

        Random random = new Random();

        Console.WriteLine("Battle begins! Human warrior against Skeleton warrior.");

        while (player.playerHealth > 0 && enemy.enemyHealth > 0)
        {
            // Player turn
            // Inform player of current game state
            
            Console.WriteLine("The human warrior has " + player.playerHealth + " health.");
            Console.WriteLine("The skeleton warrior has " + enemy.enemyHealth + " health.\n");
            Console.WriteLine("What would like you to do?\n\n 1. Attack\n 2. Heal");

            // Get the player's choice
            string choice = Console.ReadLine()!;

            // Process player action
            Console.WriteLine("\n-- Player turn --");
            if (choice == "1")
            {
                //If the player attacks
                
                Console.WriteLine("Human warrior attacks Skeleton warrior, dealing " + player.playerDamage + " damage.\n");
                enemy.enemyHealth -= player.playerDamage;
            }
                //else if (choice == "2")
                //{
                //    // If the player defends
                //    Console.WriteLine("You blocked against the attack!");
                //    Console.WriteLine("The enemy would've dealt " + enemy.enemyDamage + " damage!\n");
                //    enemy.enemyDamage -= enemy.enemyDamage;
                //}
                    else if (choice == "2")
                    {
                         // If the player heals
                         player.playerHealth += healAmount;
                         Console.WriteLine("You healed " + healAmount + " yourself!\n");
                    }
                        else
                        {
                            Console.WriteLine("You choose something else.");
                            return;
                        }

            // Enemy turn
            if (enemy.enemyHealth > 0)
            {
                Console.WriteLine("-- Enemy turn --");
                int enemyChoice = random.Next(0, 2);

                if (enemyChoice == 0)
                {
                    player.playerHealth -= enemy.enemyDamage;
                    Console.WriteLine("Skeleton warrior attack Human warrior dealing " + enemy.enemyDamage + " damage!\n");
                }
                  else /*if(enemyChoice >= 1)*/
                  {
                     enemy.enemyHealth += healAmount;
                     Console.WriteLine("Skeleton Warrior restored " + healAmount + " health points!\n");
                  }
                    //else
                    //{
                    //    // If the enemy defends
                    //    Console.WriteLine("Enemy blocked against the attack!");
                    //    Console.WriteLine("You would've dealt " + player.playerDamage + " damage!\n");
                    //    player.playerDamage -= player.playerDamage;
                    //}
            }
        }

        // Player won
        if (player.playerHealth >= 0)
        {
            Console.WriteLine("Skeleton warrior is defeated!");
            Console.WriteLine("Human warrior is victorious!");
        }
            // Player lost
            else
            {
                Console.WriteLine("You Lose!");
            }
    }
}