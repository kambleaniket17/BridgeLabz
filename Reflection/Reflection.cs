// --------------------------------------------------------------------------------------------------------------------
// <copyright file="Reflection.cs" company="Bridgelabz">
//   Copyright © 2018 Company
// </copyright>
// <creator name="Aniket Kamble"/>
// --------------------------------------------------------------------------------------------------------------------

namespace Design_Pattern.Reflection
{
    using System;
    using System.Reflection;

    /// <summary>
    /// Employee reflection is a class which give information about the data
    /// means data about data metadata
    /// </summary>
    public class Reflection
    {
        /// <summary>
        /// Gets or sets the identifier.
        /// </summary>
        /// <value>
        /// The identifier.
        /// </value>
        public int Id { get; set; }

        /// <summary>
        /// Gets or sets the first name.
        /// </summary>
        /// <value>
        /// The first name.
        /// </value>
        public string FirstName { get; set; }

        /// <summary>
        /// Gets or sets the last name.
        /// </summary>
        /// <value>
        /// The last name.
        /// </value>
        public string LastName { get; set; }

        /// <summary>
        /// Gets or sets the address.
        /// </summary>
        /// <value>
        /// The address.
        /// </value>
        public string Address { get; set; }

        /// <summary>
        /// Reflections this instance.
        /// </summary>
        public void Reflections()
        {
            ////Type is a class of reflection namespace which show the type of data
            Type type = typeof(Reflection);
            Console.WriteLine("Class" + type.Name);
            Console.WriteLine("Class" + type.FullName);
            Console.WriteLine("Class" + type.Namespace);
            ////property info is an array which keep all the public data
            PropertyInfo[] pinfo = type.GetProperties();
            ////iteration is to iterate till the length of the array
            foreach (PropertyInfo propertyInfo in pinfo)
            {
                Console.WriteLine(propertyInfo.PropertyType.Name + " " + propertyInfo.Name);
            }

            ////constructor info array give all the types of constructor
            ConstructorInfo[] constructorInfos = type.GetConstructors();
            ////iteration will iterate till the length of array
            foreach (ConstructorInfo info in constructorInfos)
            {
                Console.WriteLine(info);
            }
        }
    }
}
