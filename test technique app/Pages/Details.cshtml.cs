using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using test_technique_app.Data;
using test_technique_app.models;

namespace test_technique_app.Pages
{
    public class DetailsModel : PageModel
    {
        private readonly test_technique_app.Data.choixContext _context;

        public DetailsModel(test_technique_app.Data.choixContext context)
        {
            _context = context;
        }

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
    }
}
