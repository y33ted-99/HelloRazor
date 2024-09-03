using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using System.Diagnostics;

namespace HellowRazor.Pages
{
    public class ProcessModel : PageModel
    {
        public void OnGet()
        {
            var Procs = Process.GetProcesses();
            ViewData["Procs"] = Procs;
        }
    }
}
