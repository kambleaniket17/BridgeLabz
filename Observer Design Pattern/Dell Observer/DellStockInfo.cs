// -------------------------------------------------------------------------------------------------------------------------
// <copyright file="DellStockInfo.cs" company="Bridgelabz">
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
    /// DellStockInfo class
    /// </summary>
    public class DellStockInfo
    {
        /// <summary>
        /// Dells the stock.
        /// </summary>
        public static void DellStock()
        {
            //// Creating Product dell Object,Add Customer and Add Price
            Product Dell = new Product("Dell",1000);
            Customer customer1 = new Customer("Customer1");
            Dell.Subscribe(customer1);
            Customer customer2 = new Customer("Customer2");
            Dell.Subscribe(customer2);
            Dell.Price = 800;
            Dell.UnSubscribe(customer1);
            Dell.Price = 900;
        }
    }
}
