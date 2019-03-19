namespace Design_Pattern.Factory_Design_Pattern
{
    using System;
    using System.Collections.Generic;
    using System.Text;

    public abstract class Computer
    {
        public abstract void GetObject();
    }

    public class PC : Computer
    {
        public override void GetObject()
        {
            Console.WriteLine("PC Object Created");
        }
    }

    public class Laptop : Computer
    {
        public override void GetObject()
        {
            Console.WriteLine("Laptop Object Created");
        }
    }

    public class Server : Computer
    {
        public override void GetObject()
        {
            Console.WriteLine("Server Object Created");
        }
    }

    public class ComputerFactory
    {
        public Computer GetPlan(string computerObj)
        {
            if (computerObj.Equals("PC"))
            {
                return new PC();
            }

            if (computerObj.Equals("LAPTOP"))
            {
                return new Laptop();
            }

            if (computerObj.Equals("SERVER"))
            {
                return new Server();
            }

            return null;
        }
    }

    public class Bill
    {
        public static void Calculate()
        {
            ComputerFactory factoryData = new ComputerFactory();
            Console.WriteLine("List Of Computer Factory\n1:PC\n2:LAPTOP\n3:SERVER");
            Console.WriteLine("Write Name of Object You Want");
            string objectName = Console.ReadLine();
            objectName = objectName.ToUpper();
            Computer p = factoryData.GetPlan(objectName);
            p.GetObject();
        }
    }
}