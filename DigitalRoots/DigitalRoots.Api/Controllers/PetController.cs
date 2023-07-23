using DigitalRoots.Business.Services;
using DigitalRoots.Models;
using Microsoft.AspNetCore.Mvc;

namespace DigitalRoots.Api.Controllers;

[ApiController]
[Route("pet")]
public class PetController : ControllerBase
{
    private readonly IPetService _petService;

    public PetController(IPetService petService)
    {
        _petService = petService;
    }

    [HttpGet("{ownerId:long}")]
    public ActionResult<PetModel> GetPets([FromRoute] long ownerId)
    {
        return Ok(this._petService.GetPets(ownerId));
    }
    
    [HttpPost]
    public ActionResult<PetModel> CreatePet([FromBody] CreatePetModel pet)
    {
        return Ok(this._petService.CreatePet(pet));
    }
}