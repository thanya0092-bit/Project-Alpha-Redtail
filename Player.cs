public class Player
{
    public int CurrentHitPoints;
    public int MaximumHitPoints;
    public int ExperiencePoints;
    public Weapon CurrentWeapon;

    public Player(int maximumHitPoints, Weapon startingWeapon)
    {
        MaximumHitPoints = maximumHitPoints;
        CurrentHitPoints = maximumHitPoints;
        ExperiencePoints = 0;
        CurrentWeapon = startingWeapon;
    }
}