/// <generate>
/// wsdl /out:LemonWayWebServiceProxy.cs http://localhost:40822/LemonWayWebService.asmx?WSDL
/// </generate>
/// <compile>
/// csc /t:library /r:System.Web.Services.dll /r:System.Xml.dll LemonWayWebServiceProxy.cs
/// </compile>

using System;
using LemonWayBusinessLogicLayer;

namespace LemonWayConsoleClient
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                LemonWayWebServiceProxy proxy = new LemonWayWebServiceProxy();

                string i = proxy.Fibonacci(10);

                Console.WriteLine("Result fot the call of Fibonacci(10) funtion :");
                Console.WriteLine(i.ToString());
                Console.ReadLine();
            }

            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                Console.ReadLine();

                throw;
            }
        }
    }
}
