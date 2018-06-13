using System;
using System.Collections.Generic;
using System.Net.NetworkInformation;
using System.Text;
using static Basket.Ag;

namespace Basket.OrientedObject.Domain.ArticleType
{
    /// <summary>
    /// 46 61 69 74 20 70 61 72 20 41 64 72 69 61 6E 20 47 61 6E 64 6F 6E
    /// </summary>
    public class ArticleToy : ArticleBase
    {
        public ArticleToy(string id, int price) : base(id, price)
        {
        }
        public override int Calculate()
        {
            int price = Price - 3;
            // 46 61 69 74 20 70 61 72 20 41 64 72 69 61 6E 20 47 61 6E 64 6F 6E
            var amount =+ price * 100 + price * 20;
            return amount;
        }
    }
}
