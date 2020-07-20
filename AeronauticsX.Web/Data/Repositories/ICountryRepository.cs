namespace AeronauticsX.Web.Data.Repositories
{
    using System.Collections.Generic;

    using AeronauticsX.Web.Data.Entities;
    using AeronauticsX.Web.Models;

    using Microsoft.AspNetCore.Mvc.Rendering;

    public interface ICountryRepository : IGenericRepository<Country>
    {
        IEnumerable<SelectListItem> GetComboCountries();

    }
}
