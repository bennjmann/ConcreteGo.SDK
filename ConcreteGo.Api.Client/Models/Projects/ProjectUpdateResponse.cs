using System.Xml.Serialization;

namespace ConcreteGo.Api.Client.Models.Projects
{
    [XmlRoot("ProjectUpdateRs")]
    public class ProjectUpdateResponse
    {
        [XmlAttribute("statusCode")]
        public string StatusCode { get; set; } = string.Empty;

        [XmlAttribute("statusSeverity")]
        public string StatusSeverity { get; set; } = string.Empty;

        [XmlAttribute("statusMessage")]
        public string StatusMessage { get; set; } = string.Empty;

        [XmlElement("ProjectRet")]
        public List<ProjectRet> ProjectRet { get; set; } = null!;
    }
}