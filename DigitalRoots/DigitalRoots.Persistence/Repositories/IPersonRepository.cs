using DigitalRoots.Persistence.Entities;

namespace DigitalRoots.Persistence.Repositories;

public interface IPersonRepository
{
    PersonEntity GetPerson(long id);
    List<PersonEntity> GetPeople();
    void CreatePerson(PersonEntity person);
}