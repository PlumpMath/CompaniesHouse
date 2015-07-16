using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using RestSharp;
using CompaniesHouse.Models;
using System.Runtime.InteropServices;
using Newtonsoft.Json;

namespace CompaniesHouse
{
    [ComVisible(true)]
    [ClassInterface(ClassInterfaceType.None)]
    [Guid("D68BF4CF-7FEC-4A6E-9B75-649F0B5C3C7F")]
    public class CompaniesHouseClient : ICompaniesHouseClient
    {
        const string BaseUrl = "https://api.companieshouse.gov.uk/";
        const string ErrorMessage = "Error retrieving response.  Check inner details for more info.";

        public string UserName { get; set; }
        public string Password { get; set; }
        public Error LastError { get; set; }

        public CompaniesHouseClient()
        {
        }

        public CompaniesHouseClient(string userName, string password)
        {
            UserName = userName;
            Password = password;
        }

        private T Execute<T>(RestRequest request) where T : new()
        {
            RestClient client = new RestClient(BaseUrl);
            client.Authenticator = new HttpBasicAuthenticator(UserName, Password);

            var response = client.Execute<T>(request);

            if (response.ErrorException != null)
            {
                throw new ApplicationException(ErrorMessage, response.ErrorException);
            }

            if (response.StatusCode != System.Net.HttpStatusCode.OK)
            {
                LastError = JsonConvert.DeserializeObject<Error>(response.Content);
                return default(T);
            }

            return response.Data;
        }

        public CompanySearch SearchCompanies(string searchTerm)
        {
            RestRequest request = new RestRequest();
            request.Resource = "search/companies";

            request.AddParameter("q", searchTerm);

            return Execute<CompanySearch>(request);
        }

        public CompanyProfile GetCompanyProfile(string companyNumber)
        {
            RestRequest request = new RestRequest();
            request.Resource = "company/{company_number}";

            request.AddUrlSegment("company_number", companyNumber);

            return Execute<CompanyProfile>(request);
        }
    }

    [Guid("3EFB1D12-DF96-4605-B4B7-B5694E5A2D33")]
    public interface ICompaniesHouseClient
    {
        string UserName { get; set; }
        string Password { get; set; }
        Error LastError { get; set; }
        CompanySearch SearchCompanies(string searchTerm);
        CompanyProfile GetCompanyProfile(string companyNumber);
    }
}
