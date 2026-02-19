using System.ComponentModel.DataAnnotations;

namespace WebApplication1.Models
{
    public class Student
    {
        [Required]public int id { get; set; }

        [Required]public string name { get; set; }
        [Required][Range(18, 60)] public int age { get; set; }
        
        [Required][EmailAddress] public string emailid{ get; set; }

    }
}
