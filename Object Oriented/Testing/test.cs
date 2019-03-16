using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

namespace Object_Oriented.Testing
{

    public class abc
    {
        public static void test()
        {
            string xyz = File.ReadAllText("E:/New Bridge/Object Oriented/Test.json");
            JObject rss = JObject.Parse(xyz);

            JObject channel = (JObject)rss["channel"];

            channel["title"] = ((string) channel["title"]).ToUpper();
            channel["description"] = ((string) channel["description"]).ToUpper();

            channel.Property("obsolete").Remove();

            channel.Property("description").AddAfterSelf(new JProperty("new", "New value"));

        Console.WriteLine(rss.ToString());
        }
    }
}

