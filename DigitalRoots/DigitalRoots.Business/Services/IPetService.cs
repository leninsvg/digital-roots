using DigitalRoots.Models;

namespace DigitalRoots.Business.Services;

public interface IPetService
{
     PetModel CreatePet(CreatePetModel pet);
}