using ApexRestaurant.Repository.Domain;
using ApexRestaurant.Repository.RMenus;

namespace ApexRestaurant.Services.SMenus
{
    public class MenusService : GenericService<Menus>, IMenusService
    {
        public MenusService(IMenusRepository MenusRepository) : base(MenusRepository)
        {

        }
    }
}