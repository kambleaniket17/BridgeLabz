// --------------------------------------------------------------------------------------------------------------------
// <copyright file="IText.cs" company="Bridgelabz">
//   Copyright © 2018 Company
// </copyright>
// <creator Name="Aniket Kamble"/>
// --------------------------------------------------------------------------------------------------------------------
namespace Design_Pattern.Injection
{
    using System;
    using System.Collections.Generic;
    using System.Text;

    /// <summary>
    /// class to implement interface
    /// </summary>
    /// <seealso cref="Implementations.Text" />
    public class Format : IText
    {
        /// <summary>
        /// Prints this instance.
        /// </summary>
        public void Print()
        {
            Console.WriteLine("it's text format");
        }
    }
}
