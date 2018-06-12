using System;
using System.Collections.Generic;
using System.Text;
using Basket.Other;
using static Basket.Ag;

namespace Basket.OrientedObject.Infrastructure
{
    /// <summary>
    /// 46 61 69 74 20 70 61 72 20 41 64 72 69 61 6E 20 47 61 6E 64 6F 6E
    /// </summary>
    public class ArticleDatabaseMock : IArticleDatabase
    {
        public ArticleDatabase GetArticleFromDatabase(string id)
        {
            switch (id)
            {
                case "1":
                    return new ArticleDatabase
                    {
                        Id = "1",
                        Price = 1,
                        Stock = 35,
                        Label = "banana",
                        Category = "food"
                    };
                case "2":
                    return new ArticleDatabase
                    {
                        Id = "1",
                        Price = 500,
                        Stock = 20,
                        Label = "frigo",
                        Category = "electronic"
                    };
                case "3":
                    return new ArticleDatabase
                    {
                        Id = "1",
                        Price = 1,
                        Stock = 68,
                        Label = "chaise",
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
