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
    [Guid("656E8A2F-59C6-436B-ADB4-67CAAAB61A4F")]
    public class FilingHistoryItem : IFilingHistoryItem
    {
        public List<Annotation> Annotations { get; set; }
        public Annotation[] Annotations_COM
        {
            get
            {
                return Annotations == null ? null : Annotations.ToArray();
            }
        }
        public List<AssociatedFiling> AssociatedFilings { get; set; }
        public string Barcode { get; set; }
        public string Category { get; set; }
        public DateTime Date { get; set; }
        public string Description { get; set; }
        public List<Link> Links { get; set; }
        public Link[] Links_COM
        {
            get
            {
                return Links == null ? null : Links.ToArray();
            }
        }
        public int Pages { get; set; }
        public bool PaperFiled { get; set; }
        public List<Resolution> Resolutions { get; set; }
        public Resolution[] Resolutions_COM
        {
            get
            {
                return Resolutions == null ? null : Resolutions.ToArray();
            }
        }
        public string Subcategory { get; set; }
        public string TransactionID { get; set; }
        public string Type { get; set; }

        [Guid("D8AF29E2-CC57-4CDC-9CB7-E517C73FC652")]
        public interface IAnnotation
        {
            string Annotation { get; set; }
            DateTime Date { get; set; }
            string Description { get; set; }
        }

        [ComVisible(true)]
        [ClassInterface(ClassInterfaceType.None)]
        [Guid("B9AE65F7-2B4C-4752-A6D8-5F62834AFE34")]
        public class Annotation : IAnnotation
        {
            public string Annotation { get; set; }
            public DateTime Date { get; set; }
            public string Description { get; set; }
        }

        [Guid("C8BC54BE-39DB-43F2-86C9-BDF736626AEA")]
        public interface IAssociatedFiling
        {
            DateTime Date { get; set; }
            string Description { get; set; }
            string Type { get; set; }
        }

        [ComVisible(true)]
        [ClassInterface(ClassInterfaceType.None)]
        [Guid("7D74D16E-F937-4980-9237-7FB463E39F3B")]
        public class AssociatedFiling : IAssociatedFiling
        {
            public DateTime Date { get; set; }
            public string Description { get; set; }
            public string Type { get; set; }
        }

        [Guid("12BD37E5-7BB5-4FD6-BA1C-08177C6F53B7")]
        public interface ILink
        {
            string DocumentMetaData { get; set; }
            string Self { get; set; }
        }

        [ComVisible(true)]
        [ClassInterface(ClassInterfaceType.None)]
        [Guid("AAD018AD-EFCD-43C5-8311-656DD45DF86E")]
        public class Link : ILink
        {
            public string DocumentMetaData { get; set; }
            public string Self { get; set; }
        }

        [Guid("9F3755DE-1E7F-446D-A9BB-214AF0ADEE98")]
        public interface IResolution
        {
            string Category { get; set; }
            string Description { get; set; }
            string DocumentID { get; set; }
            string ReceiveDate { get; set; }
            string Subcategory { get; set; }
            string Type { get; set; }
        }

        [ComVisible(true)]
        [ClassInterface(ClassInterfaceType.None)]
        [Guid("E8ECBFF7-D6C5-43A5-A6DD-C2B0AF241F71")]
        public class Resolution : IResolution
        {
            public string Category { get; set; }
            public string Description { get; set; }
            public string DocumentID { get; set; }
            public string ReceiveDate { get; set; }
            public string Subcategory { get; set; }
            public string Type { get; set; }
        }
    }

    [Guid("5C0B1980-61F1-4393-A8C7-3F4372F31A4A")]
    public interface IFilingHistoryItem
    {
        List<FilingHistoryItem.Annotation> Annotations { get; set; }
        FilingHistoryItem.Annotation[] Annotations_COM { get; }
        List<FilingHistoryItem.AssociatedFiling> AssociatedFilings { get; set; }
        string Barcode { get; set; }
        string Category { get; set; }
        DateTime Date { get; set; }
        string Description { get; set; }
        List<FilingHistoryItem.Link> Links { get; set; }
        FilingHistoryItem.Link[] Links_COM { get; }
        int Pages { get; set; }
        bool PaperFiled { get; set; }
        List<FilingHistoryItem.Resolution> Resolutions { get; set; }
        FilingHistoryItem.Resolution[] Resolutions_COM { get; }
        string Subcategory { get; set; }
        string TransactionID { get; set; }
        string Type { get; set; }
    }
}
