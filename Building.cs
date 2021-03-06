using System;

namespace Planner
{
    public class Building
    {
        private string _designer;
        private DateTime _dateConstructed;
        private string _address;
        private string _owner;

        public string Name {get; set;}
        public int Stories { get; set; }
        public double Width { get; set; }
        public double Depth { get; set; }

        public double Volume
        {
            get
            {
                return Width * Depth * (3 * Stories);

            }
        }

        public Building(string address)
        {
            _address = address;
        }

        public void Construct()
        {
            _dateConstructed = DateTime.Now;
        }

        public void Purchase(string name){
            _owner = name;

        }

        public void PrintBuilding()
        {
            DateTime printTime = _dateConstructed;
            string printOwner = _owner;
            string printAddress = _address;
            Console.WriteLine("---------------");
            Console.WriteLine(printAddress);
            Console.WriteLine($"Constructed on {printTime}");
            Console.WriteLine($"Owned by {printOwner}");
            Console.WriteLine($"{Volume} cubic meters");
        }



    }
}
