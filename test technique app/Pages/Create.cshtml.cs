using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;
using test_technique_app.Data;
using test_technique_app.models;

namespace test_technique_app.Pages
{
    public class CreateModel : PageModel
    {
        private readonly test_technique_app.Data.choixContext _context;

        public CreateModel(test_technique_app.Data.choixContext context)
        {
            _context = context;
        }

        public IActionResult OnGet()
        {
            return Page();
        }

        [BindProperty]
        public choix choix { get; set; }

        // To protect from overposting attacks, see https://aka.ms/RazorPagesCRUD
        public async Task<IActionResult> OnPostAsync()
        {
            if (!ModelState.IsValid)
            {
                return Page();
            }

            _context.choix.Add(choix);
            await _context.SaveChangesAsync();

            return RedirectToPage("./Index");
        }
    }
}
