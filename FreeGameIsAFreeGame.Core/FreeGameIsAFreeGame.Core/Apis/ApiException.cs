using System;
using System.Net;
using RestSharp;

namespace FreeGameIsAFreeGame.Core.Apis
{
    [Serializable]
    public class ApiException : Exception
    {
        public ApiException(IRestResponse response)
        {
            StatusCode = response.StatusCode;
            StatusDescription = response.StatusDescription;
            ResponseStatus = response.ResponseStatus;
        }

        public HttpStatusCode StatusCode { get; }
        public string StatusDescription { get; }
        public ResponseStatus ResponseStatus { get; }
    }
}
