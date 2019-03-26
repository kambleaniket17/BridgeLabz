// -------------------------------------------------------------------------------------------------------------------------
// <copyright file="FactoryData.cs" company="Bridgelabz">
//   Copyright © 2018 Company
// </copyright>
// <creator name="Aniket Kamble"/>
// ---------------------------------------------------------------------------------------------------------------------------
namespace Design_Pattern.Factory_Design_Pattern
{
    using System;
    using System.Collections.Generic;
    using System.Text;

    /// <summary>
    /// Abstract Class Computer
    /// </summary>
    public abstract class Computer
    {
        /// <summary>
        /// Gets the object.
        /// </summary>
        public abstract void GetObject();
    }

    /// <summary>
    /// class PC
    /// </summary>
    /// <seealso cref="Design_Pattern.Factory_Design_Pattern.Computer" />
    public class PC : Computer
    {
        /// <summary>
        /// Gets the object.
        /// </summary>
        public override void GetObject()
        {
            //// Object Created
            Console.WriteLine("PC Object Created");
        }
    }

    /// <summary>
    /// class Laptop
    /// </summary>
    /// <seealso cref="Design_Pattern.Factory_Design_Pattern.Computer" />
    public class Laptop : Computer
    {
        /// <summary>
        /// Gets the object.
        /// </summary>
        public override void GetObject()
        {
            //// Object Created
            Console.WriteLine("Laptop Object Created");
        }
    }

    /// <summary>
    /// Server Class
    /// </summary>
    /// <seealso cref="Design_Pattern.Factory_Design_Pattern.Computer" />
    public class Server : Computer
    {
        /// <summary>
        /// Gets the object.
        /// </summary>
        public override void GetObject()
        {
            //// Object Created
            Console.WriteLine("Server Object Created");
        }
    }

   

    
}