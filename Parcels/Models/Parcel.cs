using System.Collections.Generic;

namespace Parcels.Models
{
    public class Parcel
    {
        public int Width { get; set; }
        public int Height { get; set; }
        public int Length { get; set; }
        public int Weight { get; set; }
        public int Volume { get; set; }
        public int Cost { get; set; }
        private static List<Parcel> _instances = new List<Parcel> { };

        public Parcel(int width, int height, int length, int weight)
        {
            Width = width;
            Height = height;
            Length = length;
            Weight = weight;
            Volume = 0;
            Cost = 0;
            _instances.Add(this);
        }

        public void CalculateVolume()
        {
            Volume = Width * Height * Length;
        }

        public void CostToShip()
        {
            Cost = (Volume * Weight) / 30;
        }

        public static List<Parcel> GetAll()
        {
            return _instances;
        }
    }
}