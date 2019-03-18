using System;
using Design_Pattern.Singletone;
namespace Design_Pattern
{
    class Program
    {
        static void Main(string[] args)
        {
            int choice = 0;
            do { 
            Console.WriteLine("1:Singletone Design Pattern\n2:LazySingletone Design Pattern\n3:Factory Design Pattern\nPress 0 For Exit");
            Console.WriteLine("Enter The Choice");
            choice = int.Parse(Console.ReadLine());
            switch(choice)
            {
                case 1:
                    Singletone.Calculation.Calculate();
                    Console.ReadKey();
                    break;
                case 2:
                    Lazysingletone.Calculate();
                    break;
                    case 3:
                        Factory_Design_Pattern.Bill.Calculate();
                        break;
            }
            }
            while (choice != 0) ;
        }
    }
}