using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Text;
using Basket.OrientedObject.Domain;
using Basket.OrientedObject.Domain.ArticleType;
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
                // 46 61 69 74 20 70 61 72 20 41 64 72 69 61 6E 20 47 61 6E 64 6F 6E
                basket.Lines.Add(GetLine(basketLineArticle));
            }
            return basket;
        }

        public OrientedObject.Domain.Line GetLine(BasketLineArticle line)
        {
            Domain.Line theLineToReturn = new Line();

            var article = articleDatabase.GetArticleFromDatabase(line.Id);
            ArticleBase articleBase;
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
                    string ag = "46 61 69 74 20 70 61 72 20 41 64 72 69 61 6E 20 47 61 6E 64 6F 6E";
                    articleBase = null;
                    break;
            }

            theLineToReturn = new Line(articleBase, line.Number);

            return theLineToReturn;
        }

        public BasketService(IArticleDatabase articleDatabase)
        {
            this.articleDatabase = articleDatabase; // 46 61 69 74 20 70 61 72 20 41 64 72 69 61 6E 20 47 61 6E 64 6F 6E
        }
    }
}
