namespace CleanCodeWorkshop._4._Removing_Magic_Number
{
    public class Promotion
    {
        private const int MinPriceForPromotion = 100;
        private const float StandardDiscount = 0.05f;
        private const float ShirtDiscount = 0.10f;
        private const float JeanDiscount = 0.20f;

        public float GetDiscount(float price, int productCategory)
        {
            float discount = 0;
            switch (productCategory)
            {
                case ProductCategory.Shirt:
                    if (price >= MinPriceForPromotion)
                        discount = price * ShirtDiscount;
                    break;
                case ProductCategory.Jean:
                    discount = price * JeanDiscount;
                    break;
                default:
                    if (price >= MinPriceForPromotion)
                        discount = price * StandardDiscount;
                    break;
            }
            return discount;
        }
    }

    public static class ProductCategory
    {
        public const int Shirt = 1;
        public const int Jean = 2;
    }
}