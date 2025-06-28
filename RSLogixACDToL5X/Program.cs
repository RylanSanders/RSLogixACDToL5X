using RockwellSoftware.LogixCompare.CompareService;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RSLogixACDToL5X
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string ACDFilePath = args[0];
            string L5XFilePath = args[1];

            ProjectCompare projectCompare = new ProjectCompare();
            RockwellSoftware.LogixCompare.CompareService.XmlDocCompare comp = new RockwellSoftware.LogixCompare.CompareService.XmlDocCompare(".\\Parser.config", projectCompare, ACDFilePath, ACDFilePath);
            var l5xXMLDocument = comp.GetL5XDocument(true);
            File.WriteAllText(L5XFilePath, l5xXMLDocument.OuterXml);
        }
    }
}
