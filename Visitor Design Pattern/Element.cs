// -------------------------------------------------------------------------------------------------------------------------
// <copyright file="Element.cs" company="Bridgelabz">
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
    /// Element Abstract Class
    /// </summary>
    public abstract class Element
    {
        /// <summary>
        /// Accepts the specified visitor.
        /// </summary>
        /// <param name="visitor">The visitor.</param>
        public abstract void Accept(IVisitor visitor);
    }
    /// <summary>
    /// Employee Class
    /// </summary>
    /// <seealso cref="Design_Pattern.Visitor_Design_Pattern.Element" />
    public class Employee : Element
    {
        public string Name { get; set; }
        public double AnnualSalary { get; set; }
        public int PaidOffDay { get; set; }
        /// <summary>
        /// Initializes a new instance of the <see cref="Employee"/> class.
        /// </summary>
        /// <param name="name">The name.</param>
        /// <param name="annualSalary">The annual salary.</param>
        /// <param name="paidOffDay">The paid off day.</param>
        public Employee(string name,double annualSalary,int paidOffDay)
        {
            Name = name;
            AnnualSalary = annualSalary;
            PaidOffDay = paidOffDay;
        }
        /// <summary>
        /// Accepts the specified visitor.
        /// </summary>
        /// <param name="visitor">The visitor.</param>
        public override void Accept(IVisitor visitor)
        {
            visitor.Visit(this);
        }
    }
}