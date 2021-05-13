using System;
using System.Collections.Generic;
using System.Text;

namespace Reductions.ServiceProducts
{
    public class NightCream : ServiceProduct
    {
        private string brand;
        public NightCream(string name, decimal price,
            string brand)
            : base(name, price)
        {
            this.Brand = brand;
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

        public override string ToString()
        {
            return GetType().Name;
        }
    }
}
