using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Y.Contract.SharedKernel.Abstractions.Messaging;
public sealed record MessageMetadata
{
    public required string MessageKey { get; init; }
    public required string Topic { get; init; }
}
