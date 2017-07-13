using System.Collections.Generic;

namespace CleanCodeWorkshop._1._Renaming
{
    public class Order
    {
        public float GetTotalPrice(List<float> prices, float shippingCost)
        {
            float subTotalPrice = 0;
            for (int i = 0; i < prices.Count; i++)
            {
                subTotalPrice += prices[i];
            }
            return subTotalPrice + shippingCost;
        }
    }
}