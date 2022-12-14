using System.ComponentModel.DataAnnotations;

namespace GraphQL.Models;

public class Track
{
    public int Id { get; init; }

    [Required]
    [StringLength(200)]
    public string? Name { get; set; }

    public ICollection<Session> Sessions { get; set; } = 
        new List<Session>();
}
