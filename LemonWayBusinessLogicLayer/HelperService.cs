using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Web.Script.Serialization;
using System.Xml.Linq;

namespace LemonWayBusinessLogicLayer
{
    public static class HelperService
    {
        public static string GetOnePairJson(string value)
        {
            var keyValues = new Dictionary<string, string>
            {
                { "response", value.ToString()}
            };

            JavaScriptSerializer js = new JavaScriptSerializer();
            var res = js.Serialize(keyValues);

            return res;
        }

        public static string GetOnePairJson(string name, string value)
        {
            var keyValues = new Dictionary<string, string>
            {
                { name, value.ToString()}
            };

            JavaScriptSerializer js = new JavaScriptSerializer();
            var res = js.Serialize(keyValues);

            return res;
        }

        /*
         * Function written by Habib licensed under the creative commons license (https://creativecommons.org/licenses/by-sa/3.0/)
         * code source page : http://stackoverflow.com/questions/14977848/how-to-make-sure-that-string-is-valid-json-using-json-net
         */
        public static bool IsValidJson(string strInput)
        {
            strInput = strInput.Trim();
            if ((strInput.StartsWith("{") && strInput.EndsWith("}")) || //For object
                (strInput.StartsWith("[") && strInput.EndsWith("]"))) //For array
            {
                try
                {
                    var obj = JToken.Parse(strInput);
                    return true;
                }
                catch (JsonReaderException jex)
                {
                    //Exception in parsing json
                    Console.WriteLine(jex.Message);
                    return false;
                }
                catch (Exception ex) //some other exception
                {
                    Console.WriteLine(ex.ToString());
                    return false;
                }
            }
            else
            {
                return false;
            }
        }     
    }
}
