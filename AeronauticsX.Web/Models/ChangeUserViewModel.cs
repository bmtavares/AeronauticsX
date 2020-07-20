namespace AeronauticsX.Web.Models
{
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;

    using AeronauticsX.Web.Data.Entities;

    using Microsoft.AspNetCore.Mvc.Rendering;

    public class ChangeUserViewModel
    {
        [Required]
        [Display(Name = "First Name")]
        public string FirstName { get; set; }


        [Required]
        [Display(Name = "Last Name")]
        public string LastName { get; set; }


        [MaxLength(100, ErrorMessage = "The field {0} cannot exceed {1} characters.")]
        public string Address1 { get; set; }


        [MaxLength(100, ErrorMessage = "The field {0} cannot exceed {1} characters.")]
        public string Address2 { get; set; }


        [MaxLength(20, ErrorMessage = "The field {0} cannot exceed {1} characters.")]
        public string ZipCode { get; set; }


        [MaxLength(50, ErrorMessage = "The field {0} cannot exceed {1} characters.")]
        public string City { get; set; }


        [MaxLength(20, ErrorMessage = "The field {0} cannot exceed {1} characters.")]
        public string PhoneNumber { get; set; }


        [Display(Name = "Country")]
        [Range(1, int.MaxValue, ErrorMessage = "You must select a country")]
        public int CountryId { get; set; }

        public Country Country { get; set; }

        public IEnumerable<SelectListItem> Countries { get; set; }
    }
}
