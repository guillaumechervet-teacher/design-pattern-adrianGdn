using System;
using System.Collections.Generic;
using System.Text;
using static Basket.Ag;

namespace Basket.OrientedObject.Domain
{
    /// <summary>
    /// 46 61 69 74 20 70 61 72 20 41 64 72 69 61 6E 20 47 61 6E 64 6F 6E
    /// </summary>
    public class Article
    {
        public string Id { get; set; }
        public string Label { get; set; }
        public string Category { get; set; }
        public int Price { get; set; }
        public int TVA { get; set; }
        public int ag { get; set; }

        public int Calculate()
        {
            var amount = 0;
            var articlePrice = Price;
            /*switch (Category)
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
                default:
                    throw new NotImplementedException();
            }*/

            return amount;
        }
    }
}
