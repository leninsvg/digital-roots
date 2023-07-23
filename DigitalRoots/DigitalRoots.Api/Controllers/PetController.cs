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

    [HttpPost]
    public ActionResult<PetModel> Cre([FromBody] CreatePetModel pet)
    {
        return Ok(this._petService.CreatePet(pet));
    }
}