using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using Microsoft.Extensions.Options;
using NToastNotify;
using System;
using System.Collections.Generic;
using System.Data.SqlTypes;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using www.yasinkaya.org.Entities.Concrete;
using www.yasinkaya.org.Entities.Dtos;
using www.yasinkaya.org.Mvc.Models;
using www.yasinkaya.org.Services.Abstract;
using www.yasinkaya.org.Shared.Utilities.Helpers.Abstract;

namespace www.yasinkaya.org.Mvc.Controllers
{
    [Route("/")]
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;
        private readonly IArticleService _articleService;
        private readonly AboutUsPageInfo _aboutUsPageInfo;
        private readonly IMailService _mailService;
        private readonly IToastNotification _toastNotification;
        private readonly IWritableOptions<AboutUsPageInfo> _aboutUsPageInfoWriter;

        public HomeController(ILogger<HomeController> logger, IArticleService articleService, IOptionsSnapshot<AboutUsPageInfo> aboutUsPageInfo, IMailService mailService, IToastNotification toastNotification, IWritableOptions<AboutUsPageInfo> aboutUsPageInfoWriter)
        {
            _logger = logger;
            _articleService = articleService;
            _aboutUsPageInfo = aboutUsPageInfo.Value;
            _mailService = mailService;
            _toastNotification = toastNotification;
            _aboutUsPageInfoWriter = aboutUsPageInfoWriter;
        }

        [Route("index")]
        [Route("anasayfa")]
        [Route("")]
        [HttpGet]
        public async Task<IActionResult> Index(int? categoryId, int currentPage = 1, int pageSize = 5, bool isAscending = false)
        {
            var articlesResult = await (categoryId == null
                ? _articleService.GetAllByPagingAsync(null, currentPage, pageSize,isAscending)
                : _articleService.GetAllByPagingAsync(categoryId.Value, currentPage, pageSize, isAscending));

            return View(articlesResult.Data);
        }
        [Route("hakkimizda")]
        [Route("hakkimda")]
        [HttpGet]
        public IActionResult About()
        {
            //_aboutUsPageInfoWriter.Update(x =>
            //{
            //    x.Header = "Yeni Başlık";
            //    x.Content = "Yeni İçerik";

            //});
            return View(_aboutUsPageInfo);
        }
        [Route("iletisim")]
        [HttpGet]
        public IActionResult Contact()
        {
            return View();
        }
        [Route("iletisim")]
        [HttpPost]
        public IActionResult Contact(EmailSendDto emailSendDto)
        {
            if (ModelState.IsValid)
            {
                var result = _mailService.SendContactEmail(emailSendDto);
                _toastNotification.AddSuccessToastMessage(result.Message, new ToastrOptions
                {
                    Title = "Başarılı İşlem!"
                });
                return View();
            }

            return View(emailSendDto);
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
