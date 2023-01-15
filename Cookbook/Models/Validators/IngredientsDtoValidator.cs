using FluentValidation;

namespace Cookbook.Models.Validators
{
	public class IngredientsDtoValidator : AbstractValidator<IngredientsDto>
	{
		public IngredientsDtoValidator()
		{
			RuleFor(x => x.Name).NotEmpty();
			RuleFor(x => x.Name).MaximumLength(255);

			RuleFor(x => x.Description).MinimumLength(1000);
		}
	}
}
