using ConcreteGo.Api.Client.Models.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace ConcreteGo.Api.Client.Models.Customers
{
    [XmlRoot(ElementName = "CustomerRet")]
    public class CustomerRet
    {
        [XmlElement(ElementName = "ID")]
        public int ID { get; set; }

        [XmlElement(ElementName = "Code")]
        public string Code { get; set; }

        [XmlElement(ElementName = "Name")]
        public string Name { get; set; }

        [XmlElement(ElementName = "SortName")]
        public string SortName { get; set; }

        [XmlElement(ElementName = "SetupDate")]
        public DateTime SetupDate { get; set; }

        [XmlElement(ElementName = "Address")]
        public Address Address { get; set; }

        [XmlElement(ElementName = "InvoiceAddress")]
        public InvoiceAddress InvoiceAddress { get; set; }

        [XmlElement(ElementName = "StatementAddress")]
        public StatementAddress StatementAddress { get; set; }

        [XmlElement(ElementName = "Contact")]
        public string Contact { get; set; }

        [XmlElement(ElementName = "Phone")]
        public string Phone { get; set; }

        [XmlElement(ElementName = "Fax")]
        public string Fax { get; set; }

        [XmlElement(ElementName = "Cellular")]
        public string Cellular { get; set; }

        [XmlElement(ElementName = "Email")]
        public string Email { get; set; }

        [XmlElement(ElementName = "QBInvoiceEmailChecked")]
        public bool QBInvoiceEmailChecked { get; set; }

        [XmlElement(ElementName = "Sales")]
        public Sales Sales { get; set; }

        [XmlElement(ElementName = "Taxing")]
        public Taxing Taxing { get; set; }

        [XmlElement(ElementName = "Pricing")]
        public Pricing Pricing { get; set; }

        [XmlElement(ElementName = "Charges")]
        public Charges Charges { get; set; }

        [XmlElement(ElementName = "Accounting")]
        public Accounting Accounting { get; set; }

        [XmlElement(ElementName = "Distribution")]
        public Distribution Distribution { get; set; }

        [XmlElement(ElementName = "DivisionID")]
        public int DivisionID { get; set; }

        [XmlElement(ElementName = "DivisionCode")]
        public string DivisionCode { get; set; }

        [XmlElement(ElementName = "UpdateDate")]
        public DateTime UpdateDate { get; set; }

        [XmlElement(ElementName = "InActive")]
        public bool InActive { get; set; }
        [XmlElement(ElementName = "UserDefinedFields")]
        public CustomerRetUserDefinedFields UserDefinedFields { get; set; }
    }

    [XmlRoot(ElementName = "UserDefinedFields")]
    public class CustomerRetUserDefinedFields
    {

        [XmlElement(ElementName = "UserDefinedField")]
        public List<CustomerRetUserDefinedField> UserDefinedField { get; set; }
    }

    [XmlRoot("UserDefinedField")]
    public class CustomerRetUserDefinedField
    {
        [XmlElement("Name")]
        public string Name { get; set; } = string.Empty;
        [XmlElement("Value")]
        public string Value { get; set; } = string.Empty;
    }

    [XmlRoot(ElementName = "CreditInformation")]
    public class CreditInformation
    {

        [XmlElement(ElementName = "Credit")]
        public Credit Credit { get; set; }
    }

    [XmlRoot(ElementName = "Credit")]
    public class Credit
    {

        [XmlElement(ElementName = "CompanyCode")]
        public int CompanyCode { get; set; }

        [XmlElement(ElementName = "CreditCode")]
        public int CreditCode { get; set; }

        [XmlElement(ElementName = "CreditChangeDate")]
        public object CreditChangeDate { get; set; }

        [XmlElement(ElementName = "CreditLimit")]
        public object CreditLimit { get; set; }

        [XmlElement(ElementName = "CurrentBalance")]
        public object CurrentBalance { get; set; }

        [XmlElement(ElementName = "HighBalance")]
        public object HighBalance { get; set; }

        [XmlElement(ElementName = "UpdateCredit")]
        public bool UpdateCredit { get; set; }

        [XmlElement(ElementName = "HighBalanceDate")]
        public object HighBalanceDate { get; set; }

        [XmlElement(ElementName = "CreditUpdateDate")]
        public object CreditUpdateDate { get; set; }

        [XmlElement(ElementName = "LastInvoiceDate")]
        public object LastInvoiceDate { get; set; }

        [XmlElement(ElementName = "CreditPersonCode")]
        public object CreditPersonCode { get; set; }

        [XmlElement(ElementName = "CreditPersonName")]
        public object CreditPersonName { get; set; }
    }

    [XmlRoot(ElementName = "CreditCard")]
    public class CreditCard
    {

        [XmlElement(ElementName = "CardName")]
        public object CardName { get; set; }

        [XmlElement(ElementName = "CardNumber")]
        public object CardNumber { get; set; }

        [XmlElement(ElementName = "ResponsibleName")]
        public object ResponsibleName { get; set; }
    }

    [XmlRoot(ElementName = "Address")]
    public class Address
    {

        [XmlElement(ElementName = "Addr1")]
        public string Addr1 { get; set; }

        [XmlElement(ElementName = "Addr2")]
        public string Addr2 { get; set; }

        [XmlElement(ElementName = "Addr3")]
        public string Addr3 { get; set; }

        [XmlElement(ElementName = "City")]
        public string City { get; set; }

        [XmlElement(ElementName = "State")]
        public string State { get; set; }

        [XmlElement(ElementName = "PostalCode")]
        public string PostalCode { get; set; }

        [XmlElement(ElementName = "Country")]
        public string Country { get; set; }
    }

    
}
