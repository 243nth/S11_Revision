using System;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using PresseMots.Models;
using PresseMots.Models.Data;

namespace PresseMots.Controllers
{
    public class TagsController : Controller
    {
        private readonly PresseMotsDbContext _context;

        public TagsController(PresseMotsDbContext context)
        {
            _context = context;
        }

        // GET: Tags
        public async Task<IActionResult> Index()
        {
              return View(_context.Tags.ToList());
        }

        // GET: Tags/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: Tags/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create(Object model ,[Bind("Id,Name")] Tags tag)
        {
            if (ModelState.IsValid)
            {
                model = _context.Tags.Add(tag);
            }
            return View(model);
        }

        // GET: Tags/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
         var jsp= await  _context.Tags.FirstOrDefaultAsync(i => i.Id == id);
            if (jsp==null)
            {
                NotFound();
            }

           
            return View(jsp);
        }

        // POST: Tags/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var jspIgo = await _context.Tags.FirstOrDefaultAsync(i=>i.Id==id);
              _context.Tags.Remove(jspIgo);
          await   _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }
    }
}
