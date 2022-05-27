using System.Net;
using DotNet.ResponseWrapper.Sample.Library.ClassObjects;
using DotNet.ResponseWrapper.Sample.Library.Constants;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Http.Extensions;

namespace DotNet.ResponseWrapper.Sample.Library.Helpers
{
    /// <summary>
    /// Response Wrap Manager to handle any customizations on result and return Custom Formatted Response.
    /// </summary>
    public static class ResponseWrapManager
    {
        /// <summary>
        /// The Response Wrapper method handles customizations and generate Formatted Response.
        /// </summary>
        /// <param name="result">The Result</param>
        /// <param name="context">The HTTP Context</param>
        /// <param name="exception">The Exception</param>
        /// <returns>Sample Response Object</returns>
        public static SampleResponse ResponseWrapper(object? result, HttpContext context, object? exception = null)
        {
            var requestUrl = context.Request.GetDisplayUrl();
            var data = result;
            var error = exception != null ? ServiceConstants.ExceptionWrapperMessage : null;
            var status = result != null;
            var httpStatusCode = (HttpStatusCode)context.Response.StatusCode;

            // NOTE: Add any further customizations if needed

            return new SampleResponse(requestUrl, data, error, status, httpStatusCode);
        }
    }
}