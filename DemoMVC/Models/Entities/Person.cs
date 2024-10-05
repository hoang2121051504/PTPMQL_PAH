namespace DemoMVC.Models.Entities{

using System.ComponentModel.DataAnnotations;

public class Person {
    [Key]
    public string  PersonId { get; set; }

    public string HoTen{ get; set; }

    public string QueQuan   { get; set; }
}
}