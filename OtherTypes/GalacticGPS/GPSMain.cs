
namespace GalacticGPS
{
    using System;

    public class GPSMain
    {
        public static void Main()
        {
            var location = new Location(18.037986, 28.870097, Planet.Earth);

            Console.WriteLine(location);
        }
    }
}
