using System;
using System.Collections.Generic;
using System.Text;

namespace Basket.OrientedObject.Domain
{
    public class Line
    {
        public string Id { get; set; }
        public int Number { get; set; }
        public string Label { get; set; }
        public Article Article { get; set; }


        public int Calculate()
        {
            return Article.Calculate() * Number;
        }
    }
}
