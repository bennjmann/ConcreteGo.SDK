using System.Xml.Serialization;

namespace ConcreteGo.Api.Client.Models.Projects
{
    [XmlRoot(ElementName = "ProjectQueryRs")]
    public class ProjectResponse
    {
        [XmlElement(ElementName = "ProjectRet")]
        public List<ProjectRet>? ProjectRet { get; set; }
    }
}