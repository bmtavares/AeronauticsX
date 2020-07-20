namespace AeronauticsX.Web.Models.Entities
{
    public class Plane : IEntity
    {
        public int ID { get; set; }

        public string Maker { get; set; }

        public string Model { get; set; }

        public string Name { get; set; }
    }
}
