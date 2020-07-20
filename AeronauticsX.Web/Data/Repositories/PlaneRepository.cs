namespace AeronauticsX.Web.Data.Repositories
{
    using AeronauticsX.Web.Data.Entities;

    public class PlaneRepository : GenericRepository<Plane>, IPlaneRepository
    {
        public PlaneRepository(DataContext context) : base(context) { }
    }
}
