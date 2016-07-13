using System;
using Autodesk.Revit.UI;

namespace Gensler.Learning
{
    public class Application : IExternalApplication
    {
        public Result OnShutdown(UIControlledApplication application)
        {
            return Result.Succeeded;
        }

        public Result OnStartup(UIControlledApplication application)
        {
            application.RegisterDockablePane(new DockablePaneId(Guid.NewGuid()), "Learning Structure", new MainPage());
            return Result.Succeeded;
        }
    }
}
