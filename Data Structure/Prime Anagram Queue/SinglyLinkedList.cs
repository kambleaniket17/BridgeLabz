// -------------------------------------------------------------------------------------------------------------------------
// <copyright file="SinglyLinkedList.cs" company="Bridgelabz">
//   Copyright © 2018 Company
// </copyright>
// <creator name="Aniket Kamble"/>
// ---------------------------------------------------------------------------------------------------------------------------
namespace Data_Structure.PrimeAnagramQueue
{
    using System;
    using System.Collections.Generic;
    using System.Text;

    /// <summary>
    /// Singly linked list
    /// </summary>
    public class SinglyLinkedList : ILinkedList
    {
        /// <summary>
        /// The head
        /// </summary>
        private Node front;

        /// <summary>
        /// The last
        /// </summary>
        private Node rear;

        /// <summary>
        /// The size
        /// </summary>
        private long size = 0;

        /// <summary>
        /// Adds the specified number.
        /// </summary>
        /// <param name="number">The number.</param>
        /// <returns>
        /// returns true or false
        /// </returns>
        public bool Add(string data)
        {
            //// Console.WriteLine(data);
            try
            {
                Node n = new Node(data, this.size);
                this.size++;
               // Console.WriteLine(data);
                if (this.front == null && this.rear == null)
                {
                    this.front = n;
                    this.rear = n;
                }
                else
                {
                    this.rear.Next = n;
                    this.rear = n;
                }
                Console.WriteLine(data);
                return true;
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        /// <summary>
        /// Determines whether this instance contains the object.
        /// </summary>
        /// <param name="word">The number.</param>
        /// <returns>
        /// <c>true</c> if [contains] [the specified number]; otherwise, <c>false</c>.
        /// </returns>
        public bool Contains(string word)
        {
            try
            {
                Node temp = rear;

                while (temp != null)
                {
                    if (temp.Data.Equals(word))
                    {
                        return true;
                    }

                    temp = temp.Next;
                }

                return false;
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        /// <summary>
        /// Deletes the specified number to delete.
        /// </summary>
        /// <param name="numberToDelete">The number to delete.</param>
        /// <returns>returns true or false</returns>
        public bool Dequeue(string numberToDelete)
        {
            try
            {
                if (this.front == null)
                {
                    Console.WriteLine("Stack Underflow. Deletion not possible");
                    return false;
                }

                Console.WriteLine("Item popped is {0}", front);
                front = front.Next;
                this.size = this.size - 1;
                return true;
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
        /// <c>true</c> if this instance is empty; otherwise, <c>false</c>.
        /// </returns>
        public bool IsEmpty()
        {
            try
            {
                if (this.size == 0)
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
        /// Prints this instance.
        /// </summary>
        public void Print()
        {
            try
            {
                if (this.front == null)
                {
                    Console.WriteLine("List is empty");
                }
                else
                {
                    Node temp = this.front;
                    while (temp != null)
                    {
                        Console.WriteLine(temp.Data + " " + temp.Position);
                        temp = temp.Next;
                    }
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
        /// <returns> returns size</returns>
        public long Size()
        {
            return this.size;
        }

        /// <summary>
        /// Exceptions
        /// </summary>
        public bool Add(int number)
        {
            throw new NotImplementedException();
        }

        public bool Delete(int numberToSearch)
        {
            throw new NotImplementedException();
        }

        public bool Insert(int data, long pos)
        {
            throw new NotImplementedException();
        }
    }

   public class T
    {
    }
}