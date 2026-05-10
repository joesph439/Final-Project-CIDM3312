namespace Final_Project_CIDM3312.Models;

public class Stats
{
    public int StatsID {get; set;}

    public int Health {get; set;}

    public int Mana {get; set;}

    public int Strength {get; set;}

    public int Intelligence {get; set;}

    public int Willpower {get; set;}

    public int Agility {get; set;}

    public int Luck {get; set;}

    public int CharacterID {get; set;}

    public List<Character> Characters {get; set;} = default!;
}