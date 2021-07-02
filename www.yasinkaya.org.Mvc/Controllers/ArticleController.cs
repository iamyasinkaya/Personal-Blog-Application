using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using www.yasinkaya.org.Entities.ComplexTypes;
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
                var userArticles = await _articleService.GetAllByUserIdOnFilterAsnyc(articleResult.Data.Article.UserId,
                    FilterBy.Category,
                    OrderBy.Date,
                    false,
                    10,
                    articleResult.Data.Article.CategoryId,
                    DateTime.Now,
                    DateTime.Now, 0, 99999, 0, 99999);

                await _articleService.IncreaseViewCountAsync(articleId);
                return View(new ArticleDetailViewModel
                {
                    ArticleDto = articleResult.Data,
                    ArticleDetailRideSideBarViewModel = new ArticleDetailRideSideBarViewModel
                    {
                        ArticleListDto = userArticles.Data,
                        Header = "Kullanıcının Aynı Kategori Üzerindeki En Çok Makaleleri",
                        User = articleResult.Data.Article.User
                    }
                });
            }
            return NotFound();
        }
    }
}
