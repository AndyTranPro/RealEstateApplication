using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using RealEstateApplication.Models;
using RealEstateApplication.Services;

namespace RealEstateApplication.Pages
{
    public class HomeDetailModel : PageModel
    {
        private readonly HomeService _homeService;

        public HomeDetailModel(HomeService homeService)
        {
            _homeService = homeService;
        }

        [BindProperty]
        public Home Home { get; set; }

        public IActionResult OnGet(int id)
        {
            Home = GetHomeById(id);

            return Page();
        }

        private Home GetHomeById(int id)
        {
            return _homeService.GetHomeById(id);
        }

        public IActionResult OnPostUpdate()
        {
            if (!ModelState.IsValid)
            {
                return Page();
            }

            try
            {
                _homeService.UpdateHome(Home);
                TempData["SuccessMessage"] = "Home updated successfully!";
                return RedirectToPage("/Index");
            }
            catch (Exception ex)
            {
                TempData["ErrorMessage"] = $"Error updating home: {ex.Message}";
            }
            return Page();
        }

        public IActionResult OnPostDelete(int id)
        {
            try
            {
                _homeService.DeleteHome(id);
                TempData["SuccessMessage"] = "Home deleted successfully!";
                return new OkResult();
            }
            catch (Exception ex)
            {
                TempData["ErrorMessage"] = $"Error deleting home: {ex.Message}";
                return BadRequest(new { message = ex.Message });
            }
        }
    }
}
