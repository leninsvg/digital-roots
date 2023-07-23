using DigitalRoots.Persistence.Entities;

namespace DigitalRoots.Persistence.Repositories;

public class PersonRepository : IPersonRepository
{
    private readonly ApplicationDbContext _applicationDbContext;

    public PersonRepository(ApplicationDbContext applicationDbContext)
    {
        _applicationDbContext = applicationDbContext;
    }

    public PersonEntity GetPerson(long id)
    {
        return _applicationDbContext.People.FirstOrDefault(x => x.Id == id);
    }

    public List<PersonEntity> GetPeople(long id)
    {
        return _applicationDbContext.People.ToList();
    }

    public void CreatePerson(PersonEntity person)
    {
        _applicationDbContext.People.Add(person);
        _applicationDbContext.SaveChanges();
    }
}