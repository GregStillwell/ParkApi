using System.ComponentModel.DataAnnotations;

namespace ParksApi.Models
{
  public class Park
  {
    [Required]
    public int ParkId { get; set; }
    public string Name { get; set; }
    public string State {get; set;}
  
  }
}