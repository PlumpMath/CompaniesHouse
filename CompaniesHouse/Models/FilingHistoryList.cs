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
    [Guid("B770EC83-9B70-4D24-BD85-AA5DAEC293DE")]
    public class FilingHistoryList : IFilingHistoryList
    {
        public string Etag { get; set; }
        public string FilingHistoryStatus { get; set; }
        public List<FilingHistoryItem> Items { get; set; }
        public FilingHistoryItem[] Items_COM 
        { 
            get {
                return Items == null ? null : Items.ToArray();
            }
        }
        public int ItemsPerPage { get; set; }
        public string Kind { get; set; }
        public int StartIndex { get; set; }
        public int TotalCount { get; set; }
    }

    [Guid("77D11B8E-1F8C-42A5-ACA0-4BE5CEE65C4D")]
    public interface IFilingHistoryList
    {
        string Etag { get; set; }
        string FilingHistoryStatus { get; set; }
        List<FilingHistoryItem> Items { get; set; }
        FilingHistoryItem[] Items_COM { get; }
        int ItemsPerPage { get; set; }
        string Kind { get; set; }
        int StartIndex { get; set; }
        int TotalCount { get; set; }
    }
}
