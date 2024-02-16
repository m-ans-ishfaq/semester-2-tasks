using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPS.PD4
{
    internal class Angle
    {
        public int Degrees;
        public float Minutes;
        public char Direction;

        public Angle(int Degrees, float Minutes, char Direction)
        {
            this.Degrees = Degrees;
            this.Minutes = Minutes;
            this.Direction = Direction;
        }
        public string GetAngle()
        {
            return $"{Degrees}\u00b0{Minutes}' {Direction}";
        }
    }
    internal class Ship
    {
        public int SerialNumber;
        public Angle Latitude;
        public Angle Longitude;
        public Ship(int SerialNumber, Angle Latitude, Angle Longitude)
        {
            this.SerialNumber = SerialNumber;
            this.Latitude = Latitude;
            this.Longitude = Longitude;
        }
        public void PrintPosition()
        {
            Console.WriteLine($"Longitude: {Longitude.GetAngle()}");
            Console.WriteLine($"Latitude: {Latitude.GetAngle()}");
        }
        public void PrintSerialNumber()
        {
            Console.WriteLine($"Serial Number: {SerialNumber}");
        }
    }
}
