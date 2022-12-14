using System.ComponentModel.DataAnnotations;

namespace GraphQL.Models;

public sealed class Speaker
{
    public long Id { get; init; }

    [Required]
    [StringLength(200)]
    public string? Name { get; set; }

    [StringLength(4000)]
    public string? Bio { get; set; }

    [StringLength(1000)]
    public string? WebSite { get; set; }

    public ICollection<SessionSpeaker> SessionSpeakers { get; set; } = 
        new List<SessionSpeaker>();
}