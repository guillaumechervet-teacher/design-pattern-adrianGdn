using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Reflection;
using Basket;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Newtonsoft.Json;

namespace BasketTest
{
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
            get
            {
                return new[]
                { new object[] {
                        new BasketTest(){ BasketLineArticles = new List<BasketLineArticle>
                            {
                                new BasketLineArticle {Id = "1", Number = 12, Label = "Banana"},
                                new BasketLineArticle {Id = "2", Number = 1, Label = "Fridgeelectrolux"},
                                    new BasketLineArticle {Id = "3", Number = 4, Label = "Chair"}
                            },
                            ExpectedPrice = 84868}
                        },
                        new object[] {
                            new BasketTest(){ BasketLineArticles = new List<BasketLineArticle>
                                {
                                    new BasketLineArticle {Id = "1", Number = 20, Label = "Banana"},
                                    new BasketLineArticle {Id = "3", Number = 6, Label = "Chair"}
                                },
                                ExpectedPrice = 37520}
                        },
                    };
                }
        }
            [TestMethod]
            [DynamicData("Baskets")]
            public void ReturnCorrectAmoutGivenBasket(BasketTest basketTest)
            {
            var amountTotal = 0;
                amountTotal = ImperativeProgramming.CalculateBasketAmount(basketTest.BasketLineArticles);
                Assert.AreEqual(amountTotal, basketTest.ExpectedPrice);
            }
    }
}
