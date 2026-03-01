
public class Weapon
{
    public int ID;
    public string Name;
    public int Damage;

    public Weapon(int id, string name, int damage)
    {
        this.ID = id;
        this.Name = name;
        this.Damage = damage;
    }
}

public class Rewards
{
    public Weapon Reward_weapon;
    public string Reward_other;
    public List <Weapon> Weapons = new();


    public Rewards(Weapon Reward_weapon)
    {
        this.Reward_weapon = Reward_weapon;

    }

    // geeft quest_id die gewonnen is
    // method gaat kijken om welke quest het gaat en geeft daarbij de behorende reward
    public void give_reward(int Quest_id)
    {   
        //Weapon rewarded_weapon = null;
        switch (Quest_id)
        {
            case World.QUEST_ID_CLEAR_ALCHEMIST_GARDEN:
                // maak obj voor Weapon class
                Weapon rewarded_poison = new Weapon(3, "snake poison", 20);
                // voeg obj toe aan list
                Weapons.Add(rewarded_poison);
                //new Rewards(rewarded_poison);
                Console.WriteLine($"You got rewarded with a {rewarded_poison.Name}.\nUse it on Rats so they die faster.");
                break;
            case World.QUEST_ID_CLEAR_FARMERS_FIELD:
                Weapon rewarded_weapon = new Weapon(4, "AK 47", 25);
                Weapons.Add(rewarded_weapon);
                //new Rewards(rewarded_weapon);
                Console.WriteLine($"You got rewarded with a {rewarded_weapon.Name}.");
                break;
            case World.QUEST_ID_COLLECT_SPIDER_SILK:
                Weapon reward_silk = new Weapon(5, "Spider slik", 0);
                Weapons.Add(reward_silk);
                Console.WriteLine($"You got rewarded with {reward_silk.Name}.");
                break;
            default:
                Console.WriteLine("Nothing for you buddy");
                break;
        }
    }


}

static class Program
{
    static void Main()
    {
        /*
        Rewards rewards = new Rewards(null);
        rewards.give_reward(3);
        rewards.give_reward(2);
        rewards.give_reward(1);
        foreach(var obj in rewards.Weapons)
        {
            Console.WriteLine(obj);
        }
        */
    }
}















