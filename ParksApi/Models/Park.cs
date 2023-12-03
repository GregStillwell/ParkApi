using System.ComponentModel.DataAnnotations;

namespace ParksApi.Models
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