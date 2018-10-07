using System.Collections.Generic;
using Ingenico.Enterprise.Webshop.Domain;

namespace Ingenico.Enterprise.Webshop.Services
{
    public interface IArticleService
    {
        Article GetArticle(int id);
        IList<Article> GetArticlesPhysicalGood();
    }
}