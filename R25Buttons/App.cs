using System.Reflection;
using Autodesk.Revit.UI;

namespace R25Buttons;

public class App : IExternalApplication
{
    public Result OnStartup(UIControlledApplication application)
    {
        const string tabName = "My Tools";
        const string panelName = "My Panel";

        try
        {
            application.CreateRibbonTab(tabName);
        }
        catch {}

        RibbonPanel panel = application.CreateRibbonPanel(tabName, panelName);
        string AssemblyPath = Assembly.GetExecutingAssembly().Location;

        PushButtonData buttonData1 = new PushButtonData("BtnOne", "Hello 1", AssemblyPath, "R25Buttons.CommandOne");
        PushButtonData buttonData2 = new PushButtonData("BtnTwo", "Hello 2", AssemblyPath, "R25Buttons.CommandTwo");   
        PushButtonData buttonData3 = new PushButtonData("BtnThree", "Hello 3", AssemblyPath, "R25Buttons.CommandThree"); 

        panel.AddItem(buttonData1);
        panel.AddItem(buttonData2);
        panel.AddItem(buttonData3);

        return Result.Succeeded;
    }

    public Result OnShutdown(UIControlledApplication application)
    {
        return Result.Succeeded;
    }
}