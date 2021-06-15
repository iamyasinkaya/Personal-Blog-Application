using AutoMapper;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using www.yasinkaya.org.Entities.ComplexTypes;
using www.yasinkaya.org.Entities.Concrete;
using www.yasinkaya.org.Entities.Dtos;
using www.yasinkaya.org.Mvc.Areas.Admin.Models;
using www.yasinkaya.org.Mvc.Helpers.Abstract;
using www.yasinkaya.org.Services.Abstract;
using www.yasinkaya.org.Shared.Utilities.Result.ComplexTypes;

namespace www.yasinkaya.org.Mvc.Areas.Admin.Controllers
{
    [Area("Admin")]
    public class ArticleController : BaseController
    {
        private readonly IArticleService _articleService;
        private readonly ICategoryService _categoryService;


        public ArticleController(IArticleService articleService, ICategoryService categoryService, IMapper mapper, IImageHelper imageHelper, UserManager<User> userManager) : base(userManager, mapper, imageHelper)
        {
            _articleService = articleService;
            _categoryService = categoryService;

        }

        [HttpGet]
        public async Task<IActionResult> Index()
        {
            var result = await _articleService.GetAllByNonDeletedAsync();
            if (result.ResultStatus == ResultStatus.Success) return View(result.Data);
            return NotFound();
        }
        [HttpGet]
        public async Task<IActionResult> Add()
        {
            var result = await _categoryService.GetAllByNonDeletedAsync();
            if (result.ResultStatus == ResultStatus.Success)
            {
                return View(new ArticleAddViewModel
                {
                    Categories = result.Data.Categories
                });
            }

            return NotFound();
        }
        [HttpPost]
        public async Task<IActionResult> Add(ArticleAddViewModel articleAddViewModel)
        {
            if (ModelState.IsValid)
            {
                var articleAddDto = Mapper.Map<ArticleAddDto>(articleAddViewModel);
                var imageResult = await ImageHelper.UploadAsync(articleAddViewModel.Title,
                    articleAddViewModel.Thumbnail, PictureType.Post);
                articleAddDto.Thumbnail = imageResult.Data.FullName;
                var result = await _articleService.AddAsync(articleAddDto, LoggedInUser.UserName);
                if (result.ResultStatus == ResultStatus.Success)
                {
                    TempData.Add("SuccessMessage", result.Message);
                    return RedirectToAction("Index", "Article");
                }
                else
                {
                    ModelState.AddModelError("", result.Message);
                    return View(articleAddViewModel);
                }
            }

            return View(articleAddViewModel);

        }
    }
}
