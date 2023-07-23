using DigitalRoots.Persistence.Entities;
using DigitalRoots.Utils.Enums;

namespace DigitalRoots.Persistence.Repositories;

public interface IPetRepository
{
    List<PetEntity> GetPets(long ownerId);
    List<PetEntity> GetPets(long ownerId, PeetCategoryEnum category);
    void CreatePet(PetEntity pet);
}