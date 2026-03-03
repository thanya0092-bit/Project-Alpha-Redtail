public static class Program
{
    public static void Main()
    {
        bool running = true;
        while (running)
        {
            Console.WriteLine($"You are at: {World.CurrentLocation.Name}. From here you can go:");
            Console.WriteLine(World.CurrentLocation.Compass());
            string input = Console.ReadLine()!;
            if (!World.TryToMoveTo(World.CurrentLocation.GetLocationAt(input)))
            {
                Console.WriteLine("That is not a valid direction!");
            }
            if (World.CurrentLocation == World.LocationByID(9))
            {
                break;   
            }
        }
    }
}