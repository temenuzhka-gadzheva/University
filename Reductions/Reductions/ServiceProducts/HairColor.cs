using System;


namespace Reductions.ServiceProducts
{
    public class HairColor : ServiceProduct
    {
        private string brand;
        private string color;
        public HairColor(string name, decimal price, 
            string brand, string color) 
            : base(name, price)
        {
            this.Brand = brand;
            this.Color = color;
        }
        public string Brand
        {
            get => this.brand;
            private set
            {
                if (string.IsNullOrEmpty(value))
                {
                    throw new ArgumentException("Brand cannot be null or empty!");
                }
                this.brand = value;
            }
        }
        public string Color
        {
            get => this.color;
            private set
            {
                if (string.IsNullOrEmpty(value))
                {
                    throw new ArgumentException("Color cannot be null or empty!");
                }
                this.color = value;
            }
        }

        public override string ToString()
        {
            return GetType().Name;
        }
    }
}
