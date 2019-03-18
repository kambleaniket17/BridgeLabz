// -------------------------------------------------------------------------------------------------------------------------
// <copyright file="RegularExpression.cs" company="Bridgelabz">
//   Copyright © 2018 Company
// </copyright>
// <creator name="Aniket Kamble"/>
// ---------------------------------------------------------------------------------------------------------------------------
namespace Object_Oriented 
{

    using System;
    using System.IO;
    using System.Text.RegularExpressions;

   
    public class RegularExpresstion
    {
        public void Operation()
        {
            ReadData();
        }

        public void information(string fname, string lname, string mno)
        {

            string message = File.ReadAllText("E:/BridgeLabz/Object Oriented/Regex.txt");
           
            string Name = "<<name>>";
           
            message = RegularExpresstion.ShowMatch(message, fname, Name);
           
            string fame = "<<full name>>";
           
            message = RegularExpresstion.ShowMatch(message, fname + " " + lname, fame);
           
            string contactNumber = "<<91-xxxxxxxxx>>";
           
            message = RegularExpresstion.ShowMatch(message, "91" + " " + mno, contactNumber);
           
            string Currentdate = "<<dd/mm/yyyy>>";
            DateTime today = DateTime.Now;
           
            message = RegularExpresstion.ShowMatch(message, today.ToString(), Currentdate);
            Console.WriteLine(message);
        }

        public static string ShowMatch(string text, string expression, string pattern)
        {
           
            Regex rgx = new Regex(pattern);
            string newString = rgx.Replace(text, expression);
            return newString;
        }
        public void ReadData()
        {
            Console.WriteLine("** ** **");
            Console.WriteLine("Enter First Name");
            string fname = Console.ReadLine();
          
            Console.WriteLine("Enter Last Name");
            string lname = Console.ReadLine();
          
            Console.WriteLine("Enter Mobie Number");
            string mobilenum = Console.ReadLine();
          
            DateTime thisDay = DateTime.Today;


            string date = thisDay.ToString();
            date = thisDay.ToString();
            if (Regex.IsMatch(mobilenum, @"[0-9]{10}") && Regex.IsMatch(fname, @"[a-zA-z]") && Regex.IsMatch(lname, @"[a-zA-z]"))
            {
                information(fname, lname, mobilenum);
            }
            else
            {
                Console.WriteLine("DATA Is Invalid");
            }
        }
    }
}


