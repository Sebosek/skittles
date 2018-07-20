using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

using Skittles.Services;

namespace Skittles.Pages
{
    public class IndexModel : PageModel
    {
        private readonly FilesService _filesService;

        public string Content { get; private set; }

        public IndexModel(FilesService filesService)
        {
            _filesService = filesService;
        }

        public IActionResult OnGet(string url)
        {
            var result = _filesService.Read(string.IsNullOrEmpty(url) ? "introduction" : url);
            if (result == null)
            {
                return Redirect("NotFound");
            }

            Content = result.Content;
            ViewData["Title"] = result.Title;

            return Page();
        }
    }
}
