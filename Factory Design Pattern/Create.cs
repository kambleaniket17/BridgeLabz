// -------------------------------------------------------------------------------------------------------------------------
// <copyright file="Create.cs" company="Bridgelabz">
//   Copyright © 2018 Company
// </copyright>
// <creator name="Aniket Kamble"/>
// ---------------------------------------------------------------------------------------------------------------------------
namespace Design_Pattern.Factory_Design_Pattern
{
    using System;
    using System.Collections.Generic;
    using System.Text;

    /// <summary>
    /// Create Class For Creating Objects
    /// </summary>
    public class Create
    {
        /// <summary>
        /// Creates the object.
        /// </summary>
        public static void CreateObj()
        {
            //// Creating Object As Input
            ComputerFactory factoryData = new ComputerFactory();
            Console.WriteLine("List Of Computer Factory\n1:PC\n2:LAPTOP\n3:SERVER");
            Console.WriteLine("Write Name of Object You Want");
            string objectName = Console.ReadLine();
            objectName = objectName.ToUpper();
            Computer p = factoryData.GetPlan(objectName);
            p.GetObject();
        }
    }
}
