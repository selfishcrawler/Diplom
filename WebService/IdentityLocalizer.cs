using Microsoft.AspNetCore.Identity;

namespace WebService;

public sealed class IdentityLocalizer : IdentityErrorDescriber
{
    private readonly IdentityError passwordRequiresNonAlphanumericError;

    public IdentityLocalizer()
    {
        passwordRequiresNonAlphanumericError = new()
        {
            Description = "Пароль должен содержать символы",
        };
    }

    public override IdentityError PasswordRequiresNonAlphanumeric() => passwordRequiresNonAlphanumericError;
}
