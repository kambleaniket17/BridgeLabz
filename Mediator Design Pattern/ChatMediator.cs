// -------------------------------------------------------------------------------------------------------------------------
// <copyright file="ChatMediator.cs" company="Bridgelabz">
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
    /// Interface IMediator
    /// </summary>
    public interface IMediator
    {
        void SendMessage(string message, ConcessionStand concessionStand);
    }

    /// <summary>
    /// Abstract Class ConcessionStand
    /// </summary>
   

    /// <summary>
    /// Mediator class whic Implemetes from Imediator Interface
    /// </summary>
    /// <seealso cref="Design_Pattern.Mediator_Design_Pattern.IMediator" />
    public class Mediator : IMediator
    {
        private NorthConcessionStand NorthConcession;
        private SouthConcessionStand SouthConcession;
        public NorthConcessionStand NorthConcessionStand
        {
            set
            {
                NorthConcession = value;
            }
        }
        public SouthConcessionStand SouthConcessionStand
        {
            set
            {
                SouthConcession = value;
            }
        }

        /// <summary>
        /// Sends the message.
        /// </summary>
        /// <param name="message">The message.</param>
        /// <param name="concessionStand">The concession stand.</param>
        public void SendMessage(string message, ConcessionStand concessionStand)
        {
            if(concessionStand==NorthConcession)
            {
                SouthConcession.Receive(message);
            }
            else
            {
                NorthConcession.Receive(message);
            }
        }
        /// <summary>
        /// Handles this instance.
        /// </summary>
        public static void Handle()
        {
            Mediator mediator = new Mediator();
            NorthConcessionStand northConcessionStand = new NorthConcessionStand(mediator);
            SouthConcessionStand southConcessionStand = new SouthConcessionStand(mediator);
            mediator.SouthConcession = southConcessionStand;
            mediator.NorthConcession = northConcessionStand;
            northConcessionStand.Send("HII");
            southConcessionStand.Send("Hello");
            northConcessionStand.Send("Where R U");
        }
    }
}