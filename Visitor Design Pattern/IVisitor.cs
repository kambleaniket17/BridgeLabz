// -------------------------------------------------------------------------------------------------------------------------
// <copyright file="IVisitor.cs" company="Bridgelabz">
//   Copyright © 2018 Company
// </copyright>
// <creator name="Aniket Kamble"/>
// ---------------------------------------------------------------------------------------------------------------------------
namespace Design_Pattern.Visitor_Design_Pattern
{
    using System;
    using System.Collections.Generic;
    using System.Text;

    /// <summary>
    /// IVisitor class
    /// </summary>
    public interface IVisitor
    {
        void Visit(Element element);
    }
    /// <summary>
    /// IncomeVisitor class
    /// </summary>
    /// <seealso cref="Design_Pattern.Visitor_Design_Pattern.IVisitor" />
    public class IncomeVisitor : IVisitor
    {
        /// <summary>
        /// Visits the specified element.
        /// </summary>
        /// <param name="element">The element.</param>
        public void Visit(Element element)
        {
            //// Claculate New Income
            Employee employee = element as Employee;
            employee.AnnualSalary  *= 1.10;
            Console.WriteLine("{0}{1} Employee has New Income {2:C}=",employee.GetType().Name,employee.Name,employee.AnnualSalary);
        }
    }
    /// <summary>
    /// PiadoffDays class
    /// </summary>
    /// <seealso cref="Design_Pattern.Visitor_Design_Pattern.IVisitor" />
    public class PaidOffDays : IVisitor
    {
        /// <summary>
        /// Visits the specified element.
        /// </summary>
        /// <param name="element">The element.</param>
        public void Visit(Element element)
        {
            //// claculate PaidOffDays
            Employee employee = element as Employee;
            employee.PaidOffDay += 3;
            Console.WriteLine("{0}{1} Employess new PiadOffDays {2}",employee.GetType().Name,employee.Name, employee.PaidOffDay);
        }
    }
}