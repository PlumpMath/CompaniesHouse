using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace CompaniesHouse.Models
{
    [ComVisible(true)]
    [ClassInterface(ClassInterfaceType.None)]
    [Guid("B35A45D7-7488-4204-9588-AEE07E5A6B5C")]
    public class CompanySearch : ICompanySearch
    {
        public string ETag { get; set; }
        public List<Item> Items { get; set; }
        public int ItemsPerPage { get; set; }
        public string Kind { get; set; }
        public int PageNumber { get; set; }
        public int StartIndex { get; set; }
        public int TotalResults { get; set; }

        [Guid("57E6F5B7-F7E5-410F-ADF8-60A55F8B0A42")]
        public interface IItem
        {
            Address Address { get; set; }
            string CompanyNumber { get; set; }

            // enums
            string CompanyStatus { get; set; }
            string CompanyType { get; set; }

            DateTime DateOfCessation { get; set; }
            DateTime DateOfCreation { get; set; }
            string Description { get; set; }
            List<string> DescriptionIdentifier { get; set; }
            string Kind { get; set; }

            Link Links { get; set; }
            Match Matches { get; set; }

            string Snippet { get; set; }
            string Title { get; set; }
        }

        [ComVisible(true)]
        [ClassInterface(ClassInterfaceType.None)]
        [Guid("B9690AE7-CAD2-42A8-9007-DFC875FFF0A6")]
        public class Item : IItem
        {
            public Address Address { get; set; }
            public string CompanyNumber { get; set; }
            
            // enums
            public string CompanyStatus { get; set; }
            public string CompanyType { get; set; }

            public DateTime DateOfCessation { get; set; }
            public DateTime DateOfCreation { get; set; }
            public string Description { get; set; }
            public List<string> DescriptionIdentifier { get; set; }
            public string Kind { get; set; }

            public Link Links { get; set; }
            public Match Matches { get; set; }

            public string Snippet { get; set; }
            public string Title { get; set; }
        }

        [Guid("4A06C260-E9C2-45D4-BBD3-1BF150D909ED")]
        public interface IAddress
        {
            string AddressLine1 { get; set; }
            string AddressLine2 { get; set; }
            string CareOf { get; set; }
            string Country { get; set; }
            string Locality { get; set; }
            string POBox { get; set; }
            string PostalCode { get; set; }
            string Region { get; set; }
        }

        [ComVisible(true)]
        [ClassInterface(ClassInterfaceType.None)]
        [Guid("4C816836-BBFC-4649-BA56-DC78E4D4E4D4")]
        public class Address : IAddress
        {
            public string AddressLine1 { get; set; }
            public string AddressLine2 { get; set; }
            public string CareOf { get; set; }
            public string Country { get; set; }
            public string Locality { get; set; }
            public string POBox { get; set; }
            public string PostalCode { get; set; }
            public string Region { get; set; }
        }

        [Guid("2F2B1738-79AF-49BD-A5D2-9401918039A7")]
        public interface ILink
        {
            string Self { get; set; }
        }

        [ComVisible(true)]
        [ClassInterface(ClassInterfaceType.None)]
        [Guid("832A8EDA-2111-401C-95B1-3338F1401E3F")]
        public class Link : ILink
        {
            public string Self { get; set; }
        }

        [Guid("BAC26961-07A6-4246-80E9-D698C2D2FFFE")]
        public interface IMatch
        {
            List<string> Title { get; set; }
        }

        [ComVisible(true)]
        [ClassInterface(ClassInterfaceType.None)]
        [Guid("4E63812E-0B5C-4EE7-91D6-2129DF4778F1")]
        public class Match : IMatch
        {
            public List<string> Title { get; set; }
        }
    }

    [Guid("16F0861E-A82F-43DC-9C37-0694B34C5A91")]
    public interface ICompanySearch
    {
        string ETag { get; set; }
        List<CompanySearch.Item> Items { get; set; }
        int ItemsPerPage { get; set; }
        string Kind { get; set; }
        int PageNumber { get; set; }
        int StartIndex { get; set; }
        int TotalResults { get; set; }
    }
}
