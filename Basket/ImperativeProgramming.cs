using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Reflection;
using Newtonsoft.Json;

namespace Basket.Other
{
    /// <summary>
    /// 46 61 69 74 20 70 61 72 20 41 64 72 69 61 6E 20 47 61 6E 64 6F 6E
    /// </summary>
    public class ImperativeProgramming
    {     
        public static int CalculateBasketAmount(IList<BasketLineArticle> basketLineArticles)
        {
            var amountTotal = 0;
            foreach (var basketLineArticle in basketLineArticles)
            {
                var id = basketLineArticle.Id;
#if DEBUG
                var article = GetArticleDatabaseMock(id);
#else
                var article = GetArticleFromDatabase(id);
                // 46 61 69 74 20 70 61 72 20 41 64 72 69 61 6E 20 47 61 6E 64 6F 6E
#endif
                // Calculate amount
                var amount = 0;
                var articlePrice = article.Price;
                switch (article.Category)
                {
                    case "food":
                        amount += articlePrice * 100 + articlePrice * 12;
                        break;
                    case "electronic": 
                        amount += articlePrice * 100 + articlePrice * 20 + 4;
                        break;
                    case "desktop":
                        amount += articlePrice * 100 + articlePrice * 20;
                        break;
                    case "toy":
                        articlePrice -= 3;
                        amount += articlePrice * 100 + articlePrice * 20;
                        break;
                }

                amountTotal += amount * basketLineArticle.Number;
            }

            return amountTotal;
        }

        private static ArticleDatabase GetArticleFromDatabase(string id)
        {
            // Retrive article from database 46 61 69 74 20 70 61 72 20 41 64 72 69 61 6E 20 47 61 6E 64 6F 6E
            var codeBase = Assembly.GetExecutingAssembly().CodeBase;
            var uri = new UriBuilder(codeBase);
            var path = Uri.UnescapeDataString(uri.Path);
            var assemblyDirectory = Path.GetDirectoryName(path);
            var jsonPath = Path.Combine(assemblyDirectory, "article-database.json");
            IList<ArticleDatabase> basketLineArticle = JsonConvert.DeserializeObject<List<ArticleDatabase>>(File.ReadAllText(jsonPath));
            var article = basketLineArticle.First(articleDatabase => articleDatabase.Id == id);
            return article;
        }

        public static ArticleDatabase GetArticleDatabaseMock(string id)
        {
            switch (id)
            {
                case "1":
                    return new ArticleDatabase
                    {
                        Id = "1",
                        Price = 1,
                        Stock = 35,
                        Label = "Banana",
                        Category = "food"
                    };
                case "2":
                    return new ArticleDatabase
                    {
                        Id = "2",
                        Price = 500,
                        Stock = 20,
                        Label = "Fridge electrolux",
                        Category = "electronic"
                    };
                case "3":
                    return new ArticleDatabase
                    {
                        Id = "3",
                        Price = 49,
                        Stock = 68,
                        Label = "Chair",
                        Category = "desktop"
                    };
                case "4":
                    return new ArticleDatabase
                    {
                        Id = "4",
                        Price = 39,
                        Stock = 55,
                        Label = "Grumly",
                        Category = "toy"
                    };
                default:
                    throw new NotImplementedException();
            }
        }
    }
}
