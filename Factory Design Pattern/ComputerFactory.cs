// -------------------------------------------------------------------------------------------------------------------------
// <copyright file="ComputerFactory.cs" company="Bridgelabz">
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
    /// Class Computer Factory
    /// </summary>
    public class ComputerFactory
        {
        /// <summary>
        /// Gets the plan.
        /// </summary>
        /// <param name="computerObj">The computer object.</param>
        /// <returns></returns>
        public Computer GetPlan(string computerObj)
            {
                if (computerObj.Equals("PC"))
                {
                //// if input equal to PC,Create PC Class Object
                    return new PC();
                }

                if (computerObj.Equals("LAPTOP"))
                {
                //// if input equal to LAPTOP,Create Laptop Class Object
                return new Laptop();
                }

                if (computerObj.Equals("SERVER"))
                {
                //// if input equal to SERVER,Create SERVER Class Object
                return new Server();
                }
                //// return Null Object
                return null;
            }
        }
    
}
