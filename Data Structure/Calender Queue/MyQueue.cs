// -------------------------------------------------------------------------------------------------------------------------
// <copyright file="MyQueue.cs" company="Bridgelabz">
//   Copyright © 2018 Company
// </copyright>
// <creator name="Aniket Kamble"/>
// ---------------------------------------------------------------------------------------------------------------------------
namespace Data_Structure.CalendarQueue
{
    using System;
    using System.Collections.Generic;
    using System.Text;

    /// <summary>
    /// MyQueue Class
    /// </summary>
    /// <typeparam name="T">Any Parameter</typeparam>
    public class MyQueue<T>
    {
        /// <summary>
        /// The queue maximum size
        /// </summary>
        private int queueMaxSize = 500;

        /// <summary>
        /// The front
        /// </summary>
        private int front = -1;

        /// <summary>
        /// The rear
        /// </summary>
        private int rear = -1;

        /// <summary>
        /// The queue array
        /// </summary>
        private readonly T[] queueArray = new T[1000];

        /// <summary>
        /// The size/
        /// </summary>
        private int size;

        /// <summary>
        /// Gets or sets the queue maximum size.
        /// </summary>
        /// <value>
        /// The queue maximum size.
        /// </value>
        public int QueueMaxSize
        {
            get { return this.queueMaxSize; }
            set { this.queueMaxSize = value; }
        }

        /// <summary>
        /// Gets or sets the front.
        /// </summary>
        /// <value>
        /// The front.
        /// </value>
        public int Front
        {
            get { return this.front; }
            set { this.front = value; }
        }

        /// <summary>
        /// Gets or sets the rear.
        /// </summary>
        /// <value>
        /// The rear.
        /// </value>
        public int Rear
        {
            get { return this.rear; }

            set { this.rear = value; }
        }

        /// <summary>
        /// Gets or sets the size.
        /// </summary>
        /// <value>
        /// The size.
        /// </value>
        public int Size
        {
            get { return this.size; }
            set { this.size = value; }
        }

        /// <summary>
        /// Enqueues the specified data.
        /// </summary>
        /// <param name="data">The data.</param>
        /// <returns>returns true or false</returns>
        public bool Enqueue(T data)
        {
            try
            {
                if (this.rear == this.queueMaxSize - 1)
                {
                    Console.WriteLine("Queue Overflow");
                    return false;
                }
                else
                {
                    if (this.front == -1)
                    {
                        this.front = 0;
                    }

                    this.rear++;
                    this.queueArray[this.rear] = data;
                    this.size++;
                    return true;
                }
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        /// <summary>
        /// queues Operations
        /// </summary>
        /// <returns>returns true or false</returns>
        public int Dequeue()
        {
            try
            {
                if (this.front == -1 || this.front > this.rear)
                {
                    Console.WriteLine("Queue Underflow");
                    return -1;
                }
                else
                {
                    int d = this.front;
                    this.front++;
                    this.size--;
                    return d;
                }
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        /// <summary>
        /// Shows the elements.
        /// </summary>
        public void ShowElements()
        {
            try
            {
                if (this.front == -1)
                {
                    Console.WriteLine("Queue is Empty");
                }
                else
                {
                    for (int i = this.front; i <= this.rear; i++)
                    {
                        Console.WriteLine(this.queueArray[i]);
                    }
                }
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        /// <summary>
        /// Checks the size.
        /// </summary>
        /// <returns>returns current size</returns>
        public int CheckSize()
        {
            try
            {
                return this.size;
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }
    }
}
