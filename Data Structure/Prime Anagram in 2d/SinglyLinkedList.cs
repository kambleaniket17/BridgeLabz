// -------------------------------------------------------------------------------------------------------------------------
// <copyright file="SinglyLinkedList.cs" company="Bridgelabz">
//   Copyright © 2018 Company
// </copyright>
// <creator name="Aniket Kamble"/>
// ---------------------------------------------------------------------------------------------------------------------------
namespace Data_Structure.PrimeAnagrams
{
    using System;
    using System.Collections.Generic;
    using System.Text;
    using Data_Structure.LinkedList_Ordered_;

    /// <summary>
    /// Singly linkedList
    /// </summary>
    public class SinglyLinkedList 
    {
        /// <summary>
        /// The head
        /// </summary>
        private Node head;

        /// <summary>
        /// The last
        /// </summary>
        private Node last;

        /// <summary>
        /// The size/
        /// </summary>
        private long size = 0;

        /// <summary>
        /// Sorts the linked list.
        /// </summary>
        /// <param name="head">The head.</param>
        public static void SortLinkedList(Node head)
        {
            try
            {
                Node i;
                Node j;

                i = head;

                //// using Bubble sort method to sort the linked list
                for (i = head; i.Next != null; i = i.Next)
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
        public bool Add(int number)
        {
            try
            {
                Node n = new Node(number, this.size); ////A new node is created whenever Add is invoked
                this.size++;

                if (this.head == null && this.last == null)
                {
                    this.head = n;
                    this.last = n;
                }
                else
                {
                    this.last.Next = n;
                    this.last = n;
                }

                SortLinkedList(this.head);
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
                Node temp = this.head;

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
        public bool Delete(int numberToDelete)
        {
            try
            {
                if (this.head == null)
                {
                    Console.WriteLine("list is already empty");
                    return false;
                }
                else
                {
                    Node temp = this.head;
                    Node remove = null;

                    if (temp.Data.Equals(numberToDelete))
                    {
                        remove = temp;
                        this.head = temp.Next;
                        return true;
                    }

                    for (int i = 0; i < this.size; i++)
                    {
                        if (temp.Next.Data.Equals(numberToDelete))
                        {
                            remove = temp.Next;
                            temp.Next = remove.Next;
                            break;
                        }

                        temp = temp.Next;
                    }

                    Console.WriteLine("removed " + remove.Data);
                    remove.Next = null;

                    this.Reposition();

                    this.size = this.size - 1;
                    return true;
                }
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        /// <summary>
        /// Inserts the specified data.
        /// </summary>
        /// <param name="data">The data.</param>
        /// <param name="pos">The position.</param>
        /// <returns> returns true or false </returns>
        public bool Insert(int data, long pos)
        {
            try
            {
                if (pos > this.size)
                {
                    Console.WriteLine("Specified position is greater than existing size");
                    return false;
                }
                else
                {
                    Node n = new Node(data, pos);

                    Node temp = this.head;

                    for (int i = 0; i < pos - 1; i++)
                    {
                        temp = temp.Next;
                    }

                    Node n1 = temp.Next;
                    temp.Next = n;
                    n.Next = n1;
                    temp = null;
                    this.size++;
                    this.Reposition();
                    return true;
                }
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
                if (this.head == null)
                {
                    Console.WriteLine("List is empty");
                }
                else
                {
                    Node temp = this.head;
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
                Node temp = this.head;

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

        /// <summary>
        /// Writes to file.
        /// </summary>
        /// <param name="path">The path.</param>
        /// <returns>returns true or false</returns>
        public bool WriteToFile(string path)
        {
            try
            {
                if (this.head == null)
                {
                    Console.WriteLine("list is already empty");
                    return false;
                }
                else
                {
                    Node temp = this.head;
                    using (var writer = new System.IO.StreamWriter(path))
                    {
                        while (temp != null)
                        {
                            writer.Write(temp.Data.ToString().Trim() + " ");
                            temp = temp.Next;
                        }
                    }
                }

                return true;
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }
    }
}
