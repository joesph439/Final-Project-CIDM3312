using Microsoft.AspNetCore.SignalR;

namespace Final_Project_CIDM3312.Models;

public class Character
{
    public int CharacterID {get; set;}

    public string Name {get; set;} = string.Empty;

    public string Class {get; set;} = string.Empty;

    public int Level {get; set;}

    public int XP {get; set;}

    public int PlayerID {get; set;}

    public Player Player { get; set; } = default!;
    public Stats Stats { get; set; } = default!;
}