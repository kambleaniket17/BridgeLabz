// -------------------------------------------------------------------------------------------------------------------------
// <copyright file="SinglyLinkedList.cs" company="Bridgelabz">
//   Copyright © 2018 Company
// </copyright>
// <creator name="Aniket Kamble"/>
// ---------------------------------------------------------------------------------------------------------------------------
namespace Data_Structure.PrimeAnagramStack
{
    using System;
    using System.Collections.Generic;
    using System.Text;

    /// <summary>
    /// Singly linked list
    /// </summary>
    /// <seealso cref="DataStructures.LinkedList_Ordered_.ILinkedList" />
    public class SinglyLinkedList : ILinkedList
    {
        /// <summary>
        /// The Top
        /// </summary>
        private Node top;

        /// <summary>
        /// The size/
        /// </summary>
        private long size = 100;

        /// <summary>
        /// Sorts the linked list.
        /// </summary>
        /// <param name="head">The head.</param>
        public static void SortLinkedList(Node top)
        {
            try
            {
                Node i;
                Node j;

                i = top;

                //// using Bubble sort method to sort the linked list
                for (i = top; i.Next != null; i = i.Next)
                {
                    for (j = i.Next; j != null; j = j.Next)
                    {
                        if (i.Data > j.Data)
                        {
                            int temp = i.Data;
                            i.Data = j.Data;
                            j.Data = temp;
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        /// <summary>
        /// Adds the specified number.
        /// </summary>
        /// <param name="number">The number.</param>
        /// <returns>
        /// returns true or false
        /// </returns>
        public bool Push(string number)
        {
            try
            {
                Node n = new Node(number, this.size); ////A new node is created whenever Add is invoked
                this.size++;

                if (top == null)
                {
                    n.Next = null;
                }
                else
                {
                    n.Next = top;
                }
                top = n;
                Console.WriteLine(top);
                SortLinkedList(this.top);
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
        public bool Contains(int word)
        {
            try
            {
                Node temp = this.top;

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
        public bool pop(int numberToDelete)
        {
            try
            {

                if (top == null)
                {
                    Console.WriteLine("Stack Underflow. Deletion not possible");
                    return false;
                }

                Console.WriteLine("Item popped is {0}", top.Data);
                top = top.Next;
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
                if (this.top == null)
                {
                    Console.WriteLine("List is empty");
                }
                else
                {
                    Node temp = this.top;
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
        /// Repositions this instance.
        /// </summary>
        public void Reposition()
        {
            try
            {
                Node temp = this.top;

                int i = 0;

                while (temp != null)
                {
                    temp.Position = i++;
                    temp = temp.Next;
                }
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

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
}