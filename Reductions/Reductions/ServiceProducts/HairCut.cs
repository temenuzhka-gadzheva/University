using System;


namespace Reductions.ServiceProducts
{
    public class HairCut : ServiceProduct
    {
        private string style;
        public HairCut(string name, decimal price,
            string style) 
            : base(name, price)
        {
            this.Style = style;
        }
        public string Style
        {
            get => this.style;
            private set
            {
                if (string.IsNullOrEmpty(value))
                {
                    throw new ArgumentException("Style cannot be null or empty!");
                }
                this.style = value;
            }
        }

        public override string ToString()
        {
            return GetType().Name;
        }
    }
}
