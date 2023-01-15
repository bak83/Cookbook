using FluentValidation;

namespace Cookbook.Models.Validators
{
	public class DishDtoValidator : AbstractValidator<DishDto>
	{
		public DishDtoValidator()
		{
			RuleFor(x => x.Name).NotEmpty();
			RuleFor(x => x.Name).MaximumLength(255);
		}
	}
}
