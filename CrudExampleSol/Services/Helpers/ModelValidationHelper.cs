using System.ComponentModel.DataAnnotations;

namespace Services.Helpers
{
    public class ModelValidationHelper
    {

        internal static void ModelValidation(Object obj)
        {
            ValidationContext validationContext = new ValidationContext(obj);
            List<ValidationResult> validationResults = new List<ValidationResult>();

            bool IsValid = Validator.TryValidateObject(obj, validationContext, validationResults, true);

            if (!IsValid)
                throw new ArgumentException(validationResults.FirstOrDefault()?.ErrorMessage);

        }
    }
}
