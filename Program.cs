public static class Program
{
    public static void Main()
    {
        // Create player
        Player player = new Player(
            20,
            World.WeaponByID(World.WEAPON_ID_RUSTY_SWORD)
        );

        // Get a monster from World
        Monster Rat1 = World.MonsterByID(World.MONSTER_ID_RAT);

        // Fight until someone dies
        while (player.CurrentHitPoints > 0 && Rat1.CurrentHitPoints > 0)
        {
            Combat.AttackMonster(player, Rat1);
            Console.WriteLine();
        }
    }
}
