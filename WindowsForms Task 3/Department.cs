using System;

namespace WindowsForms_Task_3
{
    public class Department
    {
        public readonly PetrolStation PetrolStation = new PetrolStation();
        public readonly MiniCafe MiniCafe = new MiniCafe();
        public double AllPetrolAndMiniCafePaidPrice = default;

        public void AddGasoline(Gasoline gasoline)
        {
            if(gasoline != null)
            PetrolStation.Gasolines.Add(gasoline);
        }

        public void AddMeal(Meal meal)
        {
            if (meal != null)
                MiniCafe.Meals.Add(meal);
        }

    }
}
