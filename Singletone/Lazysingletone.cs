namespace Design_Pattern.Singletone
{
    using System;
    using System.Collections.Generic;
    using System.Text;

    public sealed class Lazysingletone
    {
        private static readonly Lazysingletone instance = new Lazysingletone();
        static Lazysingletone()
        {

        }
        private Lazysingletone()
        {

        }
        public static Lazysingletone Instance
        {
            get
            {
                return instance;
            }
        }
        public static void Calculate()
        {
            Console.WriteLine("1:Addition\n2:Subtraction");
            Console.WriteLine("Enter The Choice");
            int choice = int.Parse(Console.ReadLine());
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
            } while (choice != 0) ;

        }
        public void Addition()
        {
            Console.WriteLine("Enter 1st Element");
            int first = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter 2nd Element");
            int second = int.Parse(Console.ReadLine());
            int addition = first + second;
            Console.WriteLine("Addition =" + addition);
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
