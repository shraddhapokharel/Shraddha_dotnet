using ApexRestaurant.Repository.Domain;

namespace ApexRestaurant.Repository.RMenus
{
    public class MenusRepository : GenericRepository<Menus>, IMenusRepository
    {
        public MenusRepository(RestaurantContext dbContext)
        {
            DbContext = dbContext;
        }
    }
}
