using System;
using System.Collections.Generic;
using System.Text;

namespace Basket.OrientedObject.Domain
{
    public class Article
    {
        public string Id { get; set; }
        public string Label { get; set; }
        public string Category { get; set; }
        public int Price { get; set; }
        public int TVA { get; set; }

        public int Calculate()
        {
            var amount = 0;
            var articlePrice = Price;
            switch (Category)
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
            }

            return amount;
        }
    }
}
