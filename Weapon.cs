public class Player
{
    public int CurrentHitPoints { get; set; }
    public int MaximumHitPoints { get; set; }
    public int ExperiencePoints { get; set; }
    public Weapon CurrentWeapon { get; set; }

    public Player(int maximumHitPoints, Weapon startingWeapon)
    {
        MaximumHitPoints = maximumHitPoints;
        CurrentHitPoints = maximumHitPoints;
        ExperiencePoints = 0;
        CurrentWeapon = startingWeapon;
    }
}
