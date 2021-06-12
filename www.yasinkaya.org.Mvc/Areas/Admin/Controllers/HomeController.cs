using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using www.yasinkaya.org.Entities.Concrete;
using www.yasinkaya.org.Mvc.Areas.Admin.Models;
using www.yasinkaya.org.Mvc.Models;
using www.yasinkaya.org.Services.Abstract;
using www.yasinkaya.org.Shared.Utilities.Result.ComplexTypes;

namespace www.yasinkaya.org.Areas.Admin.Controllers
{
    [Area("Admin")]
    [Authorize(Roles = "Admin,Editor")]
    public class HomeController : Controller
    {
        private readonly ICategoryService _categoryService;
        private readonly ICommentService _commentService;
        private readonly UserManager<User> _userManager;
        private readonly IArticleService _articleService;

        public HomeController(ICategoryService categoryService, ICommentService commentService, UserManager<User> userManager, IArticleService articleService)
        {
            _categoryService = categoryService;
            _commentService = commentService;
            _userManager = userManager;
            _articleService = articleService;
        }


        public async Task<IActionResult> Index()
        {
            var categoriesCountResult = await _categoryService.CountByNonDeletedAsync();
            var commentsCountResult = await _commentService.CountByNonDeletedAsync();
            var usersCountResult = await _userManager.Users.CountAsync();
            var articlesCountResult = await _articleService.CountByNonDeletedAsync();
            var articleResult = await _articleService.GetAllAsync();


            if (categoriesCountResult.ResultStatus == ResultStatus.Success && commentsCountResult.ResultStatus == ResultStatus.Success && usersCountResult > -1 && articlesCountResult.ResultStatus == ResultStatus.Success && articleResult.ResultStatus == ResultStatus.Success)
            {
                return View(new DashboardViewModel
                {

                    CategoriesCount = categoriesCountResult.Data,
                    CommentsCount = commentsCountResult.Data,
                    UsersCount = usersCountResult,
                    ArticlesCount = articlesCountResult.Data,
                    Articles = articleResult.Data
                });
            }
            return NotFound();
        }
    }
}
