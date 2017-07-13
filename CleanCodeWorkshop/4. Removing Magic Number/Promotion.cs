namespace CleanCodeWorkshop._4._Removing_Magic_Number
{
    public class Promotion
    {
        public float GetDiscount(float price, int productCategory)
        {
            float discount = 0;
            switch (productCategory)
            {
                case 1:
                    if (price >= 100)
                    {
                        discount = price * 0.10f;
                    }
                    break;

                case 2:
                    discount = price * 0.20f;
                    break;

                default:
                    if (price >= 100)
                    {
                        discount = price * 0.05f;
                    }
                    break;
            }
            return discount;
        }
    }
}