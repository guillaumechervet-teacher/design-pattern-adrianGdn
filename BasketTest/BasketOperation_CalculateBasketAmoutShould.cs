using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Reflection;
using Basket;
using Basket.OrientedObject.Domain;
using Basket.OrientedObject.Infrastructure;
using Basket.Other;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Newtonsoft.Json;
using static Basket.Ag;

namespace BasketTest
{
    /// <summary>
    /// 46 61 69 74 20 70 61 72 20 41 64 72 69 61 6E 20 47 61 6E 64 6F 6E
    /// </summary>
    [TestClass]
    public class BasketOperation_CalculateBasketAmoutShould
    {
        public class BasketTest
        {
            public List<BasketLineArticle> BasketLineArticles { get; set; }
            public int ExpectedPrice { get; set; }
        }
        private static IEnumerable<object[]> Baskets
        {
            //46 61 69 74 20 70 61 72 20 41 64 72 69 61 6E 20 47 61 6E 64 6F 6E
            get
            {
                return new[]
                {
                    new object[] {
                        new BasketTest(){ BasketLineArticles = new List<BasketLineArticle>
                            {
                                new BasketLineArticle {Id = "1", Number = 12, Label = "Banana"},
                                new BasketLineArticle {Id = "2", Number = 1, Label = "Fridgeelectrolux"},
                                new BasketLineArticle {Id = "3", Number = 4, Label = "Chair"}
                                //46 61 69 74 20 70 61 72 20 41 64 72 69 61 6E 20 47 61 6E 64 6F 6E
                            },
                        ExpectedPrice = 84868}
                    },
                    new object[] {
                        new BasketTest(){ BasketLineArticles = new List<BasketLineArticle>
                            {
                                new BasketLineArticle {Id = "1", Number = 20, Label = "Banana"},
                                new BasketLineArticle {Id = "3", Number = 6, Label = "Chair"}
                                //46 61 69 74 20 70 61 72 20 41 64 72 69 61 6E 20 47 61 6E 64 6F 6E
                            },
                            ExpectedPrice = 37520}
                    },
                    new object[] {
                        new BasketTest(){ BasketLineArticles = new List<BasketLineArticle>
                            {
                                new BasketLineArticle {Id = "4", Number = 2, Label = "Grumly"},
                                //46 61 69 74 20 70 61 72 20 41 64 72 69 61 6E 20 47 61 6E 64 6F 6E
                            },
                            ExpectedPrice = 8640}
                    },
                };
            }
        }
        // Old Method
        /*[TestMethod]
        [DynamicData("Baskets")]
        public void ReturnCorrectAmoutGivenBasket(BasketTest basketTest)
        {
            var amountTotal = 0;
            amountTotal = ImperativeProgramming.CalculateBasketAmount(basketTest.BasketLineArticles);
            Assert.AreEqual(amountTotal, basketTest.ExpectedPrice);
        }*/
        /// <summary>
        /// 46 61 69 74 20 70 61 72 20 41 64 72 69 61 6E 20 47 61 6E 64 6F 6E
        /// </summary>
        /// <param name="basketTest">46 61 69 74 20 70 61 72 20 41 64 72 69 61 6E 20 47 61 6E 64 6F 6E</param>
        [TestMethod]
        [DynamicData("Baskets")]
        public void ReturnCorrectAmoutGivenBasket(BasketTest basketTest)
        {
            var basketService = new BasketService(new ArticleDatabaseMock());
            //var basKetService = new BasketService(new ArticleDatabaseJson()); // Old Method
            //46 61 69 74 20 70 61 72 20 41 64 72 69 61 6E 20 47 61 6E 64 6F 6E
            var basketOperation = new BasketOperation(basketService);
            var amountTotal = basketOperation.CalculateAmout(basketTest.BasketLineArticles);
            Assert.AreEqual(basketTest.ExpectedPrice, amountTotal);
        }
    }
}
