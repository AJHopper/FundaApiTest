using FundaApiTest.WrappingApi.Models;
using System;
using System.IO;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace FundaApiTest.WrappingApi
{
    public interface IWrapFundaApi : IDisposable
    {
        Task<LocatieFeed> GetProperties(int pageSize, int pageNumber, string location, string type, string[] filters, CancellationToken ct = default);
    }

    public class FundaApiWrapper : IWrapFundaApi
    {
        protected readonly HttpClient _httpClient;
        private readonly string _ApiKey;

        public FundaApiWrapper(string apiKey, HttpClient httpClient)
        {
            _ApiKey = apiKey;
            _httpClient = httpClient;
        }

        public async Task<LocatieFeed> GetProperties(int pageSize, int pageNumber, string location, string type, string[] filters, CancellationToken ct = default)
        {
            // running a 650ms sleep here to ensure the API doesnt exceed the 100 request per min limitation.
            ApplyThrottling();

            var urlBuilder_ = new StringBuilder();

            urlBuilder_.Append($"{_ApiKey}/");
            urlBuilder_.Append($"?type={type}");
            urlBuilder_.Append($"&zo=/{location}/");

            if (filters != null)
            {
                foreach (var filter in filters)
                {
                    urlBuilder_.Append($"{filter}/");
                }
            }
            
            urlBuilder_.Append($"&page={pageNumber}");
            urlBuilder_.Append($"&pagesize={pageSize}");

            var client_ = _httpClient;

            try
            {
                using(var request_ = new HttpRequestMessage())
                {
                    request_.Method = new HttpMethod("GET");
                    request_.Headers.Accept.Add(new MediaTypeWithQualityHeaderValue("application/xml"));
                    var url_ = urlBuilder_.ToString();
                    request_.RequestUri = new System.Uri(url_, System.UriKind.RelativeOrAbsolute);

                    var response_ = await client_.SendAsync(request_, System.Net.Http.HttpCompletionOption.ResponseHeadersRead, ct).ConfigureAwait(false);

                    try
                    {
                        // Switch on status code to allow for specific handling of certain status codes - allows greater flexibility in throwing specific errors
                        switch (response_.StatusCode)
                        {
                            case System.Net.HttpStatusCode.OK:
                                {
                                    var responseData_ = response_.Content == null ? null : await response_.Content.ReadAsStringAsync().ConfigureAwait(false);
                                    var result_ = default(LocatieFeed);

                                    try
                                    {
                                        var serializer = new XmlSerializer(typeof(LocatieFeed));

                                        using (TextReader reader = new StringReader(responseData_))
                                        {
                                            result_ = (LocatieFeed)serializer.Deserialize(reader);
                                            return result_;
                                        }
                                    }
                                    catch(Exception e)
                                    {
                                        // Catch and throw new exception - we could implement a "FundaApiException" class that inherits from Exception and contains more / specific info on the error.
                                        throw new Exception("Failed to deserialize response body", e);
                                    }
                                }
                            default:
                                {
                                    throw new Exception($"Unexpected status code in API response. Status code: {response_.StatusCode}");
                                }
                        }
                    }
                    finally
                    {
                        if (response_ != null)
                            response_.Dispose();
                    }
                }
            }
            finally
            {                
            }
            // outer try blocks don't catch exceptions as all exception cases should be caught and handles by innermost try - these are here for cleaning up resources.
        }

        public void Dispose()
        {
            _httpClient.Dispose();
        }

        private void ApplyThrottling()
        {
            Thread.Sleep(650);
        }
    }
}
