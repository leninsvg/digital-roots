using DigitalRoots.Models;
using DigitalRoots.Persistence.Entities;

namespace DigitalRoots.Business.Mappers;

public static class PetMapper
{
    public static PetEntity MapToPetEntity(this CreatePetModel pet)
    {
        return new PetEntity
        {
            Category = pet.Category,
            Gender = pet.Gender,
            Name = pet.Name,
            OwnerId = pet.OwnerId
        };
    }

    public static PetModel MapToPetModel(this PetEntity pet)
    {
        return new PetModel
        {
            Id = pet.Id,
            Category = pet.Category,
            Gender = pet.Gender,
            Name = pet.Name,
            OwnerId = pet.OwnerId
        };
    }
}