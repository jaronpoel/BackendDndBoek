using BackendDndBoek.Models;

namespace BackendDndBoek.Services;

public interface ICharacterService
{
    IEnumerable<Character> GetAllCharacters();

    Character? GetCharacterById(int id);

    int GetNextId();

    void AddCharacter(Character character);

    void UpdateCharacter(Character character);

    bool DeleteCharacter(int id);
}