namespace AeronauticsX.Web.Data.Repositories
{
    using System.Collections.Generic;
    using System.Linq;

    using AeronauticsX.Web.Data.Entities;
    using Microsoft.AspNetCore.Mvc.Rendering;

    public class CountryRepository : GenericRepository<Country>, ICountryRepository
    {
        private readonly DataContext _context;

        public CountryRepository(DataContext context) : base(context)
        {
            _context = context;
        }


        public IEnumerable<SelectListItem> GetComboCountries()
        {
            var list = _context.Countries.Select(c => new SelectListItem
            {
                Text = c.Name,
                Value = c.Id.ToString()

            }).OrderBy(l => l.Text).ToList();

            list.Insert(0, new SelectListItem
            {
                Text = "(Select a country...)",
                Value = "0"
            });

            return list;
        }
    }
}
