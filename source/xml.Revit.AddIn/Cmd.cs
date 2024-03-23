using System.Diagnostics;
using Autodesk.Revit.DB;

namespace xml.Revit.AddIn
{
    [Xml("功能名称")]
    [Transaction(TransactionMode.Manual)]
    public class Cmd : XmlExternalCommand
    {
        protected override void Execute(ref string message, ElementSet elements)
        {
            XmlDoc.Print(uidoc.Document.Title);
        }
    }
}
