
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace TradesiesAPI.Models;

public class Address
{
    [Key]
    [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
    public int Id {get; set;}
    public required string Line1 {get; set;}
    public required string Line2 {get; set;}
    public required string City {get; set;}
    public required string State {get; set;}
    public required string PostalCode {get; set;}
    public required string Type {get; set;}
}
