using DigitalRoots.Business.Services;
using DigitalRoots.Models;
using DigitalRoots.Utils.Enums;
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
    
    [HttpGet("{ownerId:long}/{category}")]
    public ActionResult<PetModel> GetPets([FromRoute] long ownerId, [FromRoute] PeetCategoryEnum category)
    {
        return Ok(this._petService.GetPets(ownerId, category));
    }
    
    [HttpPost]
    public ActionResult<PetModel> CreatePet([FromBody] CreatePetModel pet)
    {
        return Ok(this._petService.CreatePet(pet));
    }
}