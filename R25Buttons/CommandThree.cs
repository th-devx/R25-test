using System.Text;
using Autodesk.Revit.Attributes;
using Autodesk.Revit.DB;
using Autodesk.Revit.UI;

namespace R25Buttons;

[Transaction(TransactionMode.Manual)]
public class CommandThree : IExternalCommand
{
    public Result Execute(ExternalCommandData commandData, ref string message, ElementSet elements)
    {
        UIDocument uiDoc = commandData.Application.ActiveUIDocument;
        Document doc = uiDoc.Document;
        ICollection<ElementId> selectedIds = uiDoc.Selection.GetElementIds();

        if (selectedIds.Count == 0)
        {
            TaskDialog.Show("Selection", "No elements are selected.");
            return Result.Succeeded;
        }

        StringBuilder sb = new StringBuilder();
        sb.AppendLine($"Selected count: {selectedIds.Count}");
        sb.AppendLine();

        int shown = 0;
        foreach (ElementId id in selectedIds)
        {
            Element? e = doc.GetElement(id);
            if (e == null) continue;

            sb.AppendLine($"- {e.Name} (Id: {e.Id.Value})");
            shown++;

            if (shown >= 5) break;
        }

        if (selectedIds.Count > shown)
        {
            sb.AppendLine("...");
        }

        TaskDialog.Show("Selection", sb.ToString());
        return Result.Succeeded;
    }
}