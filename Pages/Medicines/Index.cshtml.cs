using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using Pharma.Data;
using Pharma.Models;

namespace Pharma.Pages.Medicines
{
    public class IndexModel : PageModel
    {
        private readonly Pharma.Data.PharmaContext _context;

        public IndexModel(Pharma.Data.PharmaContext context)
        {
            _context = context;
        }

        public IList<Medicine> Medicine { get;set; }

        public async Task OnGetAsync()
        {
            Medicine = await _context.Medicine.ToListAsync();
        }
    }
}
