using Autodesk.Revit.Attributes;
using Nice3point.Revit.Toolkit.External;
using Autodesk.Revit.UI;

namespace R25Buttons_Template.Commands;

/// <summary>
///     External command entry point.
/// </summary>
[UsedImplicitly]
[Transaction(TransactionMode.Manual)]
public class StartupCommand : ExternalCommand
{
    public override void Execute()
    {
        TaskDialog.Show(Application.ActiveUIDocument.Document.Title, "R25Buttons_Template");
    }
}