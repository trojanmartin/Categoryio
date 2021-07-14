namespace Categoryio.Api.Models
{
    /// <summary>
    /// Validation error.
    /// </summary>
    public class ValidationError
    {
        /// <summary> Initializes a new instance of ValidationError. </summary>
        public ValidationError()
        {
        }

        /// <summary> Initializes a new instance of ValidationError. </summary>
        /// <param name="errorCode"> Error code. </param>
        /// <param name="errorMessage"> Error message. </param>
        /// <param name="fieldId"> Field Id. </param>
        public ValidationError(string errorCode, string errorMessage, string fieldId)
        {
            ErrorCode = errorCode;
            ErrorMessage = errorMessage;
            FieldId = fieldId;
        }

        /// <summary> Error code. </summary>
        public string ErrorCode { get; set; }
        /// <summary> Error message. </summary>
        public string ErrorMessage { get; set; }
        /// <summary> Field Id. </summary>
        public string FieldId { get; set; }
    }
}
