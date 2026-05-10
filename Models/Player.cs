using System.ComponentModel.DataAnnotations;
using Microsoft.AspNetCore.OutputCaching;

namespace Final_Project_CIDM3312.Models;

public class Player
{
    public int PlayerID {get; set;}

    public string PlayerName {get; set;} = string.Empty;

    public int Currency {get; set;}
}