using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using www.yasinkaya.org.Mvc.Models;
using www.yasinkaya.org.Services.Abstract;

namespace www.yasinkaya.org.Mvc.Controllers
{
    public class ArticleController : Controller
    {
        private readonly IArticleService _articleService;

        public ArticleController(IArticleService articleService)
        {
            _articleService = articleService;
        }
        [HttpGet]
        public async Task<IActionResult> Search(string keyword, int currentPage = 1, int pageSize = 5, bool isAscending = false)
        {
            var searchResult = await _articleService.SearchAsync(keyword, currentPage, pageSize, isAscending);
            if (searchResult.ResultStatus == Shared.Utilities.Result.ComplexTypes.ResultStatus.Success)
            {
                return View(new ArticleSearchViewModel
                {
                    ArticleListDto = searchResult.Data,
                    Keyword = keyword
                });
            }

            return NotFound();
        }

        [HttpGet]
        public async Task<IActionResult> Detail(int articleId)
        {
            var articleResult = await _articleService.GetAsync(articleId);
            if (articleResult.ResultStatus == Shared.Utilities.Result.ComplexTypes.ResultStatus.Success)
            {
                return View(articleResult.Data);
            }
            return NotFound();
        }
    }
}
