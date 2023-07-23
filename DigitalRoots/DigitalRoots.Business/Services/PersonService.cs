using DigitalRoots.Business.Mappers;
using DigitalRoots.Models;
using DigitalRoots.Persistence.Entities;
using DigitalRoots.Persistence.Repositories;
using DigitalRoots.Utils;
using DigitalRoots.Utils.Exceptions;

namespace DigitalRoots.Business.Services;

public class PersonService : IPersonService
{
    private readonly IPersonRepository _personRepository;

    public PersonService(IPersonRepository personRepository)
    {
        _personRepository = personRepository;
    }

    public PersonModel GetPerson(long personId)
    {
        PersonEntity personEntity = _personRepository.GetPerson(personId);
        if (personEntity == null)
        {
            throw new CustomNotFoundException(ExceptionsSettings.NotFound);
        }
        return personEntity.MapToPersonModel();
    }

    public PersonModel CreatePerson(CreatePersonModel person)
    {
        PersonEntity personEntity = person.MapToPersonEntity();
        this._personRepository.CreatePerson(personEntity);
        return personEntity.MapToPersonModel();
    }

    public List<PersonModel> GetPeople()
    {
        return this._personRepository.GetPeople()
            .Select(x => x.MapToPersonModel()).ToList();
    }
}