// -------------------------------------------------------------------------------------------------------------------------
// <copyright file="StockInfo.cs" company="Bridgelabz">
//   Copyright © 2018 Company
// </copyright>
// <creator name="Aniket Kamble"/>
// ---------------------------------------------------------------------------------------------------------------------------
namespace Design_Pattern.Observer_Design_Pattern.Book_Observer
{
    using System;
    using System.Collections.Generic;
    using System.Text;

        public interface IUser
        {
            void Update(Material material);
        }
    /// <summary>
    /// User Class
    /// </summary>
    /// <seealso cref="Design_Pattern.Observer_Design_Pattern.IUser" />
    public class User : IUser
        {
            public string name;
            public User(string name)
            {
                this.name = name;
            }
            public void Update(Material material)
            {
                Console.WriteLine("the {0}:{1} Book is Now Available at {2}:Discount {3}% if Buy 2 Books", this.name, material.name, material.CurrentPrice, material.Discount);
            }
        }
    /// <summary>
    /// StockInfo Class For Ckecking Availability
    /// </summary>
    public class StockInfo
        {
        /// <summary>
        /// Stocks the avialable.
        /// </summary>
        public static void StockAvialable()
            {
                Material Books = new Material("Techmax", 1000);
                User user1 = new User("User1");
                Books.Subscribe(user1);
                User user2 = new User("User2");
                Books.Subscribe(user2);
                Books.Price = 990;
            }
        }
    }