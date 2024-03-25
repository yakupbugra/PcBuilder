
using System.ComponentModel.DataAnnotations;
using PcBuilder.Domain.Shared;

namespace PcBuilder.Product.Domain
{
    public class Brand : Entity
    {
        public Brand()
        {

        }
        [Required]
        public string Name { get; set; }
    }
}