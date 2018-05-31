using System;
using System.Collections.Generic;
using System.Text;

namespace Basket.OrientedObject.Domain
{
    public class BasketOperation
    {
        private readonly Infrastructure.BasketService _basketService;

        public BasketOperation(OrientedObject.Infrastructure.BasketService basketService)
        {
            _basketService = basketService;
        }

        public int CalculateAmout(IList<BasketLineArticle> lines)
        {
            OrientedObject.Domain.Basket basket = _basketService.GetBasket(lines);
            return basket.CalculateAmount();
        }
    }
}
