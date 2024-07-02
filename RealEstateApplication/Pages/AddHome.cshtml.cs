using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using RealEstateApplication.Models;
using RealEstateApplication.Services;

namespace RealEstateApplication.Pages
{
    public class AddHomeModel : PageModel
    {
        private readonly HomeService _homeService;

        public AddHomeModel(HomeService homeService)
        {
            _homeService = homeService;
        }

        [BindProperty]
        public Home NewHome { get; set; }
        public void OnGet()
        {
        }

        public IActionResult OnPost()
        {
            if (!ModelState.IsValid)
            {
                return Page();
            }
            _homeService.AddHome(NewHome);
            return RedirectToPage("/Index");
        }
    }
}
