namespace AeronauticsX.Web.Data.Entities
{
    public class Plane : IEntity
    {
        public int Id { get; set; }


        public string Maker { get; set; }


        public string Model { get; set; }


        public string Name { get; set; }


        public bool Operational { get; set; }
    }
}
