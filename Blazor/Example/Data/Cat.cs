using System.ComponentModel.DataAnnotations;

namespace Example.Data{
public class Cat{
    
    public int Id { get; set; }
    
    [MinLength(3)]
    public string Name { get; set; }
    
    [MinLength(3)]
    [Required]
    public string Race { get; set; }
    
    public string ImageURL { get; set; }
}
}