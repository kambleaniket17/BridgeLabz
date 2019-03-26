// -------------------------------------------------------------------------------------------------------------------------
// <copyright file="IProduct.cs" company="Bridgelabz">
//   Copyright © 2018 Company
// </copyright>
// <creator name="Aniket Kamble"/>
// ---------------------------------------------------------------------------------------------------------------------------
namespace Design_Pattern.Observer_Design_Pattern
{
    using System;
    using System.Collections.Generic;
    using System.Text;

    /// <summary>
    /// Interface IProduct
    /// </summary>
    public interface IProduct
    {
        /// <summary>
        /// Subscribes the specified customer.
        /// </summary>
        /// <param name="customer">The customer.</param>
        void Subscribe(Customer customer);
        void UnSubscribe(Customer customer);
        void Notify();
    }

    /// <summary>
    /// Product Class
    /// </summary>
    /// <seealso cref="Design_Pattern.Observer_Design_Pattern.IProduct" />
    public class Product : IProduct
    {
        /// <summary>
        /// The name
        /// </summary>
        public string name;
        /// <summary>
        /// The base price
        /// </summary>
        public float BasePrice;
        /// <summary>
        /// The current price
        /// </summary>
        public float currentPrice;

        List<Customer> customers = new List<Customer>();

        /// <summary>
        /// Initializes a new instance of the <see cref="Product"/> class.
        /// </summary>
        /// <param name="name">The name.</param>
        /// <param name="BasePrice">The base price.</param>
        public Product(string name, float BasePrice)
        {
            this.name = name;
            this.BasePrice = BasePrice;
            this.currentPrice = BasePrice;
        }

        /// <summary>
        /// Gets or sets the price.
        /// </summary>
        /// <value>
        /// The price.
        /// </value>
        public float Price
        {
            get
            {
                //// Current Price
                return CurrentPrice;
            }
            set
            {
                currentPrice = value;
                //// Check BasePrice
                if (value <= BasePrice)
                {
                    //// Notify To All Subscribers
                    Notify();
                }
            }
        }
        /// <summary>
        /// Subscribes the specified customer.
        /// </summary>
        /// <param name="customer">The customer.</param>
        public void Subscribe(Customer customer)
        {
            customers.Add(customer);
        }
        /// <summary>
        /// Uns the subscribe.
        /// </summary>
        /// <param name="customer">The customer.</param>
        public void UnSubscribe(Customer customer)
        {
            customers.Remove(customer);
        }
        /// <summary>
        /// Notifies this instance.
        /// </summary>
        public void Notify()
        {
            foreach (Customer customer in customers)
            {
                //// Update Info
                customer.Update(this);
            }
        }
        /// <summary>
        /// Gets the name.
        /// </summary>
        /// <value>
        /// The name.
        /// </value>
        public string Name
        {
            get
            {
                return name;
            }
        }
        /// <summary>
        /// Gets the discount.
        /// </summary>
        /// <value>
        /// The discount.
        /// </value>
        public float Discount
        {
            get
            {
                return (BasePrice - CurrentPrice) * 100 / BasePrice;
            }
        }
        /// <summary>
        /// Gets the current price.
        /// </summary>
        /// <value>
        /// The current price.
        /// </value>
        public float CurrentPrice
        {
            get
            {
                return currentPrice;
            }
        }
    }
}
