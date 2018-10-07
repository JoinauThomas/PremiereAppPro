using Ingenico.Enterprise.Webshop.Repositories;
using Moq;
using System.Collections.Generic;
using System.Linq;
using Xunit;

namespace Ingenico.Enterprise.Webshop.Tests
{
    public class ArticleServiceTests
    {
        [Fact]
        public void Test1()
        {
            // Arrange
            var articleRepositoryMock = new Mock<IArticleRepository>();
            var sut = new Services.ArticleService(articleRepositoryMock.Object);
            var articleList = new List<Domain.Article>();
            var expectedCount = 5;
            for (int i = 0; i < expectedCount; i++)
            {
                articleList.Add(new Domain.Article
                {
                    Kind = Domain.ArticleKind.Physical
                });
            }
            for (int i = 0; i < expectedCount; i++)
            {
                articleList.Add(new Domain.Article
                {
                    Kind = Domain.ArticleKind.Virtual
                });
            }

            articleRepositoryMock
                            .Setup(c => c.GetArticles())
                            .Returns(articleList);

            // Act
            var response = sut.GetArticlesPhysicalGood();

            // Assert
            Assert.NotNull(response);
            Assert.IsType<List<Domain.Article>>(response);
            Assert.True(response.Any());
            Assert.True(response.All(c=> c.Kind == Domain.ArticleKind.Physical));
            Assert.Equal(expectedCount, response.Count);
        }
    }
}
