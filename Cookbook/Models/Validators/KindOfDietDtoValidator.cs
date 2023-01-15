using Cookbook.Entities;
using FluentValidation;

namespace Cookbook.Models
{
	public class KindOfDietDtoValidator : AbstractValidator<KindOfDietDto>
	{
		public KindOfDietDtoValidator()
		{
			RuleFor(c => c.kindOfDiet).MaximumLength(5);
		}
	}
}
