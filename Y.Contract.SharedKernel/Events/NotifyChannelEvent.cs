using Y.Contract.SharedKernel.Abstractions;

namespace Y.Contract.SharedKernel.Events;
public sealed record NotifyChannelEvent : IKafkaMessage
{
    public EmailTemplate EmailTemplate { get; set; } = EmailTemplate.Unknown;
    public WhatsappTemplate WhatsappTemplate { get; set; } = WhatsappTemplate.Unknown; 
    public Channel Channel { get; set; } = Channel.Unknown;
    public Dictionary<string, string> Properties { get; set; } = [];
}

public enum EmailTemplate
{
    Unknown = 0,
    AccountVerification = 1,
}

public enum WhatsappTemplate
{
    Unknown = 0
}

public enum Channel
{
    Unknown = 0,
    Email = 1,
}
