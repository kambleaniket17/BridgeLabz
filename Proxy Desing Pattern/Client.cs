// -------------------------------------------------------------------------------------------------------------------------
// <copyright file="Client.cs" company="Bridgelabz">
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
    /// Client class
    /// </summary>
    public class Client
    {
        /// <summary>
        /// Clients the request.
        /// </summary>
        public static void ClientRequest()
        {
            //// Call The iNTERNET cLASS AND cHECK prOXY
            IInternet internet = new ProxyInternet();
            internet.ConnectTo("pqr.com");
            internet.ConnectTo("abc.com");
        }
                
    }
}
