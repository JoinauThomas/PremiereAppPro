using Ingenico.Enterprise.Webshop.Domain;
using System.Collections.Generic;
using System.Linq;

namespace Ingenico.Enterprise.Webshop.Repositories
{
    public class ArticleRepository : IArticleRepository
    {
        private readonly List<Article> list;

        public ArticleRepository()
        {
            list = new List<Article>()
            {
                new Article
                {
                    Id = 1,
                    Comment = "blabla",
                    Mark = "Salut",
                    Name = "My product",
                    Picture = "/img",
                    Price = 12.50f
                },
            };
        }

        public Article GetArticle(int id)
        {
            return list.FirstOrDefault(c => c.Id == id);
        }
        public IList<Article> GetArticles()
        {
            return list;
        }
    }
}
