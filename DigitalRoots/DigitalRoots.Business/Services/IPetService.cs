using DigitalRoots.Models;
using DigitalRoots.Utils.Enums;

namespace DigitalRoots.Business.Services;

public interface IPetService
{
     PetModel CreatePet(CreatePetModel pet);
     List<PetModel> GetPets(long ownerId);
     List<PetModel> GetPets(long ownerId, PeetCategoryEnum category);
}