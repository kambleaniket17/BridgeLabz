// -------------------------------------------------------------------------------------------------------------------------
// <copyright file="TransactionInput.cs" company="Bridgelabz">
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
    /// Can deposit and withdraw
    /// </summary>
    public class TransactionInput
    {
        /// <summary>
        /// Deposits the details.
        /// </summary>
        /// <param name="person">The person.</param>
        public static void DepositeDetails(Person person)
        {
            try
            {
                bool loopDeposite = true;

                while (loopDeposite)
                {
                    Console.WriteLine("Enter the Money you want to Deposite,You have currently " + person.Balance + " in your account");
                    string amountToDeposite = Console.ReadLine();

                    if (Utility.IsNumber(amountToDeposite) == false)
                    {
                        Console.WriteLine("Invalid Input");
                        continue;
                    }

                    if (person.Deposite(Convert.ToInt32(amountToDeposite)) == false)
                    {
                        continue;
                    }

                    loopDeposite = false;
                }
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        /// <summary>
        /// Withdraws the amount .
        /// </summary>
        /// <param name="person">The person.</param>
        public static void WithdrawlDetails(Person person)
        {
            try
            {
                bool loopWithdraw = true;
                while (loopWithdraw)
                {
                    Console.WriteLine("Enter the Money you want to Withdraw,You have currently " + person.Balance + " in your account");
                    string amountToWithdraw = Console.ReadLine();

                    if (Utility.IsNumber(amountToWithdraw) == false)
                    {
                        Console.WriteLine("Invalid Input");
                        continue;
                    }

                    if (person.Withdraw(Convert.ToInt32(amountToWithdraw)) == false)
                    {
                        continue;
                    }

                    loopWithdraw = false;
                }
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }
    }
}