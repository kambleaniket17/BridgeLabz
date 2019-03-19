namespace Design_Pattern.Adapter_Design_Pattern
{
    using System;
    using System.Collections.Generic;
    using System.Text;

    public class Volt
    {
        private int volts;

        public Volt(int v)
        {
            this.volts = v;
        }

        public int GetVolts()
        {
            return this.volts;
        }

        public void SetVolts(int v)
        {
            this.volts = v;
        }
    }

    public class Socket
    {
        public Volt GetVolt()
        {
            return new Volt(120);
        }
    }

    public interface ISocketAdapter
    {
         Volt Get120Volt();

         Volt Get12Volt();

         Volt Get3Volt();
    }

    public class SocketClassAdapterImp : Socket, ISocketAdapter
    {
        public Volt Get120Volt()
        {
            return GetVolt();
        }

        public Volt Get12Volt()
        {
            Volt v = GetVolt();
            return this.ConvertVolt(v, 10);
        }

        public Volt Get3Volt()
        {
            Volt v = GetVolt();
            return this.ConvertVolt(v, 40);
        }

        public Volt ConvertVolt(Volt v, int number)
        {
            return new Volt(v.GetVolts() / number);
        }

        public static void ClassAdapter()
        {
            ISocketAdapter sockAdapter = new SocketClassAdapterImp();
            Volt v3 = GetVolt(sockAdapter, 3);
            Volt v12 = GetVolt(sockAdapter, 12);
            Volt v120 = GetVolt(sockAdapter, 120);
            Console.WriteLine("v3 using the Class Adapter=" + v3.GetVolts());
            Console.WriteLine("v12 using the Class Adapter=" + v12.GetVolts());
            Console.WriteLine("v120 using the Class Adapter=" + v120.GetVolts());
        }

        private static Volt GetVolt(ISocketAdapter sockAdapter, int i)
        {
            switch (i)
            {
                case 3: return sockAdapter.Get3Volt();
                case 12: return sockAdapter.Get12Volt();
                case 120: return sockAdapter.Get120Volt();
                default: return sockAdapter.Get120Volt();
            }
        }
    }
}