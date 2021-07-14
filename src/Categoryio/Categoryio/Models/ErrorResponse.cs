using System.Collections.Generic;

namespace Categoryio.Api.Models
{
    /// <summary>
    /// Error response.
    /// </summary>
    public class ErrorResponse
    {
        public ErrorResponse()
        {
            ValidationErrors = new List<ValidationError>();
        }

        /// <summary> Initializes a new instance of ErrorResponse. </summary>
        /// <param name="message"> Description of the error. </param>
        /// <param name="validationErrors"> List of the validation errors. </param>
        public ErrorResponse(string message, IReadOnlyList<ValidationError> validationErrors)
        {
            Message = message;
            ValidationErrors = validationErrors;
        }

        /// <summary> Description of the error. </summary>
        public string Message { get; set; }
        /// <summary> List of the validation errors. </summary>
        public IReadOnlyList<ValidationError> ValidationErrors { get; set; }
    }
}
