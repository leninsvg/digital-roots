using System.ComponentModel.DataAnnotations;
using DigitalRoots.Utils.Enums;

namespace DigitalRoots.Models;

public class PetModel
{
    public long Id { get; set; }
    public long OwnerId { get; set; }
    public string Name { get; set; }
    public string Gender { get; set; }
    public PeetCategoryEnum Category { get; set; }
}

public class CreatePetModel
{
    [Required]
    public long OwnerId { get; set; }

    [Required]
    public string Name { get; set; }

    [Required]
    public string Gender { get; set; }

    [Required]
    public PeetCategoryEnum Category { get; set; }
}