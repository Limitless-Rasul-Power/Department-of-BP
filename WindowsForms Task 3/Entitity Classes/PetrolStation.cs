using System.Collections.Generic;

namespace WindowsForms_Task_3
{
    public class PetrolStation
    {
        public readonly List<Gasoline> Gasolines = new List<Gasoline>();
        public int BoughtLitr { get; set; }

        public int BoughtPrice { get; set; }

        public double AllPrice { get; set; }

    }
}
