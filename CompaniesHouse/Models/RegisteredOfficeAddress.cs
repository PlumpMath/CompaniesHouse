using RestSharp.Deserializers;
using System;
using System.Runtime.InteropServices;

namespace CompaniesHouse.Models
{
    [ComVisible(true)]
    [ClassInterface(ClassInterfaceType.None)]
    [Guid("AB452CBA-8ED3-461C-86F3-F7B1A70E3C40")]
    public class RegisteredOfficeAddress : IRegisteredOfficeAddress
    {
        [DeserializeAs(Name="address_line_1")]
        public string AddressLine1 { get; set; }
        [DeserializeAs(Name = "address_line_2")]
        public string AddressLine2 { get; set; }
        public string Country { get; set; }
        public string ETag { get; set; }
        public string Locality { get; set; }
        public string POBox { get; set; }
        public string PostalCode { get; set; }
        public string Premises { get; set; }
        public string Region { get; set; }
    }

    [Guid("01729513-EB8A-4981-961C-327E69F859FC")]
    public interface IRegisteredOfficeAddress
    {
        string AddressLine1 { get; set; }
        string AddressLine2 { get; set; }
        string Country { get; set; }
        string ETag { get; set; }
        string Locality { get; set; }
        string POBox { get; set; }
        string PostalCode { get; set; }
        string Premises { get; set; }
        string Region { get; set; }
    }
}
