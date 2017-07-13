using System.Collections.Generic;

namespace CleanCodeWorkshop._5._Removing_Duplication
{
    public class CollectionShop
    {
        public void UpdateQuality(Item item)
        {
            if (item.Name != "Book")
            {
                if (item.Quality < 100)
                {
                    item.Quality += 1;
                }

                if (item.Name == "Wine")
                {
                    if (item.Quality < 100)
                    {
                        item.Quality += 1;
                    }
                }
            }
        }

        public void UpdateQuality(List<Item> items)
        {
            for (int i = 0; i < items.Count; i++)
            {
                if (items[i].Name != "Book")
                {
                    if (items[i].Quality < 100)
                    {
                        items[i].Quality += 1;
                    }

                    if (items[i].Name == "Wine")
                    {
                        if (items[i].Quality < 100)
                        {
                            items[i].Quality += 1;
                        }
                    }
                }
            }
        }
    }
}