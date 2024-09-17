using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
namespace DemoMVC.Models.Entities
{
    public class Student{
        [Key]
        public string Ho_Ten{ get; set; }

        public string Student_Id{ get; set; }
    }
}
