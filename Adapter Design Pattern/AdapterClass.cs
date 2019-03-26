// -------------------------------------------------------------------------------------------------------------------------
// <copyright file="AdapterClass.cs" company="Bridgelabz">
//   Copyright © 2018 Company
// </copyright>
// <creator name="Aniket Kamble"/>
// ---------------------------------------------------------------------------------------------------------------------------
namespace Design_Pattern.Adapter_Design_Pattern
{
    using System;
    using System.Collections.Generic;
    using System.Text;

    /// <summary>
    /// Class Volt for Set Volt
    /// </summary>
    public class Volt
    {
        /// <summary>
        /// The volts
        /// </summary>
        private int volts;

        public Volt(int v)
        {
            this.volts = v;
        }

        /// <summary>
        /// Gets the volts.
        /// </summary>
        /// <returns>Volt</returns>
        public int GetVolts()
        {
            return this.volts;
        }

        /// <summary>
        /// Sets the volts.
        /// </summary>
        /// <param name="v">The v.</param>
        public void SetVolts(int v)
        {
            this.volts = v;
        }
    }

    /// <summary>
    /// Socket class for constant Volt ie 120v
    /// </summary>
    public class Socket
    {
        public Volt GetVolt()
        {
            return new Volt(120);
        }
    }

    /// <summary>
    /// Adapter class
    /// </summary>
    public interface ISocketAdapter
    {
        /// <summary>
        /// Get120s the volt.
        /// </summary>
        /// <returns>120v</returns>
        Volt Get120Volt();
        /// <summary>
        /// Get12s the volt.
        /// </summary>
        /// <returns>12v</returns>
        Volt Get12Volt();
        /// <summary>
        /// Get3s the volt.
        /// </summary>
        /// <returns>3v</returns>
        Volt Get3Volt();
    }

    /// <summary>
    /// SocketClassAdapterImp for Calculate volt
    /// </summary>
    /// <seealso cref="Design_Pattern.Adapter_Design_Pattern.Socket" />
    /// <seealso cref="Design_Pattern.Adapter_Design_Pattern.ISocketAdapter" />
    public class SocketClassAdapterImp : Socket, ISocketAdapter
    {
        /// <summary>
        /// Get120s the volt.
        /// </summary>
        /// <returns>
        /// 120v
        /// </returns>
        public Volt Get120Volt()
        {
            //// 120volt
            return GetVolt();
        }
        /// <summary>
        /// Get12s the volt.
        /// </summary>
        /// <returns>
        /// 12v
        /// </returns>
        public Volt Get12Volt()
        {
            //// 12v
            Volt v = GetVolt();
            return this.ConvertVolt(v, 10);
        }
        /// <summary>
        /// Get3s the volt.
        /// </summary>
        /// <returns>
        /// 3v
        /// </returns>
        public Volt Get3Volt()
        {
            //// 3v
            Volt v = GetVolt();
            return this.ConvertVolt(v, 40);
        }
        /// <summary>
        /// Converts the volt.
        /// </summary>
        /// <param name="v">The v.</param>
        /// <param name="number">The number.</param>
        /// <returns>Converted Volt</returns>
        public Volt ConvertVolt(Volt v, int number)
        {
            //// Convert Volt
            return new Volt(v.GetVolts() / number);
        }

        /// <summary>
        /// Classes the adapter.
        /// </summary>
        public static void ClassAdapter()
        {
            //// Call Method For Convert Volt
            ISocketAdapter sockAdapter = new SocketClassAdapterImp();
            Volt v3 = GetVolt(sockAdapter, 3);
            Volt v12 = GetVolt(sockAdapter, 12);
            Volt v120 = GetVolt(sockAdapter, 120);
            Console.WriteLine("v3 using the Class Adapter=" + v3.GetVolts());
            Console.WriteLine("v12 using the Class Adapter=" + v12.GetVolts());
            Console.WriteLine("v120 using the Class Adapter=" + v120.GetVolts());
        }
        /// <summary>
        /// Gets the volt.
        /// </summary>
        /// <param name="sockAdapter">The sock adapter.</param>
        /// <param name="i">The i.</param>
        /// <returns>Volt</returns>
        private static Volt GetVolt(ISocketAdapter sockAdapter, int i)
        {
            switch (i)
            {
                //// return Volt
                case 3: return sockAdapter.Get3Volt();
                case 12: return sockAdapter.Get12Volt();
                case 120: return sockAdapter.Get120Volt();
                default: return sockAdapter.Get120Volt();
            }
        }
    }
}