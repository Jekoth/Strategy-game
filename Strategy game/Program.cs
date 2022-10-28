class Program
{
    static void Main(string[] args)
    {
        
        // Declare variables
        int warriorHealth = 100;
        int skeletonHealth = 100;

        int healAmount = 5;

        Random random = new Random();

        Console.WriteLine("Battle Begins!" + " Human warrior against Skeleton warrior.");

        while (warriorHealth > 0 && skeletonHealth > 0)
        {
            // Player turn
            // Inform player of current game state
            
            Console.WriteLine("The human warrior has " + warriorHealth + " health.");
            Console.WriteLine("The skeleton warrior has " + skeletonHealth + " health.\n");
            Console.WriteLine("What would like you to do?\n\n 1. Attack\n 2. Block\n 3. Heal");

            // Get the player's choice
            string choice = Console.ReadLine()!;

            // Decide enemy damage
            int enemyDamage = new Random().Next(5, 10);

            // Process player action
            Console.WriteLine("\n-- Player turn --");
            if (choice == "1")
            {
                //If the player attacks
                
                Console.WriteLine("Human warrior attacks Skeleton warrior, dealing 20 damage.\n");
                skeletonHealth -= 20;
            }
                else if (choice == "2")
                {
                    // If the player defends
                    Console.WriteLine("You blocked against the attack!");
                    Console.WriteLine("The enemy would've dealt " + enemyDamage + " damage!\n");
                    enemyDamage -= enemyDamage;
                }
                    else if (choice == "3")
                    {
                         // If the player heals
                         warriorHealth += healAmount;
                         Console.WriteLine("You healed " + healAmount + " yourself!\n");
                    }
                        else
                        {
                            Console.WriteLine("You choose something else.");
                            return;
                        }

            // Enemy turn
            if (skeletonHealth > 0)
            {
                Console.WriteLine("-- Enemy turn --");
                int enemyChoice = random.Next(0, 2);

                if (enemyChoice == 0)
                {
                    warriorHealth -= enemyDamage;
                    Console.WriteLine("Skeleton warrior attack Human warrior dealing " + enemyDamage + " damage!\n");
                }
                    else
                    {
                        skeletonHealth += healAmount;
                        Console.WriteLine("Skeleton Warrior restored " + healAmount + " health points!\n");
                    }
            }
        }

        // Player won
        if (warriorHealth >= 0)
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