using ApexRestaurant.Repository.Domain;
using ApexRestaurant.Repository.Rmeal_dishes;

namespace ApexRestaurant.Services.Smeal_dishes
{
    public class meal_dishesService : GenericService<meal_dishes>, Imeal_dishesService
    {
        public meal_dishesService(Imeal_dishesRepository meal_dishesRepository) : base(meal_dishesRepository)
        {

        }
    }
}