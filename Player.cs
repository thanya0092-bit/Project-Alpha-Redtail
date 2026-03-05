public class Player
{
    public int CurrentHitPoints;
    public int MaximumHitPoints;
    public int ExperiencePoints;
    public Weapon CurrentWeapon;
    public List<Weapon> Inventory = new List<Weapon>();
    public int RatsKilled = 0;
    public int SnakesKilled = 0;
    public int SpidersKilled = 0;

    public Player(int maximumHitPoints, Weapon startingWeapon)
    {
        MaximumHitPoints = maximumHitPoints;
        CurrentHitPoints = maximumHitPoints;
        ExperiencePoints = 0;
        CurrentWeapon = startingWeapon;
        Inventory.Add(startingWeapon);
    }

    public void AddWeaponToInventory(Weapon weapon)
    {
        Inventory.Add(weapon);
        Console.WriteLine($"You found a {weapon.Name}!");
    }

    public void ShowInventory()
    {
        Console.WriteLine("\n=== Inventory ===");
        for (int i = 0; i < Inventory.Count; i++)
        {
            Console.WriteLine($"{i + 1} - {Inventory[i].Name}");
        }
        Console.WriteLine("Select a weapon to equip (or 0 to cancel):");

        int choice = Convert.ToInt32(Console.ReadLine());
        while (choice < 0 || choice > Inventory.Count)
        {
            Console.WriteLine("Invalid input. Please enter a number corresponding to a weapon in your inventory.");
            choice = Convert.ToInt32(Console.ReadLine());
        }
        if (choice == 0)
        {
            Console.WriteLine("No changes made to your equipped weapon.");
        }
        else
        {
        CurrentWeapon = Inventory[choice - 1];
        Console.WriteLine($"You equipped the {CurrentWeapon.Name}.");
        }
    }

    public void ShowStatus()
    {
        Console.WriteLine("\n=== Player Status ===");
        Console.WriteLine($"HP: {CurrentHitPoints}/{MaximumHitPoints}");
        Console.WriteLine($"Rats killed: {RatsKilled}/3");
        Console.WriteLine($"Snakes killed: {SnakesKilled}/3");
        Console.WriteLine($"Spiders killed: {SpidersKilled}/3");
    }
}