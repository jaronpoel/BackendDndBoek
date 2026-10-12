using BackendDndBoek.Data;
using BackendDndBoek.Models;

namespace BackendDndBoek.Services;

public class CharacterService : ICharacterService
{
    private readonly List<Character> _characters;

    public CharacterService(CharacterData characterData)
    {
        _characters = characterData.Characters;
    }

    public IEnumerable<Character> GetAllCharacters()
    {
        return _characters;
    }

    public Character? GetCharacterById(int id)
    {
        return _characters.FirstOrDefault(character => character.Id == id);
    }

    public int GetNextId()
    {
        return _characters.Count == 0 ? 1 : _characters.Max(character => character.Id) + 1;
    }

    public void AddCharacter(Character character)
    {
        _characters.Add(character);
    }

    public void UpdateCharacter(Character character)
    {
        var index = _characters.FindIndex(existingCharacter => existingCharacter.Id == character.Id);

        if (index >= 0)
        {
            _characters[index] = character;
        }
    }

    public bool DeleteCharacter(int id)
    {
        var character = GetCharacterById(id);

        return character != null && _characters.Remove(character);
    }
}