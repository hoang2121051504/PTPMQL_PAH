namespace DemoMVC.Models.Entities{

using System.ComponentModel.DataAnnotations;

public class Person {
    [Key]
    public required string  PersonId { get; set; }

    public required string HoTen{ get; set; }

    public string? QueQuan   { get; set; }
}
}