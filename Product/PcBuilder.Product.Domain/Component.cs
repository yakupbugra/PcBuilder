using PcBuilder.Domain.Shared;

namespace PcBuilder.Product.Domain;

public class Component : Entity
{
    public string Name { get; set; }
    public int BrandId { get; set; }
    public int CategoryId { get; set; }
    public virtual Brand Brand { get; set; }
    public virtual Category Category { get; set; }
}
