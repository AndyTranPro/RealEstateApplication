using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using RealEstateApplication.Models;
using RealEstateApplication.Services;

namespace RealEstateApplication.Pages
{
    public class IndexModel : PageModel
    {
        private readonly HomeService _homeService;
        public List<Home> Homes { get; private set; }
        public decimal ThresholdPrice { get; set; }

        public IndexModel(HomeService homeService)
        {
            _homeService = homeService;
        }

        public void OnGet()
        {
            Homes = _homeService.GetHomes(); // use the HomeService to get the list of homes
            ThresholdPrice = 400000;
        }
    }
}
