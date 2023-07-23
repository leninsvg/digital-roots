using DigitalRoots.Models;

namespace DigitalRoots.Business.Services;

public interface IPersonService
{
    PersonModel GetPerson(long personId);
    PersonModel CreatePerson(CreatePersonModel person);
    List<PersonModel> GetPeople();
}