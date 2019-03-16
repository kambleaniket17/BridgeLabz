
namespace Object_Oriented 
{

    using System;
    using System.Text.RegularExpressions;

   
    public class RegularExpresstion
    {
        public void Operation()
        {
            this.ReadData();
        }

        public void information(string fname, string lname, string mno, string date)
        {
           
            string message = "Hello <<name>>, We have your full name as <<full name>> in our system your contact number is <<91-xxxxxxxxx>>, Please,let us know in case of any clarification Thank you BridgeLabz <<dd/mm/yyyy>>.";
           
            string Name = "<<name>>";
           
            message = RegularExpresstion.ShowMatch(message, fname, Name);
           
            string fame = "<<full name>>";
           
            message = RegularExpresstion.ShowMatch(message, fname + " " + lname, fame);
           
            string contactNumber = "<<91-xxxxxxxxx>>";
           
            message = RegularExpresstion.ShowMatch(message, "91" + " " + mno, contactNumber);
           
            string Currentdate = "<<dd/mm/yyyy>>";
            DateTime today = DateTime.Today;
           
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
           
            Console.WriteLine("Enter First Name");
            string fname = Console.ReadLine();
          
            Console.WriteLine("Enter Last Name");
            string lname = Console.ReadLine();
          
            Console.WriteLine("Enter Mobie Number");
            string mobilenum = Console.ReadLine();
          
            DateTime thisDay = DateTime.Today;


            string date = thisDay.ToString("D");
            date = thisDay.ToString("g");
            if (Regex.IsMatch(mobilenum, @"[0-9]{10}") && Regex.IsMatch(fname, @"[a-zA-z]") && Regex.IsMatch(lname, @"[a-zA-z]"))
            {
                information(fname, lname, mobilenum, date);
            }
            else
            {
                Console.WriteLine("DATA Is Invalid");
            }
        }
    }
}


