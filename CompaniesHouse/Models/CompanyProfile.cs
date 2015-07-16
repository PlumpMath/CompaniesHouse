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
    [Guid("8DB60953-C4DD-44AA-B1D6-FB6027ED77EB")]
    public class CompanyProfile : ICompanyProfile
    {
        public AccountsInfo Accounts { get; set; }
        public AnnualReturnInfo AnnualReturn { get; set; }
        public bool CanFile { get; set; }
        public string CompanyName { get; set; }
        public string CompanyNumber { get; set; }
        public string CompanyStatus { get; set; }
        public string CompanyStatusDetail { get; set; }
        public DateTime DateOfCreation { get; set; }
        public DateTime DateOfDissolution { get; set; }
        public string ETag { get; set; }
        public bool HasBeenLiquidated { get; set; }
        public bool HasCharges { get; set; }
        public bool HasInsolvencyHistory { get; set; }
        public string Jurisdiction { get; set; }
        public DateTime LastFullMembersListDate { get; set; }
        public OfficerSummaryInfo OfficerSummary { get; set; }
        public RegisteredOfficeAddress RegisteredOfficeAddress { get; set; }
        public bool RegisteredOfficeIsInDispute { get; set; }
        public List<string> SicCodes { get; set; }
        public string[] SicCodes_COM
        {
            get
            {
                return SicCodes == null ? null : SicCodes.ToArray();
            }
        }
        public string Type { get; set; }
        public bool UndeliverableRegisteredOfficeAddress { get; set; }

        [Guid("99408832-CB14-46EA-B9A3-CAAE907F7AEF")]
        public interface IAccountsInfo
        {
            AccountingReferenceDate AccountingReferenceDate { get; set; }
            LastAccounts LastAccounts { get; set; }
            DateTime NextDue { get; set; }
            DateTime NextMadeUpTo { get; set; }
            bool Overdue { get; set; }
        }

        [ComVisible(true)]
        [ClassInterface(ClassInterfaceType.None)]
        [Guid("34E29C86-FC38-4FBF-B751-C61656D1EF4D")]
        public class AccountsInfo : IAccountsInfo
        {
            public AccountingReferenceDate AccountingReferenceDate { get; set; }
            public LastAccounts LastAccounts { get; set; }
            public DateTime NextDue { get; set; }
            public DateTime NextMadeUpTo { get; set; }
            public bool Overdue { get; set; }
        }

        [Guid("3BB8D50A-6DEF-4576-900A-3BFA27B5808B")]
        public interface IAccountingReferenceDate
        {
            int Day { get; set; }
            int Month { get; set; }
        }

        [ComVisible(true)]
        [ClassInterface(ClassInterfaceType.None)]
        [Guid("657388A9-8DB2-49E2-ADCC-88FB2B118673")]
        public class AccountingReferenceDate : IAccountingReferenceDate
        {
            public int Day { get; set; }
            public int Month { get; set; }
        }

        [Guid("54FB6201-B3B2-48C3-AB45-90F0DE005186")]
        public interface ILastAccounts
        {
            DateTime MadeUpTo { get; set; }
            string Type { get; set; }
        }

        [ComVisible(true)]
        [ClassInterface(ClassInterfaceType.None)]
        [Guid("E5D0149D-FED8-4062-B4E6-C2EEB85E43E8")]
        public class LastAccounts : ILastAccounts
        {
            public DateTime MadeUpTo { get; set; }
            public string Type { get; set; }
        }

        [Guid("8D65AF49-B190-4032-AD64-A2A10B2D641B")]
        public interface IAnnualReturnInfo
        {
            DateTime LastMadeUpTo { get; set; }
            DateTime NextDue { get; set; }
            DateTime NextMadeUpTo { get; set; }
            bool Overdue { get; set; }
        }

        [ComVisible(true)]
        [ClassInterface(ClassInterfaceType.None)]
        [Guid("36775755-17DD-4917-8B87-86EA7EF4DA16")]
        public class AnnualReturnInfo : IAnnualReturnInfo
        {
            public DateTime LastMadeUpTo { get; set; }
            public DateTime NextDue { get; set; }
            public DateTime NextMadeUpTo { get; set; }
            public bool Overdue { get; set; }
        }

        [Guid("22A283F9-0E12-4277-A649-89BD59200A47")]
        public interface IOfficerSummaryInfo
        {
            int ActiveCount { get; set; }
            List<Officer> Officers { get; set; }
            Officer[] Officers_COM { get; }
            int ResignedCount { get; set; }
        }

        [ComVisible(true)]
        [ClassInterface(ClassInterfaceType.None)]
        [Guid("60CDEC6F-20C0-4684-993B-F530FBDAF026")]
        public class OfficerSummaryInfo : IOfficerSummaryInfo
        {
            public int ActiveCount { get; set; }
            public List<Officer> Officers { get; set; }
            public Officer[] Officers_COM
            {
                get
                {
                    return Officers == null ? null : Officers.ToArray();
                }
            }
            public int ResignedCount { get; set; }
        }

        [Guid("353DC281-65E7-4D2C-BA81-A5883E739D2C")]
        public interface IOfficer
        {
            DateTime AppointedOn { get; set; }
            DateOfBirth DateOfBirth { get; set; }
            string Name { get; set; }
            string OfficerRole { get; set; }
        }

        [ComVisible(true)]
        [ClassInterface(ClassInterfaceType.None)]
        [Guid("F057F1D0-06F0-47A4-8283-6517F83E56A2")]
        public class Officer : IOfficer
        {
            public DateTime AppointedOn { get; set; }
            public DateOfBirth DateOfBirth { get; set; }
            public string Name { get; set; }
            public string OfficerRole { get; set; }
        }

        [Guid("7737BE77-9FB9-4912-97E3-462B186FC6E8")]
        public interface IDateOfBirth
        {
            int Day { get; set; }
            int Month { get; set; }
            int Year { get; set; }
        }

        [ComVisible(true)]
        [ClassInterface(ClassInterfaceType.None)]
        [Guid("986A846C-6EB5-41F1-B4DB-3E59D933C6C3")]
        public class DateOfBirth : IDateOfBirth
        {
            public int Day { get; set; }
            public int Month { get; set; }
            public int Year { get; set; }
        }
    }

    [Guid("07ECE5D1-9257-4A02-83C7-F17A408E09A9")]
    public interface ICompanyProfile
    {
        CompanyProfile.AccountsInfo Accounts { get; set; }
        CompanyProfile.AnnualReturnInfo AnnualReturn { get; set; }
        bool CanFile { get; set; }
        string CompanyName { get; set; }
        string CompanyNumber { get; set; }
        string CompanyStatus { get; set; }
        string CompanyStatusDetail { get; set; }
        DateTime DateOfCreation { get; set; }
        DateTime DateOfDissolution { get; set; }
        string ETag { get; set; }
        bool HasBeenLiquidated { get; set; }
        bool HasCharges { get; set; }
        bool HasInsolvencyHistory { get; set; }
        string Jurisdiction { get; set; }
        DateTime LastFullMembersListDate { get; set; }
        CompanyProfile.OfficerSummaryInfo OfficerSummary { get; set; }
        RegisteredOfficeAddress RegisteredOfficeAddress { get; set; }
        bool RegisteredOfficeIsInDispute { get; set; }
        List<string> SicCodes { get; set; }
        string[] SicCodes_COM { get; }
        string Type { get; set; }
        bool UndeliverableRegisteredOfficeAddress { get; set; }
    }
}
