using Reductions.MemberShips;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Reductions.Customers
{
  public  class Customer
    {
        private string name;
        private string phone;
        private readonly Dictionary<Customer, MemberShip> keyValuePairs;
        public Customer(string name, string phone)
        {
            this.Name = name;
            this.Phone = phone; 
            this.keyValuePairs = new Dictionary<Customer, MemberShip>();
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
        public string Phone
        {
            get => this.phone;
            private set
            {
                if (string.IsNullOrEmpty(value))
                {
                    throw new ArgumentException("Phone cannot be null or empty!");
                }
                if (value.Length != 10)
                {
                    throw new ArgumentException("Phone contains 10 symbols!");
                }
                if (!value.All(char.IsDigit))
                {
                    throw new ArgumentException("Phone contains only digits !");
                }
                this.phone = value;
            }
        }
       
   
        public void GetReduce(string name, string phone, MemberShip memberShip)
        {

            if (this.keyValuePairs.Keys.Any(c => c.Name == name || c.Phone == phone))
            {
                throw new InvalidOperationException($"Customenr with this Name {Name} and phone {Phone} already exist!");
            }
            Customer customer = new Customer(name, phone);
            this.keyValuePairs.Add(customer, memberShip);

            if (memberShip.GetType().Name == "Premium")
            {
                memberShip.GetDiscount();
            }
            else if (memberShip.GetType().Name == "Gold")
            {
                memberShip.GetDiscount();

            }
            else if (memberShip.GetType().Name == "Silver")
            {
                memberShip.GetDiscount();

            }
            else if (memberShip.GetType().Name == "NotMember")
            {
                memberShip.GetDiscount();

            }
            else
            {
                throw new InvalidOperationException("Invalid membership!");
            }


        }
      

        public override string ToString()
        {
            return GetType().Name;
        }
    }
}
