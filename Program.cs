class Program
{
    static Player player = new Player(
        20,
        World.WeaponByID(World.WEAPON_ID_RUSTY_SWORD)
    );

    static void Main(string[] args)
    {
        Console.WriteLine("The people in your town are being terrorized by giant spiders.");
        Console.WriteLine("You decide to do what you can to help.​");

        bool isRunning = true;

        while (isRunning)
        {
            Console.WriteLine("\n=========================");
            Console.WriteLine("1 - View Map");
            Console.WriteLine("2 - Move");
            Console.WriteLine("3 - View Inventory");
            Console.WriteLine("4 - View Status");
            Console.WriteLine("5 - Quit");
            Console.WriteLine("=========================");

            string choice = Console.ReadLine()!;

            switch (choice)
            {
                case "1":
                    Location.ShowMap();
                    break;

                case "2":
                    MovePlayer();
                    break;

                case "3":
                    player.ShowInventory();
                    break;

                case "4":
                    player.ShowStatus();
                    break;

                case "5":
                    isRunning = false;
                    break;

                default:
                    Console.WriteLine("Invalid choice.");
                    break;
            }
            if (player.CurrentHitPoints <= 0)
            {
                Console.WriteLine("You died. Game Over.");
                break;
            }
        }
        Console.WriteLine("Thanks for playing!");
    }

    static void MovePlayer()
    {
        Console.WriteLine(World.CurrentLocation.Compass());
        Console.WriteLine("Move using N, S, E, W:");
        string input = Console.ReadLine()!.ToUpper();

        Location newLocation = World.CurrentLocation.GetLocationAt(input);

        if (newLocation == null)
        {
            Console.WriteLine("You can't go that way.");
            return;
        }

        // Bridge lock
        if (newLocation.ID == World.LOCATION_ID_BRIDGE)
        {
            if (player.RatsKilled < 3 || player.SnakesKilled < 3)
            {
                Console.WriteLine("Guard blocks the bridge!");
                Console.WriteLine("Kill 3 rats and 3 snakes first.");
                return;
            }
        }

        World.TryToMoveTo(newLocation);

        Console.WriteLine($"You moved to {World.CurrentLocation.Name}");

        // Quest check
        if (World.CurrentLocation.QuestAvailableHere != null)
        {
            Quest quest = World.CurrentLocation.QuestAvailableHere;
            if (!quest.IsStarted)
            {
                quest.StartQuest();
            }
        }

        // Monster check
        if (World.CurrentLocation.MonsterLivingHere != null)
        {
            Monster monster = World.CurrentLocation.MonsterLivingHere;

            // Check if player already killed enough monsters
            if ((monster.ID == World.MONSTER_ID_RAT && player.RatsKilled >= 3) ||
                (monster.ID == World.MONSTER_ID_SNAKE && player.SnakesKilled >= 3) ||
                (monster.ID == World.MONSTER_ID_GIANT_SPIDER && player.SpidersKilled >= 3))
            {
                Console.WriteLine("There are no more monsters here.");
                return;
            }

            while (true)
            {
                Console.WriteLine($"A {monster.Name} is here!");
                Console.WriteLine("Do you want to fight? (Y/N)");

                string fightChoice = Console.ReadLine()!.ToUpper();

                if (fightChoice == "Y")
                {
                    Combat.StartFight(player, monster);

                    if (monster.CurrentHitPoints <= 0)
                    {
                        if (monster.ID == World.MONSTER_ID_RAT)
                        {
                            player.RatsKilled++;
                            Console.WriteLine($"Rats killed: {player.RatsKilled}/3");

                            if (player.RatsKilled >= 3)
                            {
                                Console.WriteLine("There are no more rats here.");
                                break;
                            }
                        }
                        else if (monster.ID == World.MONSTER_ID_SNAKE)
                        {
                            player.SnakesKilled++;
                            Console.WriteLine($"Snakes killed: {player.SnakesKilled}/3");

                            if (player.SnakesKilled >= 3)
                            {
                                Console.WriteLine("There are no more snakes here.");
                                break;
                            }
                        }
                        else if (monster.ID == World.MONSTER_ID_GIANT_SPIDER)
                        {
                            player.SpidersKilled++;
                            Console.WriteLine($"Spiders killed: {player.SpidersKilled}/3");

                            if (player.SpidersKilled >= 3)
                            {
                                Console.WriteLine("There are no more spiders here.");
                                break;
                            }
                        }

                        Console.WriteLine("Fight another monster? (Y/N)");
                        string again = Console.ReadLine()!.ToUpper();

                        if (again == "Y")
                        {
                            monster = World.MonsterByID(monster.ID);
                            monster.CurrentHitPoints = monster.MaximumHitPoints;
                            continue;
                        }
                        else
                        {
                            break;
                        }
                    }
                }
                else
                {
                    Console.WriteLine("You avoid the fight.");
                    break;
                }
            }
        }
    }
}
