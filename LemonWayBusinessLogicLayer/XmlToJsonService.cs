using log4net;
using Newtonsoft.Json;
using System;
using System.Xml;

namespace LemonWayBusinessLogicLayer
{
    public class XmlToJsonService : IXmlToJsonService
    {
        private static readonly ILog log = LogManager.GetLogger(typeof(FibonacciService));

        public string convertXmlToJson(string xml)
        {
            try
            {
               XmlDocument doc = new XmlDocument();
               doc.LoadXml(xml);
               string jsonText = JsonConvert.SerializeXmlNode(doc);

                log.Debug(String.Format("XmlToJson function with parameter {0} has return {1}", xml, jsonText));

                return jsonText;
            }

            catch (Exception ex)
            {
                if (ex is XmlException)
                {
                    string errorMessage = "Bad Xml format";
                    log.Error(String.Format("XmlToJson function with parameter {0} has return {1}", xml, errorMessage));

                    return errorMessage;
                }

                else
                {
                    log.Fatal(String.Format("XmlToJson function with parameter {0} has return {1}", xml, ex.Message));

                    return ex.Message;
                }
            }
        }

        public string GetXml(IXmlFileService xfs)
        {
            return xfs.getXmlFromFilePath(@"test.xml");
        }
    }
}
