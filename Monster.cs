public class Monster
{
    public int ID;
    public string Name;
    public int MaximumDamage;
    public int MaximumHitPoints;
    public int CurrentHitPoints;

    public Monster(int id, string name, int maximumDamage, int currentHitPoints, int maximumHitPoints)
    {
        ID = id;
        Name = name;
        MaximumDamage = maximumDamage;
        CurrentHitPoints = currentHitPoints;
        MaximumHitPoints = maximumHitPoints;
    }
}