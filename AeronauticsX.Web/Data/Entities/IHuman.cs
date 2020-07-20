namespace AeronauticsX.Web.Data.Entities
{
    public interface IHuman
    {
        //[Display(Name = "First Name")]
        //[MaxLength(50, ErrorMessage = "The field {0} cannot exceed {1} characters.")]
        string FirstName { get; set; }


        //[Display(Name = "Last Name")]
        //[MaxLength(50, ErrorMessage = "The field {0} cannot exceed {1} characters.")]
        string LastName { get; set; }


        //[Display(Name = "Address Line 1")]
        string Address1 { get; set; }


        //[Display(Name = "Address Line 2")]
        string Address2 { get; set; }


        //[Display(Name = "Zip Code")]
        string ZipCode { get; set; }


        //[Display(Name = "City")]
        string City { get; set; }


        int CountryId { get; set; }


        Country Country { get; set; }


        //[Display(Name = "Full Name")]
        string FullName { get; }
    }
}
