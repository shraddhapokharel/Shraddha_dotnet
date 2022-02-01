using ApexRestaurant.Repository.Domain;
using ApexRestaurant.Repository.RRef_staff_roles;

namespace ApexRestaurant.Services.SRef_staff_roles
{
    public class Ref_staff_rolesService : GenericService<Ref_staff_roles>, IRef_staff_rolesService
    {
        public Ref_staff_rolesService(IRef_staff_rolesRepository Ref_staff_rolesRepository) : base(Ref_staff_rolesRepository)
        {

        }
    }
}