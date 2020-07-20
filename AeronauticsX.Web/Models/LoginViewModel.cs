namespace AeronauticsX.Web.Models
{
    using System.ComponentModel.DataAnnotations;

    public class LoginViewModel
    {

        [Required]
        [EmailAddress]
        public string Username { get; set; }


        [Required]     // TODO: Change for prod
        [MinLength(6)] // As stated in Startup.cs
        public string Password { get; set; }


        public bool RememberMe { get; set; }
    }
}
