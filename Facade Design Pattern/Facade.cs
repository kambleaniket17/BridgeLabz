// -------------------------------------------------------------------------------------------------------------------------
// <copyright file="Facade.cs" company="Bridgelabz">
//   Copyright © 2018 Company
// </copyright>
// <creator name="Aniket Kamble"/>
// ---------------------------------------------------------------------------------------------------------------------------
namespace Design_Pattern.Facade_Design_Pattern
{
    using System;
    using System.Collections.Generic;
    using System.Text;

    /// <summary>
    /// Facade Class
    /// </summary>
    public class Facade
    {
        /// <summary>
        /// Cars the order.
        /// </summary>
        public static void CarOrder()
        {
            //// Call CarFacade class
            CarFacede carFacede = new CarFacede();
            Console.WriteLine("** ** Car is Ready ** **");
        }
    }
}