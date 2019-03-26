// -------------------------------------------------------------------------------------------------------------------------
// <copyright file="IMaterial.cs" company="Bridgelabz">
//   Copyright © 2018 Company
// </copyright>
// <creator name="Aniket Kamble"/>
// ---------------------------------------------------------------------------------------------------------------------------
namespace Design_Pattern.Observer_Design_Pattern.Book_Observer
{
    using System;
    using System.Collections.Generic;
    using System.Text;

    /// <summary>
    /// IMaterial
    /// </summary>
    public interface IMaterial
    {
        /// <summary>
        /// Subscribes the specified user.
        /// </summary>
        /// <param name="user">The user.</param>
        void Subscribe(User user);
        void UnSubscribe(User user);
        void Notify();
    }
    /// <summary>
    /// Material Class
    /// </summary>
    /// <seealso cref="Design_Pattern.Observer_Design_Pattern.IMaterial" />
    public class Material : IMaterial
    {
        public string name;
        public float BasePrice;
        public float currentPrice;

        List<User> users = new List<User>();
        /// <summary>
        /// Initializes a new instance of the <see cref="Material"/> class.
        /// </summary>
        /// <param name="name">The name.</param>
        /// <param name="BasePrice">The base price.</param>
        public Material(string name, float BasePrice)
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
                //// Check Value
                currentPrice = value;
                if (value <= BasePrice)
                {
                    Notify();
                }
            }
        }
        /// <summary>
        /// Subscribes the specified user.
        /// </summary>
        /// <param name="user">The user.</param>
        public void Subscribe(User user)
        {
            users.Add(user);
        }
        /// <summary>
        /// Uns the subscribe.
        /// </summary>
        /// <param name="user">The user.</param>
        public void UnSubscribe(User user)
        {
            users.Remove(user);
        }
        /// <summary>
        /// Notifies this instance.
        /// </summary>
        public void Notify()
        {
            foreach (User user in users)
            {
                //// Call Uodate
                user.Update(this);
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
