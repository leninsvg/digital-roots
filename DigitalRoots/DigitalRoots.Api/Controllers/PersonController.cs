using DigitalRoots.Business.Services;
using DigitalRoots.Models;
using Microsoft.AspNetCore.Mvc;

namespace DigitalRoots.Api.Controllers;

[ApiController]
[Route("person")]
public class PersonController : ControllerBase
{
    private readonly IPersonService _personService;

    public PersonController(IPersonService personService)
    {
        _personService = personService;
    }

    [HttpGet("{personId:long}")]
    public ActionResult<PersonModel> GetPerson([FromRoute] long personId)
    {
        return Ok(_personService.GetPerson(personId));
    }
    
    [HttpPost]
    public ActionResult<PersonModel> CreatePerson([FromBody] CreatePersonModel person)
    {
        return Ok(_personService.CreatePerson(person));
    }
}