using System;
using System.Collections.Generic;

namespace Planner
{

    public class City
    {

        public City(string name)
        {
            Name = name;
            // CityBuildings = initialBuildings; 
        }
        public string Name { get; set; }
        public string Mayor { get; set; }
        public int YearFounded { get; set; }

        public List<Building> CityBuildings { get; set;} = new List<Building>();

        

        public void AddBuilding(Building building)
        {
            CityBuildings.Add(building);
        }

        public void PrintBuildings(){
            Console.WriteLine($"Buildings in the city of {Name}");
            CityBuildings.ForEach(building => Console.WriteLine(building.Name));
        }
    }




}