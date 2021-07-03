using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Options;
using NToastNotify;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using www.yasinkaya.org.Entities.Concrete;
using www.yasinkaya.org.Shared.Utilities.Helpers.Abstract;

namespace www.yasinkaya.org.Mvc.Areas.Admin.Controllers
{
    [Area("Admin")]
    [Authorize]
    public class OptionsController : Controller
    {
        private readonly AboutUsPageInfo _aboutUsPageInfo;
        private readonly IWritableOptions<AboutUsPageInfo> _aboutUsPageInfoWriter;
        private readonly IToastNotification _toastNotification;
        private readonly WebsiteInfo _websiteInfo;
        private readonly IWritableOptions<WebsiteInfo> _websiteInfoWriter;
        private readonly SmtpSettings _smtpSettings;
        private readonly IWritableOptions<SmtpSettings> _smtpSettingWriter;

        public OptionsController(IOptionsSnapshot<AboutUsPageInfo> aboutUsPageInfo, IWritableOptions<AboutUsPageInfo> aboutUsPageInfoWriter, IToastNotification toastNotification, IOptionsSnapshot<WebsiteInfo> websiteInfo, IWritableOptions<WebsiteInfo> websiteInfoWriter, IOptionsSnapshot<SmtpSettings> smtpSettings, IWritableOptions<SmtpSettings> smtpSettingWriter)
        {
            _aboutUsPageInfo = aboutUsPageInfo.Value;
            _aboutUsPageInfoWriter = aboutUsPageInfoWriter;
            _toastNotification = toastNotification;
            _websiteInfo = websiteInfo.Value;
            _websiteInfoWriter = websiteInfoWriter;
            _smtpSettings = smtpSettings.Value;
            _smtpSettingWriter = smtpSettingWriter;
        }

        [HttpGet]
        public IActionResult About()
        {
            return View(_aboutUsPageInfo);
        }
        [HttpPost]
        public IActionResult About(AboutUsPageInfo aboutUsPageInfo)
        {
            if (ModelState.IsValid)
            {
                _aboutUsPageInfoWriter.Update(x =>
                {
                    x.Header = aboutUsPageInfo.Header;
                    x.Content = aboutUsPageInfo.Content;
                    x.SeoAuthor = aboutUsPageInfo.SeoAuthor;
                    x.SeoDescription = aboutUsPageInfo.SeoDescription;
                    x.SeoTags = aboutUsPageInfo.SeoTags;
                });
                _toastNotification.AddSuccessToastMessage("Hakkımda sayfa içerikleri başarıyla güncellenmiştir!", new ToastrOptions
                {
                    Title = "Başarılı İşlem!"
                });
                return View(aboutUsPageInfo);
            }
            return View(aboutUsPageInfo);
        }
        [HttpGet]
        public IActionResult GeneralSettings()
        {
            return View(_websiteInfo);
        }
        [HttpPost]
        public IActionResult GeneralSettings(WebsiteInfo websiteInfo)
        {
            if (ModelState.IsValid)
            {
                _websiteInfoWriter.Update(x =>
                {
                    x.Title = websiteInfo.Title;
                    x.MenuTitle = websiteInfo.MenuTitle;
                    x.SeoAuthor = websiteInfo.SeoAuthor;
                    x.SeoDescription = websiteInfo.SeoDescription;
                    x.SeoTags = websiteInfo.SeoTags;
                });
                _toastNotification.AddSuccessToastMessage("Sitenin genel ayarları başarıyla güncellenmiştir!", new ToastrOptions
                {
                    Title = "Başarılı İşlem!"
                });
                return View(websiteInfo);
            }
            return View(websiteInfo);
        }
        [HttpGet]
        public IActionResult EmailSettings()
        {
            return View(_smtpSettings);
        }
        [HttpPost]
        public IActionResult EmailSettings(SmtpSettings smtpSettings)
        {
            if (ModelState.IsValid)
            {
                _smtpSettingWriter.Update(x =>
                {
                    x.Server = smtpSettings.Server;
                    x.Port = smtpSettings.Port;
                    x.SenderName = smtpSettings.SenderName;
                    x.SenderEmail = smtpSettings.SenderEmail;
                    x.Username = smtpSettings.Username;
                    x.Password = smtpSettings.Password;
                });
                _toastNotification.AddSuccessToastMessage("Sitenin E-posta ayarları başarıyla güncellenmiştir!", new ToastrOptions
                {
                    Title = "Başarılı İşlem!"
                });
                return View(smtpSettings);
            }
            return View(smtpSettings);
        }
    }
}
