using BackendDndBoek.Models;

namespace BackendDndBoek.Data;

public class CharacterData
{
    public List<Character> Characters { get; } =
    [
        new Character
        {
            Id = 1,
            Name = "Mira Thorn",
            Level = 4,
            Race = "Wood Elf",
            Class = "Ranger",
            Background = "Verhaal van Matthijs",
            Strength = 10,
            Dexterity = 16,
            Constitution = 13,
            Intelligence = 12,
            Wisdom = 15,
            Charisma = 8
        }
    ];
}