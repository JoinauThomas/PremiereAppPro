using Ingenico.Enterprise.Webshop.Domain;
using Ingenico.Enterprise.Webshop.Repositories;
using System.Collections.Generic;
using System.Linq;

namespace Ingenico.Enterprise.Webshop.Services
{
    public class ArticleService : IArticleService
    {
        private readonly IArticleRepository articleRepository;

        public ArticleService(IArticleRepository articleRepository)
        {
            this.articleRepository = articleRepository;
        }

        public IList<Article> GetArticlesPhysicalGood()
        {
            var list = articleRepository.GetArticles();
            return list.Where(a => a.Kind == ArticleKind.Physical).ToList();
        }

        public Article GetArticle(int id)
        {
            return articleRepository.GetArticle(id);
        }
    }
}
