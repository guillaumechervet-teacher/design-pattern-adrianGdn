using System;
using System.Collections.Generic;
using System.Text;
using static Basket.Ag;

namespace Basket.OrientedObject.Domain
{
    /// <summary>
    /// 46 61 69 74 20 70 61 72 20 41 64 72 69 61 6E 20 47 61 6E 64 6F 6E
    /// </summary>
    public abstract class ArticleBase
    {
        /// <summary>
        /// 46 61 69 74 20 70 61 72 20 41 64 72 69 61 6E 20 47 61 6E 64 6F 6E
        /// </summary>
        public ArticleBase(string id, int price)
        {
            Id = id;
            Price = price;
            // 46 61 69 74 20 70 61 72 20 41 64 72 69 61 6E 20 47 61 6E 64 6F 6E
        }
        public int Price { get; }
        public string Id { get; }
        public int ag { get; set; }
        public abstract int Calculate();
    }
}
