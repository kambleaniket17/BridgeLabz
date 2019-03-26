// -------------------------------------------------------------------------------------------------------------------------
// <copyright file="ICustomer.cs" company="Bridgelabz">
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
    /// Interface ICUstomer
    /// </summary>
    public interface ICustomer
{
    /// <summary>
    /// Updates the specified product.
    /// </summary>
    /// <param name="product">The product.</param>
    void Update(Product product);
}
    /// <summary>
    /// class Customer
    /// </summary>
    /// <seealso cref="Design_Pattern.Observer_Design_Pattern.ICustomer" />
    public class Customer : ICustomer
    {
        /// <summary>
        /// The name
        /// </summary>
        public string name;
        /// <summary>
        /// Initializes a new instance of the <see cref="Customer"/> class.
        /// </summary>
        /// <param name="name">The name.</param>
        public Customer(string name)
        {
            this.name = name;
        }
        /// <summary>
        /// Updates the specified product.
        /// </summary>
        /// <param name="product">The product.</param>
        public void Update(Product product)
        {
            Console.WriteLine("the {0}:{1} Laptop is Now Available at {2}:Discount {3}%", this.name, product.name, product.CurrentPrice, product.Discount);
        }
    }
}
