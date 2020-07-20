namespace AeronauticsX.Web.Data.Entities
{
    using System.ComponentModel.DataAnnotations;
    using Microsoft.AspNetCore.Identity;

    public enum UserRoles
    {
        Customer,
        Employee,
        Admin
    }

    public class User : IdentityUser
    {
        [Display(Name = "First Name")]
        [MaxLength(50, ErrorMessage = "The field {0} cannot exceed {1} characters.")]
        public string FirstName { get; set; }


        [Display(Name = "Last Name")]
        [MaxLength(50, ErrorMessage = "The field {0} cannot exceed {1} characters.")]
        public string LastName { get; set; }


        [Display(Name = "Address Line 1")]
        public string Address1 { get; set; }


        [Display(Name = "Address Line 2")]
        public string Address2 { get; set; }


        [Display(Name = "City")]
        public string City { get; set; }


        public int CountryId { get; set; }


        public Country Country { get; set; }


        [Display(Name = "Zip Code")]
        public string ZipCode { get; set; }


        public string FullName
        {
            get => $"{FirstName} {LastName}";
        }
    }
}
