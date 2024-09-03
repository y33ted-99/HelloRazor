using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace HellowRazor.Pages
{
    public class ProcessModel : PageModel
    {
        public void OnGet()
        {
            ViewData["Yes"] = "hellow";
        }
    }
}
