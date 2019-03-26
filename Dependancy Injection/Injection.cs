// --------------------------------------------------------------------------------------------------------------------
// <copyright file="Injection.cs" company="Bridgelabz">
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
    /// Dependancy Injection
    /// </summary>
    public class Injection
    {
        /// <summary>
        /// The text
        /// </summary>
        private IText text;

        /// <summary>
        /// Initializes a new instance of the <see cref="ConstructorInjection"/> class.
        /// </summary>
        /// <param name="text1">The text1.</param>
        public Injection(IText text1)
        {
            this.text = text1;
        }

        /// <summary>
        /// Prints this instance.
        /// </summary>
        public void Print()
        {
            this.text.Print();
        }
    }
}
