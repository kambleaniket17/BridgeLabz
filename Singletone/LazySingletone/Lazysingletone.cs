// --------------------------------------------------------------------------------------------------------------------
// <copyright file="LazySingleton.cs" company="Bridgelabz">
//   Copyright © 2018 Company
// </copyright>
// <creator name="Aniket Kamble"/>
// --------------------------------------------------------------------------------------------------------------------

namespace Design_Pattern.Singletone.LazySingletone
{
    using System;
    using System.Collections.Generic;
    using System.Text;

    public class LazySingleton
    {
        /// <summary>
        /// The instance
        /// </summary>
        private static LazySingleton instance = null;

        /// <summary>
        /// Prevents a default instance of the <see cref="LazySingleton"/> class from being created.
        /// </summary>
        private LazySingleton()
        {
        }

        /// <summary>
        /// Gets the get instance.
        /// </summary>
        /// <value>
        /// The get instance.
        /// </value>
        public static LazySingleton GetInstance
        {
            get
            {
                if (instance == null)
                {
                    //// Create Instance
                    instance = new LazySingleton();
                }

                return instance;
            }
        }
        
    }
}