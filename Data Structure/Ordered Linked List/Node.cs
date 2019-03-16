// -------------------------------------------------------------------------------------------------------------------------
// <copyright file="Node.cs" company="Bridgelabz">
//   Copyright © 2018 Company
// </copyright>
// <creator name="Aniket Kamble"/>
// ---------------------------------------------------------------------------------------------------------------------------
namespace Data_Structure.LinkedList_Ordered_
{
    using System;
    using System.Collections.Generic;
    using System.Text;

    /// <summary>
    /// Node class
    /// </summary>
    public class Node
    {
        /// <summary>
        /// The next
        /// </summary>
        private Node next;

        /// <summary>
        /// The data
        /// </summary>
        private int data;

        /// <summary>
        /// The position
        /// </summary>
        private long position;

        public Node(int value)
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="Node"/> class.
        /// </summary>
        /// <param name="data">The data.</param>
        /// <param name="position">The position.</param>
        public Node(int data, long position)
        {
            this.position = position;
            this.data = data;
        }

        /// <summary>
        /// Gets or sets the next.
        /// </summary>
        /// <value>
        /// The next.
        /// </value>
        public Node Next
        {
            get { return this.next; }
            set { this.next = value; }
        }

        /// <summary>
        /// Gets or sets the position.
        /// </summary>
        /// <value>
        /// The position.
        /// </value>
        public long Position
        {
            get { return this.position; }
            set { this.position = value; }
        }

        /// <summary>
        /// Gets or sets the data.
        /// </summary>
        /// <value>
        /// The data.
        /// </value>
        public int Data
        {
            get { return this.data; }
            set { this.data = value; }
        }
    }
}