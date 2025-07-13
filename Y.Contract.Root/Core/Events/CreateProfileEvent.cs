using Y.Contract.SharedKernel;

namespace Y.Contract.Root.Core.Events;
public sealed record CreateProfileEvent : Event
{
    public static string Exchange => "create-profile";

    public required Guid UserId { get; set; }
    public string Name { get; set; } = string.Empty;
}
