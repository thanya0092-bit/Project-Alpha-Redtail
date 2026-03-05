public class Location
{
    public int ID;
    public string Name;
    public string Description;
    public Quest QuestAvailableHere = null;
    public Monster MonsterLivingHere = null;

    public Location LocationToNorth = null;
    public Location LocationToSouth = null;
    public Location LocationToEast = null;
    public Location LocationToWest = null;

    public Location(int id, string name, string description, Quest quest, Monster monster)
    {
        ID = id;
        Name = name;
        Description = description;
        QuestAvailableHere = quest;
        MonsterLivingHere = monster;
    }

    public string Compass()
    {
        string directions = "From here you can go:\n";
        if (LocationToNorth != null)
        {
            directions += "    N\n    |\n";
        }
        if (LocationToWest != null)
        {
            directions += "W---|";
        }
        else
        {
            directions += "    |";
        }
        if (LocationToEast != null)
        {
            directions += "---E";
        }
        directions += "\n";
        if (LocationToSouth != null)
        {
            directions += "    |\n    S\n";
        }
        return directions;
    }

    public Location GetLocationAt(string direction) => direction switch
    {
        "N" => LocationToNorth,
        "E" => LocationToEast,
        "S" => LocationToSouth,
        "W" => LocationToWest,
        _ => null
    };
    
    public static void ShowMap()
    {
        Console.WriteLine("\n========= WORLD MAP =========\n");

        void Print(string name)
        {
            if (World.CurrentLocation.Name == name)
                Console.Write($"[>{name}<]");
            else
                Console.Write($"[{name}]");
        }

        Console.Write("                                  ");
        Print("Alchemist's garden");
        Console.WriteLine();

        Console.WriteLine("                                        |");

        Console.Write("                                  ");
        Print("Alchemist's hut");
        Console.WriteLine();

        Console.WriteLine("                                        |");

        Print("Farmer's field");
        Console.Write(" -- ");
        Print("Farmhouse");
        Console.Write(" -- ");
        Print("Town square");
        Console.Write(" -- ");
        Print("Guard post");
        Console.Write(" -- ");
        Print("Bridge");
        Console.Write(" -- ");
        Print("Forest");
        Console.WriteLine();

        Console.WriteLine("                                        |");

        Console.Write("                                    ");
        Print("Home");
        Console.WriteLine();

        Console.WriteLine("\n*Your location marked with [>name<]");
    }
}