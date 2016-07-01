using log4net;
using System;
using System.Web.Script.Services;
using System.Web.Services;
using LemonWayBusinessLogicLayer;

/// <summary>
/// Summary description for LemonWayWebService
/// </summary>
[WebService(Namespace = "http://tempuri.org/")]
[WebServiceBinding(ConformsTo = WsiProfiles.BasicProfile1_1)]
// To allow this Web Service to be called from script, using ASP.NET AJAX, uncomment the following line. 
// [System.Web.Script.Services.ScriptService]
public class LemonWayWebService : WebService
{
    private static readonly ILog log = LogManager.GetLogger(typeof(LemonWayWebService));
    private IFibonacciService _fs;
    private IXmlToJsonService _xjs;

    public LemonWayWebService(){}

    [WebMethod]
    [ScriptMethod(ResponseFormat = ResponseFormat.Json)]
    public string Fibonacci(int n)
    {
        try
        {
            IFibonacciService _fs = new FibonacciService();
            long f = _fs.getFibonacci(n);

            var response = HelperService.GetOnePairJson(f.ToString());

            log.Debug(String.Format("Fibonacci function with parameter {0} has return {1}", n, response.ToString()));
            return response;
        }

        catch (Exception ex)
        {
            log.Error(String.Format("Fibonacci function with parameter {0} has return -1 ({1})", n, ex.Message));
            return "-1";
        }
    }

    [WebMethod]
    [ScriptMethod(ResponseFormat = ResponseFormat.Json)]
    public string XmlToJson(string xml)
    {
        try
        {
            IXmlToJsonService _xjs = new XmlToJsonService();
            string res = _xjs.convertXmlToJson(xml);
            return res;
        }

        catch (Exception ex)
        {
            log.Error(String.Format("XmlToJson function with parameter {0} has return -1 ({1})", ex.Message));
            return "-1";
        }
    }
}
