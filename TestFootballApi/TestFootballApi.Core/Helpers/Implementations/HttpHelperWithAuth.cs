using System;
using System.Collections.Generic;
using System.Net;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Threading.Tasks;
using Newtonsoft.Json;
using TestFootballApi.Core.Exceptions;
using TestFootballApi.Core.Extensions;
using TestFootballApi.Core.Helpers.Interfaces;

namespace TestFootballApi.Core.Helpers.Implementations
{
    public  class HttpHelperWithAuth : IHttpHelperService
    {
        string _token;
        string _scheme;
        HttpClient _client = new HttpClient();

        public HttpHelperWithAuth()
        {
            _client.DefaultRequestHeaders.Connection.Add("keep-alive");
        }

        public HttpHelperWithAuth(string token)
        {
            AuthToken = token;
            _client.DefaultRequestHeaders.Connection.Add("keep-alive");
        }

        public HttpHelperWithAuth(bool addOriginHeader, string key, string value)
        {
            if (addOriginHeader)
                AddCustomHeader(key, value);
        }

        public string AuthorizationScheme
        {
            get => _scheme;
            set
            {
                _scheme = value;
                AuthToken = _token;
            }
        }

        public string AuthToken
        {
            get
            {
                return _token;
            }

            set
            {
                _token = value;
                _client.DefaultRequestHeaders.Authorization = new AuthenticationHeaderValue(AuthorizationScheme, _token);
            }
        }

        #region IHttpHelper Implementation
        public IEnumerable<string> GetCustomHeader(string name)
        {
            if(_client.DefaultRequestHeaders.Contains(name))
                return _client.DefaultRequestHeaders.GetValues(name);
            return null;
        }

        public void AddCustomHeader(string name, string value)
        {
            if (_client.DefaultRequestHeaders.Contains(name))
                _client.DefaultRequestHeaders.Remove(name);
            _client.DefaultRequestHeaders.Add(name, value);
        }
        public void RemoveAllHeaders()
        {
           _client.DefaultRequestHeaders.Clear();
        }

        public void RemoveCustomHeader(string name)
        {
            if (_client.DefaultRequestHeaders.Contains(name))
                _client.DefaultRequestHeaders.Remove(name);
        }

        public async Task DeleteJSONResponse(string uri)
        {
            try
            {
                HttpResponseMessage response = await _client.DeleteAsync(uri);
                response.CheckStatusCode();
            }
            catch (HttpResponseException)
            {
                throw;
            }
            catch (Exception ex)
            {
                throw new InternalServiceException(ex);
            }
        }

        public async Task<R> DeleteJSONResponse<R>(string uri)
            where R : class, new()
        {
            try
            {
                HttpResponseMessage response = await _client.DeleteAsync(uri);
                response.CheckStatusCode();
                string responseBody = await response.Content.ReadAsStringAsync();
                var responseObj = JsonConvert.DeserializeObject<R>(responseBody);

                return responseObj;
            }
            catch (HttpResponseException)
            {
                throw;
            }
            catch (Exception ex)
            {
                throw new InternalServiceException(ex);
            }
        }
        
        public async Task<R> GetJSONResponse<R>(string uri) where R : class, new()
        {
            try
            {
                HttpResponseMessage response = await _client.GetAsync(uri);
                response.CheckStatusCode();
                string responseBody = await response.Content.ReadAsStringAsync();
                var responseObj = JsonConvert.DeserializeObject<R>(responseBody);

                return responseObj;
            }
            catch (HttpResponseException)
            {
                throw;
            }
            catch (Exception ex)
            {
                throw new InternalServiceException(ex);
            }
        }

        public async Task PatchJSONResponse<T>(string uri, T body) where T : class, new()
        {
            try
            {
                var method = new HttpMethod("PATCH");
                var request = new HttpRequestMessage(method, uri);
                var bodyJson = JsonConvert.SerializeObject(body);
                request.Content = new StringContent(bodyJson, System.Text.Encoding.UTF8, "application/json");
                var response = await _client.SendAsync(request);
                response.CheckStatusCode();
            }
            catch (HttpResponseException)
            {
                throw;
            }
            catch (Exception ex)
            {
                throw new InternalServiceException(ex);
            }
        }

        public async Task<bool> HeadJSONResponse(string uri)
        {
            try
            {
                var method = new HttpMethod("HEAD");
                var request = new HttpRequestMessage(method, uri);
                var response = await _client.SendAsync(request);
                
                // allow 404 response
                if (response.StatusCode != HttpStatusCode.NotFound)
                {
                    response.CheckStatusCode();
                }

                return response.IsSuccessStatusCode;
            }
            catch (HttpResponseException)
            {
                throw;
            }
            catch (Exception ex)
            {
                throw new InternalServiceException(ex);
            }
        }

