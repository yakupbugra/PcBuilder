using System.ComponentModel.DataAnnotations;

namespace PcBuilder.Domain.Shared;

public class Entity
{
    [Required]
    public int Id { get; set; }
}
