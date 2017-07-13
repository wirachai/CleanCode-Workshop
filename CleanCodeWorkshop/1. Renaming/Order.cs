using System.Collections.Generic;

namespace CleanCodeWorkshop._1._Renaming
{
    public class Order
    {
        public float Calculate(List<float> list, float p)
        {
            float temp = 0;
            for (int i = 0; i < list.Count; i++)
            {
                temp += list[i];
            }
            return temp + p;
        }
    }
}