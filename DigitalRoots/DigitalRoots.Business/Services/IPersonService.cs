using DigitalRoots.Models;

namespace DigitalRoots.Business.Services;

public interface IPersonService
{
    PersonModel GetPerson(long personId);
    PersonModel GetPeople();
}