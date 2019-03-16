// -------------------------------------------------------------------------------------------------------------------------
// <copyright file="Stack.cs" company="Bridgelabz">
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
    /// stack class
    /// </summary>
    public class Stack
    {
        /// <summary>
        /// The maximum size
        /// </summary>
        private int maxSize;

        /// <summary>
        /// The stack array
        /// </summary>
        private char[] stackArray;

        /// <summary>
        /// The top
        /// </summary>
        private int top;

        /// <summary>
        /// Stacks the initialize.
        /// </summary>
        /// <param name="stackSize">Size of the stack.</param>
        public void StackInitialise(int stackSize)
        {
            try
            {
                this.maxSize = stackSize; //// to set the maximum size for the stack
                this.stackArray = new char[this.maxSize];
                this.top = -1;
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        /// <summary>
        /// Pushes the specified character.
        /// </summary>
        /// <param name="character">The character.</param>
        public void Push(char character)
        {
            try
            {
                this.top++; //// Top values increases for each pushed data
                this.stackArray[this.top] = character;
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        /// <summary>
        /// Pops this instance.
        /// </summary>
        /// <returns> returns the top element from the stack</returns>
        public long Pop()
        {
            try
            {
                //// checks if weather the current data is the last data in Stack
                if (this.top == 0)
                {
                    this.top--; //// top values keeps decreasing for each popped out data
                    return this.stackArray[this.top + 1];
                }
                else
                {
                    this.top--;
                    return this.stackArray[this.top];
                }
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }  
        }

        /// <summary>
        /// Peeks this instance.
        /// </summary>
        /// <returns>returns the top element</returns>
        public long Peek()
        {
            try
            {
                return this.stackArray[this.top]; ////returns the data which is at the top.
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        /// <summary>
        /// Determines whether this instance is empty.
        /// </summary>
        /// <returns>
        ///   <c>true</c> if this instance is empty; otherwise, <c>false</c>.
        /// </returns>
        public bool IsEmpty()
        {
            try
            {
                return this.top == -1; //// if the Top value is -1 that means the stack is empty
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        /// <summary>
        /// Determines whether this instance is full.
        /// </summary>
        /// <returns>
        ///   <c>true</c> if this instance is full; otherwise, <c>false</c>.
        /// </returns>
        public bool IsFull()
        {
            try
            {
                return this.top == this.maxSize - 1; //// if the top value reaches the max size of stack,it means the stack is full
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }
    }
}
