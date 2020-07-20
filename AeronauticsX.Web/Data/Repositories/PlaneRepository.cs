using AeronauticsX.Web.Models.Entities;

namespace AeronauticsX.Web.Models
{
    public class PlaneRepository : GenericRepository<Plane>, IPlaneRepository
    {
        public PlaneRepository(DataContext context) : base(context) { }
    }
}
