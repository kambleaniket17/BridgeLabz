// -------------------------------------------------------------------------------------------------------------------------
// <copyright file="Person.cs" company="Bridgelabz">
//   Copyright © 2018 Company
// </copyright>
// <creator name="Aniket Kamble"/>
// ---------------------------------------------------------------------------------------------------------------------------
namespace Data_Structure.BankingCashCounter
{
    using System;
    using System.Collections.Generic;
    using System.Text;

    /// <summary>
    /// Person class
    /// </summary>
    public class Person
    {
        /// <summary>
        /// The name
        /// </summary>
        private string name;

        /// <summary>
        /// The balance
        /// </summary>
        private double balance;

        /// <summary>
        /// Initializes a new instance of the <see cref="Person"/> class.
        /// </summary>
        /// <param name="name">The name.</param>
        /// <param name="balance">The balance.</param>
        public Person(string name, int balance)
        {
            try
            {
                this.name = name;
                if (balance < 0)
                {
                    Console.WriteLine("Please provide a positive value for balance");
                    return;
                }

                this.balance = balance;
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        /// <summary>
        /// Gets or sets the name.
        /// </summary>
        /// <value>
        /// The name.
        /// </value>
        public string Name
        {
            get { return this.name; }
            set { this.name = value; }
        }

        /// <summary>
        /// Gets or sets the balance.
        /// </summary>
        /// <value>
        /// The balance.
        /// </value>
        public double Balance
        {
            get { return this.balance; }
            set { this.balance = value; }
        }

        /// <summary>
        /// Deposits the specified deposit amount.
        /// </summary>
        /// <param name="depositAmount">The deposit amount.</param>
        /// <returns> returns true or false</returns>
        public bool Deposite(int depositAmount)
        {
            try
            {
                if (depositAmount <= 0)
                {
                    Console.WriteLine("Please Provide a positive value for amount to deposite");
                    Console.ReadKey();
                    return false;
                }

                this.balance = this.balance + depositAmount;
                Console.WriteLine("your total Balance = " + this.balance);
                return true;
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        /// <summary>
        /// Withdraws the specified withdraw amount.
        /// </summary>
        /// <param name="withdrawAmount">The withdraw amount.</param>
        /// <returns> returns true or false</returns>
        public bool Withdraw(int withdrawAmount)
        {
            try
            {
                if (withdrawAmount > this.balance)
                {
                    Console.WriteLine("You dont have enough money in your Account");
                    return false;
                }

                this.balance = this.balance - withdrawAmount;
                Console.WriteLine("Remaining balance = " + this.balance);
                return true;
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }
    }
}
