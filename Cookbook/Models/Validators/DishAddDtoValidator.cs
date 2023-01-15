using FluentValidation;

namespace Cookbook.Models.Validators
{
	public class DishAddDtoValidator : AbstractValidator<DishAddDto>
	{
		public DishAddDtoValidator()
		{
			RuleFor(x => x.Name).NotEmpty();
			RuleFor(x => x.Name).MaximumLength(255);

			RuleForEach(x => x.Ingredients)
				.ChildRules(max =>
				{
					max.RuleFor(y => y.Name).MaximumLength(2);
				});
				
		}
	}
}
