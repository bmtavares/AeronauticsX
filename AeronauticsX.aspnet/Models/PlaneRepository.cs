using AeronauticsX.aspnet.Models.Entities;

namespace AeronauticsX.aspnet.Models
{
    public class PlaneRepository : GenericRepository<Plane>, IPlaneRepository
    {
        public PlaneRepository(DataContext context) : base(context) { }
    }
}
