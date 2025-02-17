using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace TradesiesAPI.Models;

public class User
{
    [Key]
    [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
    public int Id {get; set;}
    public string FirstName {get; set;}
    public string LastName {get; set;}
    public string DateOfBirth {get; set;}
}
