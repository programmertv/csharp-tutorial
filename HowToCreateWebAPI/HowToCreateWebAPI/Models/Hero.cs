using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using HowToCreateWebAPI.Contracts;

namespace HowToCreateWebAPI.Models
{
    public class Hero: IBaseModel, IValidatableObject
    {
        public int Id { get; set; }
        [Required(ErrorMessage = "Required ang pangalan nang hero")]
        public string Name { get; set; }
        [Required, Range(18, 100)]
        public int Age { get; set; }

        public IEnumerable<ValidationResult> Validate(ValidationContext validationContext)
        {
            if (Age % 2 != 0)
                yield return new ValidationResult("Even number lang");

            if(Name.Equals("ninoy", StringComparison.OrdinalIgnoreCase))
                yield return new ValidationResult("Invalid hero");
        }
    }
}
