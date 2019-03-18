// -------------------------------------------------------------------------------------------------------------------------
// <copyright file="Stock.cs" company="Bridgelabz">
//   Copyright © 2018 Company
// </copyright>
// <creator name="Aniket Kamble"/>
// ---------------------------------------------------------------------------------------------------------------------------
namespace Object_Oriented.Stock
{
    using System;
    using System.Collections.Generic;
    using System.Text;

    /// <summary>
    /// Stock
    /// </summary>
    public class Stock
        {
            /// <summary>
            /// Gets or sets the identifier.
            /// </summary>
            /// <value>
            /// The identifier.
            /// </value>
            public int id { get; set; }

            /// <summary>
            /// Gets or sets the name.
            /// </summary>
            /// <value>
            /// The name.
            /// </value>
            public string name { get; set; }

            /// <summary>
            /// Gets or sets the available shares.
            /// </summary>
            /// <value>
            /// The available shares.
            /// </value>
            public int shares { get; set; }

            /// <summary>
            /// Gets or sets the price.
            /// </summary>
            /// <value>
            /// The price.
            /// </value>
            public int Price { get; set; }
        }
    }

