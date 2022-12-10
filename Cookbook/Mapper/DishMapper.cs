using AutoMapper;

namespace Cookbook.Mapper
{
	public class DishMapper: Profile
	{
		public DishMapper()
		{
			CreateMap<Entities.Dishes, Models.DishDto>();
			CreateMap<Models.DishDto, Entities.Dishes>();

		}
	}
}
