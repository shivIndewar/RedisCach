using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Caching.Distributed;
using Newtonsoft.Json;
using RedisCach.Data;
using RedisCach.Models;
using System.Diagnostics;

namespace RedisCach.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;
        private readonly ApplicationDbContext _context;
        private IDistributedCache _distributedCache;
        public HomeController(ILogger<HomeController> logger, ApplicationDbContext context, IDistributedCache distributedCache)
        {
            _logger = logger;
            _context = context;
            _distributedCache = distributedCache;
        }

        public IActionResult Index()
        {
            List<Category> categories = new List<Category>();
            var cachedCategory = _distributedCache.GetString("categoryList");

            if (!string.IsNullOrEmpty(cachedCategory))
            {
                categories = JsonConvert.DeserializeObject<List<Category>>(cachedCategory);
            }
            else {
                categories = _context.Category.ToList();
                DistributedCacheEntryOptions options = new();
                options.SetAbsoluteExpiration(new TimeSpan(0, 0, 30));
                _distributedCache.SetString("categoryList", JsonConvert.SerializeObject(categories), options);
            } 
            return View(categories);
        }

        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
