// --------------------------------------------------------------------------------------------------------------------
// <copyright file="LazySingleton.cs" company="Bridgelabz">
//   Copyright © 2018 Company
// </copyright>
// <creator name="Aniket Kamble"/>
// --------------------------------------------------------------------------------------------------------------------

namespace Design_Pattern
{
    using System;
    using Design_Pattern.Singletone;
    using Design_Pattern.Adapter_Design_Pattern;
    using Design_Pattern.Mediator_Design_Pattern;
    using Design_Pattern.Visitor_Design_Pattern;

    /// <summary>
    /// Main Program Class
    /// </summary>
    public class Program
    {
        /// <summary>
        /// Defines the entry point of the application.
        /// </summary>
        /// <param name="args">The arguments.</param>
        static void Main(string[] args)
        {
            int choice = 0;

            do
            {
                    Console.WriteLine("******\n");
                    Console.WriteLine("1:LazySingletone Design Pattern\n2:ThreadSafe Singletone Design Pattern\n3:Factory Design Pattern\n4:Adapter Class Design Pattern\n5:Adapter Object Design Pattern\n6:Mediator Design Pattern\n7:Visitor Design Pattern\n" +
                        "8:Observer Design Pattern(Dell Observer)\n9:Observer Design Pattern(Book Observer)\n10:Facade Design Pattern\n11:Proxy Design Pattern\n12:Prototype Design Pattern\n13:Dependancy Injection\n14:Reflection\n15:Annotation\nPress 0 For Exit");
                    Console.WriteLine("Enter The Choice");
                try
                {
                    choice = int.Parse(Console.ReadLine());
                }
                catch (Exception)
                {
                    Console.WriteLine("Enter Correct Input");
                    Console.ReadKey();
                }
                switch (choice)
                    {
                        case 1:
                        Singletone.LazySingletone.Test.TestObject();
                            Console.ReadKey();
                            break;
                         case 2:
                        Singletone.ThreadSafe.Test.TestObject();
                            break;
                         case 3:
                            Factory_Design_Pattern.Create.CreateObj();
                            break;
                         case 4:
                            Adapter_Design_Pattern.SocketClassAdapterImp.ClassAdapter();
                            break;
                         case 5:
                            Adapter_Design_Pattern.Object.SocketObjectAdapterImp.ObjectAdapter();
                            break;
                         case 6:
                            Mediator_Design_Pattern.Mediator.Handle();
                            break;
                         case 7:
                            Visitor_Design_Pattern.Visitor.VisitorInfo();
                            break;
                         case 8:
                           Observer_Design_Pattern.DellStockInfo.DellStock();
                           break;
                         case 9:
                        Observer_Design_Pattern.Book_Observer.StockInfo.StockAvialable();
                           break;
                         case 10:
                           Facade_Design_Pattern.Facade.CarOrder();
                           break;
                        case 11:
                           Proxy_Desing_Pattern.Client.ClientRequest();
                           break;
                       case 12:
                           Prototype_Design_Pattern.Clone.CreateClone();
                           break;
                    case 13:
                        Injection.Format format = new Injection.Format();
                        format.Print();
                        break;
                    case 14:
                        Reflection.Reflection reflection = new Reflection.Reflection();
                        reflection.Reflections();
                        break;
                    case 15:
                        Annotation annotation = new Annotation();
                        annotation.ValidateOfAnnotation();
                        break;
                        default:
                            break;
                    }
            }
            while (choice != 0);
        }
    }
}