using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;

namespace Basket.OrientedObject.Domain
{
    public class Basket
    {
        public IList<Line> Lines { get; set; }

        public int CalculateAmount()
        {
            int price = 0;

            foreach (Line lineArticles in Lines)
            {
                price += lineArticles.Calculate();
            }

            return price;
        }
    }
}
