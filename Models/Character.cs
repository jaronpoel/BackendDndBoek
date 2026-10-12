using System.ComponentModel.DataAnnotations;

namespace BackendDndBoek.Models;

public class Character
{
    public int Id { get; set; }

    [Required]
    public string Name { get; set; } = string.Empty;

    [Range(1, 20)]
    public int Level { get; set; }

    [Required]
    public string Race { get; set; } = string.Empty;

    [Required]
    public string Class { get; set; } = string.Empty;

    public string Background { get; set; } = string.Empty;

    [Range(1, 30)]
    public int Strength { get; set; }

    [Range(1, 30)]
    public int Dexterity { get; set; }

    [Range(1, 30)]
    public int Constitution { get; set; }

    [Range(1, 30)]
    public int Intelligence { get; set; }

    [Range(1, 30)]
    public int Wisdom { get; set; }

    [Range(1, 30)]
    public int Charisma { get; set; }
}