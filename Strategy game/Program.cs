using System;
using System.Collections.Generic;
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

        // initialize a new stack of PlayerMove objects
        Stack<PlayerMove> moves = new Stack<PlayerMove>();

        Console.WriteLine("Battle begins! Human warrior against Skeleton warrior.");

        while (player.playerHealth > 0 && enemy.enemyHealth > 0)
        {
            // Player turn
            // Inform player of current game state

            Console.WriteLine("The human warrior has " + player.playerHealth + " health.");
            Console.WriteLine("The skeleton warrior has " + enemy.enemyHealth + " health.\n");
            Console.WriteLine("What would like you to do?\n\n 1. Attack\n 2. Heal\n 3. Undo");

            // Get the player's choice
            string choice = Console.ReadLine()!;


            // Process player action
            Console.WriteLine("\n-- Player turn --");
            if (choice == "1")
            {
                //If the player attacks
                moves.Push(new PlayerMove("attack", player.playerDamage, enemy.enemyHealth));
                Console.WriteLine("Human warrior attacks Skeleton warrior, dealing " + player.playerDamage + " damage.\n");
                enemy.enemyHealth -= player.playerDamage;
            }
            else if (choice == "2")
            {
                // If the player heals
                moves.Push(new PlayerMove("heal", healAmount, player.playerHealth));
                player.playerHealth += healAmount;
                Console.WriteLine("You healed " + healAmount + " yourself!\n");
            }
            else if (choice == "3")
            {
                if (moves.Count > 0)
                {
                    PlayerMove lastMove = moves.Pop();
                    if (lastMove.Type == "attack")
                    {
                        enemy.enemyHealth = lastMove.Health;
                        Console.WriteLine("Undo successful: Attack undone. Skeleton warrior health: " + enemy.enemyHealth);
                    }
                    else if (lastMove.Type == "heal")
                    {
                        player.playerHealth = lastMove.Health;
                        Console.WriteLine("Undo successful: Heal undone. Player health: " + player.playerHealth);
                    }
                }
                else
                {
                    Console.WriteLine("Nothing to undo.");
                }
            }
            else
            {
                Console.WriteLine("Invalid choice.");
                return;
            }

            // Check if player chose option 3 (undo move)
            if (choice != "3")
            {
                // Enemy turn
                if (enemy.enemyHealth > 0)
                {
                    Console.WriteLine("-- Enemy turn --");
                    int enemyChoice = random.Next(0, 2);

                    if (enemyChoice == 0)
                    {
                        moves.Push(new PlayerMove("attack", player.playerDamage, enemy.enemyHealth));
                        Console.WriteLine("Skeleton warrior attack Human warrior dealing " + enemy.enemyDamage + " damage!\n");
                        player.playerHealth -= enemy.enemyDamage;
                    }
                    else if (enemyChoice >= 1)
                    {
                        enemy.enemyHealth += healAmount;
                        Console.WriteLine("Skeleton Warrior restored " + healAmount + " health points!\n");
                    }
                }
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