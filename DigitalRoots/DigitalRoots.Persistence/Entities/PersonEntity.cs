using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace DigitalRoots.Persistence.Entities;

[Table("Person")]
public class PersonEntity : BaseEntity
{
    [MaxLength(64)]
    [Required]
    public string FirstName { get; set; }

    [MaxLength(64)]
    [Required]
    public string LastName { get; set; }

    [Required]
    public int Age { get; set; }

    private ICollection<PeetEntity> Peets { get; set; }
}