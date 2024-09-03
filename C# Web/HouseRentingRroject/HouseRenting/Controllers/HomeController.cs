using HouseRenting.Contracts;
using HouseRenting.Models;
using HouseRenting.Models.Home;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;
using System.Net.WebSockets;

namespace HouseRenting.Controllers
{
    public class HomeController : Controller
    {
        private readonly IHouseService _houses;

        public HomeController(IHouseService houses)
        {
            _houses = houses;
        }
        public async Task<IActionResult> Index()
        {
            var houses = await _houses.LastThreeHouses();
            return View(houses);
        }

        [Route("Home/Error")]
        public IActionResult Error(int statusCode)
        {
            switch (statusCode)
            {
                case 400:
                    return View("Error400");
                case 401:
                    return View("Error401");
                default:
                    return View("Error");
            }
        }
    }
}