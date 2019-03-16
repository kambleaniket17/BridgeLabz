// -------------------------------------------------------------------------------------------------------------------------
// <copyright file="SinglyLinkedList.cs" company="Bridgelabz">
//   Copyright © 2018 Company
// </copyright>
// <creator name="Aniket Kamble"/>
// ---------------------------------------------------------------------------------------------------------------------------
namespace Data_Structure.LinkedList_UnOrdered_
{
    using System;
    using System.Collections.Generic;
    using System.Text;

    /// <summary>
    /// Singly Linked list
    /// </summary>
    /// <typeparam name="T"> any parameter</typeparam>
    /// <seealso cref="Data_Structure.LinkedList_UnOrdered_.LinkedList{T}" />
    public class SinglyLinkedList<T> : ILinkedList<T>
    {
        /// <summary>
        /// The head
        /// </summary>
        private Node<T> head;

        /// <summary>
        /// The last
        /// </summary>
        private Node<T> last;

        /// <summary>
        /// The size
        /// </summary>
        private long size = 0;

        /// <summary>
        /// Adds the specified word.
        /// </summary>
        /// <param name="word">The word.</param>
        /// <returns>returns true or false</returns>
        public bool Add(T word)
        {
            try
            {
                Node<T> n = new Node<T>(word, this.size);
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
        /// <param name="word">The word.</param>
        /// <returns>
        /// <c>true</c> if [contains] [the specified word]; otherwise, <c>false</c>.
        /// </returns>
        public bool Contains(T word)
        {
            try
            {
                Node<T> temp = this.head;

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
        /// Deletes the specified word to delete.
        /// </summary>
        /// <param name="wordToDelete">The word to delete.</param>
        /// <returns>returns true or false</returns>
        public bool Delete(string wordToDelete)
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
                    Node<T> temp = this.head;
                    Node<T> remove = null;

                    if (temp.Data.Equals(wordToDelete))
                    {
                        remove = temp;
                        this.head = temp.Next;
                        return true;
                    }

                    for (int i = 0; i < this.size; i++)
                    {
                        if (temp.Next.Data.Equals(wordToDelete))
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
        public bool Insert(T data, long pos)
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
                    Node<T> n = new Node<T>(data, pos);

                    Node<T> temp = this.head;

                    for (int i = 0; i < pos - 1; i++)
                    {
                        temp = temp.Next;
                    }

                    Node<T> n1 = temp.Next;
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
                    Node<T> temp = this.head;
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
                Node<T> temp = this.head;

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
                    Node<T> temp = this.head;
                    using (var writer = new System.IO.StreamWriter(path))
                    {
                        while (temp != null)
                        {
                            if (typeof(T) == typeof(string))
                            {
                                writer.Write(temp.Data.ToString().Trim() + " ");
                                temp = temp.Next;
                            }
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
