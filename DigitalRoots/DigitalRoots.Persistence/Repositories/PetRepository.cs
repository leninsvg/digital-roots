using DigitalRoots.Persistence.Entities;
using DigitalRoots.Utils.Enums;

namespace DigitalRoots.Persistence.Repositories;

public class PetRepository : IPetRepository
{
    private readonly ApplicationDbContext _applicationDbContext;

    public PetRepository(ApplicationDbContext applicationDbContext)
    {
        _applicationDbContext = applicationDbContext;
    }

    public List<PetEntity> GetPets(long ownerId)
    {
        return _applicationDbContext.Pets
            .Where(x => x.OwnerId == ownerId).ToList();
    }

    public List<PetEntity> GetPets(long ownerId, PeetCategoryEnum category)
    {
        return _applicationDbContext.Pets
            .Where(x => x.OwnerId == ownerId)
            .Where(x => x.Category == category)
            .ToList();
    }

    public void CreatePet(PetEntity pet)
    {
        _applicationDbContext.Pets.Add(pet);
        _applicationDbContext.SaveChanges();
    }
}