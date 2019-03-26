// -------------------------------------------------------------------------------------------------------------------------
// <copyright file="Client.cs" company="Bridgelabz">
//   Copyright © 2018 Company
// </copyright>
// <creator name="Aniket Kamble"/>
// ---------------------------------------------------------------------------------------------------------------------------
namespace Design_Pattern.Prototype_Design_Pattern
{
    using System;
    using System.Collections.Generic;
    using System.Text;

    /// <summary>
    /// Clone Class
    /// </summary>
    public class Clone
    {
        /// <summary>
        /// Creates the clone.
        /// </summary>
        public static void CreateClone()
        {
            //// Call Permanant and Temporory Class
            PermanentEmployee permanentEmployee = new PermanentEmployee();
            permanentEmployee.Name = "Sam";
            permanentEmployee.Age = 25;
            permanentEmployee.EmploymentType = "Permanent";
            PermanentEmployee permanentEmployeeClone = (PermanentEmployee)permanentEmployee.Clone();
            permanentEmployeeClone.Name = "Tom";
            permanentEmployeeClone.Age = 30;

            Console.WriteLine("Permanent Employee Details");
            Console.WriteLine("Name: {0}; Age: {1}; Employment Type: {2}", permanentEmployee.Name, permanentEmployee.Age, permanentEmployee.EmploymentType);

            Console.WriteLine("Cloned Permanent Employee Details");
            Console.WriteLine("Name: {0}; Age: {1}; Employment Type: {2}", permanentEmployeeClone.Name, permanentEmployeeClone.Age, permanentEmployeeClone.EmploymentType);
            Console.ReadLine();
        }
    }
}