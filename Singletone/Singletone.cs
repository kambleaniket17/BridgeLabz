namespace Design_Pattern.Singletone
{
    using System;
    using System.Collections.Generic;
    using System.Text;

    public sealed class Calculation
    {
        private Calculation()
        {

        }
        private static readonly object Padlock = new object();
        private static Calculation instance = null;
        public static Calculation Instance
        {
            get
            {
                lock(Padlock)
                {
                if(instance==null)
                {
                    instance = new Calculation();
                }
                 return instance;
                }
            }
        }
        public static void Calculate()
        {
            int choice = 0;
            do
            {
                Console.WriteLine("1:Addition\n2:Subtraction\nExit Press 0");
              Console.WriteLine("Enter The Choice");
              choice = int.Parse(Console.ReadLine());
            
            switch (choice)
            {
                case 1:
                    Instance.Addition();
                    break;
                case 2:
                    Instance.Subtraction();
                    break;
                default:
                    break;
            }
            } while (choice != 0);
        }
        public void Addition()
        {
            Console.WriteLine("Enter 1st Element");
            int first = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter 2nd Element");
            int second = int.Parse(Console.ReadLine());
            int addition = first + second;
            Console.WriteLine("Addition ="+addition);
        }
        public void Subtraction()
        {
            Console.WriteLine("Enter 1st Element");
            int first = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter 2nd Element");
            int second = int.Parse(Console.ReadLine());
            int addition = first - second;
            Console.WriteLine("Addition =" + addition);
        }
    }
}