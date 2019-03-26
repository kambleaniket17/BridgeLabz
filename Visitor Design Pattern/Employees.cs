// -------------------------------------------------------------------------------------------------------------------------
// <copyright file="Employees.cs" company="Bridgelabz">
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
    /// Employee
    /// </summary>
    public class Employees
    {
        private List<Employee> employees = new List<Employee>();
        /// <summary>
        /// Adds the specified employee.
        /// </summary>
        /// <param name="employee">The employee.</param>
        public void Add(Employee employee)
        {
            employees.Add(employee);
        }
        /// <summary>
        /// Detaches the specified employee.
        /// </summary>
        /// <param name="employee">The employee.</param>
        public void Detach(Employee employee)
        {
            employees.Add(employee);
        }
        /// <summary>
        /// Accepts the specified visitor.
        /// </summary>
        /// <param name="visitor">The visitor.</param>
        public void Accept(IVisitor visitor)
        {
            foreach(Employee employee in employees)
            {
                employee.Accept(visitor);
            }
            Console.WriteLine();
        }
    }
    /// <summary>
    /// 
    /// </summary>
    /// <seealso cref="Design_Pattern.Visitor_Design_Pattern.Employee" />
    public class LineBook : Employee
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="LineBook"/> class.
        /// </summary>
        public LineBook() : base("Suraj",32500,2)
        {

        }
        
    }
    /// <summary>
    /// HeadChef Class
    /// </summary>
    /// <seealso cref="Design_Pattern.Visitor_Design_Pattern.Employee" />
    class HeadChef : Employee
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="HeadChef"/> class.
        /// </summary>
        public HeadChef() : base("Jackson", 69015, 21)
        {
        }
    }

    /// <summary>
    /// GeneralManager Class
    /// </summary>
    /// <seealso cref="Design_Pattern.Visitor_Design_Pattern.Employee" />
    class GeneralManager : Employee
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="GeneralManager"/> class.
        /// </summary>
        public GeneralManager() : base("Amanda", 78000, 24)
        {
        }
    }

    /// <summary>
    /// Visitor Class
    /// </summary>
    public class Visitor
    {
        /// <summary>
        /// Visitors the information.
        /// </summary>
        public static void VisitorInfo()
    {
            //// Call Emploee and check Income And PaidOff Days
        Employees e = new Employees();
        e.Add(new LineBook());
        e.Add(new HeadChef());
        e.Add(new GeneralManager());

        // Employees are visited, giving them 10% raises and 3 extra paid time off days.
        e.Accept(new IncomeVisitor());
        e.Accept(new PaidOffDays());
        }
    }
}