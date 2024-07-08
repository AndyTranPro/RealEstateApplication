using RealEstateApplication.Models;

namespace RealEstateApplication.Services
{
    public class HomeService
    {
        private List<Home> _homes;
        private readonly HomeContext _context;


        public HomeService(HomeContext context)
        {
            _context = context;
            _homes = new List<Home>
        {
            new Home { Id = 1, Price = 300000, Address = "123 Main St", Area = 120, ImageUrl = "https://images.unsplash.com/photo-1568605114967-8130f3a36994" },
            new Home { Id = 2, Price = 450000, Address = "456 Elm St", Area = 150, ImageUrl = "https://images.unsplash.com/photo-1570129477492-45c003edd2be"  },
            new Home { Id = 3, Price = 350000, Address = "789 Oak St", Area = 130, ImageUrl = "https://plus.unsplash.com/premium_photo-1661964475795-f0cb85767a88"},
            new Home { Id = 4, Price = 500000, Address = "101 Pine St", Area = 160, ImageUrl = "https://images.unsplash.com/photo-1580587771525-78b9dba3b914" },
            new Home { Id = 5, Price = 275000, Address = "202 Birch St", Area = 115, ImageUrl = "https://images.unsplash.com/photo-1613977257363-707ba9348227" },
            new Home { Id = 6, Price = 600000, Address = "303 Cedar St", Area = 180, ImageUrl = "https://images.pexels.com/photos/106399/pexels-photo-106399.jpeg" },
            new Home { Id = 7, Price = 320000, Address = "404 Maple St", Area = 140, ImageUrl = "https://images.pexels.com/photos/9951999/pexels-photo-9951999.jpeg" },
            new Home { Id = 8, Price = 470000, Address = "505 Cherry St", Area = 155, ImageUrl = "https://images.pexels.com/photos/5178060/pexels-photo-5178060.jpeg" },
            new Home { Id = 10, Price = 420000, Address = "707 Ash St", Area = 150, ImageUrl = "https://images.pexels.com/photos/8583869/pexels-photo-8583869.jpeg" },
            new Home { Id = 11, Price = 310000, Address = "808 Willow St", Area = 135, ImageUrl = "https://images.pexels.com/photos/7710011/pexels-photo-7710011.jpeg" },
            new Home { Id = 12, Price = 440000, Address = "909 Redwood St", Area = 158, ImageUrl = "https://images.pexels.com/photos/5524205/pexels-photo-5524205.jpeg"}
        };
            SeedHomes();
        }

        public void SeedHomes()
        {
            if (!_context.Homes.Any())
            {
                _context.Homes.AddRange(_homes);
            }

            _context.SaveChanges();
        }
        public List<Home> GetHomes()
        {
            return _context.Homes.ToList();
        }

        public Home GetHomeById(int id)
        {
            return _context.Homes.Single(h => h.Id == id);
        }

        public void AddHome(Home home)
        {
            _context.Homes.Add(home);
            _context.SaveChanges();
        }

        public void DeleteHome(int id)
        {
            var home = _context.Homes.FirstOrDefault(h => h.Id == id);

            _context.Homes.Remove(home);
            _context.SaveChanges();
        }

        public void UpdateHome(Home updatedHome)
        {
            var home = _context.Homes.FirstOrDefault(h => h.Id == updatedHome.Id);

            home.Price = updatedHome.Price;
            home.Address = updatedHome.Address;
            home.Area = updatedHome.Area;

            _context.Homes.Update(home);
            _context.SaveChanges();
        }
    }
}
