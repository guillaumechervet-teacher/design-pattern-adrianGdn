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
        private IArticleDatabase articleDatabase;
        public OrientedObject.Domain.Basket GetBasket(IList<BasketLineArticle> lines)
        {
            Domain.Basket basket = new Domain.Basket();
            basket.Lines = new List<Line>();
            
            foreach (var basketLineArticle in lines)
            {
                var article = articleDatabase.GetArticleFromDatabase(basketLineArticle.Id);

                var line = new Line()
                {
                    Article = new Article() {Category = article.Category, Price = article.Price},
                    Number = basketLineArticle.Number
                };

                basket.Lines.Add(line);
            }
            return basket;
        }

        public BasketService(IArticleDatabase articleDatabase)
        {
            this.articleDatabase = new ArticleDatabaseJson();
        }
    }
}
