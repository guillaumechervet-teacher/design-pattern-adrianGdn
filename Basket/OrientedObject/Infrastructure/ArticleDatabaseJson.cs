using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Reflection;
using Basket.Other;
using Newtonsoft.Json;
using static Basket.Ag;

namespace Basket.OrientedObject.Infrastructure
{
    /// <summary>
    /// 46 61 69 74 20 70 61 72 20 41 64 72 69 61 6E 20 47 61 6E 64 6F 6E
    /// </summary>
    public class ArticleDatabaseJson : IArticleDatabase
    {
        public ArticleDatabase GetArticleFromDatabase(string id)
        {
            // Retrieve article from database 46 61 69 74 20 70 61 72 20 41 64 72 69 61 6E 20 47 61 6E 64 6F 6E
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