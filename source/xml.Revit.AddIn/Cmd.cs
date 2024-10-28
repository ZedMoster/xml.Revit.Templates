namespace xml.Revit.AddIn
{
    [Xml("输入功能名称", "功能提示", "功能长提示")]
    [Transaction(TransactionMode.Manual)]
    public class Cmd : XmlExternalCommand
    {
        protected override void Execute(ref string message, ElementSet elements)
        {
            XmlDoc.Print(uidoc.Document.Title);
        }
    }
}
