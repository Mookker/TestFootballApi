using System.Collections.Generic;
using System.Threading.Tasks;

namespace TestFootballApi.Core.Helpers.Interfaces
{
    public interface IHttpHelperService
    {
        /// <summary>
        /// Authorization token
        /// </summary>
        string AuthToken { get; set; }

        /// <summary>
        /// Authorization scheme
        /// </summary>
        string AuthorizationScheme { get; set; }
        /// <summary>
        /// Gets custom header
        /// </summary>
        /// <param name="name">header name</param>
        /// <returns>Value of header</returns>
        IEnumerable<string> GetCustomHeader(string name);

        /// <summary>
        /// Adds custom header
        /// </summary>
        /// <param name="name">header name</param>
        /// <param name="value">header value</param>
        void AddCustomHeader(string name, string value);

        /// <summary>
        /// Removes header
        /// </summary>
        /// <param name="name">header name</param>
        void RemoveCustomHeader(string name);

        /// <summary>
        /// Removes all headers
        /// </summary>
        void RemoveAllHeaders();

        /// <summary>
        /// Performs GET request
        /// </summary>
        /// <typeparam name="R">Type of return result</typeparam>
        /// <param name="uri">Uri to send request</param>
        /// <returns></returns>
        Task<R> GetJSONResponse<R>(string uri) where R : class, new();

        /// <summary>
        /// Performs POST request
        /// </summary>
        /// <typeparam name="T">Type of body object</typeparam>
        /// <typeparam name="R">Type of return result</typeparam>
        /// <param name="uri">Uri to send request></param>
        /// <param name="body">Body</param>
        /// <returns></returns>
        Task<R> PostJSONResponse<T, R>(string uri, T body) where T : class, new() where R : class, new();

        /// <summary>
        /// Performs POST request with XForm values.
        /// </summary>
        /// <typeparam name="R">Type of return result.</typeparam>
        /// <param name="uri">The URI.</param>
        /// <param name="formValues">The form values.</param>
        /// <returns></returns>
        Task<R> PostXFormResponse<R>(string uri, Dictionary<string, string> formValues) where R : class, new();

        /// <summary>
        /// Performs PUT request
        /// </summary>
        /// <typeparam name="T">Type of body object</typeparam>
        /// <typeparam name="R">Type of return result</typeparam>
        /// <param name="uri">Uri to send request></param>
        /// <param name="body">Body</param>
        /// <returns></returns>
        Task<R> PutJSONResponse<T, R>(string uri, T body) where T : class, new() where R : class, new();
        
        /// <summary>
        /// Performs DELETE request
        /// </summary>
        /// <typeparam name="T">Type of body object</typeparam>
        /// <typeparam name="R">Type of return result</typeparam>
        /// <param name="uri">Uri to send request></param>
        /// <returns></returns>
        Task<R> DeleteJSONResponse<R>(string uri) where R : class, new();

        /// <summary>
        /// Performs PATCH request
        /// </summary>
        /// <typeparam name="T">Type of body object</typeparam>
        /// <typeparam name="R">Type of return result</typeparam>
        /// <param name="uri">Uri to send request></param>
        /// <param name="body">Body</param>
        /// <returns></returns>
        Task<R> PatchJSONResponse<T, R>(string uri, T body) where T : class, new() where R : class, new();

        /// <summary>
        /// Performs POST request
        /// </summary>
        /// <typeparam name="T">Type of body object</typeparam>
        /// <param name="uri">Uri to send request></param>
        /// <param name="body">Body</param>
        /// <returns></returns>
        Task PostJSONResponse<T>(string uri, T body) where T : class, new();

        /// <summary>
        /// Performs POST request.
        /// </summary>
        /// <typeparam name="R">Type of return result.</typeparam>
        /// <param name="uri">Uri to send request.</param>
        /// <returns></returns>
        Task<R> PostJSONResponse<R>(string uri) where R : class, new();

        /// <summary>
        /// Performs POST request.
        /// </summary>
        /// <param name="uri">Uri to send request.</param>
        /// <returns></returns>
        Task PostJSONResponse(string uri);

        /// <summary>
        /// Performs HEAD request.
        /// </summary>
        /// <param name="uri">The URI.</param>
        /// <returns></returns>
        Task<bool> HeadJSONResponse(string uri);

        /// <summary>
        /// Performs PUT request
        /// </summary>
        /// <typeparam name="T">Type of body object</typeparam>
        /// <param name="uri">Uri to send request></param>
        /// <param name="body">Body</param>
        /// <returns></returns>
        Task PutJSONResponse<T>(string uri, T body) where T : class, new();

        /// <summary>
        /// Performs PUT request.
        /// </summary>
        /// <param name="uri">The URI.</param>
        /// <returns></returns>
        Task PutJSONResponse(string uri);

        /// <summary>
        /// Performs DELET request
        /// </summary>
        /// <typeparam name="T">Type of body object</typeparam>
        /// <param name="uri">Uri to send request></param>
        /// <returns></returns>
        Task DeleteJSONResponse(string uri);

        /// <summary>
        /// Performs PATCH request
        /// </summary>
        /// <typeparam name="T">Type of body object</typeparam>
        /// <param name="uri">Uri to send request></param>
        /// <param name="body">Body</param>
        /// <returns></returns>
        Task PatchJSONResponse<T>(string uri, T body) where T : class, new();
    }
}
