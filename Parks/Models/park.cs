using System.ComponentModel.DataAnnotations;

namespace Parks.Models
{
  public class Park
  {
    [Required]
    public int ParkId { get; set; }
    public string State { get; set; }
    public string Name {get; set;}
  
  }
}