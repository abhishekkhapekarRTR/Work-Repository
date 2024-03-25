
namespace Skinet.API.Errors
{
    public class ApiResponse
    {
        public ApiResponse(int statusCode, string message = null)
        {
            this.StatusCode = statusCode;
            this.Message = message ?? GetDefaultMessageForStatusCode(statusCode);
        }

        public int StatusCode { get; set; }

        public string Message { get; set; }


        private string GetDefaultMessageForStatusCode(int statusCode)
        {
            return statusCode switch
            {
                400 => "A bad request, You have made",
                401 => "Authorized, You are not",
                404 => "Resource found, It was not",
                500 => "Errors are the path to the dark side. Errors lead to anger, Anger lead to hate. Hate leads to career change",
                _ => null
            };
        }
    }
}
