// -------------------------------------------------------------------------------------------------------------------------
// <copyright file="Deque.cs" company="Bridgelabz">
//   Copyright © 2018 Company
// </copyright>
// <creator name="Aniket Kamble"/>
// ---------------------------------------------------------------------------------------------------------------------------
namespace Data_Structure.PalindromChecker
{
    using System;
    using System.Collections.Generic;
    using System.Text;

    /// <summary>
    /// queue Operations
    /// </summary>
    /// <typeparam name="T">any parameter</typeparam>
    public class Deque<T>
    {
        /// <summary>
        /// The front
        /// </summary>
        private DequeNode<T> front;

        /// <summary>
        /// The rear
        /// </summary>
        private DequeNode<T> rear;

        /// <summary>
        /// The size
        /// </summary>
        private long size = 0;

        /// <summary>
        /// Adds the front.
        /// </summary>
        /// <param name="data">The data.</param>
        public void AddFront(T data)
        {
            try
            {
                //// if front is null , it means this is the first element
                if (this.front == null) 
                {
                    this.front.Data = data;
                    this.rear = this.front;
                }
                else
                {
                    DequeNode<T> tempNode = null;
                    tempNode.Data = data;
                    tempNode.Next = this.front;
                    this.front.Pre = tempNode;
                    this.front = tempNode;
                }

                this.size++; ////increasing the size of queue
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        /// <summary>
        /// Adds the data to rear of queue
        /// </summary>
        /// <param name="data">The data.</param>
        public void Addrear(T data)
        {
            try
            {
                if (this.front == null)
                {
                    DequeNode<T> dequeNode = new DequeNode<T>(data);
                    this.front = dequeNode;
                    this.rear = this.front;
                }
                else
                {
                    DequeNode<T> dequeNode = new DequeNode<T>(data);
                    this.rear.Next = dequeNode;
                    dequeNode.Pre = this.rear;
                    this.rear = dequeNode;
                }

                this.size++;
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        /// <summary>
        /// Removes the front.
        /// </summary>
        /// <returns>returns the removed data from the front </returns>
        public T RemoveFront()
        {
            try
            {
                T dataToRemove = default(T);
                if (this.front == null)
                {
                    Console.WriteLine("Allready empty, nothing to delete");
                }
                else
                {
                    dataToRemove = this.front.Data;
                    this.front = this.front.Next;
                }

                this.size--;
                return dataToRemove;
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        /// <summary>
        /// Removes the rear.
        /// </summary>
        /// <returns>returns the removed data from the rear</returns>
        public T RemoveRear()
        {
            try
            {
                T dataToRemove = default(T);
                if (this.front == null)
                {
                    Console.WriteLine("Allready empty, nothing to delete");
                }
                else
                {
                    dataToRemove = this.rear.Data;
                    this.rear = this.rear.Pre;
                    this.rear.Next = null;
                }

                this.size--;
                return dataToRemove;
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
                if (this.front == null)
                {
                    return true;
                }
                else
                {
                    return false;
                }
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        /// <summary>
        /// Sizes this instance.
        /// </summary>
        /// <returns>returns current size</returns>
        public long Size()
        {
            return this.size;
        }
    }
}
