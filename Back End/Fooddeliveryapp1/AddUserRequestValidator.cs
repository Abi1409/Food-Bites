using FluentValidation;
using Fooddeliveryapp1.DTO;

namespace Fooddeliveryapp1
{
    public class AddUserRequestValidator : AbstractValidator<AddUserRequestDTO>
    {
        public AddUserRequestValidator()
        {
            RuleFor(dto => dto.Email).NotEmpty().EmailAddress();
            RuleFor(dto => dto.Password).NotEmpty().MinimumLength(8);

        }
    }
}
