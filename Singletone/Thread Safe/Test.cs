// --------------------------------------------------------------------------------------------------------------------
// <copyright file="Test.cs" company="Bridgelabz">
//   Copyright © 2018 Company
// </copyright>
// <creator name="Aniket Kamble"/>
// --------------------------------------------------------------------------------------------------------------------

namespace Design_Pattern.Singletone.ThreadSafe
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;

    /// <summary>
    /// Test Class
    /// </summary>
    public class Test
    {
        /// <summary>
        /// Testing The Methods
        /// </summary>
        public static void Testing()
        {
            int Choice = 0;
            do
            {
            Console.WriteLine("Enter Choice\n1:Lazy singletone\n2:Thread Safe Singletone\nPress 0 For Exit\n");
            Choice=int.Parse(Console.ReadLine());
            switch (Choice)
            {
                case 1:
                    //// Calling LazySingleTone
                    LazySingletone.Test.TestObject();
                    break;
                case 2:
                    //// Calling Thread Safe SingleTone
                    Design_Pattern.Singletone.ThreadSafe.Test.TestObject();
                    break;
            }
            }
            while(Choice !=0);
        }
        /// <summary>
        /// Testing Object
        /// </summary>
        public static void TestObject()
        {
            //// Check Instances Same Or not
            Console.WriteLine("** Thread Safe SingleTone **");
            ThreadSafe object1 = ThreadSafe.Instance;
            ThreadSafe object2 = ThreadSafe.Instance;
            Console.WriteLine("ThreadSafe Object1 == ThreadSafe Object2 = " + (object1 == object2));
           
        }
    }
}
