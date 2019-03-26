// --------------------------------------------------------------------------------------------------------------------
// <copyright file="Annotation.cs" company="Bridgelabz">
//   Copyright © 2018 Company
// </copyright>
// <creator name="Aniket Kamble"/>
// --------------------------------------------------------------------------------------------------------------------
namespace Design_Pattern
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;
    using System.ComponentModel;
    using System.ComponentModel.DataAnnotations;

    /// <summary>
    /// Annotation
    /// </summary>
    public class Annotation
    {
         /// <summary>
         /// Validation of name
         /// </summary>
        private string name { get; set; }
       // [Required(ErrorMessage = "this field is mandatory")]
       // [RegularExpression(@"[a-zA-Z]{3,25}")]
        public string Name
        {
            get
            {
                return name;
            }

            set
            {
                name = value;
            }
        }
         /// <summary>
         /// ValidateOfAnnotation
         /// </summary>
        public void ValidateOfAnnotation()
        {
            try
            {
                Console.WriteLine("Enter the Name");
                string name = Console.ReadLine();
                Annotation annotation = new Annotation();
                annotation.name = name;
                ValidationContext validation = new ValidationContext(annotation, null, null);
                var result = new List<ValidationResult>();
                bool isValid = Validator.TryValidateObject(annotation, validation, result, true);
                Console.WriteLine(isValid);
                foreach (var message in result)
                {
                    Console.WriteLine(message);
                }
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
        }
    } 
}
