namespace GraphQL.Services.Speakers;

public record AddSpeakerInput(
    string Name,
    string? Bio,
    string? WebSite
);
