using System;


namespace Reductions.ServiceProducts
{
    public abstract class ServiceProduct
    {
        private string name;
        private decimal price;
        protected ServiceProduct(string name, decimal price)
        {
            this.Name = name;
            this.Price = price;
        }
        public string Name
        {
            get => this.name;
            private set
            {
                if (string.IsNullOrEmpty(value))
                {
                    throw new ArgumentException("Name cannot be null or empty!");
                }
                this.name = value;
            }
        }

        public decimal Price
        {
            get => this.price;
            private set
            {
                if (value <= 0)
                {
                    throw new ArgumentException("Price cannot be zero or negative!");
                }
                this.price = value;
            }
        }
    }
}
