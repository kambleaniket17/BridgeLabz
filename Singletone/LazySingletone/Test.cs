// --------------------------------------------------------------------------------------------------------------------
// <copyright file="Test.cs" company="Bridgelabz">
//   Copyright © 2018 Company
// </copyright>
// <creator name="Aniket Kamble"/>
// --------------------------------------------------------------------------------------------------------------------

namespace Design_Pattern.Singletone.LazySingletone
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;

    /// <summary>
    /// test Class
    /// </summary>
    public class Test
    {
        /// <summary>
        /// Testing Object
        /// </summary>
        public static void TestObject()
        {
            //// Check Instances Same Or not
            Console.WriteLine("** Lazy Initialization SingleTone **");
            LazySingleton object1 = LazySingleton.GetInstance;
            LazySingleton object2 = LazySingleton.GetInstance;
            Console.WriteLine("Lazy Initialization Object1 == Lazy Initialization Object2 = " + (object1 == object2));
        }
        
    }
}
