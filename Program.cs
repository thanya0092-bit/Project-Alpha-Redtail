public static class Program
{
    public static void Main()
    {
        Player player = new Player(
            20,
            World.WeaponByID(World.WEAPON_ID_RUSTY_SWORD)
        );

        // Get a monster from World
        Monster Rat1 = World.MonsterByID(World.MONSTER_ID_RAT);

        bool running = true;
        while (running)
        {
            Console.WriteLine($"You are at: {World.CurrentLocation.Name}. From here you can go:");
            Console.WriteLine(World.CurrentLocation.Compass());
            string input = Console.ReadLine()!;
            World.TryToMoveTo(World.CurrentLocation.GetLocationAt(input));
            if (World.CurrentLocation == World.LocationByID(9))
            {
                break;   
            }
        }
    }
}