using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace login_tutorial
{
    internal class DistanceCalculator
    {
        public Decimal CalDistance(List<GeoLocator> positions)
        {
            //creates the initial value of the distance at the start of the journey
            Decimal distance = 0;
            for (int i = 1; i < positions.Count; i++) 
            {
                // this code goes through all positions in the list and uses iteration to perform a haversine formula every 10 seconds to calculate the total distance travelled
                Double World = 6378.137;
                Double dLat = Convert.ToDouble(positions[i - 1].returnLat()) * Math.PI / 180 - Convert.ToDouble(positions[i].returnLat()) * Math.PI / 180;
                Double dLong = Convert.ToDouble(positions[i - 1].returnLong()) * Math.PI / 180 - Convert.ToDouble(positions[i].returnLong()) * Math.PI / 180;
                Double a = Math.Sin(dLat / 2) * Math.Sin(dLat / 2) + Math.Cos(Convert.ToDouble(positions[i].returnLat()) * Math.PI / 180) * Math.Cos(Convert.ToDouble(positions[i - 1].returnLat()) * Math.PI / 180) * Math.Sin(dLong / 2) * Math.Sin(dLong / 2);
                Double c = 2 * Math.Atan2(Math.Sqrt(a), Math.Sqrt(1 - a));
                Double d = World * c;
                distance = distance + Convert.ToDecimal(d / 1000);
                // the code below was the first concept of measuring the distance between points
                //Double val = (Math.Sqrt((Math.Pow(Convert.ToDouble(positions[i].returnLat()) - Convert.ToDouble(positions[i - 1].returnLat()),2)     + (Math.Pow(Convert.ToDouble(positions[i].returnLong()) - Convert.ToDouble(positions[i - 1].returnLong()), 2)))));
                //distance = distance + Convert.ToDecimal(val);
            }
            return distance;
        }
    }
}
