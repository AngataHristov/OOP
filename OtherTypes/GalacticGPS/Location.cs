using System;

namespace GalacticGPS
{
    using System;

    public struct Location
    {
        private double latitude;
        private double longtitude;

        public Location(double latitude, double longtitude, Planet planet) : this()
        {
            this.Latitude = latitude;
            this.Longtitude = longtitude;
            this.Planet = planet;
        }

        public Planet Planet { get; set; }

        public double Latitude
        {
            get
            {
                return this.latitude;
            }
            private set
            {
                if (value < -90 || value > 90)
                {
                    throw new ArgumentOutOfRangeException("Latitude must be between -90 and 90 degrees inclusive.");
                }

                this.latitude = value;
            }
        }

        public double Longtitude
        {
            get
            {
                return this.longtitude;
            }
            private set
            {
                if (value < -180 || value > 180)
                {
                    throw new ArgumentOutOfRangeException("Longitude must be between -180 and 180 degrees inclusive.");
                }

                this.longtitude = value;
            }
        }

        public override string ToString()
        {
            return string.Format("{0}, {1} - {2}", this.Latitude, this.Longtitude, this.Planet);
        }
    }
}
