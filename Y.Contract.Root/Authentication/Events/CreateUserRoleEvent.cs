using Y.Contract.Root.Authentication.Shared;
using Y.Contract.SharedKernel;

namespace Y.Contract.Root.Authentication.Events;
public sealed record CreateUserRoleEvent : Event
{
    public static string Exchange => "create-user-role";

    public required Guid UserId { get; set; }
    public required Role Role { get; set; }
}
