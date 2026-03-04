public class Health
{
    
    public int PlayerHealth;

    public Health(int playerHealth)
    {
        PlayerHealth = playerHealth;
    }

    public int CurrentHealth()
    {

        if (PlayerHealth <= 0)
        {
            PlayerHealth = 0;
            return $"You died Game Over!";
        }
        return $" Your current health is: {PlayerHealth}";
    }

    public Health_after_Damege(int damage)
    {
        PlayerHealth -= damage;
        return new Health(PlayerHealth);
    }

    public recoverHealth(int healthRecovered)
    {
        PlayerHealth += healthRecovered;
        return new Health(PlayerHealth);
    }   
}