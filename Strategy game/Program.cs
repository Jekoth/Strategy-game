internal class Program
{
    static void Main(string[] args)
    {

        // Declare variables
        int warriorHealth = 100;
        int skeletonHealth = 100;

        Console.WriteLine("Battle Begins!" + " Human warrior against Skeleton warrior.");

        while (warriorHealth > 0 && skeletonHealth > 0)
        {

            // Inform player of current game state
            Console.WriteLine("The human warrior has " + warriorHealth + " health.");
            Console.WriteLine("The skeleton warrior has " + skeletonHealth + " health.");
            Console.WriteLine("Write 'attack' to attack the enemy or 'block' to block an enemy attack");

            // Get the player's choice
            string choice = Console.ReadLine();
            // Decide enemy damage
            int enemyDamage = new Random().Next(5, 10);

            // Process player action
            if (choice == "attack")
            {
                //If the player attacks
                Console.WriteLine("Human warrior attacks Skeleton warrior, dealing 20 damage.");
                skeletonHealth -= 20;
                Console.WriteLine("Skeleton warrior attack Human warrior dealing " + enemyDamage + " damage!");
                warriorHealth -= enemyDamage;
            }


            if (choice == "block")
            {
                // If the player defends
                Console.WriteLine("You blocked against the attack!");
                Console.WriteLine("The enemy would've dealt " + enemyDamage + " damage!");
            }

        }
        if (skeletonHealth <= 0)
        {
            Console.WriteLine("Skeleton warrior is defeated!");
            Console.WriteLine("Human warrior is victorious!");
        }
    }
}