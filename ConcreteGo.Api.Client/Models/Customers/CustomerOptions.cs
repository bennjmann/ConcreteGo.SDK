using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace ConcreteGo.Api.Client.Models.Customers
{
    [XmlRoot(ElementName = "CustomerQueryRq")]
    public class CustomerOptions
    {
        [XmlElement(ElementName = "ID")]
        public List<int>? IDs { get; set; } = new List<int>();
        public bool ShouldSerializeIDs() => IDs != null && IDs.Count > 0;

        [XmlElement(ElementName = "Code")]
        public List<string>? Codes { get; set; } = new List<string>();
        public bool ShouldSerializeCodes() => Codes != null && Codes.Count > 0;

        [XmlElement(ElementName = "Name")]
        public List<string>? Names { get; set; } = new List<string>();
        public bool ShouldSerializeNames() => Names != null && Names.Count > 0;

        [XmlElement(ElementName = "MaxReturned")]
        public int? MaxReturned { get; set; }
        public bool ShouldSerializeMaxReturned() => MaxReturned.HasValue;

        [XmlElement(ElementName = "ListOnly")]
        public bool? ListOnly { get; set; }
        public bool ShouldSerializeListOnly() => ListOnly.HasValue;

        [XmlElement(ElementName = "InActive")]
        public bool? InActive { get; set; }
        public bool ShouldSerializeInActive() => InActive.HasValue;

        [XmlElement(ElementName = "FromSetupDate")]
        public DateTime? FromSetupDate { get; set; }
        public bool ShouldSerializeFromSetupDate() => FromSetupDate.HasValue;

        [XmlElement(ElementName = "ToSetupDate")]
        public DateTime? ToSetupDate { get; set; }
        public bool ShouldSerializeToSetupDate() => ToSetupDate.HasValue;

        [XmlElement(ElementName = "FromUpdateDate")]
        public DateTime? FromUpdateDate { get; set; }
        public bool ShouldSerializeFromUpdateDate() => FromUpdateDate.HasValue;

        [XmlElement(ElementName = "ToUpdateDate")]
        public DateTime? ToUpdateDate { get; set; }
        public bool ShouldSerializeToUpdateDate() => ToUpdateDate.HasValue;

        [XmlElement(ElementName = "SalesAnalysisCode")]
        public List<string>? SalesAnalysisCodes { get; set; } = new List<string>();
        public bool ShouldSerializeSalesAnalysisCodes() => SalesAnalysisCodes != null && SalesAnalysisCodes.Count > 0;

        [XmlElement(ElementName = "SalesmanCode")]
        public List<string>? SalesmanCodes { get; set; } = new List<string>();
        public bool ShouldSerializeSalesmanCodes() => SalesmanCodes != null && SalesmanCodes.Count > 0;

        [XmlElement(ElementName = "SalesmanName")]
        public List<string>? SalesmanNames { get; set; } = new List<string>();
        public bool ShouldSerializeSalesmanNames() => SalesmanNames != null && SalesmanNames.Count > 0;

        [XmlElement(ElementName = "PriceCategoryCode")]
        public List<string>? PriceCategoryCodes { get; set; } = new List<string>();
        public bool ShouldSerializePriceCategoryCodes() => PriceCategoryCodes != null && PriceCategoryCodes.Count > 0;

        [XmlElement(ElementName = "PricingPlantCode")]
        public List<string>? PricingPlantCodes { get; set; } = new List<string>();
        public bool ShouldSerializePricingPlantCodes() => PricingPlantCodes != null && PricingPlantCodes.Count > 0;

        [XmlElement(ElementName = "TermsCode")]
        public List<string>? TermsCodes { get; set; } = new List<string>();
        public bool ShouldSerializeTermsCodes() => TermsCodes != null && TermsCodes.Count > 0;

        [XmlElement(ElementName = "ZoneCode")]
        public List<string>? ZoneCodes { get; set; } = new List<string>();
        public bool ShouldSerializeZoneCodes() => ZoneCodes != null && ZoneCodes.Count > 0;

        [XmlElement(ElementName = "StatementCycle")]
        public List<string>? StatementCycles { get; set; } = new List<string>();
        public bool ShouldSerializeStatementCycles() => StatementCycles != null && StatementCycles.Count > 0;

        [XmlElement(ElementName = "AccountingCategoryCode")]
        public List<string>? AccountingCategoryCodes { get; set; } = new List<string>();
        public bool ShouldSerializeAccountingCategoryCodes() => AccountingCategoryCodes != null && AccountingCategoryCodes.Count > 0;

        [XmlElement(ElementName = "IncludeRetElement")]
        public List<string>? IncludeRetElement { get; set; } = new List<string>();
        public bool ShouldSerializeIncludeRetElement() => IncludeRetElement != null && IncludeRetElement.Count > 0;
    }
}
