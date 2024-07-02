using RealEstateApplication.Models;

namespace RealEstateApplication.Services
{
    public class HomeService
    {
        private List<Home> _homes;
        public HomeService()
        {
            _homes = new List<Home>
            {
                new Home { Id = 1, Price = 300000, Address = "123 Main St", Area = 120 },
                new Home { Id = 2, Price = 450000, Address = "456 Elm St", Area = 150 },
                new Home { Id = 3, Price = 350000, Address = "789 Oak St", Area = 130 },
                new Home { Id = 4, Price = 500000, Address = "101 Pine St", Area = 160 },
                new Home { Id = 5, Price = 275000, Address = "202 Birch St", Area = 115 },
                new Home { Id = 6, Price = 600000, Address = "303 Cedar St", Area = 180 },
                new Home { Id = 7, Price = 320000, Address = "404 Maple St", Area = 140 },
                new Home { Id = 8, Price = 470000, Address = "505 Cherry St", Area = 155 },
                new Home { Id = 10, Price = 420000, Address = "707 Ash St", Area = 150 },
                new Home { Id = 11, Price = 310000, Address = "808 Willow St", Area = 135 },
                new Home { Id = 12, Price = 440000, Address = "909 Redwood St", Area = 158 }
            };
        }
        public List<Home> GetHomes()
        {
            return _homes;
        }

        public Home GetHomeById(int id)
        {
            return _homes.Single(h => h.Id == id);
        }

        public void AddHome(Home home)
        {
            _homes.Add(home);
        }

        public void DeleteHome(int id)
        {
            var home = _homes.FirstOrDefault(h => h.Id == id);

            _homes.Remove(home);
        }

        public void UpdateHome(Home updatedHome)
        {
            var home = _homes.FirstOrDefault(h => h.Id == updatedHome.Id);

            home.Price = updatedHome.Price;
            home.Address = updatedHome.Address;
            home.Area = updatedHome.Area;
        }
    }
}
