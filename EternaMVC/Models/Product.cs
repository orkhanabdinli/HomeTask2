using System.ComponentModel.DataAnnotations;

namespace EternaMVC.Models;

public class Product : BaseEntity
{
    public int CategoryId { get; set; }
    [Required]
    [StringLength(50)]
    public string Name { get; set; }
    [Required]
    [StringLength(50)]
    public string Title { get; set; }
    [Required]
    [StringLength(250)]
    public string Description { get; set; }
    [Required]
    [StringLength(50)]
    public string Client { get; set; }
    public string ProjectUrl { get; set; }
    public Category Category { get; set; }
    public List<ProductImage> ProductImages { get; set; }
}
