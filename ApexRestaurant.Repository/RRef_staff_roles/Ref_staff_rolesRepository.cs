using ApexRestaurant.Repository.Domain;

namespace ApexRestaurant.Repository.RRef_staff_roles
{
    public class Ref_staff_rolesRepository : GenericRepository<Ref_staff_roles>, IRef_staff_rolesRepository
    {
        public Ref_staff_rolesRepository(RestaurantContext dbContext)
        {
            DbContext = dbContext;
        }
    }
}
