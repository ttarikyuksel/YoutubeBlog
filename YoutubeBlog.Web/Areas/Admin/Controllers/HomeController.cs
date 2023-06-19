using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using YoutubeBlog.Service.Services.Abstractions;

namespace YoutubeBlog.Web.Areas.Admin.Controllers
{
    [Area("Admin")]
    [Authorize]
    public class HomeController : Controller
    {
        IArticleService articleService;

        public HomeController(IArticleService articleService)
        {
            this.articleService = articleService;
        }

        public async  Task<IActionResult> Index()
        {
            var artivle = await articleService.GetAllArticleWithCategoryNoneDeletedAsync();
            return View(artivle);
        }
    }
}
