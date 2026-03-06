public class Quest
{
    

    public int ID;
    public string Name;
    public string Description;

    public bool IsStarted;
    public bool IsCompleted;

    public Quest(int id, string name, string description)
    {
        ID = id;
        Name = name;
        Description = description;
        IsStarted = false;
        IsCompleted = false;
    }


    public void StartQuest()
    {
        IsStarted = true;

        Console.WriteLine($"Quest started: {Name}");
        Console.WriteLine(Description);
    }

    public void CompleteQuest()
    {
        IsCompleted = true;

        Console.WriteLine($"Quest completed: {Name}");
    }

}