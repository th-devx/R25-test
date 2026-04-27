using Autodesk.Revit.Attributes;
using Autodesk.Revit.DB;
using Autodesk.Revit.UI;

namespace R25Buttons;

[Transaction(TransactionMode.Manual)]
public class CommandThree : IExternalCommand
{
    public Result Execute(ExternalCommandData commandData, ref string message, ElementSet elements)
    {
        TaskDialog.Show("Hello", "This is Command Three!");
        return Result.Succeeded;
    }
}