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
    [Guid("33C6AF01-4763-4A41-B3C7-759E3B574958")]
    public class OfficerList : IOfficerList
    {
        public int ActiveCount { get; set; }
        public string ETag { get; set; }
        public List<Item> Items { get; set; }
        public Item[] Items_COM { 
            get 
            {
                return Items == null ? null : Items.ToArray();
            }
        }
        public int ItemsPerPage { get; set; }
        public string Kind { get; set; }
        public int ResignedCount { get; set; }
        public int StartIndex { get; set; }
        public int TotalResults { get; set; }

        [Guid("6322F091-BDF5-4E9D-A13F-2E21F04B535C")]
        public interface IItem
        {
            CompanySearch.Address Address { get; set; }
            DateTime AppointedOn { get; set; }
            string CountryOfResidence { get; set; }
            CompanyProfile.DateOfBirth DateOfBirth { get; set; }
            string Name { get; set; }
            string Nationality { get; set; }
            string Occupation { get; set; }
            string OfficerRole { get; set; }
            DateTime ResignedOn { get; set; }
        }

        [ComVisible(true)]
        [ClassInterface(ClassInterfaceType.None)]
        [Guid("0A941682-8204-40F5-BF64-2136181ED1B1")]
        public class Item : IItem
        {
            public CompanySearch.Address Address { get; set; }
            public DateTime AppointedOn { get; set; }
            public string CountryOfResidence { get; set; }
            public CompanyProfile.DateOfBirth DateOfBirth { get; set; }
            public string Name { get; set; }
            public string Nationality { get; set; }
            public string Occupation { get; set; }
            public string OfficerRole { get; set; }
            public DateTime ResignedOn { get; set; }
        }
    }

    [Guid("061A8CDE-1A0F-4CD0-B17B-BC46836697C8")]
    public interface IOfficerList
    {
        int ActiveCount { get; set; }
        string ETag { get; set; }
        List<OfficerList.Item> Items { get; set; }
        OfficerList.Item[] Items_COM { get; }
        int ItemsPerPage { get; set; }
        string Kind { get; set; }
        int ResignedCount { get; set; }
        int StartIndex { get; set; }
        int TotalResults { get; set; }
    }
}
