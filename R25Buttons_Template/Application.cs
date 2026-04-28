using Nice3point.Revit.Toolkit.External;
using R25Buttons_Template.Commands;

namespace R25Buttons_Template;

/// <summary>
///     Application entry point
/// </summary>
[UsedImplicitly]
public class Application : ExternalApplication
{
    public override void OnStartup()
    {
        CreateRibbon();
    }


    private void CreateRibbon()
    {
        var panel = Application.CreatePanel("Commands", "R25Buttons_Template");

        panel.AddPushButton<StartupCommand>("Execute")
            .SetImage("/R25Buttons_Template;component/Resources/Icons/RibbonIcon16.png")
            .SetLargeImage("/R25Buttons_Template;component/Resources/Icons/RibbonIcon32.png");
    }
}