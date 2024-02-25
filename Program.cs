using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C2T18P2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            AbstractHandler handlerXML = new XMLHandler();
            handlerXML.Create();
            handlerXML.Open();
            handlerXML.Change();
            handlerXML.Save();
            Console.WriteLine('\t');

            AbstractHandler handlerTXT = new TXTHandler();
            handlerTXT.Create();
            handlerTXT.Open();
            handlerTXT.Change();
            handlerTXT.Save();
            Console.WriteLine('\t');

            AbstractHandler handlerDOC = new DOCHandler();
            handlerDOC.Create();
            handlerDOC.Open();
            handlerDOC.Change();
            handlerDOC.Save();
        }
    }
}
