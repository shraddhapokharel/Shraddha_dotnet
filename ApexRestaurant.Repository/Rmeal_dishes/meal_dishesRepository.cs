using ApexRestaurant.Repository.Domain;

namespace ApexRestaurant.Repository.Rmeal_dishes
{
    public class MealDishesRepository : GenericRepository<meal_dishes>, Imeal_dishesRepository
    {
        public MealDishesRepository(RestaurantContext dbContext)
        {
            DbContext = dbContext;
        }
    }
}