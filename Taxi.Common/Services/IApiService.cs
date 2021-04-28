using System;
using System.Collections.Generic;
using System.Text;
using Taxi.Common.Models;
using System.Threading.Tasks;

namespace Taxi.Common.Services
{
    public interface IApiService
    {
        Task<Response> GetTokenAsync(string urlBase, string servicePrefix, string controller, TokenRequest request);

        Task<Response> GetUserByEmail(string urlBase, string servicePrefix, string controller, string tokenType, string accessToken, EmailRequest request);

        Task<Response> GetTaxiAsync(string plaque, string urlBase, string servicePrefix, string controller);
        Task<bool> CheckConnectionAsync(string url);

    }
}

