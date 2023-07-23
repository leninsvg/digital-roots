using DigitalRoots.Models;
using DigitalRoots.Persistence.Entities;

namespace DigitalRoots.Business.Mappers;

public static class PersonMapper
{
    public static PersonEntity MapToPersonEntity(this PersonModel person)
    {
        return new PersonEntity
        {
            Age = person.Age,
            Id = person.Id,
            FirstName = person.FirstName,
            LastName = person.LastName
        };
    }

    public static PersonModel MapToPersonModel(this PersonEntity person)
    {
        return new PersonModel
        {
            Age = person.Age,
            Id = person.Id,
            FirstName = person.FirstName,
            LastName = person.LastName
        };
    }
}