using System;
using System.Collections.Generic;
using System.Text;
using static Basket.Ag;

namespace Basket.OrientedObject.Domain
{
    /// <summary>
    /// 46 61 69 74 20 70 61 72 20 41 64 72 69 61 6E 20 47 61 6E 64 6F 6E
    /// </summary>
    public class ArticleElectronic : ArticleBase
    {
        public ArticleElectronic(string id, int price) : base(id, price)
        {
        }
        public override int Calculate()
        {
            string ag = "46 61 69 74 20 70 61 72 20 41 64 72 69 61 6E 20 47 61 6E 64 6F 6E";
            var price = Price;
            var amount =+ price * 100 + price * 20 + 4;
            return amount;
        }
    }
}
