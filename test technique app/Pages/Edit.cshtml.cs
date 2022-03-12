using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using test_technique_app.Data;
using test_technique_app.models;

namespace test_technique_app.Pages
{
    public class EditModel : PageModel
    {
        private readonly test_technique_app.Data.choixContext _context;

        public EditModel(test_technique_app.Data.choixContext context)
        {
            _context = context;
        }

        [BindProperty]
        public choix choix { get; set; }

        public async Task<IActionResult> OnGetAsync(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            choix = await _context.choix.FirstOrDefaultAsync(m => m.Id == id);

            if (choix == null)
            {
                return NotFound();
            }
            return Page();
        }

        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see https://aka.ms/RazorPagesCRUD.
        public async Task<IActionResult> OnPostAsync()
        {
            if (!ModelState.IsValid)
            {
                return Page();
            }

            _context.Attach(choix).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!choixExists(choix.Id))
                {
                    return NotFound();
                }
                else
                {
                    throw;
                }
            }

            return RedirectToPage("./Index");
        }

        private bool choixExists(int id)
        {
            return _context.choix.Any(e => e.Id == id);
        }
    }
}
