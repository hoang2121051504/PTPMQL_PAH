using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
namespace DemoMVC.Models.Entities
{
    public class Student{
        [Key]
        public required string Ho_Ten{ get; set; }

        public required string Student_Id{ get; set; }
    }
}
