
using System.Xml.Linq;

namespace LemonWayBusinessLogicLayer
{
    public class XmlFileService : IXmlFileService
    {
        public string getXmlFromFilePath(string path)
        {
            XElement xmlFromFile = XElement.Load(path);
            return xmlFromFile.Value;
        }
    }
}
