using System;
using System.Collections.Generic;
using System.Xml.Serialization;

namespace ConcreteGo.Api.Client.Models.Jobs
{
    [XmlRoot(ElementName = "JobQueryRq")]
    public class JobRequestOptions
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

        [XmlElement(ElementName = "CustomerID")]
        public List<int>? CustomerIDs { get; set; } = new List<int>();
        public bool ShouldSerializeCustomerIDs() => CustomerIDs != null && CustomerIDs.Count > 0;

        [XmlElement(ElementName = "CustomerCode")]
        public List<string>? CustomerCodes { get; set; } = new List<string>();
        public bool ShouldSerializeCustomerCodes() => CustomerCodes != null && CustomerCodes.Count > 0;

        [XmlElement(ElementName = "CustomerName")]
        public List<string>? CustomerNames { get; set; } = new List<string>();
        public bool ShouldSerializeCustomerNames() => CustomerNames != null && CustomerNames.Count > 0;

        [XmlElement(ElementName = "MaxReturned")]
        public int? MaxReturned { get; set; }
        public bool ShouldSerializeMaxReturned() => MaxReturned.HasValue;

        [XmlElement(ElementName = "ListOnly")]
        public bool? ListOnly { get; set; }
        public bool ShouldSerializeListOnly() => ListOnly.HasValue;

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
        public List<string>? IncludeRetElements { get; set; } = new List<string>();
        public bool ShouldSerializeIncludeRetElements() => IncludeRetElements != null && IncludeRetElements.Count > 0;
    }
}
