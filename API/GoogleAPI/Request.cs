using RestSharp;

namespace GoogleAPI
{
    /// <summary>
    /// Request information from a REST API.
    /// </summary>
    public class Request
    {
        /// <summary>
        /// Build a Request object with the given baseAddress.
        /// </summary>
        /// <param name="baseAddress"><see cref="BaseAddress"/></param>
        public Request(string baseAddress)
        {
            BaseAddress = baseAddress;
        }

        /// <summary>
        /// Base address for the given requests.
        /// </summary>
        public string BaseAddress { get; }

        /// <summary>
        /// Request data from a Get REST API.
        /// </summary>
        /// <param name="route">Request path after the BaseAddress.</param>
        /// <returns></returns>
        public string Get(string route)
        {
            var client = new RestClient(BaseAddress);
            var request = new RestRequest(route, Method.GET);

            return client.Execute(request).Content;
        }
    }
}
