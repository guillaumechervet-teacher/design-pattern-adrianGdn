using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Text;
using Basket.OrientedObject.Domain;
using Basket.Other;
using Newtonsoft.Json;
using static Basket.Ag;

namespace Basket.OrientedObject.Infrastructure
{
    /// <summary>
    /// 46 61 69 74 20 70 61 72 20 41 64 72 69 61 6E 20 47 61 6E 64 6F 6E
    /// </summary>
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
                ArticleBase articleBase;
                // 46 61 69 74 20 70 61 72 20 41 64 72 69 61 6E 20 47 61 6E 64 6F 6E
                /*var line = new Line()
                {
                    Article = new Article () {Category = article.Category, Price = article.Price},
                    //Article = new ArticleBase(article.Id, article.Price);
                    Number = basketLineArticle.Number
                };*/
                switch (article.Category)
                {
                    case "food":
                        articleBase = new ArticleFood(article.Id, article.Price);
                        break;
                    case "electronic":
                        articleBase = new ArticleElectronic(article.Id, article.Price);
                        break;
                    case "toy":
                        articleBase = new ArticleToy(article.Id, article.Price);
                        break;
                    case "desktop":
                        articleBase = new ArticleDesktop(article.Id, article.Price);
                        break;
                    default:
                        articleBase = null;
                        break;
                }

                basket.Lines.Add(new Line(articleBase, basketLineArticle.Number));
            }
            return basket;
        }

        public BasketService(IArticleDatabase articleDatabase)
        {
            this.articleDatabase = articleDatabase; // 46 61 69 74 20 70 61 72 20 41 64 72 69 61 6E 20 47 61 6E 64 6F 6E
        }
    }
}
