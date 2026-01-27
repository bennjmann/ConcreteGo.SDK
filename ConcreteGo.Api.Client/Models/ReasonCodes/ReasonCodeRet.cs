using System.Xml.Serialization;

namespace ConcreteGo.Api.Client.Models.ReasonCodes
{
    [XmlRoot(ElementName = "ReasonCodeRet")]
    public class ReasonCodeRet
    {
        [XmlElement(ElementName = "ID")]
        public int ID { get; set; }

        [XmlElement(ElementName = "Code")]
        public string Code { get; set; } = string.Empty;

        [XmlElement(ElementName = "Description")]
        public string? Description { get; set; }
        public bool ShouldSerializeDescription() => !string.IsNullOrEmpty(Description);

        [XmlElement(ElementName = "ShortDescription")]
        public string? ShortDescription { get; set; }
        public bool ShouldSerializeShortDescription() => !string.IsNullOrEmpty(ShortDescription);

        [XmlElement(ElementName = "ReasonUsage")]
        public string ReasonUsage { get; set; } = string.Empty;
    }
}