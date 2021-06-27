using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using www.yasinkaya.org.Mvc.Models;
using www.yasinkaya.org.Services.Abstract;

namespace www.yasinkaya.org.Mvc.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;
        private readonly IArticleService _articleService;

        public HomeController(ILogger<HomeController> logger, IArticleService articleService)
        {
            _logger = logger;
            _articleService = articleService;
        }

        [HttpGet]
        public async Task<IActionResult> Index(int? categoryId)
        {
            var articlesResult = await (categoryId == null
                ? _articleService.GetAllByNonDeleteAndActiveAsync()
                : _articleService.GetAllByCategoryAsync(categoryId.Value));

            return View(articlesResult.Data);
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
