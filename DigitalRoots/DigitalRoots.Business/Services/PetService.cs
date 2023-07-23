using System.Reflection;
using DigitalRoots.Business.Mappers;
using DigitalRoots.Models;
using DigitalRoots.Persistence.Entities;
using DigitalRoots.Persistence.Repositories;
using DigitalRoots.Utils;

namespace DigitalRoots.Business.Services;

public class PetService : IPetService
{
    private readonly IPetRepository _petRepository;
    private readonly IPersonRepository _personRepository;

    public PetService(IPetRepository petRepository, IPersonRepository personRepository)
    {
        _petRepository = petRepository;
        _personRepository = personRepository;
    }

    public PetModel CreatePet(CreatePetModel pet)
    {
        if (!this._personRepository.ExistPerson(pet.OwnerId))
        {
            throw new CustomAttributeFormatException(ExceptionsSettings.OwnerNotFound);
        }
        PetEntity petEntity = pet.MapToPetEntity();
        this._petRepository.CreatePet(petEntity);
        return petEntity.MapToPetModel();
    }

    public List<PetModel> GetPets(long ownerId)
    {
        if (!this._personRepository.ExistPerson(ownerId))
        {
            throw new CustomAttributeFormatException(ExceptionsSettings.OwnerNotFound);
        }
        return this._petRepository.GetPets(ownerId)
            .Select(x => x.MapToPetModel()).ToList();
    }
}