using System.Xml.Serialization;

namespace ConcreteGo.Api.Client.Models.Employees
{
    [XmlRoot(ElementName = "EmployeeQueryRs")]
    public class EmployeeResponse
    {
        [XmlElement(ElementName = "EmployeeRet")]
        public List<EmployeeRet>? EmployeeRet { get; set; }
    }
}