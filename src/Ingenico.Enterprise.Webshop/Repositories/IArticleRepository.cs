using System.Collections.Generic;
using Ingenico.Enterprise.Webshop.Domain;

namespace Ingenico.Enterprise.Webshop.Repositories
{
    public interface IArticleRepository
    {
        Article GetArticle(int id);
        IList<Article> GetArticles();
    }
}