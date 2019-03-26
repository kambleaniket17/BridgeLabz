// -------------------------------------------------------------------------------------------------------------------------
// <copyright file="AdapterObject.cs" company="Bridgelabz">
//   Copyright © 2018 Company
// </copyright>
// <creator name="Aniket Kamble"/>
// ---------------------------------------------------------------------------------------------------------------------------
namespace Design_Pattern.Adapter_Design_Pattern.Object
{
    using System;
    using System.Collections.Generic;
    using System.Text;

    /// <summary>
    /// Volt Class
    /// </summary>
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

    /// <summary>
    /// Socket class
    /// </summary>
    public class Socket
    {
        /// <summary>
        /// Gets the volt.
        /// </summary>
        /// <returns>Volt</returns>
        public Volt GetVolt()
        {
            return new Volt(120);
        }
    }

    /// <summary>
    /// Interface ISocketAdapter Class
    /// </summary>
    public interface ISocketAdapter
    {
        Volt Get120Volt();

        Volt Get12Volt();

        Volt Get3Volt();
    }

    /// <summary>
    /// class SocketObjectAdapterImp which extends Socket class And Implements ISocketAdapter Interface
    /// </summary>
    /// <seealso cref="Design_Pattern.Adapter_Design_Pattern.Object.Socket" />
    /// <seealso cref="Design_Pattern.Adapter_Design_Pattern.Object.ISocketAdapter" />
    public class SocketObjectAdapterImp : Socket, ISocketAdapter
    {
        private readonly Socket socket = new Socket();

        /// <summary>
        /// Get120s the volt.
        /// </summary>
        /// <returns>The Volt</returns>
        public Volt Get120Volt()
        {
            return this.socket.GetVolt();
        }

        /// <summary>
        /// Get12s the volt.
        /// </summary>
        /// <returns>The Volt</returns>
        public Volt Get12Volt()
        {
            Volt v = this.socket.GetVolt();
            return ConvertVolt(v, 10);
        }

        /// <summary>
        /// Get3s the volt.
        /// </summary>
        /// <returns>The Volt</returns>
        public Volt Get3Volt()
        {
            Volt v = this.socket.GetVolt();
            return ConvertVolt(v, 40);
        }

        /// <summary>
        /// Converts the volt.
        /// </summary>
        /// <param name="V">The v.</param>
        /// <param name="number">The number.</param>
        /// <returns>The Volt</returns>
        public Volt ConvertVolt(Volt v, int number)
        {
            return new Volt(v.GetVolts() / number);
        }

        /// <summary>
        /// Objects the adapter.
        /// </summary>
        public static void ObjectAdapter()
        {
            ISocketAdapter sockAdapter = new SocketObjectAdapterImp();
            ////passing value to GetVolt method And return Calculated Volts
            Volt v3 = GetVolt(sockAdapter, 3);
            Volt v12 = GetVolt(sockAdapter, 12);
            Volt v120 = GetVolt(sockAdapter, 120);
            Console.WriteLine("v3 using the Object Adapter=" + v3.GetVolts());
            Console.WriteLine("v12 using the Object Adapter=" + v12.GetVolts());
            Console.WriteLine("v120 using the Object Adapter=" + v120.GetVolts());
        }

        /// <summary>
        /// Gets the volt.
        /// </summary>
        /// <param name="sockAdapter">The sock adapter.</param>
        /// <param name="i">The i.</param>
        /// <returns>The Volt</returns>
        private static Volt GetVolt(ISocketAdapter sockAdapter, int i)
        {
            switch (i)
            {
                ////return the Calculated Volts
                case 3: return sockAdapter.Get3Volt();
                case 12: return sockAdapter.Get12Volt();
                case 120: return sockAdapter.Get120Volt();
                default: return sockAdapter.Get120Volt();
            }
        }
    }
}