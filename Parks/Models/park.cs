using System.ComponentModel.DataAnnotations;

namespace Parks.Models
{
  public class Park
  {
    [Required]
    public int ParkId { get; set; }
    [Required]
    public string State { get; set; }
    [Required]
    public string Name {get; set;}
  
  }
}