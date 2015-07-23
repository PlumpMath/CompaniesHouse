using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;

namespace CompaniesHouse.Models
{
    [ComVisible(true)]
    [ClassInterface(ClassInterfaceType.None)]
    [Guid("D1D0F61F-8A22-40AF-8BBF-C57D4D0CDAF8")]
    public class Error : IError
    {
        public List<ErrorInfo> Errors { get; set; }
        public ErrorInfo[] Errors_COM
        {
            get
            {
                return Errors == null ? null : Errors.ToArray();
            }
        }

        [Guid("2B084921-1A92-4F66-BE99-C7B62FBEDFDD")]
        public interface IErrorInfo
        {
            string Error { get; set; }
            Dictionary<string, string> ErrorValues { get; set; }
            string Location { get; set; }
            string LocationType { get; set; }
            string Type { get; set; }
        }

        [ComVisible(true)]
        [ClassInterface(ClassInterfaceType.None)]
        [Guid("22744494-563F-44CD-94F7-95953E4D0563")]
        public class ErrorInfo : IErrorInfo
        {
            public string Error { get; set; }
            public Dictionary<string, string> ErrorValues { get; set; }
            public string Location { get; set; }
            public string LocationType { get; set; }
            public string Type { get; set; }
        }
    }

    [Guid("973A5A31-FCE0-4CF0-B509-4BFE5EA76FD1")]
    public interface IError
    {
        List<Error.ErrorInfo> Errors { get; set; }
        Error.ErrorInfo[] Errors_COM { get; }
    }
}
