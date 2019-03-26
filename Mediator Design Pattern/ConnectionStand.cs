// -------------------------------------------------------------------------------------------------------------------------
// <copyright file="ConnectionStand.cs" company="Bridgelabz">
//   Copyright © 2018 Company
// </copyright>
// <creator name="Aniket Kamble"/>
// ---------------------------------------------------------------------------------------------------------------------------
namespace Design_Pattern.Mediator_Design_Pattern
{
    using System;
    using System.Collections.Generic;
    using System.Text;

    /// <summary>
    /// Concession Abstract Class
    /// </summary>
    public abstract class ConcessionStand
    {
        protected IMediator mediator;
        public ConcessionStand(IMediator mediator)
        {
            this.mediator = mediator;
        }
    }

    /// <summary>
    /// SouthConcessionStand class Which Extend From ConcessionStand Abstract Class
    /// </summary>
    /// <seealso cref="Design_Pattern.Mediator_Design_Pattern.ConcessionStand" />
    public class SouthConcessionStand : ConcessionStand
    {
        public SouthConcessionStand(IMediator mediator) : base(mediator)
        {

        }

        /// <summary>
        /// Sends the message.
        /// </summary>
        /// <param name="message">The message.</param>
        public void Send(string message)
        {
            Console.WriteLine("South Concession Stand send Message:\t" + message);
            mediator.SendMessage(message, this);
        }

        /// <summary>
        /// Receives the message.
        /// </summary>
        /// <param name="message">The message.</param>
        public void Receive(string message)
        {
            Console.WriteLine("South Concession Stand Receive Message:\t" + message);
        }
    }

    /// <summary>
    /// Class NorthConcessionStand whic Extends From ConcessionStand Abstract Class
    /// </summary>
    /// <seealso cref="Design_Pattern.Mediator_Design_Pattern.ConcessionStand" />
    public class NorthConcessionStand : ConcessionStand
    {
        public NorthConcessionStand(IMediator mediator) : base(mediator)
        {

        }
        /// <summary>
        /// Sends the message.
        /// </summary>
        /// <param name="message">The message.</param>
        public void Send(string message)
        {
            Console.WriteLine("North Concession Stand send Message:\t" + message);
            mediator.SendMessage(message, this);
        }
        /// <summary>
        /// Receives the message.
        /// </summary>
        /// <param name="message">The message.</param>
        public void Receive(string message)
        {
            Console.WriteLine("North Concession Stand Receive Message:\t" + message);

        }
    }
}