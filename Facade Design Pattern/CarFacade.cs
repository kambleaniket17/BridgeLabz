// -------------------------------------------------------------------------------------------------------------------------
// <copyright file="CarFacade.cs" company="Bridgelabz">
//   Copyright © 2018 Company
// </copyright>
// <creator name="Aniket Kamble"/>
// ---------------------------------------------------------------------------------------------------------------------------
namespace Design_Pattern
{
    using System;
    using System.Collections.Generic;
    using System.Text;

    /// <summary>
    /// Carmodel class
    /// </summary>
    public class CarModel
    {
        /// <summary>
        /// Sets the model.
        /// </summary>
        public void SetModel()
        {
            Console.WriteLine("CarModel-SetModel");
        }
    }
    /// <summary>
    /// CarEngine class
    /// </summary>
    public class CarEngine
    {
        /// <summary>
        /// Sets the engine.
        /// </summary>
        public void SetEngine()
        {
            Console.WriteLine("CarEngine-SetEngine");
        }
    }
    /// <summary>
    /// CarBody Class
    /// </summary>
    public class CarBody
    {
        /// <summary>
        /// Sets the body.
        /// </summary>
        public void SetBody()
        {
            Console.WriteLine("CaeBody-SetBody");
        }
    }
    /// <summary>
    /// CarAccesseries Class
    /// </summary>
    public class CarAccesseries
    {
        /// <summary>
        /// Sets the accesseries.
        /// </summary>
        public void SetAccesseries()
        {
            Console.WriteLine("Caraccesseries-SetAccesseries");
        }
    }
    /// <summary>
    /// CarFacede class
    /// </summary>
    public class CarFacede
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="CarFacede"/> class.
        /// </summary>
        public CarFacede()
        {
            //// Calling Methods
            Console.WriteLine("** ** Creating a Car ** **");
            CarModel carModel = new CarModel();
            CarEngine carEngine = new CarEngine();
            CarBody carBody = new CarBody();
            CarAccesseries carAccesseries = new CarAccesseries();
            carModel.SetModel();
            carEngine.SetEngine();
            carBody.SetBody();
            carAccesseries.SetAccesseries();
        }
        
    }
}
