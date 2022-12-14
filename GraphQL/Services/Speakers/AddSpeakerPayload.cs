using GraphQL.Models;

namespace GraphQL.Services.Speakers;

public class AddSpeakerPayload
{
    public AddSpeakerPayload(Speaker speaker)
    {
        Speaker = speaker;
    }

    public Speaker Speaker { get; }
}