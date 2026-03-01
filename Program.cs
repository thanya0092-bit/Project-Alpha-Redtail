public class Program
{
    static void Main()
    {
        bool running = true;
        while (running)
        {
            Console.WriteLine($"You are at: {World.CurrentLocation.Name}. From here you can go:");
            Console.WriteLine(World.CurrentLocation.Compass);
            string input = Console.ReadLine();
            World.TryToMoveTo(World.CurrentLocation.GetLocationAt(input));
            break;
        }
    }
}
