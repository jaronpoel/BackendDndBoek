using BackendDndBoek.Models;
using BackendDndBoek.Services;
using Microsoft.AspNetCore.Mvc;

namespace BackendDndBoek.Controllers;

[ApiController]
[Route("api/characters")]
public class CharacterController : ControllerBase
{
    private readonly ICharacterService _characterService;

    public CharacterController(ICharacterService characterService)
    {
        _characterService = characterService;
    }

    [HttpGet]
    public ActionResult<IEnumerable<Character>> GetAll()
    {
        return Ok(_characterService.GetAllCharacters());
    }

    [HttpGet("{id:int}")]
    public ActionResult<Character> GetById(int id)
    {
        var character = _characterService.GetCharacterById(id);

        if (character == null)
        {
            return NotFound();
        }

        return Ok(character);
    }

    [HttpPost]
    public ActionResult<Character> AddCharacter([FromBody] Character character)
    {
        character.Id = _characterService.GetNextId();
        _characterService.AddCharacter(character);

        return CreatedAtAction(nameof(GetById), new { id = character.Id }, character);
    }

    [HttpPut("{id:int}")]
    public IActionResult UpdateCharacter(int id, [FromBody] Character updatedCharacter)
    {
        var character = _characterService.GetCharacterById(id);

        if (character == null)
        {
            return NotFound();
        }

        updatedCharacter.Id = id;
        _characterService.UpdateCharacter(updatedCharacter);

        return Ok(updatedCharacter);
    }

    [HttpDelete("{id:int}")]
    public IActionResult DeleteCharacter(int id)
    {
        if (!_characterService.DeleteCharacter(id))
        {
            return NotFound();
        }

        return NoContent();
    }
}