using System.ComponentModel.DataAnnotations;

namespace EternaMVC.Models;

public class About : BaseEntity
{
    [Required]
    [StringLength(250)]
    public string Title { get; set; }
    [Required]
    [StringLength(250)]
    public string Description { get; set; }
    [Required]
    [StringLength(250)]
    public string List1 { get; set; }
    [Required]
    [StringLength(250)]
    public string List2 { get; set; }
    [Required]
    [StringLength(250)]
    public string List3 { get; set; }
    [Required]
    [StringLength(300)]
    public string Description2 { get; set; }
    public string Picture { get; set; }
}
