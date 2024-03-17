using System.ComponentModel.DataAnnotations;

namespace EternaMVC.Models;

public class Category : BaseEntity
{
    [Required]
    [StringLength(50)]
    public string Name { get; set; }
    public List<Product> Products { get; set; }
}
