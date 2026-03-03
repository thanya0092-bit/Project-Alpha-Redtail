public class Location
{
    public int ID;
    public string Name;
    public string Description;
    public Quest QuestAvailableHere;
    public Monster MonsterLivingHere;

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
        string directions = "";
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
}