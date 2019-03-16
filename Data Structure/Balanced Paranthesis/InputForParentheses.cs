// -------------------------------------------------------------------------------------------------------------------------
// <copyright file="InputForParentheses.cs" company="Bridgelabz">
//   Copyright © 2018 Company
// </copyright>
// <creator name="Aniket Kamble"/>
// ---------------------------------------------------------------------------------------------------------------------------

namespace Data_Structure.BalancedParenthses
{
    using System;
    using System.Collections.Generic;
    using System.Text;

    /// <summary>
    /// Takes required input To Check Parentheses
    /// </summary>
    public class InputForParentheses
    {
        /// <summary>
        /// Checks the parentheses.
        /// </summary>
        public static void CheckParentheses()
        {
            string userExpression = string.Empty;
            long expressionlength = 0;

            try
            {
                Stack stack = new Stack();

                stack.StackInitialise(Convert.ToInt32(150));

                ////keep asking until valid expression is given
                bool loopForExpression = true;

                expressionLength: ////goto lable for this while loop
                while (loopForExpression)
                {
                    Console.WriteLine("Enter the Expression");
                    userExpression = Console.ReadLine();

                    if (Utility.CheckString(userExpression))
                    {
                        Console.WriteLine("invlaid Expression");
                        continue;
                    }

                    break;
                }

                expressionlength = userExpression.Length;
                //// checks if the expression starts with ')' and gives message (Invalid expression)
                for (int i = 0; i < expressionlength; i++)
                {
                    char character = userExpression[i];

                    if (character == '(')
                    {
                        break;
                    }

                    if (character == ')')
                    {
                        Console.WriteLine("Invalid Expression");
                        goto expressionLength; //// goes to the lable to ask for expression again.
                    }
                }

                ////loop our each letter in the expression 
                for (int i = 0; i < expressionlength; i++)
                {
                    char character = userExpression[i];

                    //// pushes the charcter '(' if found.
                    if (character == '(')
                    {
                        stack.Push(character);
                    }
                    else
                    {
                        //// pops the caharacter  ')' out of stack if found
                        if (character == ')')
                        {
                            try
                            {
                                stack.Pop();
                            }
                            catch (Exception)
                            {
                                Console.WriteLine("Experession is  not Balanced Parentheses");
                                Console.Read();
                            }
                        }
                    }
                }

                ////if Stack is Empty ,it means the Expression is Balanced
                if (stack.IsEmpty())
                {
                    Console.WriteLine("Experession have Balanced Parentheses");
                    Console.Read();
                }
                else
                {
                    Console.WriteLine("Experession is not Balanced Parentheses");
                    Console.Read();
                }
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }
    }
}
