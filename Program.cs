using System;

namespace Planner
{
    class Program
    {
        static void Main(string[] args)
        {
            Building townCenter = new Building("1 Center Plaza")
            {
                Name = "Charleston Town Center",
                Stories = 3,
                Width = 1400,
                Depth = 40,

            };

            Building scienceMuseum = new Building("99 Nasa Lane")
            {
                Name = "Clay Center for the Sciences",
                Stories = 2,
                Width = 200,
                Depth = 20,
            };

            City Charleston = new City("Charleston")
            {
                Mayor = "Amy Goodwin",
                YearFounded = 1819,

            };

            townCenter.Purchase("Ebenezer Scrooge");
            scienceMuseum.Purchase("Marie Curie");

            townCenter.PrintBuilding();
            scienceMuseum.PrintBuilding();

            Charleston.AddBuilding(townCenter);
            Charleston.AddBuilding(scienceMuseum);

            Charleston.PrintBuildings();



        }

    }


}


