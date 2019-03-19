namespace Design_Pattern
{
    using System;
    using Design_Pattern.Singletone;
    using Design_Pattern.Adapter_Design_Pattern;

    public class Program
    {
        static void Main(string[] args)
        {
            int choice = 0;

            do
            {
                try
                {
                    Console.WriteLine("******\n");
                    Console.WriteLine("1:Singletone Design Pattern\n2:LazySingletone Design Pattern\n3:Factory Design Pattern\n4:Adapter Class Design Pattern\n5:Adapter Object Design Pattern\nPress 0 For Exit");
                    Console.WriteLine("Enter The Choice");
                    choice = int.Parse(Console.ReadLine());
                    switch (choice)
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
                        case 4:
                            Adapter_Design_Pattern.SocketClassAdapterImp.ClassAdapter();
                            break;
                        case 5:
                            Adapter_Design_Pattern.Object.SocketObjectAdapterImp.ObjectAdapter();
                            break;
                        default:
                            break;
                    }
                }
                catch (Exception)
                {
                    Console.WriteLine("Enter Correct Input");
                }
            }
            while (choice != 0);
        }
    }
}