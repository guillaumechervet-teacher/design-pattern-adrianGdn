using System;
using System.Collections.Generic;
using System.Text;
using static Basket.Ag;

namespace Basket.OrientedObject.Domain
{
    /// <summary>
    /// 46 61 69 74 20 70 61 72 20 41 64 72 69 61 6E 20 47 61 6E 64 6F 6E
    /// </summary>
    public class Line
    {
        public string Id { get; set; }
        public int Number { get; set; }
        public string Label { get; set; }
        public ArticleBase Article { get; set; }

        public Line(ArticleBase article, int number)
        {
            this.Article = article;
            this.Number = number;
        }

        public Line()
        {

        }

        public int Calculate()
        {
            return Article.Calculate() * Number;
            // 46 61 69 74 20 70 61 72 20 41 64 72 69 61 6E 20 47 61 6E 64 6F 6E
        }
    }
}
