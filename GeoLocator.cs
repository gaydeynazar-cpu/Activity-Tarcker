using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Device.Location;
using System.Windows.Forms;

namespace login_tutorial
{
    internal class GeoLocator
    {
        // casts 2 variables that would act as the position variables
        Decimal latitude;
        Decimal longitude;

        public GeoLocator() 
        {
            // this class would use 2 functions to detrmine the user's current position.
            SetLat();
            SetLong();
        }

        public Decimal returnLat()
        {
            return latitude;
        }

        public Decimal returnLong()
        {
            return longitude;
        }

        void SetLat()
        {
            // this algorithm uses geo coordinate watcher to generate latitude
            GeoCoordinateWatcher watcher = new GeoCoordinateWatcher(GeoPositionAccuracy.Default);
            watcher.TryStart(false, TimeSpan.FromMilliseconds(1000));
            GeoCoordinate coord = watcher.Position.Location;
            if (coord.IsUnknown != true)
            {
                latitude = Convert.ToDecimal(coord.Latitude);
            }
        }
        void SetLong()
        {
            // this algorithm uses geo coordinate watcher to generate longitude
            GeoCoordinateWatcher watcher = new GeoCoordinateWatcher(GeoPositionAccuracy.Default);
            watcher.TryStart(false, TimeSpan.FromMilliseconds(1000));
            GeoCoordinate coord = watcher.Position.Location;
            if (coord.IsUnknown != true)
            {
                longitude = Convert.ToDecimal(coord.Longitude);
            }
        }
    }
}
