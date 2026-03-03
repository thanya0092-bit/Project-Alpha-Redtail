public static class Program
{
    public static void Main()
    {
        bool running = true;
        while (running)
        {
            Console.WriteLine($"You are at: {World.CurrentLocation.Name}.");
            Console.WriteLine("What would you like to do? (enter a number)");
            Console.WriteLine("1. Move");
            Console.WriteLine("2. Fight");
            Console.WriteLine("3. Quit");
            string choice = Console.ReadLine()!;
            switch (choice)
            {
                case "1":
                    // Print map
                    Console.WriteLine("\n");
                    Console.WriteLine($"You are at: {World.CurrentLocation.Name}. From here you can go:");
                    Console.WriteLine(World.CurrentLocation.Compass());
                    string userinput = Console.ReadLine()!;
                    if (!World.TryToMoveTo(World.CurrentLocation.GetLocationAt(userinput)))
                    {
                        Console.WriteLine("That is not a valid direction!");
                    }

                    // if World.CurrentLocation.QuestAvailableHere

                    break;
                case "2":
                    // ...
                    break;
                case "3":
                    return;
                default:
                    Console.WriteLine("Invalid input");
                    break;

            }
        }
    }
}