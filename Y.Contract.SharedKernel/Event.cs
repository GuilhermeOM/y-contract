namespace Y.Contract.SharedKernel;
public record Event
{
    public required string CorrelationId { get; set; }
}
