using Ingenico.Enterprise.Webshop.Models;
using Ingenico.Enterprise.Webshop.Services;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using System.Linq;

namespace Ingenico.Enterprise.Webshop.Controllers
{
    public class Articles2Controller : Controller
    {
        private readonly IArticleService articleService;

        public Articles2Controller(IArticleService articleService)
        {
            this.articleService = articleService;
        }

        public IActionResult Index()
        {
            IList<ArticleViewModel> viewModel = articleService.GetArticlesPhysicalGood().Select(Map).ToList();
            return View(viewModel);
        }

        public IActionResult Details(int id)
        {
            ArticleViewModel viewModel = Map(articleService.GetArticle(id));
            return View(viewModel);
        }

        private static ArticleViewModel Map(Domain.Article source)
        {
            if (source == null)
                throw new System.ArgumentNullException(nameof(source));

            return new ArticleViewModel
            {
                Comment = source.Comment,
                Id = source.Id,
                Mark = source.Mark,
                Name = source.Name,
                Picture = source.Picture,
                Price = source.Price
            };
        }

    }
}