        public async Task<R> PatchJSONResponse<T, R>(string uri, T body)
            where T : class, new()
            where R : class, new()
        {
            try
            {
                var method = new HttpMethod("PATCH");
                var request = new HttpRequestMessage(method, uri);
                var bodyJson = JsonConvert.SerializeObject(body);
                request.Content = new StringContent(bodyJson, System.Text.Encoding.UTF8, "application/json");
                var response = await _client.SendAsync(request);
                response.CheckStatusCode();
                string responseBody = await response.Content.ReadAsStringAsync();
                var responseObj = JsonConvert.DeserializeObject<R>(responseBody);

                return responseObj;
            }
            catch (HttpResponseException)
            {
                throw;
            }
            catch (Exception ex)
            {
                throw new InternalServiceException(ex);
            }
        }

        public async Task PostJSONResponse<T>(string uri, T body) where T : class, new()
        {
            try
            {
                var bodyJson = JsonConvert.SerializeObject(body);
                var content = new StringContent(bodyJson, System.Text.Encoding.UTF8, "application/json");
                HttpResponseMessage response = await _client.PostAsync(uri, content);
                response.CheckStatusCode();
            }
            catch (HttpResponseException)
            {
                throw;
            }
            catch (Exception ex)
            {
                throw new InternalServiceException(ex);
            }
        }

        public async Task<R> PostJSONResponse<T, R>(string uri, T body) 
            where T : class, new() 
            where R: class, new()
        {
            try
            {
                var bodyJson = JsonConvert.SerializeObject(body);
                var content = new StringContent(bodyJson, System.Text.Encoding.UTF8, "application/json");
                HttpResponseMessage response = await _client.PostAsync(uri, content);
                response.CheckStatusCode();
                string responseBody = await response.Content.ReadAsStringAsync();
                var responseObj = JsonConvert.DeserializeObject<R>(responseBody);

                return responseObj;
            }
            catch (HttpResponseException)
            {
                throw;
            }
            catch (Exception ex)
            {
                throw new InternalServiceException(ex);
            }
        }

        public async Task<R> PostJSONResponse<R>(string uri)
            where R : class, new()
        {
            try
            {
                var content = new StringContent(String.Empty, System.Text.Encoding.UTF8, "application/json");
                HttpResponseMessage response = await _client.PostAsync(uri, content);
                response.CheckStatusCode();
                string responseBody = await response.Content.ReadAsStringAsync();
                var responseObj = JsonConvert.DeserializeObject<R>(responseBody);

                return responseObj;
            }
            catch (HttpResponseException)
            {
                throw;
            }
            catch (Exception ex)
            {
                throw new InternalServiceException(ex);
            }
        }

        public async Task PostJSONResponse(string uri)
        {
            try
            {
                var content = new StringContent(String.Empty, System.Text.Encoding.UTF8, "application/json");
                HttpResponseMessage response = await _client.PostAsync(uri, content);
                response.CheckStatusCode();
            }
            catch (HttpResponseException)
            {
                throw;
            }
            catch (Exception ex)
            {
                throw new InternalServiceException(ex);
            }
        }

        public async Task<R> PostXFormResponse<R>(string uri, Dictionary<string, string> formValues)
            where R : class, new()
        {
            try
            {
                var content = new FormUrlEncodedContent(formValues);
                HttpResponseMessage response = await _client.PostAsync(uri, content);
                response.CheckStatusCode();
                string responseBody = await response.Content.ReadAsStringAsync();
                var responseObj = JsonConvert.DeserializeObject<R>(responseBody);

                return responseObj;
            }
            catch (HttpResponseException)
            {
                throw;
            }
            catch (Exception ex)
            {
                throw new InternalServiceException(ex);
            }
        }

        public async Task PutJSONResponse(string uri)
        {
            try
            {
                HttpResponseMessage response = await _client.PutAsync(uri, null);
                response.CheckStatusCode();
            }
            catch (HttpResponseException)
            {
                throw;
            }
            catch (Exception ex)
            {
                throw new InternalServiceException(ex);
            }
        }

        public async Task PutJSONResponse<T>(string uri, T body) where T : class, new()
        {
            try
            {
                var bodyJson = JsonConvert.SerializeObject(body);
                var content = new StringContent(bodyJson, System.Text.Encoding.UTF8, "application/json");
                HttpResponseMessage response = await _client.PutAsync(uri, content);
                response.CheckStatusCode();
            }
            catch (HttpResponseException)
            {
                throw;
            }
            catch (Exception ex)
            {
                throw new InternalServiceException(ex);
            }
        }

        public async Task<R> PutJSONResponse<T, R>(string uri, T body)
            where T : class, new()
            where R : class, new()
        {
            try
            {
                var bodyJson = JsonConvert.SerializeObject(body);
                var content = new StringContent(bodyJson, System.Text.Encoding.UTF8, "application/json");
                HttpResponseMessage response = await _client.PutAsync(uri, content);
                response.CheckStatusCode();
                string responseBody = await response.Content.ReadAsStringAsync();
                var responseObj = JsonConvert.DeserializeObject<R>(responseBody);

                return responseObj;
            }
            catch (HttpResponseException)
            {
                throw;
            }
            catch (Exception ex)
            {
                throw new InternalServiceException(ex);
            }
        }

        #endregion


    }
    
}
