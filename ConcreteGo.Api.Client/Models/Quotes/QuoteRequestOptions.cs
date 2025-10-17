using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace ConcreteGo.Api.Client.Models.Quotes
{
    [XmlRoot(ElementName = "QuoteQueryRq")]
    public class QuoteRequestOptions
    {
        public List<int> IDs { get; set; } = new List<int>();
        public List<string> Codes { get; set; } = new List<string>();
        public List<string> Names { get; set; } = new List<string>();
        public List<int> CustomerIDs { get; set; } = new List<int>();
        public List<string> CustomerCodes { get; set; } = new List<string>();
        public List<string> CustomerNames { get; set; } = new List<string>();
        public int? MaxReturned { get; set; }
        public bool? ListOnly { get; set; }
        public DateTime? FromSetupDate { get; set; }
        public DateTime? ToSetupDate { get; set; }
        public DateTime? FromUpdateDate { get; set; }
        public DateTime? ToUpdateDate { get; set; }
        public List<string> SalesAnalysisCodes { get; set; } = new List<string>();
        public List<string> SalesmanCodes { get; set; } = new List<string>();
        public List<string> SalesmanNames { get; set; } = new List<string>();
        public List<string> PriceCategoryCodes { get; set; } = new List<string>();
        public List<string> PricingPlantCodes { get; set; } = new List<string>();
        public List<string> TermsCodes { get; set; } = new List<string>();
        public List<string> ZoneCodes { get; set; } = new List<string>();
        public List<string> StatementCycles { get; set; } = new List<string>();
        public List<string> AccountingCategoryCodes { get; set; } = new List<string>();
        //CUSTOMER
        public List<string> IncludeRetElements { get; set; } = new List<string>();
    }
}
