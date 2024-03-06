using System.ComponentModel.DataAnnotations;

namespace EternaMVC.Models;

public class Service : BaseEntity
{
    [Required]
    [StringLength(50)]
    public string Title { get; set; }
    [Required]
    [StringLength(250)]
    public string Description { get; set; }
    public string IconName { get; set; }
}
