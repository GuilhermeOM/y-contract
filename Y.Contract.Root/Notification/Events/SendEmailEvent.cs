using Y.Contract.Root.Notification.Shared;
using Y.Contract.SharedKernel;

namespace Y.Contract.Root.Notification.Events;
public sealed record SendEmailEvent : Event
{
    public static string Exchange => "send-notification";
    public static string RoutingKey => "send.email";

    public required string Email { get; set; }
    public EmailTemplate Template { get; set; } = EmailTemplate.UNKNOWN;
    public Dictionary<string, string> Properties { get; } = [];
}
