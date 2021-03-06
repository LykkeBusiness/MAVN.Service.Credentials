using FluentValidation;
using JetBrains.Annotations;
using MAVN.Service.Credentials.Client.Models.Requests;

namespace MAVN.Service.Credentials.Models.Validation
{
    [UsedImplicitly]
    public class GenerateClientSecretRequestValidator : AbstractValidator<GenerateClientSecretRequest>
    {
        public GenerateClientSecretRequestValidator()
        {
            RuleFor(x => x.Length)
                .InclusiveBetween(8, 100)
                .WithMessage("A valid Length between 8 and 100 (inclusive) is required.");

        }
    }
}