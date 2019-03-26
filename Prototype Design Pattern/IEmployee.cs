
// -------------------------------------------------------------------------------------------------------------------------
// <copyright file="IEmployee.cs" company="Bridgelabz">
//   Copyright © 2018 Company
// </copyright>
// <creator name="Aniket Kamble"/>
// ---------------------------------------------------------------------------------------------------------------------------
namespace Design_Pattern.Prototype_Design_Pattern
{
    using System;
    using System.Collections.Generic;
    using System.Text;

    public interface IEmployee
    {
        //// Method for cloning
        IEmployee Clone();
    }

    /// <summary>
    /// Permanant Employee
    /// </summary>
    /// <seealso cref="Design_Pattern.Prototype_Design_Pattern.IEmployee" />
    public class PermanentEmployee : IEmployee
    {
        public string Name { get; set; }
        public int Age { get; set; }
        public string EmploymentType { get; set; }

        //// Implement shallow cloning method
        public IEmployee Clone()
        {
            //// Shallow Copy
            return this.MemberwiseClone() as IEmployee;
        }
    }

    /// <summary>
    /// Temporary Employee
    /// </summary>
    /// <seealso cref="Design_Pattern.Prototype_Design_Pattern.IEmployee" />
    public class TemporaryEmployee : IEmployee
    {
        public string Name { get; set; }
        public int Age { get; set; }
        public string EmploymentType { get; set; }

        /// <summary>
        /// Clones this instance.
        /// </summary>
        /// <returns>Clone</returns>
        public IEmployee Clone()
        {
            //// Shallow Copy 
            return this.MemberwiseClone() as IEmployee;
        }
    }
}