using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Reflection;
using Newtonsoft.Json;

namespace Basket.OrientedObject.Infrastructure
{
    public class ArticleDatabaseJson : IArticleDatabase
    {
        public ArticleDatabase GetArticleFromDatabase(string id)
        {
            // Retrieve article from database
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