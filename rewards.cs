public static class Rewards
{
    // geeft quest_id die gewonnen is
    // method gaat kijken om welke quest het gaat en geeft daarbij de behorende reward
    public static void give_reward(int Quest_id, Player player)
    {   
        //Weapon rewarded_weapon = null;
        switch (Quest_id)
        {
            case World.QUEST_ID_CLEAR_ALCHEMIST_GARDEN:
                // maak obj voor Weapon class
                Weapon rewarded_poison = new Weapon(3, "Longsword", 10);
                // voeg obj toe aan list
                player.Inventory.Add(rewarded_poison);
                //new Rewards(rewarded_poison);
                Console.WriteLine($"You got rewarded with a {rewarded_poison.Name}.");
                break;
            case World.QUEST_ID_CLEAR_FARMERS_FIELD:
                Weapon rewarded_weapon = new Weapon(4, "AK-47", 20);
                player.Inventory.Add(rewarded_weapon);
                //new Rewards(rewarded_weapon);
                Console.WriteLine($"You got rewarded with an {rewarded_weapon.Name}.");
                break;
            case World.QUEST_ID_COLLECT_SPIDER_SILK:
                Weapon reward_silk = new Weapon(5, "Spider slik", 0);
                player.Inventory.Add(reward_silk);
                Console.WriteLine($"You got rewarded with {reward_silk.Name}.");
                break;
            default:
                Console.WriteLine("Nothing for you buddy");
                break;
        }
    }
}
















