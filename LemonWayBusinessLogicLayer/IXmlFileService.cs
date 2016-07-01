using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace LemonWayBusinessLogicLayer
{
    public interface IXmlFileService
    {
        string getXmlFromFilePath(string path);
    }
}
