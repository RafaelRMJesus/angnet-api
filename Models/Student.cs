using System.ComponentModel.DataAnnotations;

namespace angnet_api.Models
{
  public class Student
  {
    public int Id { get; set; }
    [Required]
    public string Name { get; set; } = string.Empty;
    public string? Adress { get; set; }
    public string? PhoneNumber { get; set; }
    public string? Email { get; set; }
  }
}