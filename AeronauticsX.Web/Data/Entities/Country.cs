namespace AeronauticsX.Web.Data.Entities
{
    using System.ComponentModel.DataAnnotations;

    public class Country : IEntity
    {
        public int Id { get; set; }

        [Required]
        [MaxLength(50, ErrorMessage = "The field {0} cannot exceed {1} characters.")]
        public string Name { get; set; }
    }
}
