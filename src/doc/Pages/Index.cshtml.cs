using Microsoft.AspNetCore.Mvc.RazorPages;

using Skittles.Services;

namespace Skittles.Pages
{
    public class IndexModel : PageModel
    {
        private readonly DocService _service;

        public string Content { get; private set; }

        public IndexModel(DocService service)
        {
            _service = service;
        }

        public void OnGet()
        {
            Content = _service.Index();
        }
    }
}
