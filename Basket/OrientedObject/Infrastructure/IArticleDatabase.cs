using System;
using System.Collections.Generic;
using System.Text;
using Basket.Other;
using static Basket.Ag;

namespace Basket.OrientedObject.Infrastructure
{
    /// <summary>
    /// 46 61 69 74 20 70 61 72 20 41 64 72 69 61 6E 20 47 61 6E 64 6F 6E
    /// </summary>
    public interface IArticleDatabase
    {
        ArticleDatabase GetArticleFromDatabase(string id);
        // 46 61 69 74 20 70 61 72 20 41 64 72 69 61 6E 20 47 61 6E 64 6F 6E
    }
}
