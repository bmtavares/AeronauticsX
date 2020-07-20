namespace AeronauticsX.Web.Controllers
{
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Mvc;
    using Microsoft.EntityFrameworkCore;
    using AeronauticsX.Web.Models;
    using AeronauticsX.Web.Models.Entities;

    public class PlanesController : Controller
    {
        private readonly IPlaneRepository _planeRepository;

        public PlanesController(IPlaneRepository planeRepository)
        {
            _planeRepository = planeRepository;
        }

        // GET: Products
        public IActionResult Index()
        {
            return View(_planeRepository.GetAll());
        }

        // GET: Products/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var product = await _planeRepository.GetByIdAsync(id.Value);
            if (product == null)
            {
                return NotFound();
            }

            return View(product);
        }

        // GET: Products/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: Products/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("ID, Maker, Model, Name")] Plane plane)
        {
            if (ModelState.IsValid)
            {
                await _planeRepository.CreateAsync(plane);
                return RedirectToAction(nameof(Index));
            }
            return View(plane);
        }

        // GET: Products/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var plane = await _planeRepository.GetByIdAsync(id.Value);
            if (plane == null)
            {
                return NotFound();
            }
            return View(plane);
        }

        // POST: Products/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("ID, Maker, Model, Name")] Plane plane)
        {
            if (id != plane.ID)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    await _planeRepository.UpdateAsync(plane);
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!await _planeRepository.ExistAsync(plane.ID))
                    {
                        return NotFound();
                    }
                    else
                    {
                        throw;
                    }
                }
                return RedirectToAction(nameof(Index));
            }
            return View(plane);
        }

        // GET: Products/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var plane = await _planeRepository.GetByIdAsync(id.Value);
            if (plane == null)
            {
                return NotFound();
            }

            return View(plane);
        }

        // POST: Products/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var plane = await _planeRepository.GetByIdAsync(id);
            await _planeRepository.DeleteAsync(plane);
            return RedirectToAction(nameof(Index));
        }
    }
}
