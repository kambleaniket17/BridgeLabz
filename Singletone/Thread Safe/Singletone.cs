// --------------------------------------------------------------------------------------------------------------------
// <copyright file="ThreadSafe.cs" company="Bridgelabz">
//   Copyright © 2018 Company
// </copyright>
// <creator name="Aniket Kamble"/>
// --------------------------------------------------------------------------------------------------------------------

namespace Design_Pattern.Singletone.ThreadSafe
{
    using System;
    using System.Collections.Generic;
    using System.Text;

    /// <summary>
    /// Sealed ThreadSafe Class
    /// </summary>
    public sealed class ThreadSafe
    {
        /// <summary>
        /// Thread Safe Constructor
        /// </summary>
        private ThreadSafe()
        {

        }
        private static readonly object Padlock = new object();
        private static ThreadSafe instance = null;
        public static ThreadSafe Instance
        {
            get
            {
                lock(Padlock)
                {
                if(instance==null)
                {
                    //// Create Instance
                    instance = new ThreadSafe();
                }
                 return instance;
                }
            }
        }
    }
}