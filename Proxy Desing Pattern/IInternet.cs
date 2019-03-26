// -------------------------------------------------------------------------------------------------------------------------
// <copyright file="IInternet.cs" company="Bridgelabz">
//   Copyright © 2018 Company
// </copyright>
// <creator name="Aniket Kamble"/>
// ---------------------------------------------------------------------------------------------------------------------------
namespace Design_Pattern.Proxy_Desing_Pattern
{
    using System;
    using System.Collections.Generic;
    using System.Text;

    /// <summary>
    /// IInternet Interface
    /// </summary>
    public interface IInternet
    {
        void ConnectTo(String serverhost);
    }

    /// <summary>
    /// RealInternet Class 
    /// </summary>
    /// <seealso cref="Design_Pattern.Proxy_Desing_Pattern.IInternet" />
    public class RealInternet : IInternet
    {
        /// <summary>
        /// Connects to.
        /// </summary>
        /// <param name="serverhost">The serverhost.</param>
        public void ConnectTo(string serverhost)
        {
            Console.WriteLine("Connecting to " + serverhost);
        }
    }

    /// <summary>
    /// ProxyInternet Class
    /// </summary>
    /// <seealso cref="Design_Pattern.Proxy_Desing_Pattern.IInternet" />
    public class ProxyInternet : IInternet
    {
        private IInternet Internet = new RealInternet();
        private List<string> bannesSites;

        /// <summary>
        /// Initializes a new instance of the <see cref="ProxyInternet"/> class.
        /// </summary>
        public ProxyInternet()
        {
            bannesSites = new List<string>();
            bannesSites.Add("abc.com");
            bannesSites.Add("xyz.com");
            bannesSites.Add("mno.com");
        }
        /// <summary>
        /// Connects to.
        /// </summary>
        /// <param name="serverhost">The serverhost.</param>
        /// <exception cref="Exception">This Site Is Banned</exception>
        public void ConnectTo(string serverhost)
        {
            try
            { 
            if(bannesSites.Contains(serverhost.ToLower()))
            {
                // Console.WriteLine("Site Is Banned");
                throw new Exception("This Site Is Banned");
            }
            else
                {
                    //// Connect
                    Internet.ConnectTo(serverhost);
                }
            }
            catch
            {
                Console.WriteLine("Site Is Banned");
            }
        }
    }
}