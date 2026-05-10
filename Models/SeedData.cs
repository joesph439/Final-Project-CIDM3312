using Microsoft.EntityFrameworkCore;

namespace Final_Project_CIDM3312.Models;
public static class SeedData
{
    public static void Initialize(IServiceProvider serviceProvider)
    {
        using var context = new AppDbContext(serviceProvider.GetRequiredService<DbContextOptions<AppDbContext>>());

        if (context.Players.Any())
        {
            return;
        }

        List<Player> players = new List<Player>
        {
            new Player { PlayerID = 1, PlayerName = "ShadowBlade", Currency = 1500 },
            new Player { PlayerID = 2, PlayerName = "IronFist", Currency = 2300 },
            new Player { PlayerID = 3, PlayerName = "StormRider", Currency = 800 },
            new Player { PlayerID = 4, PlayerName = "VoidWalker", Currency = 4100 },
            new Player { PlayerID = 5, PlayerName = "CrimsonArrow", Currency = 650 },
            new Player { PlayerID = 6, PlayerName = "FrostQueen", Currency = 3200 }
        };

        context.AddRange(players);
        context.SaveChanges();

        List<Character> characters = new List<Character>
        {
            // ShadowBlade's Characters
            new Character { CharacterID = 1, Name = "Nyxara", Class = "Rogue", Level = 12, XP = 4500, PlayerID = 1 },
            new Character { CharacterID = 2, Name = "Duskmantle", Class = "Ranger", Level = 8, XP = 2100, PlayerID = 1 },
            new Character { CharacterID = 3, Name = "Vexis", Class = "Assassin", Level = 15, XP = 7800, PlayerID = 1 },

            // IronFist's Characters
            new Character { CharacterID = 4, Name = "Brakkor", Class = "Warrior", Level = 20, XP = 12000, PlayerID = 2 },
            new Character { CharacterID = 5, Name = "Stonehide", Class = "Paladin", Level = 18, XP = 9500, PlayerID = 2 },
            new Character { CharacterID = 6, Name = "Grumdar", Class = "Berserker", Level = 14, XP = 6200, PlayerID = 2 },
            new Character { CharacterID = 7, Name = "Aegis", Class = "Guardian", Level = 11, XP = 3800, PlayerID = 2 },

            // StormRider's Characters
            new Character { CharacterID = 8, Name = "Zephyra", Class = "Mage", Level = 6, XP = 1200, PlayerID = 3 },
            new Character { CharacterID = 9, Name = "Thunderpaw", Class = "Druid", Level = 5, XP = 900, PlayerID = 3 },

            // VoidWalker's Characters
            new Character { CharacterID = 10, Name = "Malachar", Class = "Warlock", Level = 25, XP = 22000, PlayerID = 4 },
            new Character { CharacterID = 11, Name = "Obsidian", Class = "Necromancer", Level = 22, XP = 17500, PlayerID = 4 },
            new Character { CharacterID = 12, Name = "Riftborn", Class = "Sorcerer", Level = 19, XP = 11000, PlayerID = 4 },

            // CrimsonArrow's Characters
            new Character { CharacterID = 13, Name = "Fletchwind", Class = "Archer", Level = 4, XP = 750, PlayerID = 5 },
            new Character { CharacterID = 14, Name = "Scarlet", Class = "Rogue", Level = 7, XP = 1800, PlayerID = 5 },
            new Character { CharacterID = 15, Name = "Embershot", Class = "Ranger", Level = 5, XP = 1100, PlayerID = 5 },

            // FrostQueen's Characters
            new Character { CharacterID = 16, Name = "Glaciara", Class = "Mage", Level = 21, XP = 14000, PlayerID = 6 },
            new Character { CharacterID = 17, Name = "Permafrost", Class = "Paladin", Level = 17, XP = 8800, PlayerID = 6 },
            new Character { CharacterID = 18, Name = "Snowveil", Class = "Druid", Level = 13, XP = 5300, PlayerID = 6 },
            new Character { CharacterID = 19, Name = "Crystalyn", Class = "Sorcerer", Level = 16, XP = 7200, PlayerID = 6 }
   
        };

        context.AddRange(characters);
        context.SaveChanges();

        List<Stats> Statss = new List<Stats>
        {
            // Nyxara - Rogue Lv12
            new Stats { StatsID = 1, Health = 880, Mana = 420, Strength = 65, Intelligence = 50, Willpower = 40, Agility = 90, Luck = 75, CharacterID = 1 },

            // Duskmantle - Ranger Lv8
            new Stats { StatsID = 2, Health = 720, Mana = 380, Strength = 55, Intelligence = 45, Willpower = 38, Agility = 78, Luck = 60, CharacterID = 2 },

            // Vexis - Assassin Lv15
            new Stats { StatsID = 3, Health = 950, Mana = 400, Strength = 80, Intelligence = 55, Willpower = 42, Agility = 98, Luck = 85, CharacterID = 3 },

            // Brakkor - Warrior Lv20
            new Stats { StatsID = 4, Health = 1800, Mana = 200, Strength = 110, Intelligence = 30, Willpower = 75, Agility = 50, Luck = 40, CharacterID = 4 },

            // Stonehide - Paladin Lv18
            new Stats { StatsID = 5, Health = 1650, Mana = 620, Strength = 90, Intelligence = 65, Willpower = 95, Agility = 45, Luck = 50, CharacterID = 5 },

            // Grumdar - Berserker Lv14
            new Stats { StatsID = 6, Health = 1200, Mana = 150, Strength = 105, Intelligence = 20, Willpower = 55, Agility = 65, Luck = 35, CharacterID = 6 },

            // Aegis - Guardian Lv11
            new Stats { StatsID = 7, Health = 1400, Mana = 300, Strength = 75, Intelligence = 40, Willpower = 85, Agility = 40, Luck = 45, CharacterID = 7 },

            // Zephyra - Mage Lv6
            new Stats { StatsID = 8, Health = 480, Mana = 850, Strength = 25, Intelligence = 88, Willpower = 70, Agility = 42, Luck = 55, CharacterID = 8 },

            // Thunderpaw - Druid Lv5
            new Stats { StatsID = 9, Health = 520, Mana = 700, Strength = 35, Intelligence = 75, Willpower = 80, Agility = 38, Luck = 50, CharacterID = 9 },

            // Malachar - Warlock Lv25
            new Stats { StatsID = 10, Health = 1100, Mana = 1800, Strength = 50, Intelligence = 130, Willpower = 110, Agility = 60, Luck = 70, CharacterID = 10 },

            // Obsidian - Necromancer Lv22
            new Stats { StatsID = 11, Health = 980, Mana = 1600, Strength = 45, Intelligence = 120, Willpower = 105, Agility = 52, Luck = 65, CharacterID = 11 },

            // Riftborn - Sorcerer Lv19
            new Stats { StatsID = 12, Health = 850, Mana = 1400, Strength = 40, Intelligence = 115, Willpower = 95, Agility = 58, Luck = 72, CharacterID = 12 },

            // Fletchwind - Archer Lv4
            new Stats { StatsID = 13, Health = 400, Mana = 250, Strength = 38, Intelligence = 30, Willpower = 28, Agility = 70, Luck = 65, CharacterID = 13 },

            // Scarlet - Rogue Lv7
            new Stats { StatsID = 14, Health = 620, Mana = 300, Strength = 50, Intelligence = 38, Willpower = 32, Agility = 82, Luck = 70, CharacterID = 14 },

            // Embershot - Ranger Lv5
            new Stats { StatsID = 15, Health = 500, Mana = 280, Strength = 42, Intelligence = 35, Willpower = 30, Agility = 72, Luck = 58, CharacterID = 15 },

            // Glaciara - Mage Lv21
            new Stats { StatsID = 16, Health = 900, Mana = 1750, Strength = 30, Intelligence = 125, Willpower = 100, Agility = 55, Luck = 68, CharacterID = 16 },

            // Permafrost - Paladin Lv17
            new Stats { StatsID = 17, Health = 1500, Mana = 580, Strength = 85, Intelligence = 60, Willpower = 90, Agility = 42, Luck = 48, CharacterID = 17 },

            // Snowveil - Druid Lv13
            new Stats { StatsID = 18, Health = 950, Mana = 1100, Strength = 48, Intelligence = 92, Willpower = 88, Agility = 50, Luck = 62, CharacterID = 18 },

            // Crystalyn - Sorcerer Lv16
            new Stats { StatsID = 19, Health = 780, Mana = 1300, Strength = 35, Intelligence = 108, Willpower = 88, Agility = 56, Luck = 70, CharacterID = 19 }

        };

        context.AddRange(Statss);
        context.SaveChanges();
    }
}