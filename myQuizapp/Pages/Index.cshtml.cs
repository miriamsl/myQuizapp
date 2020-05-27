using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Logging;
using System.Diagnostics;

namespace myQuizapp.Pages
{
    public class IndexModel : PageModel
    {

        private readonly QuestionContext _context;

        

        public IndexModel(QuestionContext context)
        {
            _context = context;
        }

        public IList<Models.Question> Question { get; set; }

        

        public async Task OnGetAsync()
        {
            Question = await _context.Question.ToListAsync();
        }
    }
}
