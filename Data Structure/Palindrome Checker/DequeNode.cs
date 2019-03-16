// -------------------------------------------------------------------------------------------------------------------------
// <copyright file="DequeNode.cs" company="Bridgelabz">
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
    /// queue of Node
    /// </summary>
    /// <typeparam name="T">any parameter</typeparam>
    public class DequeNode<T>
    {
        /// <summary>
        /// The data
        /// </summary>
        private T data;

        /// <summary>
        /// The next
        /// </summary>
        private DequeNode<T> next;

        /// <summary>
        /// The pre
        /// </summary>
        private DequeNode<T> pre;

        /// <summary>
        /// Initializes a new instance of the <see cref="DequeNode{T}"/> class.
        /// </summary>
        /// <param name="data">The data.</param>
        public DequeNode(T data)
        {
            this.data = data;           
        }

        /// <summary>
        /// Gets or sets the data.
        /// </summary>
        /// <value>
        /// The data.
        /// </value>
        public T Data
        {
            get { return this.data; }
            set { this.data = value; }
        }

        /// <summary>
        /// Gets or sets the next.
        /// </summary>
        /// <value>
        /// The next.
        /// </value>
        public DequeNode<T> Next
        {
            get { return this.next; }
            set { this.next = value; }
        }

        /// <summary>
        /// Gets or sets the pre.
        /// </summary>
        /// <value>
        /// The pre.
        /// </value>
        public DequeNode<T> Pre
        {
            get { return this.pre; }
            set { this.pre = value; }
        }
    }
}
