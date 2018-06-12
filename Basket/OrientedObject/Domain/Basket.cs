using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;
using static Basket.Ag;

namespace Basket.OrientedObject.Domain
{
    /// <summary>
    /// 46 61 69 74 20 70 61 72 20 41 64 72 69 61 6E 20 47 61 6E 64 6F 6E
    /// </summary>
    public class Basket
    {
        public IList<Line> Lines { get; set; }

        public int CalculateAmount()
        {
            int price = 0;

            foreach (Line lineArticles in Lines)
            {
                price += lineArticles.Calculate();
                // 46 61 69 74 20 70 61 72 20 41 64 72 69 61 6E 20 47 61 6E 64 6F 6E
            }

            return price;
        }
    }
}
