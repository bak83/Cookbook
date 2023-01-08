using FluentValidation;

namespace Cookbook.Models.Validators
{
	public class DishAddDtoValidator : AbstractValidator<DishAddDto>
	{
		public DishAddDtoValidator()
		{
			RuleFor(x => x.Name).NotEmpty();
			RuleFor(x => x.Name).MaximumLength(15);
			RuleFor(x => x.Name).NotEmpty();
		}
	}
}
