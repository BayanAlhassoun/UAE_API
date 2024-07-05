using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UAE_TheLearningHub.Core.DTO
{
    public class Weather
    {
        public string Name { get; set; }
        public int timezone { get; set; }
        public int visibility { get; set; }
        public Coord Coord { get; set; }
        public Wind Wind { get; set; }

        public Main Main { get; set; }
    }

   public  class Coord
    {
        public double Lon { get; set; }
        public double Lat { get; set; }
    }

    public class Wind
    {
        public double Speed { get; set; }
    }

    public class Main
    {
        public double temp { get; set; }

        public int Humidity { get; set; }
    }
}
