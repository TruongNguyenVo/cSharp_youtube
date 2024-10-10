﻿using System.ComponentModel.DataAnnotations;

namespace WebApplication1.Helpers
{
    public class DateNotAfterAttribute : ValidationAttribute
    {
        private readonly string _otherProperty;

        public DateNotAfterAttribute(string otherProperty)
        {
            _otherProperty = otherProperty;
        }

        protected override ValidationResult IsValid(object value, ValidationContext validationContext)
        {
            var property = validationContext.ObjectType.GetProperty(_otherProperty);
            if (property == null)
            {
                return new ValidationResult(string.Format("The property '{0}' does not exist.", _otherProperty));
            }

            var otherPropertyValue = property.GetValue(validationContext.ObjectInstance);

            if (value != null && otherPropertyValue != null)
            {
                var thisValue = (DateTime)value;
                var otherValue = (DateTime)otherPropertyValue;

                if (thisValue < otherValue)
                {
                    return new ValidationResult("Ngày nhận không được nhỏ hơn ngày đặt hàng.");
                }
            }

            return ValidationResult.Success;
        }
    }
}
