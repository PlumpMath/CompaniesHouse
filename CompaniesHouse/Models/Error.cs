using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CompaniesHouse.Models
{
    public class Error
    {
        public List<ErrorInfo> Errors { get; set; }

        public class ErrorInfo
        {
            public string Error { get; set; }
            public Dictionary<string, string> ErrorValues { get; set; }
            public string Location { get; set; }
            public string LocationType { get; set; }
            public string Type { get; set; }
        }
    }
}
