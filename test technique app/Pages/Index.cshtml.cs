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
    public class IndexModel : PageModel
    {
        private readonly test_technique_app.Data.choixContext _context;

        public IndexModel(test_technique_app.Data.choixContext context)
        {
            _context = context;
        }

        public IList<choix> choix { get;set; }

        public async Task OnGetAsync()
        {
            choix = await _context.choix.ToListAsync();
        }
    }
}
