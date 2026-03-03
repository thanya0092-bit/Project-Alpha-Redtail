public static class Combat
{
    public static void AttackMonster(Player player, Monster monster)
    {
        int damageToMonster = World.RandomGenerator.Next(1, player.CurrentWeapon.MaximumDamage + 1);
        monster.CurrentHitPoints -= damageToMonster;

        Console.WriteLine($"You hit the {monster.Name} for {damageToMonster} damage.");

        if (monster.CurrentHitPoints <= 0)
        {
            Console.WriteLine($"You defeated the {monster.Name}!");
            player.ExperiencePoints += monster.RewardExperiencePoints;
            Console.WriteLine($"You gain {monster.RewardExperiencePoints} XP.");
        }
        else
        {
            AttackPlayer(player, monster);
        }
    }

    private static void AttackPlayer(Player player, Monster monster)
    {
        int damageToPlayer = World.RandomGenerator.Next(1, monster.MaximumDamage + 1);
        player.CurrentHitPoints -= damageToPlayer;

        Console.WriteLine($"The {monster.Name} hit you for {damageToPlayer} damage.");

        if (player.CurrentHitPoints <= 0)
        {
            Console.WriteLine("You died...");
        }
    }
}