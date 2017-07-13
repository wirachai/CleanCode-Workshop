using System.Collections.Generic;

namespace CleanCodeWorkshop._5._Removing_Duplication
{
    public class CollectionShop
    {
        private const string Book = "Book";
        private const string Wine = "Wine";

        public void UpdateQuality(Item item)
        {
            if (item.Name != Book)
            {
                IncreaseQuality(item);

                if (item.Name == Wine)
                {
                    IncreaseQuality(item);
                }
            }
        }

        public void UpdateQuality(List<Item> items)
        {
            for (int i = 0; i < items.Count; i++)
            {
                var item = items[i];
                UpdateQuality(item);
            }
        }

        private void IncreaseQuality(Item item)
        {
            if (item.Quality < 100)
            {
                item.Quality += 1;
            }
        }
    }
}