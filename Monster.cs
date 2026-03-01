
public class Monster
{
    public int ID;
    public string Name;
    public int MaximumDamage;
    public int RewardExperiencePoints;
    public int MaximumHitPoints;
    public int CurrentHitPoints;

    public Monster(int id, string name, int maximumDamage, int rewardExperiencePoints, int maximumHitPoints)
    {
        ID = id;
        Name = name;
        MaximumDamage = maximumDamage;
        RewardExperiencePoints = rewardExperiencePoints;
        MaximumHitPoints = maximumHitPoints;
        CurrentHitPoints = maximumHitPoints;
    }
}