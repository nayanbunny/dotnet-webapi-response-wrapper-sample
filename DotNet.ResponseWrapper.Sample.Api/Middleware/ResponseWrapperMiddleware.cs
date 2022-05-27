using DotNet.ResponseWrapper.Sample.Library.Helpers;
using Newtonsoft.Json;

namespace DotNet.ResponseWrapper.Sample.Api.Middleware
{
    /// <summary>
    /// Response Wrapper Middleware to Request Delegate and handles Request/Response Customizations.
    /// </summary>
    public class ResponseWrapperMiddleware
    {
        /// <summary>
        /// Request Delegate field to invoke HTTP Context
        /// </summary>
        private readonly RequestDelegate _next;

        /// <summary>
        /// The Response Wrapper Middleware Constructor
        /// </summary>
        /// <param name="next">The Request Delegate</param>
        public ResponseWrapperMiddleware(RequestDelegate next) => _next = next;

        /// <summary>
        /// Invoke Method for the HttpContext
        /// </summary>
        /// <param name="context">The HTTP Context</param>
        /// <returns>Response</returns>
        public async Task Invoke(HttpContext context)
        {
            // Storing Context Body Response
            var currentBody = context.Response.Body;

            // Using MemoryStream to hold Controller Response
            using var memoryStream = new MemoryStream();
            context.Response.Body = memoryStream;

            // Passing call to Controller
            await _next(context);

            // Resetting Context Body Response
            context.Response.Body = currentBody;

            // Setting Memory Stream Position to Beginning
            memoryStream.Seek(0, SeekOrigin.Begin);

            // Read Memory Stream data to the end
            var readToEnd = new StreamReader(memoryStream).ReadToEnd();

            // Deserializing Controller Response to an object
            var result = JsonConvert.DeserializeObject(readToEnd);

            // Invoking Customizations Method to handle Custom Formatted Response
            var response = ResponseWrapManager.ResponseWrapper(result, context);

            // returing response to caller
            await context.Response.WriteAsync(JsonConvert.SerializeObject(response));
        }
    }
}

