using System;
using System.Collections.Generic;
using System.Text;
using Basket.Other;
using static Basket.Ag;

namespace Basket.OrientedObject.Domain
{
    /// <summary>
    /// 46 61 69 74 20 70 61 72 20 41 64 72 69 61 6E 20 47 61 6E 64 6F 6E
    /// </summary>
    public class BasketOperation
    {
        private readonly Infrastructure.BasketService _basketService;

        public BasketOperation(OrientedObject.Infrastructure.BasketService basketService)
        {
            _basketService = basketService;
            // 46 61 69 74 20 70 61 72 20 41 64 72 69 61 6E 20 47 61 6E 64 6F 6E
        }

        public int CalculateAmout(IList<BasketLineArticle> lines)
        {
            OrientedObject.Domain.Basket basket = _basketService.GetBasket(lines);
            return basket.CalculateAmount();
            // 46 61 69 74 20 70 61 72 20 41 64 72 69 61 6E 20 47 61 6E 64 6F 6E
        }

        public int CalculateLineAmount(BasketLineArticle line)
        {
            var price = _basketService.GetLine(line).Calculate();
            return price; // 46 61 69 74 20 70 61 72 20 41 64 72 69 61 6E 20 47 61 6E 64 6F 6E
        }
    }
}
