using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Text;
using Basket.OrientedObject.Domain;
using Newtonsoft.Json;

namespace Basket.OrientedObject.Infrastructure
{
    public class BasketService
    {
        public OrientedObject.Domain.Basket GetBasket(IList<BasketLineArticle> lines)
        {
            Domain.Basket basket = new Domain.Basket();
            basket.Lines = new List<Line>();
            foreach (var basketLineArticle in lines)
            {
                var article = GetArticleFromDatabase(basketLineArticle.Id);

                var line = new Line()
                {
                    Article = new Article() {Category = article.Category, Price = article.Price},
                    Number = basketLineArticle.Number
                };

                basket.Lines.Add(line);
            }
            return basket;
        }


        private static ArticleDatabase GetArticleFromDatabase(string id)
        {
            // Retrive article from database
            var codeBase = Assembly.GetExecutingAssembly().CodeBase;
            var uri = new UriBuilder(codeBase);
            var path = Uri.UnescapeDataString(uri.Path);
            var assemblyDirectory = Path.GetDirectoryName(path);
            var jsonPath = Path.Combine(assemblyDirectory, "article-database.json");
            IList<ArticleDatabase> basketLineArticle = JsonConvert.DeserializeObject<List<ArticleDatabase>>(File.ReadAllText(jsonPath));
            var article = basketLineArticle.First(articleDatabase => articleDatabase.Id == id);
            return article;
        }

    }
}
