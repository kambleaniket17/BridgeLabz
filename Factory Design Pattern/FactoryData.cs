namespace Design_Pattern.Factory_Design_Pattern
{
    using System;
    using System.Collections.Generic;
    using System.Text;

    public abstract class Plan
    {
        protected double rate;
        public abstract void getRate();
        public void getBill(int unit)
        {
            Console.WriteLine(rate*unit);
        }
    }
    public class DomesticPlan:Plan
    {
        public override void getRate()
        {
            rate = 3.50;
        }
    }
    public class Commercial : Plan
    {
        public override void getRate()
        {
            rate = 7.50;
        }
    }
    public class InstitutionalPlan : Plan
    {
        public override void getRate()
        {
            rate = 5.50;
        }
    }
    public class FactoryData
    {
        public Plan getPlan(string plan)
        {
            if(plan.Equals("DOMESTICPLAN"))
            {
                return new DomesticPlan();
            }
            if (plan.Equals("COMMERCIAL"))
            {
                return new Commercial();
            }
            if (plan.Equals("INSTITUTIONALPLAN"))
            {
                return new InstitutionalPlan();
            }
            return null;
        }
    }
    public class Bill
    {
        public static void Calculate()
        {
            FactoryData factoryData = new FactoryData();
            Console.WriteLine("List Of Plans\n1:DOMESTICPLAN\n2:INSTITUTIONALPLAN");
            Console.WriteLine("Write Your Plan");
            string plan = Console.ReadLine();
            plan=plan.ToUpper();
            Plan p=factoryData.getPlan(plan);
            Console.WriteLine("Enter The Unit");
            int unit = int.Parse(Console.ReadLine());
            p.getRate();
            Console.WriteLine("Your Unit ="+unit+ "ANd Plan="+plan);
            p.getBill(unit);
        }
    }
}