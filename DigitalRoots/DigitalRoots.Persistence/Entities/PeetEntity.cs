using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using DigitalRoots.Utils.Enums;

namespace DigitalRoots.Persistence.Entities;

[Table("Peet")]
public class PeetEntity : BaseEntity
{
    public long OwnerId { get; set; }

    [MaxLength(64)]
    [Required]
    public string Name { get; set; }

    [Required]
    public string Gender { get; set; }

    [Required]
    public PeetCategoryEnum Category { get; set; }

    [ForeignKey("OwnerId")]
    private PersonEntity Owner { get; set; }
}